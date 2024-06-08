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
    }
}
