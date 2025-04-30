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
        private void InitializeComponent() {
            this.lblTelaLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnNaoCadastrado = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbMostarSenha = new System.Windows.Forms.CheckBox();
            this.btnRecuperrarSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTelaLogin
            // 
            this.lblTelaLogin.AutoSize = true;
            this.lblTelaLogin.Location = new System.Drawing.Point(198, 54);
            this.lblTelaLogin.Name = "lblTelaLogin";
            this.lblTelaLogin.Size = new System.Drawing.Size(90, 16);
            this.lblTelaLogin.TabIndex = 0;
            this.lblTelaLogin.Text = "Tela de Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(81, 98);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 95);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 22);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(131, 136);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(141, 22);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(76, 142);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 16);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // btnNaoCadastrado
            // 
            this.btnNaoCadastrado.Location = new System.Drawing.Point(326, 244);
            this.btnNaoCadastrado.Name = "btnNaoCadastrado";
            this.btnNaoCadastrado.Size = new System.Drawing.Size(172, 34);
            this.btnNaoCadastrado.TabIndex = 5;
            this.btnNaoCadastrado.Text = "Não possui cadastro";
            this.btnNaoCadastrado.UseVisualStyleBackColor = true;
            this.btnNaoCadastrado.Click += new System.EventHandler(this.btnNaoCadastrado_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(150, 177);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(97, 32);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbMostarSenha
            // 
            this.cbMostarSenha.AutoSize = true;
            this.cbMostarSenha.Location = new System.Drawing.Point(296, 138);
            this.cbMostarSenha.Name = "cbMostarSenha";
            this.cbMostarSenha.Size = new System.Drawing.Size(114, 20);
            this.cbMostarSenha.TabIndex = 7;
            this.cbMostarSenha.Text = "Mostrar senha";
            this.cbMostarSenha.UseVisualStyleBackColor = true;
            this.cbMostarSenha.CheckedChanged += new System.EventHandler(this.cbMostarSenha_CheckedChanged);
            // 
            // btnRecuperrarSenha
            // 
            this.btnRecuperrarSenha.Location = new System.Drawing.Point(175, 244);
            this.btnRecuperrarSenha.Name = "btnRecuperrarSenha";
            this.btnRecuperrarSenha.Size = new System.Drawing.Size(145, 34);
            this.btnRecuperrarSenha.TabIndex = 8;
            this.btnRecuperrarSenha.Text = "Recuperar senha";
            this.btnRecuperrarSenha.UseVisualStyleBackColor = true;
            this.btnRecuperrarSenha.Click += new System.EventHandler(this.btnRecuperrarSenha_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 290);
            this.Controls.Add(this.btnRecuperrarSenha);
            this.Controls.Add(this.cbMostarSenha);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnNaoCadastrado);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelaLogin);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FluxoCondicional";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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