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
        public static bool Agregar(int idioma, int tag, string traduccion)
        {
            try
            {
                return MPPTraduccion.Agregar(idioma, tag, traduccion);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BETraduccion> Listar(int idIdioma)
        {
            try
            {
                return MPPTraduccion.Listar(idIdioma);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Modificar(int idioma, int tag, string traduccion)
        {
            try
            {
                return MPPTraduccion.Modificar(idioma, tag, traduccion);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
