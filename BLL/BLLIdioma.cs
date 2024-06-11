using Abstraccion;
using BE;
using MPP;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLLIdioma
    {
        public static List<BEIdioma> Listar()
        {
            try
            {
                return MPPIdioma.Listar();
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEPalabra> ObtenerTags()
        {
            try
            {
                return MPPIdioma.ObtenerTags();
            }
            catch (Exception ex) { throw ex; }
        }

        public static void RegistrarSubscriptor(ISubscriptor subscriptor)
        {
            try
            {

            }
            catch (Exception ex) { throw ex; }
        }
    }
}
