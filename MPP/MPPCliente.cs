using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPCliente
    {
        public static bool Alta(BECliente cliente)
        {
            try
            {
                string query = $"INSERT INTO Cliente (Id, Nombre, Apellido, Email) VALUES ({cliente.Id}, '{cliente.Nombre}', '{cliente.Apellido}', '{cliente.Email}'";
                return Acceso.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
