using BE;
using DAL;
using System;
using System.Collections;

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
    }
}
