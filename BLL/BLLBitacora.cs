using BE;
using MPP;
using Servicios.Encriptador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBitacora
    {
        public static bool Agregar(BEBitacora bitacora)
        {
            return MPPBitacora.Agregar(bitacora);
        }
    }
}
