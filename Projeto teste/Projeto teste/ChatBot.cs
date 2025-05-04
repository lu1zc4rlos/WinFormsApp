using System;
using System.Drawing;
using System.Windows.Forms;
using Regras_de_negócio;

namespace Projeto_teste {
    public partial class ChatBot : Form {
        public ChatBot() {
            InitializeComponent();
        }
        private void AdicionarMensagem(string mensagem, bool ehUsuario) {
            Label lbl = new Label();
            lbl.Text = mensagem;
            lbl.Font = new Font("Segoe UI", 10);
            lbl.MaximumSize = new Size(flowExibirChat.Width - 100, 0);
            lbl.AutoSize = true;
            lbl.Padding = new Padding(10);
            lbl.BackColor = ehUsuario ? Color.LightGreen : Color.LightGray;
            lbl.Margin = new Padding(5);

            FlowLayoutPanel linha = new FlowLayoutPanel();
            linha.FlowDirection = FlowDirection.LeftToRight;
            linha.WrapContents = false;
            linha.Width = flowExibirChat.Width - 25;
            linha.AutoSize = true;
            linha.Padding = new Padding(5);

            if (ehUsuario) {
                linha.Controls.Add(new Label() { Width = linha.Width - lbl.PreferredWidth - 20 }); 
                linha.Controls.Add(lbl);
            }
            else {
                linha.Controls.Add(lbl); 
            }

            flowExibirChat.Controls.Add(linha);
            flowExibirChat.ScrollControlIntoView(linha);
        }
        private async void btnEnviarMensagem_Click(object sender, EventArgs e) { 
            string mensagem = txtEnviarMensagem.Text.Trim();

            if (!string.IsNullOrEmpty(mensagem)) {
                AdicionarMensagem(mensagem, true);

                try {
                    string resposta = await ChatBLL.ProcessarMensagemAsync(mensagem);
                    AdicionarMensagem(resposta, false);
                }
                catch (Exception ex) {
                    AdicionarMensagem("Erro ao processar resposta: " + ex.Message, false);
                }

                txtEnviarMensagem.Clear();
            }
        }
        private void Exemplo_Load(object sender, EventArgs e) {}
        private void txtEnviarMensagem_TextChanged(object sender, EventArgs e) {}
    }
}
