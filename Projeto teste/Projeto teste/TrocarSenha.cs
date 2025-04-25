using Regras_de_negócio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_teste {
    public partial class TrocarSenha : Form {

        private RecuperarSenhaEmail _referencia;

        public TrocarSenha(RecuperarSenhaEmail tela) {
            InitializeComponent();
            _referencia = tela;
        }

        public TrocarSenha() {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e) {

            string email = _referencia.EmailUsuarioPublico;

            string SenhaAlterada = textBox3.Text;


            RecuperarSenhaBLL _recuperarsenhabll = new RecuperarSenhaBLL();
            RecuperarSenhaBLL _alterarsenhadal = new RecuperarSenhaBLL();
            RecuperarSenhaBLL _retornarnomedal = new RecuperarSenhaBLL();

                if (textBox2.Text == textBox3.Text) {
                    label5.Visible = false;
                    _alterarsenhadal.AlterarSenha(email, SenhaAlterada);
                    MessageBox.Show("Senha Alterada com sucesso!");

                    EmailBLL.EnviarEmailBLL(
                     "Olá, " + _retornarnomedal.RetornoNome(email) + "\r\n\r\n" +
                     "Informamos que sua senha foi alterada com sucesso.\r\n\r\n" +
                     "Se você realizou essa alteração, pode desconsiderar esta mensagem.\r\n\r\n" +
                     "Caso não tenha solicitado essa mudança, recomendamos que entre em contato imediatamente com nossa equipe de suporte para garantir a segurança da sua conta.\r\n\r\n" +
                     "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                     email,
                     "Alteração de senha realizada com sucesso",
                     button1
                    );


                    this.Hide();
                    Exemplo exemplo = new Exemplo();
                    exemplo.ShowDialog();
                    this.Hide();
                }
                else {
                    label5.Text = "Senha diferente";
                    label5.ForeColor = Color.Red;
                    label5.Visible = true;
                }

            
        }
    }
}
