using System;
using System.Text.RegularExpressions;

namespace Servicios.ValidadorEmail
{
    public class ValidadorEmail
    {
        private static string _patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        public static bool Validar(string email)
        {
			try
			{
                return Regex.IsMatch(email, _patron);
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
