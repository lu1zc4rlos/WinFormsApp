using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access {
    public class RecuperarSenhaDAL {
        public bool RecuperarSenha (string Email, string Senha) {
            string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email AND Senha = @Senha";
            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Senha", Senha);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }

        public bool AlterarSenha(string Email, string Senha) {

            string query = "UPDATE dados_pessoais SET Senha = @Senha WHERE Email = @Email";
            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Senha", Senha);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }

        }
    }

}
