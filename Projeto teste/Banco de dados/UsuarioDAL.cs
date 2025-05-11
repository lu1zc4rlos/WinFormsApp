using System;
using Datai_Accesso;
using Npgsql;
using Regras_de_negócio;


namespace Banco_de_dados {

    public class UsuarioDAL {

        public void AdicionarUsuario(Usuario usuario) {

            string CadastrarUser = "insert into dados_pessoais (Nome, Data_Nascimento, Email, Senha) values(@Nome,@Data_Nascimento,@Email,@Senha)";

            using (var conexao = ConexaoDAL.Abrir())
            using (NpgsqlCommand comando = new NpgsqlCommand(CadastrarUser, conexao)) {

                try {
                    comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                    comando.Parameters.AddWithValue("@Data_Nascimento", usuario.Data_Nascimento);
                    comando.Parameters.AddWithValue("@Email", usuario.Email);

                    string senhaHash = CriptografiaDAL.GerarHashSenha(usuario.Senha);
                    comando.Parameters.AddWithValue("@Senha", senhaHash);

                    comando.ExecuteNonQuery();
                }
                catch (NpgsqlException ex) {

                    throw new Exception("Erro no banco de dados", ex);
                }
                catch (Exception ex) {
                    throw new Exception("Erro inesperado: " + ex.Message);
                }
            }
        }

        public bool EmailJaCadastrado(Usuario usuario) {

            if (string.IsNullOrWhiteSpace(usuario.Email))
                throw new ArgumentException("O e-mail não pode estar vazio.");
            try {
                string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email";
                using (var conexao = ConexaoDAL.Abrir())
                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@Email", usuario.Email);
                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (NpgsqlException ex) {

                throw new Exception("Erro no banco de dados", ex);
            }

        }
        public Usuario BuscarUsuarioPorId(int id)
        {
            Usuario usuario = null;
            string query = "SELECT idusuario, nome, email FROM dados_pessoais WHERE idusuario = @id";

            using (var conexao = ConexaoDAL.Abrir())
            using (var comando = new NpgsqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@id", id);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        usuario = new Usuario
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Email = reader.GetString(2)
                        };
                    }
                }
            }
            return usuario;
        }


    }
}
