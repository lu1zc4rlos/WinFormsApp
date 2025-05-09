using Npgsql;

namespace Datai_Accesso {
    public class ConexaoDAL {

            private static string _ConexaoComBanco = "Host=26.64.207.115;Username=postgres;Password=pim;Database=Omega_DB";
            public static NpgsqlConnection Abrir() {
                var Conexao = new NpgsqlConnection(_ConexaoComBanco);
                Conexao.Open();
                return Conexao;

            }
    }
}
