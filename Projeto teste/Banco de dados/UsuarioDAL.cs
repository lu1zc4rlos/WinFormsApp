using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access;
using MySql.Data.MySqlClient;
using Regras_de_negócio;


namespace Banco_de_dados {

    public class UsuarioDAL {

        public void AdicionarUsuario(Usuario usuario) {

            string CadastrarUser = "insert into dados_pessoais (Nome, Data_Nascimento, Email, Senha) values(@Nome,@Data_Nascimento,@Email,@Senha)";

            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(CadastrarUser, conexao)) {

                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Data_Nascimento", usuario.Data_Nascimento);
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                comando.Parameters.AddWithValue("@Senha", usuario.Senha);


                comando.ExecuteNonQuery();
            }
        }

        public bool EmailJaCadastrado(Usuario usuario) {
            string query = "SELECT COUNT(*) FROM dados_pessoais WHERE Email = @Email";
            using (var conexao = ConexaoDAL.Abrir())
            using (MySqlCommand comando = new MySqlCommand(query, conexao)) {
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                int count = Convert.ToInt32(comando.ExecuteScalar());
                return count > 0;
            }
        }

    }
}
