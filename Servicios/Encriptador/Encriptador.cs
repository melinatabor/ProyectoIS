using System;
using System.Security.Cryptography;
using System.Text;

namespace Servicios.Encriptador
{
    public class Encriptador
    {
        static public string Run(string str)
        {
            UnicodeEncoding ue = new UnicodeEncoding();
            byte[] bytess = ue.GetBytes(str);

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(bytess);

            return Convert.ToBase64String(hash);
        }
    }
}
