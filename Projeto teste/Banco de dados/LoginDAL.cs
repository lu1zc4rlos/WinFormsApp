using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Regras_de_negócio;

namespace Data_Access {
    public class LoginDAL {
        public bool VerificarLogin(string Email, string Senha) {


            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentException("O e-mail não pode estar vazio.");
            if (string.IsNullOrWhiteSpace(Senha))
                throw new ArgumentException("A senha não pode estar vazia.");

            try {
                string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email AND Senha = @Senha";
                using (var conexao = ConexaoDAL.Abrir())
                using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@Email", Email);

                    string senhaHash = CriptografiaDAL.GerarHashSenha(Senha);
                    comando.Parameters.AddWithValue("@Senha", senhaHash);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (MySqlException ex) {

                throw new Exception("Erro no banco de dados", ex);

            }

        }
    }
}
