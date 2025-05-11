using System;
using System.Windows.Forms;
using Datai_Accesso;
using Regras_de_negócio;
using static Datai_Accesso.LoginDAL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Npgsql;

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

        //teste de método
        public int ObterIdUsuario(string email)
        {
            int idUsuario = 0;

            using (var conexao = ConexaoDAL.Abrir())
            {
                string query = "SELECT idusuario FROM dados_pessoais WHERE email = @Email";

                using (NpgsqlCommand comando = new NpgsqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Email", email);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        idUsuario = Convert.ToInt32(resultado);
                    }
                }
            }

            return idUsuario;
        }
        public static class SessaoUsuario
        {
            public static int UsuarioId { get; set; }
        }
        //dois métodos a cima são testes

        private void btnConfirmar_Click(object sender, EventArgs e) {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            LoginBLL loginBLL = new LoginBLL();

            try {
                if (loginBLL.ValidarLogin(email, senha)) {
                    int ID_atual = ObterIdUsuario(email);
                    SessaoUsuario.UsuarioId = ID_atual;
                    this.Hide();
                    using (Home.Home home = new Home.Home()) {
                        home.ShowDialog();
                    }
                    this.Hide();
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