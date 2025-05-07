namespace Projeto_teste {
    partial class RecuperarSenhaEmail {
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
            btnEnviarCodigo = new System.Windows.Forms.Button();
            lblCodigo = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            btnConfirmar = new System.Windows.Forms.Button();
            txtCodigo = new System.Windows.Forms.TextBox();
            btnTrocarSenha = new System.Windows.Forms.Button();
            btnAcessarPrograma = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnEnviarCodigo
            // 
            btnEnviarCodigo.Location = new System.Drawing.Point(146, 82);
            btnEnviarCodigo.Name = "btnEnviarCodigo";
            btnEnviarCodigo.Size = new System.Drawing.Size(94, 22);
            btnEnviarCodigo.TabIndex = 1;
            btnEnviarCodigo.Text = "Enviar código";
            btnEnviarCodigo.UseVisualStyleBackColor = true;
            btnEnviarCodigo.Click += btnEnviarCodigo_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new System.Drawing.Point(74, 126);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new System.Drawing.Size(49, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            lblCodigo.Click += lblCodigo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(127, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(141, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(74, 59);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(44, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(158, 149);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(66, 22);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new System.Drawing.Point(127, 123);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new System.Drawing.Size(141, 23);
            txtCodigo.TabIndex = 2;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // btnTrocarSenha
            // 
            btnTrocarSenha.Location = new System.Drawing.Point(61, 204);
            btnTrocarSenha.Name = "btnTrocarSenha";
            btnTrocarSenha.Size = new System.Drawing.Size(100, 22);
            btnTrocarSenha.TabIndex = 4;
            btnTrocarSenha.Text = "Trocar Senha";
            btnTrocarSenha.UseVisualStyleBackColor = true;
            btnTrocarSenha.Click += btnTrocarSenha_Click;
            // 
            // btnAcessarPrograma
            // 
            btnAcessarPrograma.Location = new System.Drawing.Point(213, 204);
            btnAcessarPrograma.Name = "btnAcessarPrograma";
            btnAcessarPrograma.Size = new System.Drawing.Size(121, 22);
            btnAcessarPrograma.TabIndex = 5;
            btnAcessarPrograma.Text = "Acessar programa";
            btnAcessarPrograma.UseVisualStyleBackColor = true;
            btnAcessarPrograma.Click += btnAcessarPrograma_Click;
            // 
            // RecuperarSenhaEmail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 246);
            Controls.Add(btnAcessarPrograma);
            Controls.Add(btnTrocarSenha);
            Controls.Add(txtCodigo);
            Controls.Add(btnConfirmar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblCodigo);
            Controls.Add(btnEnviarCodigo);
            Name = "RecuperarSenhaEmail";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RecuperarSenhaEmail";
            Load += RecuperarSenhaEmail_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnTrocarSenha;
        private System.Windows.Forms.Button btnAcessarPrograma;
    }
}