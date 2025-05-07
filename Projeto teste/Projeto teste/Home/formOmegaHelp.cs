using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regras_de_negócio;

namespace Projeto_teste.Home
{
    public partial class formOmegaHelp : Form
    {
        public formOmegaHelp()
        {
            InitializeComponent();
        }
        private void AdicionarMensagem(string mensagem, bool ehUsuario)
        {
            Label lbl = new Label();
            lbl.Text = mensagem;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.MaximumSize = new Size(flowLayoutPanelChat.Width - 100, 0);
            lbl.AutoSize = true;
            lbl.Padding = new Padding(10);
            lbl.BackColor = ehUsuario ? Color.LightGreen : Color.LightGray;
            lbl.Margin = new Padding(5);

            FlowLayoutPanel linha = new FlowLayoutPanel();
            linha.FlowDirection = FlowDirection.LeftToRight;
            linha.WrapContents = false;
            linha.Width = flowLayoutPanelChat.Width - 25;
            linha.AutoSize = true;
            linha.Padding = new Padding(5);

            if (ehUsuario)
            {
                linha.Controls.Add(new Label() { Width = linha.Width - lbl.PreferredWidth - 20 });
                linha.Controls.Add(lbl);
            }
            else
            {
                linha.Controls.Add(lbl);
            }

            flowLayoutPanelChat.Controls.Add(linha);
            flowLayoutPanelChat.ScrollControlIntoView(linha);
        }
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensagem = txtEnviarMensagem.Text.Trim();

            if (!string.IsNullOrEmpty(mensagem))
            {
                AdicionarMensagem(mensagem, true);

                try
                {
                    string resposta = await ChatBLL.ProcessarMensagemAsync(mensagem);
                    AdicionarMensagem(resposta, false);
                }
                catch (Exception ex)
                {
                    AdicionarMensagem("Erro ao processar resposta: " + ex.Message, false);
                }

                txtEnviarMensagem.Clear();
            }
        }

        private void formOmegaHelp_Load(object sender, EventArgs e)
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
    }
}
