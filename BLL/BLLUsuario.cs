using BE;
using MPP;
using System.Collections.Generic;

namespace BLL
{
    public class BLLUsuario
    {
        static public bool Agregar(BEUsuario usuario)
        {
            // Encriptar psw. Desde donde?
            usuario.Activo = true;
            return MPPUsuario.Alta(usuario);
        }

        static public List<BEUsuario> Listar()
        {
            return MPPUsuario.Listar();
        }
    }
}
