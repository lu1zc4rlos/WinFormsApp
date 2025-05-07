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
        private void InitializeComponent()
        {
            lblNome = new Label();
            txtNome = new TextBox();
            lblDataNascimento = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblConfirmarSenha = new Label();
            btnConfirmar = new Button();
            label5 = new Label();
            lblEmailCadastrado = new Label();
            atpDataNascimento = new DateTimePicker();
            cbMostrarSenha = new CheckBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblSenhaDiferente = new Label();
            btnVoltarLogin = new Button();
            txtConfirmarSenha = new TextBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(137, 118);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(190, 115);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(205, 23);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += textBox1_TextChanged;
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(137, 162);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(117, 15);
            lblDataNascimento.TabIndex = 2;
            lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 204);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 23);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(137, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(137, 290);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(101, 15);
            lblConfirmarSenha.TabIndex = 6;
            lblConfirmarSenha.Text = "Confirmar senha: ";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(226, 330);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 36);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 61);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 9;
            label5.Text = "Tela de Cadastro";
            // 
            // lblEmailCadastrado
            // 
            lblEmailCadastrado.AutoSize = true;
            lblEmailCadastrado.BackColor = Color.Transparent;
            lblEmailCadastrado.ForeColor = Color.Red;
            lblEmailCadastrado.Location = new Point(411, 210);
            lblEmailCadastrado.Name = "lblEmailCadastrado";
            lblEmailCadastrado.Size = new Size(0, 15);
            lblEmailCadastrado.TabIndex = 10;
            lblEmailCadastrado.Click += label6_Click;
            // 
            // atpDataNascimento
            // 
            atpDataNascimento.Location = new Point(256, 156);
            atpDataNascimento.Name = "atpDataNascimento";
            atpDataNascimento.Size = new Size(103, 23);
            atpDataNascimento.TabIndex = 1;
            atpDataNascimento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Location = new Point(351, 247);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new Size(101, 19);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(190, 245);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(155, 23);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += textBox2_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(137, 251);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 13;
            lblSenha.Text = "Senha:";
            // 
            // lblSenhaDiferente
            // 
            lblSenhaDiferente.AutoSize = true;
            lblSenhaDiferente.Location = new Point(395, 293);
            lblSenhaDiferente.Name = "lblSenhaDiferente";
            lblSenhaDiferente.Size = new Size(0, 15);
            lblSenhaDiferente.TabIndex = 15;
            // 
            // btnVoltarLogin
            // 
            btnVoltarLogin.Location = new Point(360, 377);
            btnVoltarLogin.Name = "btnVoltarLogin";
            btnVoltarLogin.Size = new Size(168, 35);
            btnVoltarLogin.TabIndex = 7;
            btnVoltarLogin.Text = "Voltar para tela de login";
            btnVoltarLogin.UseVisualStyleBackColor = true;
            btnVoltarLogin.Click += button2_Click;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(234, 285);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PasswordChar = '*';
            txtConfirmarSenha.Size = new Size(177, 23);
            txtConfirmarSenha.TabIndex = 5;
            txtConfirmarSenha.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // Cadastro
            // 
            ClientSize = new Size(555, 424);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(btnVoltarLogin);
            Controls.Add(lblSenhaDiferente);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(cbMostrarSenha);
            Controls.Add(atpDataNascimento);
            Controls.Add(lblEmailCadastrado);
            Controls.Add(label5);
            Controls.Add(btnConfirmar);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblDataNascimento);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();

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
                Projeto_teste.Home.Home home = new Projeto_teste.Home.Home();
                home.ShowDialog();
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
