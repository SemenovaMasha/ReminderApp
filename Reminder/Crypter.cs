using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Reminder
{
    public static class Crypter
    {
        static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
        static string key = rsa.ToXmlString(true);

        public static string Decrypt(string text)
        {
            byte[] dec = null;

            rsa.FromXmlString(key);
            dec = rsa.Decrypt(Convert.FromBase64String(text), true);

            return _toString(dec);
        }

        private static string _toString(byte[] decrContent)
        {
            return Encoding.UTF8.GetString(decrContent);
        }

        private static byte[] _toByte(string text)
        {
            return Encoding.UTF8.GetBytes(text);
        }

        public static string Encrypt(string text)
        {
            byte[] enc = null;

            rsa.FromXmlString(key);
            enc = rsa.Encrypt(_toByte(text), true);

            return Convert.ToBase64String(enc);
        }
    }
}
