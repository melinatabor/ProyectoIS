using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
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
    }
}
