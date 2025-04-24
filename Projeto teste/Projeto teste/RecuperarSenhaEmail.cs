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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_teste {

    public partial class RecuperarSenhaEmail : Form {

        private string codigoGerado;

        public string CodigoGerado() {
            RecuperarSenhaBLL _codigo = new RecuperarSenhaBLL();
            string codigo = _codigo.GerarCodigoSeguro();

            return codigo;

        }
        public RecuperarSenhaEmail() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {

            RecuperarSenhaBLL _retornarnomedal = new RecuperarSenhaBLL();
            string email = textBox2.Text;
            codigoGerado = CodigoGerado();

            EmailBLL.EnviarEmailBLL(
               "Olá, " + _retornarnomedal.RetornoNome(email) + "\r\n\r\n" +
               "Recebemos uma solicitação para redefinir sua senha de acesso ao sistema AtendeTech.\r\n\r\n" +
               "Para confirmar essa solicitação, utilize o código abaixo dentro do aplicativo:\r\n\r\n" +
               "CÓDIGO DE VERIFICAÇÃO: " + codigoGerado + "\r\n\r\n" +
               "Se você não solicitou essa redefinição, por favor ignore esta mensagem ou entre em contato com nossa equipe de suporte.\r\n\r\n" +
               "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
               email,
               "Código para redefinição de senha",
               button1
            );

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {
        }

        private void textBox1_TextChanged(object sender, EventArgs e, string codigo) {

        }

        private void button2_Click_1(object sender, EventArgs e) {
            if (codigoGerado == textBox1.Text) {

                this.Hide();
                Exemplo exemplo = new Exemplo();
                exemplo.ShowDialog();
                this.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }
     
}
