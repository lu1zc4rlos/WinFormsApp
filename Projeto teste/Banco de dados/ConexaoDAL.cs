using Npgsql;

namespace Datai_Accesso {
    public class ConexaoDAL {

            private static string _ConexaoComBanco = "Host=localhost;Username=postgres;Password=120920;Database=sistema_usuarios";
            public static NpgsqlConnection Abrir() {
                var Conexao = new NpgsqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }
    }
}
