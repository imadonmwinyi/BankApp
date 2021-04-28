using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Commons
{
    public class PasswordHash
    {
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }


        // compare password hash
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static string ConvertPassWordHashToString(byte[] password)
        {
            var pwdString = System.Text.Encoding.UTF8.GetString(password, 0, password.Length);
            return pwdString;
        }
        public static byte[] ConvertStringPassWordByteToString(string pwd)
        {
            var password = System.Text.Encoding.UTF8.GetBytes(pwd);
            return password;
        }
        public static string AltHashTOString(byte[] password)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < password.Length; i++)
            {
                builder.Append(password[i].ToString("x2"));
            }
            return builder.ToString();
        }
    }
}
