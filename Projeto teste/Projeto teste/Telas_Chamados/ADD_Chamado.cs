using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datai_Accesso;
using Entidades;
using Npgsql;
using Regras_de_negócio;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Projeto_teste.Login;

namespace ProjetoTeste.Telas_Chamados
{
    public partial class ADD_Chamado : Form
    {
        public ADD_Chamado()
        {
            InitializeComponent();
        }
        public void AdicionarTicket(Ticket ticket)
        {

            string CadastrarTicket = "insert into ticket (Tipo, Descricao, Prioridade, Status, Usuario_Id) values(@Tipo,@Descricao,@Prioridade,@Status, @Usuario_Id)";

            using (var conexao = ConexaoDAL.Abrir())
            using (NpgsqlCommand comando = new NpgsqlCommand(CadastrarTicket, conexao))
            {

                try
                {
                    comando.Parameters.AddWithValue("@Tipo", ticket.Tipo);
                    comando.Parameters.AddWithValue("@Descricao", ticket.Descricao);
                    comando.Parameters.AddWithValue("@Prioridade", ticket.Prioridade);
                    comando.Parameters.AddWithValue("@Status", ticket.Status);
                    comando.Parameters.AddWithValue("@Usuario_Id", ticket.Usuario_Id);


                    comando.ExecuteNonQuery();
                }
                catch (NpgsqlException ex)
                {

                    throw new Exception("Erro no banco de dados", ex);
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro inesperado: " + ex.Message);
                }
            }
        }

        public bool ExcluirTicket(int idTicket)
        {
            using (var conexao = ConexaoDAL.Abrir())
            {
                string query = "DELETE FROM ticket WHERE idticket = @Id";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", idTicket);

                    conexao.Open();

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }

        private void btn_GerarTicket_Click(object sender, EventArgs e)
        {
            
            Ticket novoTicket = new Ticket()
            {
                Tipo = "Incidente",
                Descricao = txt_desc.Text,
                Prioridade = "H",
                Status = "P",
                Usuario_Id = SessaoUsuario.UsuarioId,


            };


            AdicionarTicket(novoTicket);



        }

        
    }
}
