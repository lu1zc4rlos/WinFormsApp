
using Npgsql;
using System;

namespace Datai_Accesso {
    public class RecuperarSenhaDAL {
        public bool ValidarEmail(string email) {

            try {
                string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email";
                using (var conexao = ConexaoDAL.Abrir())
                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (NpgsqlException ex) {

                throw new Exception("Erro no banco de dados", ex);
            }
        }

        public bool AlterarSenha(string email, string novaSenha) {

            try {
                string query = "UPDATE dados_pessoais SET Senha = @Senha WHERE Email = @Email";
                using (var conexao = ConexaoDAL.Abrir())
                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@Email", email);

                    string novaSenhaHash = CriptografiaDAL.GerarHashSenha(novaSenha);
                    comando.Parameters.AddWithValue("@Senha", novaSenhaHash);

                    int rowsAffected = comando.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (NpgsqlException ex) {

                throw new Exception("Erro no banco de dados", ex);
            }

        }

        public string RetornoNome(string email) {

            try {
                using (var conexao = ConexaoDAL.Abrir()) {
                    string query = "SELECT nome FROM dados_pessoais WHERE email = @email";
                    using (var comando = new NpgsqlCommand(query, conexao)) {
                        comando.Parameters.AddWithValue("@email", email);

                        using (var reader = comando.ExecuteReader()) {
                            if (reader.Read()) {
                               // return reader.GetString("nome");
                            }
                        }
                    }
                }

                return null;
            }
            catch (NpgsqlException ex) {

                throw new Exception("Erro no banco de dados", ex);
            }
        }
    }

}
