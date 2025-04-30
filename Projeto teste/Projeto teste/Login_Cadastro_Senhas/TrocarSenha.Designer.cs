namespace Projeto_teste {
    partial class TrocarSenha {
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
            this.lblErroSenha = new System.Windows.Forms.Label();
            this.txtSenhaNovamente = new System.Windows.Forms.TextBox();
            this.lblSenhaNovamente = new System.Windows.Forms.Label();
            this.txtSenhaNova = new System.Windows.Forms.TextBox();
            this.lblSenhaNova = new System.Windows.Forms.Label();
            this.cbMostrarSenha = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErroSenha
            // 
            this.lblErroSenha.AutoSize = true;
            this.lblErroSenha.Location = new System.Drawing.Point(427, 139);
            this.lblErroSenha.Name = "lblErroSenha";
            this.lblErroSenha.Size = new System.Drawing.Size(118, 16);
            this.lblErroSenha.TabIndex = 16;
            this.lblErroSenha.Text = "Senhas diferentes ";
            this.lblErroSenha.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSenhaNovamente
            // 
            this.txtSenhaNovamente.Location = new System.Drawing.Point(189, 133);
            this.txtSenhaNovamente.Name = "txtSenhaNovamente";
            this.txtSenhaNovamente.PasswordChar = '*';
            this.txtSenhaNovamente.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaNovamente.TabIndex = 15;
            this.txtSenhaNovamente.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSenhaNovamente
            // 
            this.lblSenhaNovamente.AutoSize = true;
            this.lblSenhaNovamente.Location = new System.Drawing.Point(17, 136);
            this.lblSenhaNovamente.Name = "lblSenhaNovamente";
            this.lblSenhaNovamente.Size = new System.Drawing.Size(166, 16);
            this.lblSenhaNovamente.TabIndex = 14;
            this.lblSenhaNovamente.Text = "Digite novamente a senha:";
            this.lblSenhaNovamente.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSenhaNova
            // 
            this.txtSenhaNova.Location = new System.Drawing.Point(151, 97);
            this.txtSenhaNova.Name = "txtSenhaNova";
            this.txtSenhaNova.PasswordChar = '*';
            this.txtSenhaNova.Size = new System.Drawing.Size(232, 22);
            this.txtSenhaNova.TabIndex = 13;
            this.txtSenhaNova.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblSenhaNova
            // 
            this.lblSenhaNova.AutoSize = true;
            this.lblSenhaNova.Location = new System.Drawing.Point(16, 100);
            this.lblSenhaNova.Name = "lblSenhaNova";
            this.lblSenhaNova.Size = new System.Drawing.Size(129, 16);
            this.lblSenhaNova.TabIndex = 12;
            this.lblSenhaNova.Text = "Digite a senha nova:";
            this.lblSenhaNova.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(389, 100);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(114, 20);
            this.cbMostrarSenha.TabIndex = 17;
            this.cbMostrarSenha.Text = "Mostrar senha";
            this.cbMostrarSenha.UseVisualStyleBackColor = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(233, 189);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 18;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 318);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.lblErroSenha);
            this.Controls.Add(this.txtSenhaNovamente);
            this.Controls.Add(this.lblSenhaNovamente);
            this.Controls.Add(this.txtSenhaNova);
            this.Controls.Add(this.lblSenhaNova);
            this.Name = "TrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrocarSenha";
            this.Load += new System.EventHandler(this.TrocarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErroSenha;
        private System.Windows.Forms.TextBox txtSenhaNovamente;
        private System.Windows.Forms.Label lblSenhaNovamente;
        private System.Windows.Forms.TextBox txtSenhaNova;
        private System.Windows.Forms.Label lblSenhaNova;
        private System.Windows.Forms.CheckBox cbMostrarSenha;
        private System.Windows.Forms.Button btnConfirmar;
    }
}