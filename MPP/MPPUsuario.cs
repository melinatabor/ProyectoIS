using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Remoting;
using System.Security.Cryptography;

namespace MPP
{
    public class MPPUsuario
    {
        public static bool Guardar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();
                string query = (usuario.Id == 0) ? QueryAgregar() : QueryEditar();

                parametros.Add("@Nombre", usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Username", usuario.Username);

                if (usuario.Id == 0)
                {
                    parametros.Add("@Password", usuario.Password);
                    parametros.Add("@Activo", usuario.Activo);
                }
                else parametros.Add("@Id", usuario.Id);

                return Acceso.ExecuteNonQuery(query, parametros);
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
                string query = $"UPDATE Usuario SET Activo = @Activo WHERE Id = @Id";
                parametros.Add("@Activo", false);
                parametros.Add("@Id", usuario.Id);
                return Acceso.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Buscar(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = "SELECT COUNT(*) FROM Usuario WHERE Password = @Password AND Username = @Username";
                
                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Username", usuario.Username);

                return Convert.ToBoolean(Acceso.ExecuteScalar(query, parametros));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = "SELECT Id, Nombre, Apellido, Email, Username, Password, Activo FROM Usuario WHERE Password = @Password AND Username = @Username";

                parametros.Add("@Password", usuario.Password);
                parametros.Add("@Username", usuario.Username);

                DataTable table = Acceso.ExecuteDataTable(query, parametros);

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
            catch (Exception)
            {
                throw;
            }
        }

        private static string QueryEditar()
        {
            return $"UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Username = @Username WHERE Id = @Id";
        }

        private static string QueryAgregar()
        {
            return "INSERT INTO Usuario (Nombre, Apellido, Email, Username, Password, Activo) VALUES (@Nombre, @Apellido, @Email, @Username, @Password, @Activo)";
        }

        public static List<BEUsuario> Listar()
        {
            try
            {
                List<BEUsuario> lista = new List<BEUsuario>();

                string query = "SELECT Id, Nombre, Apellido, Email, Username, Password, Activo FROM Usuario";

                DataTable table = Acceso.ExecuteDataTable(query, null);

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
            Hashtable parametros = new Hashtable();

            string query = $"SELECT Id, Nombre, Apellido, Email, Username, Password FROM Usuario WHERE Id = @Id";

            parametros.Add("@Id", idUsuario);

            DataTable tabla = Acceso.ExecuteDataTable(query, parametros);

            if (tabla.Rows.Count > 0)
            {
                BEUsuario usuario = new BEUsuario(idUsuario);
                Llenar(tabla.Rows[0],usuario);
                return usuario;
            }
            return null;
        }

        private static BEUsuario Llenar(DataRow row, BEUsuario usuario)
        {
            usuario.Id = Convert.ToInt32(row["Id"].ToString());
            usuario.Nombre = row["Nombre"].ToString();
            usuario.Apellido = row["Apellido"].ToString();
            usuario.Email = row["Email"].ToString();
            usuario.Username = row["Username"].ToString();
            usuario.Password = row["Password"].ToString();
            return usuario;
        }

        public static BEUsuario BuscarUsuarioPorUsername(string username)
        {
            try
            {
                Hashtable parametros = new Hashtable();

                string query = "SELECT Id, Nombre, Apellido, Email, Username, Password, Activo FROM Usuario WHERE Username = @Username";

                parametros.Add("@Username", username);

                DataTable table = Acceso.ExecuteDataTable(query, parametros);

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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
