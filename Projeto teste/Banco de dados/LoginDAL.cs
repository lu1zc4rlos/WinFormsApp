using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regras_de_negócio;

namespace Data_Access {
    public class LoginDAL {
        private static class Conexao {

            private static string _ConexaoComBanco = "Server=localhost;Uid=root;Pwd=120920;Database=usuarios";

            public static MySqlConnection Abrir() {
                var Conexao = new MySqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }

        }

        public bool VerificarLogin(string Email, string Senha) {
            string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email AND Senha = @Senha";
            using (var conexao = Conexao.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Senha", Senha);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
