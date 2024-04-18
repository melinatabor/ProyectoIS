using BE;
using MPP;

namespace BLL
{
    public class BLLUsuario
    {
        static public bool Agregar(BEUsuario usuario)
        {
            return MPPUsuario.Alta(usuario);
        }
    }
}
