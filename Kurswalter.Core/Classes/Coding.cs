using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace KursWalter.Core.Classes
{
    public class Coding
    {
        private readonly byte[] salt = System.Text.Encoding.UTF8.GetBytes("my salt :)");
        public string generateHashMD5(string password)
        { 
            var cryptpassword = Encoding.UTF8.GetBytes(password);
            
            var hmacMD5 = new HMACMD5(salt);
            var saltedHash = hmacMD5.ComputeHash(cryptpassword);

           

            return Convert.ToBase64String(cryptpassword);
        }

        public string generateHashSHA(string password)
        {
            var cryptpassword = Encoding.UTF8.GetBytes(password);
            var hmacSHA1 = new HMACSHA1(salt);
            var saltedHashSHA = hmacSHA1.ComputeHash(cryptpassword);

            return Convert.ToBase64String(cryptpassword);
        }
    }
}
