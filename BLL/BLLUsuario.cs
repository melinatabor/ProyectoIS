using BE;
using MPP;
using System.Collections.Generic;
using Servicios;
using Servicios.Encriptador;
using Abstraccion;
using System;

namespace BLL
{
    public class BLLUsuario
    {
        public static bool Agregar(BEUsuario usuario)
        {
            usuario.Activo = true;
            usuario.Password = Encriptador.Run(usuario.Password);
            return MPPUsuario.Guardar(usuario);
        }

        public static bool Buscar(BEUsuario usuario)
        {
            usuario.Password = Encriptador.Run(usuario.Password);
            return MPPUsuario.Buscar(usuario);
        }

        public static List<BEUsuario> Listar()
        {
            return MPPUsuario.Listar();
        }

        public static bool Guardar(BEUsuario usuario)
        {
            return MPPUsuario.Guardar(usuario);
        }

        public static BEUsuario ObtenerUsuario(int idUsuario)
        {
            return MPPUsuario.Obtener(idUsuario);
        }

        public static bool Eliminar(BEUsuario usuario)
        {
            return MPPUsuario.Baja(usuario);
        }

        public static BEUsuario BuscarUsuario(BEUsuario usuario)
        {
            usuario.Password = Encriptador.Run(usuario.Password);
            return MPPUsuario.BuscarUsuario(usuario);
        }
    }
}
