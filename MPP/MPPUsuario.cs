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
        public static bool Alta(BEUsuario usuario)
        {
            try
            {
                Hashtable parametros = new Hashtable();
               
                string query = "INSERT INTO Usuario (Nombre, Apellido, Email) VALUES (@Nombre, @Apellido, @Email)";

                parametros.Add("@Nombre", usuario.Nombre);
                parametros.Add("@Apellido", usuario.Apellido);
                parametros.Add("@Email", usuario.Email);

                return Acceso.ExecuteNonQuery(query, parametros);
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

                string query = "SELECT Id, Nombre, Apellido, Email FROM Usuario";

                DataTable table = Acceso.ExecuteDataTable(query);

                if (table.Rows.Count > 0)
                {
                    foreach (DataRow fila in table.Rows)
                    {
                        BEUsuario cliente = Llenar(fila);
                        lista.Add(cliente);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private static BEUsuario Llenar(DataRow row)
        {
            BEUsuario usuario = new BEUsuario();
            usuario.Id = row["Id"].ToString();
            usuario.Nombre = row["Nombre"].ToString();
            usuario.Apellido = row["Apellido"].ToString();
            usuario.Email = row["Email"].ToString();
            return usuario;
        }
    }
}
