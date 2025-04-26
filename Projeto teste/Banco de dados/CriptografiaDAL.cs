using System;
using System.Text;
using System.Security.Cryptography;

namespace Data_Access {
    public class CriptografiaDAL {
        public static string GerarHashSenha(string senha) {
            using (var sha256 = SHA256.Create()) {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
