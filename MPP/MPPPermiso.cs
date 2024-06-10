using BE;
using DAL;
using MPP.StoredProcedures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPPermiso
    {
        public static bool AgregarPermiso(BEPermiso permiso)
        {
			try
			{
                Hashtable parametros = new Hashtable();

                string query = $"INSERT INTO Permiso (Nombre, EsPadre) VALUES (@Nombre, @EsPadre)";

                parametros.Add("@Nombre", permiso.Nombre);
                parametros.Add("@EsPadre", permiso.EsPadre);

                return Acceso.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
			{
				throw ex;
			}
        }

        public static List<BEPermiso> ListarPermisos()
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                string query = $"SELECT Id, Nombre, EsPadre FROM Permiso";

                DataTable table = Acceso.ExecuteDataTable(query, null, false);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEPermiso()
                        {
                            Id = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre = fila["Nombre"].ToString(),
                            EsPadre = Convert.ToBoolean(fila["EsPadre"].ToString())
                        };
                        lista.Add(permiso);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
