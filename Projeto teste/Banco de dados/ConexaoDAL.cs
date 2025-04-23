using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access {
    public class ConexaoDAL {

            private static string _ConexaoComBanco = "Server=localhost;Uid=root;Pwd=120920;Database=usuarios";
            public static MySqlConnection Abrir() {
                var Conexao = new MySqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }
    }
}
