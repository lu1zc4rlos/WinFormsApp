﻿
using Npgsql;
using System;

namespace Datai_Accesso {
    public class LoginDAL {


        public bool VerificarLogin(string Email, string Senha) {


            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentException("O e-mail não pode estar vazio.");
            if (string.IsNullOrWhiteSpace(Senha))
                throw new ArgumentException("A senha não pode estar vazia.");

            try {
                string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email AND Senha = @Senha";
                using (var conexao = ConexaoDAL.Abrir())
                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao)) {
                    comando.Parameters.AddWithValue("@Email", Email);

                    string senhaHash = CriptografiaDAL.GerarHashSenha(Senha);
                    comando.Parameters.AddWithValue("@Senha", senhaHash);

                    int count = Convert.ToInt32(comando.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (NpgsqlException ex) {

                throw new Exception("Erro no banco de dados", ex);

            }

        }
    }
}
