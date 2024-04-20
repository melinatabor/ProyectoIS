using System;
using Abstraccion;

namespace Servicios.SesionManager
{
    public class SesionManager
    {
        private static SesionManager _session = null;

        private IUsuario _usuario { get; set; }

        private SesionManager() { }

        public static void Login(IUsuario usuario)
        {
            try
            {
                if (_session == null)
                {
                    _session = new SesionManager();
                    _session._usuario = usuario;
                }
                else
                    throw new Exception("Sesion no iniciada");

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static SesionManager GetInstance()
        {
            if (_session == null)
                throw new Exception("Sesion no iniciada");
            return _session;
        }

        public IUsuario GetUsuario() { return  _usuario; }

    }
}
