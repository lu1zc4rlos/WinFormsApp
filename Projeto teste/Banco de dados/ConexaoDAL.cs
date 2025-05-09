using Npgsql;

namespace Datai_Accesso {
    public class ConexaoDAL {

            private static string _ConexaoComBanco = "Host=IP_DO BANCO;Username=USERNAMEDOBANCO;Password=SENHASPOSTGRE;Database=NOMEDOBANCO";
            public static NpgsqlConnection Abrir() {
                var Conexao = new NpgsqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }
    }
}
