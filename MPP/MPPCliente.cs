using BE;
using DAL;
using System;
using System.Collections;

namespace MPP
{
    public class MPPCliente
    {
        public static bool Alta(BECliente cliente)
        {
            try
            {
                Hashtable parametros = new Hashtable();
               
                string query = "INSERT INTO Usuario (Nombre, Apellido, Email) VALUES (@Nombre, @Apellido, @Email)";

                parametros.Add("@Nombre", cliente.Nombre);
                parametros.Add("@Apellido", cliente.Apellido);
                parametros.Add("@Email", cliente.Email);

                return Acceso.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
