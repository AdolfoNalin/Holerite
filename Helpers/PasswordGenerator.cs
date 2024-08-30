using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.Helpers
{
    public class PasswordGenerator
    {
       public static string GeneratePassword(string password)
       {
            string hashpassword;
            using (SHA256 pass = SHA256.Create())
            {
                byte[] bPassword = Encoding.UTF8.GetBytes(password);
                byte[] bytes = pass.ComputeHash(bPassword);
                hashpassword = Encoding.UTF8.GetString(bytes);
            }

            return hashpassword;
       }
    }
}
