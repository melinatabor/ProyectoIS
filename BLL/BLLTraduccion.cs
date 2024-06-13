using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTraduccion
    {
        public static List<BETraduccion> Listar(int idIdioma)
        {
            try
            {
                return MPPTraduccion.Listar(idIdioma);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
