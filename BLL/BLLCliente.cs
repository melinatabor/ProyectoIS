using BE;
using MPP;

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
