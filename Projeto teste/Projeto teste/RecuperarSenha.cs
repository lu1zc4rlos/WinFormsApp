using Regras_de_negócio;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_teste {
    public partial class RecuperarSenha : Form {
        public RecuperarSenha() {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            RecuperarSenhaEmail recuperarsenhaemail = new RecuperarSenhaEmail();
            recuperarsenhaemail.ShowDialog();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            txtSenhaAtual.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNova.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenhaNovamente.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }
        private void button1_Click(object sender, EventArgs e) {

            string email = txtEmail.Text;
            string senha = txtSenhaAtual.Text;
            string novaSenha = txtSenhaNova.Text;

            RecuperarSenhaBLL _recuperarSenhaBLL = new RecuperarSenhaBLL();

            try {
                if (_recuperarSenhaBLL.ValidarEmail(email)) {
                    if (txtSenhaNova.Text == txtSenhaNovamente.Text) {
                        label5.Visible = false;

                        _recuperarSenhaBLL.AlterarSenha(email, novaSenha);

                        MessageBox.Show("Senha Alterada com sucesso!");

                        EmailBLL.EnviarEmailBLL(
                         "Olá, " + _recuperarSenhaBLL.RetornoNome(email) + "\r\n\r\n" +
                         "Informamos que sua senha foi alterada com sucesso.\r\n\r\n" +
                         "Se você realizou essa alteração, pode desconsiderar esta mensagem.\r\n\r\n" +
                         "Caso não tenha solicitado essa mudança, recomendamos que entre em contato imediatamente com nossa equipe de suporte para garantir a segurança da sua conta.\r\n\r\n" +
                         "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                         email,
                         "Alteração de senha realizada com sucesso",
                         btnConfirmar
                        );

                        this.Hide();
                        Exemplo exemplo = new Exemplo();
                        exemplo.ShowDialog();
                    }
                    else { 
                        label5.Text = "Senha diferente";
                        label5.ForeColor = Color.Red;
                        label5.Visible = true;
                    }                 
                }
                else {
                    MessageBox.Show("E-mail ou senha atual invalidos");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void RecuperarSenha_Load(object sender, EventArgs e) {}
        private void textBox3_TextChanged(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
    }
}
