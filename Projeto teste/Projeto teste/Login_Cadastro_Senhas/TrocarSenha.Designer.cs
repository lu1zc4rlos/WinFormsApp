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
        private void InitializeComponent()
        {
            lblErroSenha = new System.Windows.Forms.Label();
            txtSenhaNovamente = new System.Windows.Forms.TextBox();
            lblSenhaNovamente = new System.Windows.Forms.Label();
            txtSenhaNova = new System.Windows.Forms.TextBox();
            lblSenhaNova = new System.Windows.Forms.Label();
            cbMostrarSenha = new System.Windows.Forms.CheckBox();
            btnConfirmar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblErroSenha
            // 
            lblErroSenha.AutoSize = true;
            lblErroSenha.Location = new System.Drawing.Point(379, 128);
            lblErroSenha.Name = "lblErroSenha";
            lblErroSenha.Size = new System.Drawing.Size(102, 15);
            lblErroSenha.TabIndex = 16;
            lblErroSenha.Text = "Senhas diferentes ";
            lblErroSenha.Click += label5_Click;
            // 
            // txtSenhaNovamente
            // 
            txtSenhaNovamente.Location = new System.Drawing.Point(165, 125);
            txtSenhaNovamente.Name = "txtSenhaNovamente";
            txtSenhaNovamente.PasswordChar = '*';
            txtSenhaNovamente.Size = new System.Drawing.Size(204, 23);
            txtSenhaNovamente.TabIndex = 2;
            txtSenhaNovamente.TextChanged += textBox3_TextChanged;
            // 
            // lblSenhaNovamente
            // 
            lblSenhaNovamente.AutoSize = true;
            lblSenhaNovamente.Location = new System.Drawing.Point(15, 128);
            lblSenhaNovamente.Name = "lblSenhaNovamente";
            lblSenhaNovamente.Size = new System.Drawing.Size(147, 15);
            lblSenhaNovamente.TabIndex = 14;
            lblSenhaNovamente.Text = "Digite novamente a senha:";
            lblSenhaNovamente.Click += label3_Click;
            // 
            // txtSenhaNova
            // 
            txtSenhaNova.Location = new System.Drawing.Point(132, 91);
            txtSenhaNova.Name = "txtSenhaNova";
            txtSenhaNova.PasswordChar = '*';
            txtSenhaNova.Size = new System.Drawing.Size(204, 23);
            txtSenhaNova.TabIndex = 0;
            txtSenhaNova.TextChanged += textBox2_TextChanged;
            // 
            // lblSenhaNova
            // 
            lblSenhaNova.AutoSize = true;
            lblSenhaNova.Location = new System.Drawing.Point(14, 94);
            lblSenhaNova.Name = "lblSenhaNova";
            lblSenhaNova.Size = new System.Drawing.Size(113, 15);
            lblSenhaNova.TabIndex = 12;
            lblSenhaNova.Text = "Digite a senha nova:";
            lblSenhaNova.Click += label2_Click;
            // 
            // cbMostrarSenha
            // 
            cbMostrarSenha.AutoSize = true;
            cbMostrarSenha.Location = new System.Drawing.Point(340, 94);
            cbMostrarSenha.Name = "cbMostrarSenha";
            cbMostrarSenha.Size = new System.Drawing.Size(101, 19);
            cbMostrarSenha.TabIndex = 1;
            cbMostrarSenha.Text = "Mostrar senha";
            cbMostrarSenha.UseVisualStyleBackColor = true;
            cbMostrarSenha.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new System.Drawing.Point(204, 177);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(66, 22);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += button1_Click;
            // 
            // TrocarSenha
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(493, 298);
            Controls.Add(btnConfirmar);
            Controls.Add(cbMostrarSenha);
            Controls.Add(lblErroSenha);
            Controls.Add(txtSenhaNovamente);
            Controls.Add(lblSenhaNovamente);
            Controls.Add(txtSenhaNova);
            Controls.Add(lblSenhaNova);
            Name = "TrocarSenha";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "TrocarSenha";
            Load += TrocarSenha_Load;
            ResumeLayout(false);
            PerformLayout();

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