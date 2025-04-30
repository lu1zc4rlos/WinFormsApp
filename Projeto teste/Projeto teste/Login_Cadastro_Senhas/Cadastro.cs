using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Forms;
using Regras_de_negócio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_teste {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }
        private void InitializeComponent() {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmailCadastrado = new System.Windows.Forms.Label();
            this.atpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblSenhaDiferente = new System.Windows.Forms.Label();
            this.btnVoltarLogin = new System.Windows.Forms.Button();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(137, 118);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(190, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(137, 162);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(133, 16);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(190, 204);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(205, 22);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(137, 210);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(137, 290);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(110, 16);
            this.lblConfirmarSenha.TabIndex = 6;
            this.lblConfirmarSenha.Text = "Confirmar senha: ";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(226, 330);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 36);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tela de Cadastro";
            // 
            // lblEmailCadastrado
            // 
            this.lblEmailCadastrado.AutoSize = true;
            this.lblEmailCadastrado.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailCadastrado.ForeColor = System.Drawing.Color.Red;
            this.lblEmailCadastrado.Location = new System.Drawing.Point(411, 210);
            this.lblEmailCadastrado.Name = "lblEmailCadastrado";
            this.lblEmailCadastrado.Size = new System.Drawing.Size(0, 16);
            this.lblEmailCadastrado.TabIndex = 10;
            this.lblEmailCadastrado.Click += new System.EventHandler(this.label6_Click);
            // 
            // atpDataNascimento
            // 
            this.atpDataNascimento.Location = new System.Drawing.Point(256, 156);
            this.atpDataNascimento.Name = "atpDataNascimento";
            this.atpDataNascimento.Size = new System.Drawing.Size(103, 22);
            this.atpDataNascimento.TabIndex = 11;
            this.atpDataNascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(351, 247);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(114, 20);
            this.cbMostrarSenha.TabIndex = 12;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(190, 245);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(155, 22);
            this.txtSenha.TabIndex = 14;
            this.txtSenha.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(137, 251);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha:";
            // 
            // lblSenhaDiferente
            // 
            this.lblSenhaDiferente.AutoSize = true;
            this.lblSenhaDiferente.Location = new System.Drawing.Point(395, 293);
            this.lblSenhaDiferente.Name = "lblSenhaDiferente";
            this.lblSenhaDiferente.Size = new System.Drawing.Size(0, 16);
            this.lblSenhaDiferente.TabIndex = 15;
            // 
            // btnVoltarLogin
            // 
            this.btnVoltarLogin.Location = new System.Drawing.Point(360, 377);
            this.btnVoltarLogin.Name = "btnVoltarLogin";
            this.btnVoltarLogin.Size = new System.Drawing.Size(168, 35);
            this.btnVoltarLogin.TabIndex = 16;
            this.btnVoltarLogin.Text = "Voltar para tela de login";
            this.btnVoltarLogin.UseVisualStyleBackColor = true;
            this.btnVoltarLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.Location = new System.Drawing.Point(212, 284);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.PasswordChar = '*';
            this.txtConfirmarSenha.Size = new System.Drawing.Size(177, 22);
            this.txtConfirmarSenha.TabIndex = 17;
            this.txtConfirmarSenha.TextChanged += new System.EventHandler(this.txtConfirmarSenha_TextChanged);
            // 
            // Cadastro
            // 
            this.ClientSize = new System.Drawing.Size(555, 424);
            this.Controls.Add(this.txtConfirmarSenha);
            this.Controls.Add(this.btnVoltarLogin);
            this.Controls.Add(this.lblSenhaDiferente);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.atpDataNascimento);
            this.Controls.Add(this.lblEmailCadastrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private RecuperarSenhaBLL _requisitosSenhaBLL = new RecuperarSenhaBLL ();

        private void btnConfirmar_Click(object sender, EventArgs e) {
            DateTime Data = atpDataNascimento.Value.Date;

            Usuario novoUsuario = new Usuario() {
                Nome = txtNome.Text,
                Data_Nascimento = Data,
                Email = txtEmail.Text.Trim(),
                Senha = txtConfirmarSenha.Text,
            };

            lblEmailCadastrado.Visible = false;
            lblSenhaDiferente.Visible = false;

            if (string.IsNullOrWhiteSpace(novoUsuario.Nome) ||
                string.IsNullOrWhiteSpace(novoUsuario.Email) ||
                string.IsNullOrWhiteSpace(novoUsuario.Senha) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text)) {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_requisitosSenhaBLL.ValidarSenha(txtConfirmarSenha.Text)) {
                MessageBox.Show("Senha inválida! A senha deve ter:\n- Pelo menos 8 caracteres" +
                "\n- Uma letra maiúscula\n- Um número\n- Um caractere especial.");
                return;
            }
            if (txtSenha.Text != txtConfirmarSenha.Text) {
                lblSenhaDiferente.Text = "As senhas não coincidem.";
                lblSenhaDiferente.ForeColor = Color.Red;
                lblSenhaDiferente.Visible = true;
                return;
            }
            try {

                if (_usuarioBLL.EmailJaCadastrado(novoUsuario)) {
                    lblEmailCadastrado.Text = "Email já cadastrado";
                    lblEmailCadastrado.ForeColor = Color.Red;
                    lblEmailCadastrado.Visible = true;
                    return;
                }

                _usuarioBLL.AdicionarUsuario(novoUsuario);

                if (!EmailBLL.EmailValido(novoUsuario.Email)) {
                    MessageBox.Show("E-mail inválido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                EmailBLL.EnviarEmailBLL("Olá, " + novoUsuario.Nome + "\r\n\r\n" +
                    "Seja bem-vindo ao AtendeTech, o seu novo assistente virtual de ajuda e suporte técnico.\r\n\r\n" +
                    "Estamos muito contentes em tê-lo como usuário da nossa plataforma. O AtendeTech foi desenvolvido para tornar seu atendimento mais rápido, eficiente e acessível, sempre que você precisar de suporte técnico.\r\n\r\n" +
                    "Com o AtendeTech, você pode:\r\n\r\nObter respostas para dúvidas técnicas com agilidade\r\n\r\nReceber instruções passo a passo para resolver problemas\r\n\r\nAcessar suporte a qualquer hora, de forma simples e intuitiva\r\n\r\n" +
                    "Contar com um serviço confiável e sempre disponível\r\n\r\nSe tiver qualquer dúvida ou sugestão, nossa equipe está à disposição para ajudá-lo.\r\n\r\nAtenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                    novoUsuario.Email,
                    "Sua conta foi criada com sucesso - seja bem-vindo(a)!",
                    btnConfirmar
                );

                MessageBox.Show("Usuário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                Exemplo exemplo = new Exemplo();
                exemplo.ShowDialog();
                this.Close();
            }
            catch(Exception ex){

                MessageBox.Show("Ocorreu um erro ao adicionar o usuário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
        private void Cadastro_Load(object sender, EventArgs e) {
            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            atpDataNascimento.Format = DateTimePickerFormat.Custom;
            atpDataNascimento.CustomFormat = "dd/MM/yyyy";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

            atpDataNascimento.MaxDate = DateTime.Today;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            txtConfirmarSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
            txtSenha.PasswordChar = cbMostrarSenha.Checked ? '\0' : '*';
        }
        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e) {}
        private void textBox1_TextChanged(object sender, EventArgs e) {}
        private void label6_Click(object sender, EventArgs e) {}
        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void textBox4_TextChanged(object sender, EventArgs e) {}
    }

    [Serializable]
    internal class FormaException : Exception {
        public FormaException() {
        }
        public FormaException(string message) : base(message) {
        }
        public FormaException(string message, Exception innerException) : base(message, innerException) {
        }
        protected FormaException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
