using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPBitacora
    {
        public static bool Agregar(BEBitacora bitacora)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                string query = "INSERT INTO Bitacora (Usuario, Tipo, Mensaje, Fecha) VALUES (@Usuario, @Tipo, @Mensaje, getdate())";

                parametros.Add("@Usuario", bitacora.Usuario);
                parametros.Add("@Tipo", bitacora.Tipo);
                parametros.Add("@Mensaje", bitacora.Mensaje);


                return Acceso.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEBitacoraFiltrada> Listar()
        {
            try
            {
                List<BEBitacoraFiltrada> lista = new List<BEBitacoraFiltrada>();

                string query = "SELECT b.id AS 'Id', u.username AS 'Usuario', bt.nombre AS 'Tipo', b.Mensaje, b.Fecha FROM Bitacora AS b INNER JOIN Usuario u ON u.id = b.usuario INNER JOIN BitacoraTipo bt ON bt.id = b.tipo";

                DataTable table = Acceso.ExecuteDataTable(query, null);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEBitacoraFiltrada bitacora = new BEBitacoraFiltrada();
                        lista.Add(Llenar(fila, bitacora));
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static BEBitacoraFiltrada Llenar(DataRow fila, BEBitacoraFiltrada bitacora)
        {
            bitacora.Id = Convert.ToInt32(fila["Id"]);
            bitacora.Usuario = fila["Usuario"].ToString();
            bitacora.Tipo = fila["Tipo"].ToString();
            bitacora.Mensaje = fila["Mensaje"].ToString();
            bitacora.Fecha = Convert.ToDateTime(fila["Fecha"]);
            return bitacora;
        }

        public static List<BEBitacoraFiltrada> Filtrar(BEBitacoraCriteria criteria)
        {
            try
            {
                List<BEBitacoraFiltrada> lista = new List<BEBitacoraFiltrada>();

                string query = "SELECT b.id AS 'Id', u.username AS 'Usuario', bt.nombre AS 'Tipo', b.Mensaje, b.Fecha FROM   Bitacora AS b INNER JOIN Usuario u ON u.id = b.usuario INNER JOIN BitacoraTipo bt ON bt.id = b.tipo WHERE (@Usuario IS NULL OR u.Username = @Usuario) AND (@Tipo IS NULL OR bt.Id = @Tipo) AND (b.Fecha BETWEEN @Desde AND @Hasta) ORDER BY b.Fecha DESC OFFSET @Page ROWS FETCH NEXT @Filas ROWS ONLY";

                Hashtable parametros = ExtraerParametros(criteria);
                parametros["@Page"] = (criteria.Page - 1) * criteria.RowPerPage;
                parametros["@Filas"] = criteria.RowPerPage;

                if (string.IsNullOrEmpty(criteria.Usuario))
                    parametros["@Usuario"] = DBNull.Value;
                if (criteria.Tipo == 0 || criteria.Tipo == null)
                    parametros["@Tipo"] = DBNull.Value;

                DataTable table = Acceso.ExecuteDataTable(query, parametros);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEBitacoraFiltrada bitacora = new BEBitacoraFiltrada();
                        lista.Add(Llenar(fila, bitacora));
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

        private static Hashtable ExtraerParametros(BEBitacoraCriteria criteria)
        {
            Hashtable parametros = new Hashtable();
            parametros.Add("@Tipo", criteria.Tipo ?? (object)DBNull.Value);
            parametros.Add("@Usuario", criteria.Usuario ?? (object)DBNull.Value);
            parametros.Add("@Desde", criteria.Desde);
            parametros.Add("@Hasta", criteria.Hasta);
            return parametros;

        }
    }
}
