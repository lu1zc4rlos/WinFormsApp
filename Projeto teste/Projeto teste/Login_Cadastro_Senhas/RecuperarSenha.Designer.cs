namespace Projeto_teste {
    partial class RecuperarSenha {
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
            lblSenhaAtual = new System.Windows.Forms.Label();
            txtSenhaAtual = new System.Windows.Forms.TextBox();
            txtSenhaNova = new System.Windows.Forms.TextBox();
            lblSenhaNova = new System.Windows.Forms.Label();
            txtSenhaNovamente = new System.Windows.Forms.TextBox();
            lblSenhaNovamente = new System.Windows.Forms.Label();
            btnConfirmar = new System.Windows.Forms.Button();
            btnOutraForma = new System.Windows.Forms.Button();
            cbMostrarSenha = new System.Windows.Forms.CheckBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEamail = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblSenhaAtual
            // 
            lblSenhaAtual.AutoSize = true;
            lblSenhaAtual.Location = new System.Drawing.Point(46, 129);
            lblSenhaAtual.Name = "lblSenhaAtual";
            lblSenhaAtual.Size = new System.Drawing.Size(113, 15);
            lblSenhaAtual.TabIndex = 0;
            lblSenhaAtual.Text = "Digite a senha atual:";
            lblSenhaAtual.Click += label1_Click;
            // 
            // txtSenhaAtual
            // 
            txtSenhaAtual.Location = new System.Drawing.Point(164, 124);
            txtSenhaAtual.Name = "txtSenhaAtual";
            txtSenhaAtual.PasswordChar = '*';
            txtSenhaAtual.Size = new System.Drawing.Size(204, 23);
            txtSenhaAtual.TabIndex = 1;
            txtSenhaAtual.TextChanged += textBox1_TextChanged;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Location = new System.Drawing.Point(163, 156);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new System.Drawing.Size(204, 23);
            txtSenhaNova.TabIndex = 2;
            txtSenhaNova.TextChanged += txtSenhaNova_TextChanged;
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Location = new System.Drawing.Point(46, 161);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new System.Drawing.Size(113, 15);
            lblSenhaNova.TabIndex = 2;
            lblSenhaNova.Text = "Digite a senha nova:";
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.Location = new System.Drawing.Point(197, 192);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new System.Drawing.Size(204, 23);
            txtSenhaNovamente.TabIndex = 3;
            txtSenhaNovamente.TextChanged += textBox3_TextChanged;
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Location = new System.Drawing.Point(46, 195);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new System.Drawing.Size(147, 15);
            lblSenhaNovamente.TabIndex = 4;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(232, 255);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(66, 22);
            btnConfirmar.TabIndex = 5;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // btnOutraForma
            // 
            btnOutraForma.Location = new System.Drawing.Point(49, 255);
            btnOutraForma.Name = "btnOutraForma";
            btnOutraForma.Size = new System.Drawing.Size(151, 22);
            btnOutraForma.TabIndex = 6;
            btnOutraForma.Text = "Tentar de outra forma";
            btnOutraForma.UseVisualStyleBackColor = true;
            btnOutraForma.Click += button2_Click;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Location = new System.Drawing.Point(331, 255);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new System.Drawing.Size(101, 19);
            cbMostrarSenha.TabIndex = 4;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(184, 88);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(204, 23);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += textBox4_TextChanged;
            // 
            // lblEamail
            // 
            lblEamail.AutoSize = true;
            lblEamail.Location = new System.Drawing.Point(46, 91);
            lblEamail.Name = "lblEamail";
            lblEamail.Size = new System.Drawing.Size(137, 15);
            lblEamail.TabIndex = 9;
            lblEamail.Text = "Digite e-mail do usuário:";
            lblEamail.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(405, 198);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 15);
            label5.TabIndex = 11;
            // 
            // RecuperarSenha
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(521, 355);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(lblEamail);
            Controls.Add(cbMostrarSenha);
            Controls.Add(btnOutraForma);
            Controls.Add(btnConfirmar);
            Controls.Add(txtSenhaNovamente);
            Controls.Add(lblSenhaNovamente);
            Controls.Add(txtSenhaNova);
            Controls.Add(lblSenhaNova);
            Controls.Add(txtSenhaAtual);
            Controls.Add(lblSenhaAtual);
            Name = "RecuperarSenha";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "RecuperarSenha";
            Load += RecuperarSenha_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenhaAtual;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.TextBox txtSenhaNovamente;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnOutraForma;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEamail;
        private System.Windows.Forms.Label label5;
    }
}