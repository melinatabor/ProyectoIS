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
            return MPPUsuario.Alta(usuario);
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

        public static BEUsuario ObtenerUsuario(int idUsuario)
        {
            return MPPUsuario.Obtener(idUsuario);
        }
    }
}
