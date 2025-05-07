namespace Projeto_teste {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTelaLogin = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSenha = new System.Windows.Forms.TextBox();
            lblSenha = new System.Windows.Forms.Label();
            btnNaoCadastrado = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            cbMostarSenha = new System.Windows.Forms.CheckBox();
            btnRecuperrarSenha = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTelaLogin
            // 
            lblTelaLogin.AutoSize = true;
            lblTelaLogin.Location = new System.Drawing.Point(173, 51);
            lblTelaLogin.Name = "lblTelaLogin";
            lblTelaLogin.Size = new System.Drawing.Size(76, 15);
            lblTelaLogin.TabIndex = 0;
            lblTelaLogin.Text = "Tela de Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(71, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(41, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(115, 89);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(228, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Location = new System.Drawing.Point(115, 128);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new System.Drawing.Size(124, 23);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new System.Drawing.Point(66, 133);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(42, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // btnNaoCadastrado
            // 
            btnNaoCadastrado.Location = new System.Drawing.Point(285, 229);
            btnNaoCadastrado.Name = "btnNaoCadastrado";
            btnNaoCadastrado.Size = new System.Drawing.Size(150, 32);
            btnNaoCadastrado.TabIndex = 5;
            btnNaoCadastrado.Text = "Não possui cadastro";
            btnNaoCadastrado.UseVisualStyleBackColor = true;
            btnNaoCadastrado.Click += btnNaoCadastrado_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(131, 166);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(85, 30);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbMostarSenha
            // 
            cbMostarSenha.AutoSize = true;
            cbMostarSenha.Location = new System.Drawing.Point(259, 129);
            cbMostarSenha.Name = "cbMostarSenha";
            cbMostarSenha.Size = new System.Drawing.Size(101, 19);
            cbMostarSenha.TabIndex = 2;
            cbMostarSenha.Text = "Mostrar senha";
            cbMostarSenha.UseVisualStyleBackColor = true;
            cbMostarSenha.CheckedChanged += cbMostarSenha_CheckedChanged;
            // 
            // btnRecuperrarSenha
            // 
            btnRecuperrarSenha.Location = new System.Drawing.Point(153, 229);
            btnRecuperrarSenha.Name = "btnRecuperrarSenha";
            btnRecuperrarSenha.Size = new System.Drawing.Size(127, 32);
            btnRecuperrarSenha.TabIndex = 4;
            btnRecuperrarSenha.Text = "Recuperar senha";
            btnRecuperrarSenha.UseVisualStyleBackColor = true;
            btnRecuperrarSenha.Click += btnRecuperrarSenha_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(454, 272);
            Controls.Add(btnRecuperrarSenha);
            Controls.Add(cbMostarSenha);
            Controls.Add(btnConfirmar);
            Controls.Add(btnNaoCadastrado);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblTelaLogin);
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FluxoCondicional";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelaLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnNaoCadastrado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox cbMostarSenha;
        private System.Windows.Forms.Button btnRecuperrarSenha;
    }
}