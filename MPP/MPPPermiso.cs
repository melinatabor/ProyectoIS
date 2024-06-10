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

        public static bool AgregarPermisoAFamilia(BEPermiso permisoHijo, BEPermiso permisoPadre)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = $"INSERT INTO PermisoPermiso (PermisoHijo, PermisoPadre) VALUES (@PermisoHijo, @PermisoPadre)";

                parametros.Add("@PermisoHijo", permisoHijo.Id);
                parametros.Add("@PermisoPadre", permisoPadre.Id);

                return Acceso.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEPermiso BuscarFamilia(int idFamilia)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = $"SELECT Id, Nombre, EsPadre FROM Permiso WHERE Id = @Id AND EsPadre = 1";

                parametros.Add("@Id", idFamilia);

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

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

                        return permiso;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEPermiso BuscarPermiso(int id)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = $"SELECT Id, Nombre, EsPadre FROM Permiso WHERE Id = @Id";

                parametros.Add("@Id", id);

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

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

                        return permiso;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEPermiso> ListarFamilias()
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                string query = $"SELECT Id, Nombre, EsPadre FROM Permiso WHERE EsPadre = 1";

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

        public static List<BEPermiso> ListarHijos(BEPermiso familia)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                List<BEPermiso> lista = new List<BEPermiso>();

                string query = $"select p.Id, p.Nombre from Permiso as p inner join PermisoPermiso as pp on pp.PermisoHijo = p.Id where pp.PermisoPadre = @PermisoPadre";

                parametros.Add("@PermisoPadre", familia.Id);

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEPermiso permiso = new BEPermiso()
                        {
                            Id          = Convert.ToInt32(fila["Id"].ToString()),
                            Nombre      = fila["Nombre"].ToString(),
                            EsPadre     = false
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
