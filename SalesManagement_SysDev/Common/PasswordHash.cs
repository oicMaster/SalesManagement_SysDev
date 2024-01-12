using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement_SysDev.Common
{
    internal class PasswordHash
    {

        public void GenerateSalt(string password)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[16]; // 16バイトのソルト
            rng.GetBytes(saltBytes);

            string saltText = Convert.ToBase64String(saltBytes);
            string saltedPassword = saltText + password;

            string hashedPassword = HashPassword(saltedPassword);
        }

        public string HashPassword(string password)
        {


            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }


        }

        public string HashPasswordWithStretching(string password, string salt, int iterations)
        {
            // 初回にソルトとパスワードを結合
            string saltedPassword = salt + password;

            // 初回のハッシュ計算
            string hash = HashPassword(saltedPassword);

            // 追加のハッシュ計算
            for (int i = 0; i < iterations - 1; i++)
            {
                hash = HashPassword(hash);
            }

            return hash;
        }
    }
}
