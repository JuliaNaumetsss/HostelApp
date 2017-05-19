using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace HostelApplication
{
    public class EncryptionClass
    {
        public string GetHashString(string s)
        {
            // convert string to byte-array
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            // create MD5CryptoServiceProvider object
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            // calculate hash-value (in bytes)
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            // generate entire string
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
}
