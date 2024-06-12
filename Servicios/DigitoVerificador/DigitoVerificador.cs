using BE;
using System;

namespace Servicios.DigitoVerificador
{
    public class DigitoVerificador
    {
        private static string _digitoVerificador;
        public static string Run(BEUsuario usuario)
        {
			try
			{
                _digitoVerificador = usuario.Nombre + usuario.Apellido + usuario.Email + usuario.Username;
                
                return Encriptador.Encriptador.Run(_digitoVerificador);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ha ocurrido un error al generar el digito verificador: {ex.Message}");
            }
        }
    }
}
