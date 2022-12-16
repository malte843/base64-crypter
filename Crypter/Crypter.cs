using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypter
{
    internal class Crypter
    {

        public static String Base64Encode(String txt)
        {
            var bytes = Encoding.UTF8.GetBytes(txt);
            var encrypted = Convert.ToBase64String(bytes);

            return encrypted;
        }

        public static String Base64Decode(String txt)
        {
            var bytes = Convert.FromBase64String(txt);
            var decrypted = Encoding.UTF8.GetString(bytes);

            return decrypted;
        }

    }
}
