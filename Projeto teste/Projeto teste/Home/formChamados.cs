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
using Npgsql;
using ProjetoTeste.Telas_Chamados;


namespace Projeto_teste.Home
{
    public partial class formChamados : Form
    {
        public formChamados()
        {
            InitializeComponent();
        }

        private void formChamados_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.Dock = DockStyle.Fill;
        }

        Home home;
        private void pic_home_Click(object sender, EventArgs e)
        {
            home = new Home();
            home.FormClosed += (s, args) => Application.Exit();
            home.Show();
            this.Hide();

        }


        private void CarregarChamados()
        {

            using (var conexao = ConexaoDAL.Abrir())
            {
                string query = "SELECT id_ticket, tipo, descricao, prioridade, status FROM ticket";

                using (var da = new NpgsqlDataAdapter(query, conexao))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_chamados.AutoGenerateColumns = false; // importante!
                    dgv_chamados.DataSource = dt;
                }
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarChamados();
        }

        ADD_Chamado TelaChamado;
        private void btn_addchamado_Click(object sender, EventArgs e)
        {
            if (TelaChamado == null)
            {
                TelaChamado = new ADD_Chamado();
                TelaChamado.FormClosed += TelaChamado_FormClosed;
                this.Hide();
                TelaChamado.Show();
                TelaChamado.FormClosed += (s, args) => Application.Exit();
            }
            else
            {
                TelaChamado.Activate();
            }
        }

        private void TelaChamado_FormClosed(object sender, FormClosedEventArgs e)
        {
            TelaChamado = null;
        }


        //métodos para teste abaixo
        public bool ExcluirTicket(int idTicket)
        {
            using (var conexao = ConexaoDAL.Abrir())
            {
                string query = "DELETE FROM ticket WHERE id_ticket = @Id";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", idTicket);


                    int linhasAfetadas = comando.ExecuteNonQuery();
                    return linhasAfetadas > 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdTicket.Text); // ou o ID vindo da seleção em uma tabela

            bool sucesso = ExcluirTicket(id);

            if (sucesso)
                MessageBox.Show("Ticket excluído com sucesso!");
            else
                MessageBox.Show("Falha ao excluir o ticket.");
        }
    }
}

