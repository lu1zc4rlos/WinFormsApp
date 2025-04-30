using System;
using System.Windows.Forms;
using Regras_de_negócio;

namespace Projeto_teste {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        private void btnNaoCadastrado_Click(object sender, EventArgs e) {
            this.Hide();
            using (Cadastro cadastro = new Cadastro()) {
                cadastro.ShowDialog();
            }
            this.Show();
            LimparCampos();
        }
        private void btnConfirmar_Click(object sender, EventArgs e) {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            LoginBLL loginBLL = new LoginBLL();

            try {
                if (loginBLL.ValidarLogin(email, senha)) {
                    this.Hide();
                    using (Exemplo exemplo = new Exemplo()) {
                        exemplo.ShowDialog();
                    }
                    this.Show();
                    LimparCampos();
                }
                else {
                    MessageBox.Show("E-mail ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbMostarSenha_CheckedChanged(object sender, EventArgs e) {
            txtSenha.PasswordChar = cbMostarSenha.Checked ? '\0' : '*';
        }
        private void btnRecuperrarSenha_Click(object sender, EventArgs e) {
            this.Hide();
            using (RecuperarSenha recuperarSenha = new RecuperarSenha()) {
                recuperarSenha.ShowDialog();
            }
            this.Show();
            LimparCampos();
        }
        private void LimparCampos() {
            txtEmail.Clear();
            txtSenha.Clear();
            cbMostarSenha.Checked = false;
        }
        private void txtSenha_TextChanged(object sender, EventArgs e) {
        }
        private void lblEmail_Click(object sender, EventArgs e) {
        }
        private void lblSenha_Click(object sender, EventArgs e) {
        }
        private void Login_Load(object sender, EventArgs e) {
        }
        private void txtEmail_TextChanged(object sender, EventArgs e) {
        }
    }
}