using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Reminder_desktop_application
{
    public static class Crypter
    {
        static string hash = "rEm@iN10eR";

        public static string Decrypt(string text)
        {
            byte[] dec = null;
            byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tD = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tr = tD.CreateDecryptor();
                    dec = tr.TransformFinalBlock(data, 0, data.Length);
                }
            }
            if (dec == null)
            {
                throw new Exception("Ошибка при расшифровке");
            }
            return UTF8Encoding.UTF8.GetString(dec);
        }

        public static string Encrypt(string text)
        {
            byte[] enc = null;
            byte[] data = UTF32Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tD = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tr = tD.CreateEncryptor();
                    enc = tr.TransformFinalBlock(data, 0, data.Length);
                }
            }
            if (enc == null)
            {
                throw new Exception("Ошибка при шифровке");
            }
            return Convert.ToBase64String(enc);
        }

    }
}
