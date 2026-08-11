using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia.seguridad
{
    public class Encriptado
    {

        public static string EncriptarClave(string ClaveOriginal)
        {
            using (SHA256 sha256hasH = SHA256.Create())
            {
                byte[] bytes = sha256hasH.ComputeHash(Encoding.UTF8.GetBytes(ClaveOriginal));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
