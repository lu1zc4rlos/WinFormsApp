using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access {
    public class RecuperarSenhaDAL {
        public bool ValidarEmail(string Email) {
            string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email";
            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", Email);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }

        public bool AlterarSenha(string Email, string novaSenha) {

            string query = "UPDATE dados_pessoais SET Senha = @Senha WHERE Email = @Email";
            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Senha", novaSenha);
                int rowsAffected = comando.ExecuteNonQuery();
                return rowsAffected > 0;
            }


        }

        public string RetornoNome(string Email) {

            using (var conexao = ConexaoDAL.Abrir()) {
                string query = "SELECT nome FROM dados_pessoais WHERE email = @email";
                using (var comando = new MySqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@email", Email);

                    using (var reader = comando.ExecuteReader()) {
                        if (reader.Read()) {
                            return reader.GetString("nome");
                        }
                    }
                }
            }

            return null;
        }
    }

}
