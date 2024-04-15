using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        static public bool Agregar(BECliente cliente)
        {
            return MPPCliente.Alta(cliente);
        }
    }
}
