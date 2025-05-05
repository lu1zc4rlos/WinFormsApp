using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;


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
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=pim;Database=sistema_usuarios";

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT id, tipo, descricao, prioridade FROM chamados";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_chamados.AutoGenerateColumns = false; // importante!
                    dgv_chamados.DataSource = dt;
                }
            }
        }

        private void btn_attchamados_Click(object sender, EventArgs e)
        {
            CarregarChamados();
        }
    }
}
