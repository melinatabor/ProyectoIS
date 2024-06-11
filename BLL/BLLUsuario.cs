using BE;
using MPP;
using System.Collections.Generic;
using Servicios.Encriptador;
using System;
using Servicios.SesionManager;
using static BE.BEBitacora;
using Abstraccion;

namespace BLL
{
    public class BLLUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            try
            {
                usuario.Activo = true;
                usuario.Password = Encriptador.Run(usuario.Password);
                return MPPUsuario.Agregar(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Editar(BEUsuario usuario)
        {
            try
            {
                return MPPUsuario.Editar(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static List<BEUsuario> Listar()
        {
            try
            {
                return MPPUsuario.Listar();
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario ObtenerUsuario(int idUsuario)
        {
            try
            {
                return MPPUsuario.Obtener(idUsuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool Eliminar(BEUsuario usuario)
        {
            try
            {
                return MPPUsuario.Baja(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            try
            {
                usuario.Password = Encriptador.Run(usuario.Password);
                return MPPUsuario.BuscarUsuario(usuario);
            }
            catch (Exception ex) { throw ex; }
        }

        public static BEUsuario BuscarUsuarioPorUsername(string username)
        {
            try
            {
                return MPPUsuario.BuscarUsuarioPorUsername(username);
            }
            catch (Exception ex) { throw ex; }
        }

        public static void Login(BEUsuario usuario)
        {
            try
            {
                BEUsuario usuarioExistente = BLLUsuario.BuscarUsuario(usuario) 
                    ?? throw new Exception("Credenciales incorrectas. Por favor vuelva a ingresar los datos correctamente.");

                SesionManager.Login(usuarioExistente);

                BEBitacora bitacora = new BEBitacora()
                {
                    Usuario = usuarioExistente.Id,
                    Tipo    = BitacoraTipo.INFO,
                    Mensaje = "El usuario inició sesión"
                };

                BLLBitacora.Agregar(bitacora);


            }
            catch (Exception ex) { throw ex; }
        }

        public static bool AsignarPermiso(BEUsuario usuario, BEPermiso permiso)
        {
            try
            {
                return MPPUsuario.AsignarPermiso(usuario, permiso);
            }
            catch (Exception ex) { throw ex; }
        }

        public static bool VerificarPermiso(BEUsuario usuarioActual, int permiso)
        {
            try
            {
                return MPPUsuario.VerificarPermiso(usuarioActual, permiso);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
