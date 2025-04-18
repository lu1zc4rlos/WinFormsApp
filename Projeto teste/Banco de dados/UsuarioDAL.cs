using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Regras_de_negócio;


namespace Banco_de_dados {

    public class UsuarioDAL {

        private static class Conexao {

            private static string _ConexaoComBanco = "Server=localhost;Uid=root;Pwd=120920;Database=usuarios";

            public static MySqlConnection Abrir() {
                var Conexao = new MySqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }

        }

        public void AdicionarUsuario(Usuario usuario) {

            string CadastrarUser = "insert into dados_pessoais (Nome, Data_Nascimento, Email, Senha) values(@Nome,@Data_Nascimento,@Email,@Senha)";

            using (var conexao = Conexao.Abrir())
            using (MySqlCommand comando = new MySqlCommand(CadastrarUser, conexao)) {

                comando.Parameters.AddWithValue("@Nome", usuario.Nome);
                comando.Parameters.AddWithValue("@Data_Nascimento", usuario.Data_Nascimento);
                comando.Parameters.AddWithValue("@Email", usuario.Email);
                comando.Parameters.AddWithValue("@Senha", usuario.Senha);


                comando.ExecuteNonQuery();
            }
        }

    }
}
