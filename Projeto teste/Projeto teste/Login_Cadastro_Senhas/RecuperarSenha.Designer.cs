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
        private void InitializeComponent() {
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.txtSenhaNovamente = new System.Windows.Forms.TextBox();
            this.lblSenhaNovamente = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnOutraForma = new System.Windows.Forms.Button();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEamail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.Location = new System.Drawing.Point(53, 138);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(128, 16);
            this.lblSenhaAtual.TabIndex = 0;
            this.lblSenhaAtual.Text = "Digite a senha atual:";
            this.lblSenhaAtual.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(187, 132);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaAtual.TabIndex = 1;
            this.txtSenhaAtual.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(186, 166);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaNova.TabIndex = 3;
            this.txtSenhaNova.TextChanged += new System.EventHandler(this.txtSenhaNova_TextChanged);
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.Location = new System.Drawing.Point(52, 172);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(129, 16);
            this.lblSenhaNova.TabIndex = 2;
            this.lblSenhaNova.Text = "Digite a senha nova:";
            // 
            // txtSenhaNovamente
            // 
            this.txtSenhaNovamente.Location = new System.Drawing.Point(225, 205);
            this.txtSenhaNovamente.Name = "txtSenhaNovamente";
            this.txtSenhaNovamente.PasswordChar = '*';
            this.txtSenhaNovamente.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaNovamente.TabIndex = 5;
            this.txtSenhaNovamente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSenhaNovamente
            // 
            this.lblSenhaNovamente.AutoSize = true;
            this.lblSenhaNovamente.Location = new System.Drawing.Point(53, 208);
            this.lblSenhaNovamente.Name = "lblSenhaNovamente";
            this.lblSenhaNovamente.Size = new System.Drawing.Size(166, 16);
            this.lblSenhaNovamente.TabIndex = 4;
            this.lblSenhaNovamente.Text = "Digite novamente a senha:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(265, 272);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOutraForma
            // 
            this.btnOutraForma.Location = new System.Drawing.Point(56, 272);
            this.btnOutraForma.Name = "btnOutraForma";
            this.btnOutraForma.Size = new System.Drawing.Size(173, 23);
            this.btnOutraForma.TabIndex = 7;
            this.btnOutraForma.Text = "Tentar de outra forma";
            this.btnOutraForma.UseVisualStyleBackColor = true;
            this.btnOutraForma.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(378, 272);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(114, 20);
            this.cbMostrarSenha.TabIndex = 8;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblEamail
            // 
            this.lblEamail.AutoSize = true;
            this.lblEamail.Location = new System.Drawing.Point(53, 97);
            this.lblEamail.Name = "lblEamail";
            this.lblEamail.Size = new System.Drawing.Size(151, 16);
            this.lblEamail.TabIndex = 9;
            this.lblEamail.Text = "Digite e-mail do usuário:";
            this.lblEamail.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 11;
            // 
            // RecuperarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEamail);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.btnOutraForma);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtSenhaNovamente);
            this.Controls.Add(this.lblSenhaNovamente);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.lblSenhaNova);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.lblSenhaAtual);
            this.Name = "RecuperarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarSenha";
            this.Load += new System.EventHandler(this.RecuperarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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