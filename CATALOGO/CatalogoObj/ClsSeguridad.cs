using System;
using System.Security.Cryptography;
using System.Text;

namespace CATALOGO.CatalogoObj
{
    public static class ClsSeguridad
    {

        /// Esta clase contiene funciones para encriptar/desencriptar
        /// El ser estática no es necesario instanciar un objeto para 
        /// usar las funciones Encriptar y DesEncriptar

        /// Encripta una cadena
        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static string GetSHA256(this string pStr)
        {
            SHA256 _Sha256 = SHA256Managed.Create();
            ASCIIEncoding _Encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder _Sb = new StringBuilder();
            stream = _Sha256.ComputeHash(_Encoding.GetBytes(pStr));
            for (int i = 0; i < stream.Length; i++) _Sb.AppendFormat("{0:x2}", stream[i]);
            return _Sb.ToString();
        }
    }
}

