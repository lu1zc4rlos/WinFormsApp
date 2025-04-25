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
        private string EmailUsuario;

        public string EmailUsuarioPublico {
            get { return EmailUsuario; }
            set { EmailUsuario = value; }
        }

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
            EmailUsuario = textBox2.Text;
            codigoGerado = CodigoGerado();

            EmailBLL.EnviarEmailBLL(
               "Olá, " + _retornarnomedal.RetornoNome(EmailUsuario) + "\r\n\r\n" +
               "Recebemos uma solicitação para redefinir sua senha de acesso ao sistema AtendeTech.\r\n\r\n" +
               "Para confirmar essa solicitação, utilize o código abaixo dentro do aplicativo:\r\n\r\n" +
               "CÓDIGO DE VERIFICAÇÃO: " + codigoGerado + "\r\n\r\n" +
               "Se você não solicitou essa redefinição, por favor ignore esta mensagem ou entre em contato com nossa equipe de suporte.\r\n\r\n" +
               "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
               EmailUsuario,
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

                MessageBox.Show("Código verificado com sucesso!\n" +
                    "Escolha o que deseja fazer");
                button3.Visible = true;
                button4.Visible = true;

            }
            else {
                MessageBox.Show("Código invalido!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button3_Click(object sender, EventArgs e) {

            RecuperarSenhaEmail telaOriginal = new RecuperarSenhaEmail();
            telaOriginal.EmailUsuarioPublico = textBox2.Text;

            var telaNova = new TrocarSenha(telaOriginal);
            this.Hide();
            telaNova.ShowDialog();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e) {
          
            this.Hide();
            Exemplo exemplo = new Exemplo();
            exemplo.ShowDialog();
            this.Hide();
        }

        private void RecuperarSenhaEmail_Load(object sender, EventArgs e) {
            button3.Visible = false;
            button4.Visible = false;
        }
    }
     
}
