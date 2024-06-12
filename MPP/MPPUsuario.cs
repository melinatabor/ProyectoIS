using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class MPPUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Nombre",   usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email",    usuario.Email);
                parametros.Add("@Username", usuario.Username);
                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Activo",   usuario.Activo);

                return Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_AgregarUsuario, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Editar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();
             
                parametros.Add("@Nombre",   usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email",    usuario.Email);
                parametros.Add("@Username", usuario.Username);
                parametros.Add("@Id",       usuario.Id);

                return Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_EditarUsuario, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Baja(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Activo", false);
                parametros.Add("@Id", usuario.Id);
                
                return Acceso.ExecuteNonQuery(UsuarioStoredProcedures.SP_EliminarUsuario, parametros, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Username", usuario.Username);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXPswUsername, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario u = new BEUsuario();
                        return Llenar(fila, u);
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<BEUsuario> Listar()
        {
            try
            {
                List<BEUsuario> lista = new List<BEUsuario>();

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_ListarUsuarios, null, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario usuario = new BEUsuario();
                        Llenar(fila, usuario);
                        lista.Add(usuario);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static BEUsuario Obtener(int idUsuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Id", idUsuario);

                DataTable tabla = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXId, parametros, true);

                if (tabla.Rows.Count > 0)
                {
                    BEUsuario usuario = new BEUsuario(idUsuario);
                    Llenar(tabla.Rows[0], usuario);
                    return usuario;
                }
                return null;
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
        }

        private static BEUsuario Llenar(DataRow row, BEUsuario usuario)
        {
            try
            {
                usuario.Id = Convert.ToInt32(row["Id"].ToString());
                usuario.Nombre = row["Nombre"].ToString();
                usuario.Apellido = row["Apellido"].ToString();
                usuario.Email = row["Email"].ToString();
                usuario.Username = row["Username"].ToString();
                usuario.Password = row["Password"].ToString();
                usuario.Activo = Convert.ToBoolean(row["Activo"]);
                return usuario;
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuarioPorUsername(string username)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@Username", username);

                DataTable table = Acceso.ExecuteDataTable(UsuarioStoredProcedures.SP_BuscarUsuarioXUsername, parametros, true);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario u = new BEUsuario();
                        return Llenar(fila, u);
                    }
                }

                return null;
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AsignarPermiso(BEUsuario usuario, BEPermiso permiso)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@IdUsuario", usuario.Id);
                parametros.Add("@IdPermiso", permiso.Id);

                string query = "INSERT INTO UsuarioPermiso (Usuario, Permiso) VALUES (@IdUsuario, @IdPermiso)";
            
                return Acceso.ExecuteNonQuery(query, parametros, false);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool VerificarPermiso(BEUsuario usuarioActual, int permiso)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                parametros.Add("@IdUsuario", usuarioActual.Id);
                parametros.Add("@IdPermiso", permiso);

                string query = "SELECT Id FROM UsuarioPermiso WHERE Usuario = @IdUsuario AND Permiso = @IdPermiso";

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

                if (table.Rows.Count > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex) { throw ex; }
        }

        public static void ObtenerPermisosUsuario(BEUsuario usuario)
        {
            try
            {
                List<BEPermiso> lista = new List<BEPermiso>();

                Hashtable parametros = new Hashtable();

                parametros.Add("@IdUsuario", usuario.Id);

                string query = $"select per.Id from Usuario u inner join usuarioPermiso as up on up.Usuario = u.Id inner join permiso as per on up.Permiso=per.Id where u.Id=@IdUsuario";

                DataTable table = Acceso.ExecuteDataTable(query, parametros, false);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        int id = Convert.ToInt32(fila["Id"]);
                        lista.AddRange(MPPPermiso.ListarHijosRecursivo(MPPPermiso.BuscarPermiso(id)));
                    }
                }

                foreach (BEPermiso permiso in lista)
                {
                    usuario.ListaPermisos.Add(permiso.Id);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
