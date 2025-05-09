﻿namespace Projeto_teste {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lblTelaLogin = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtSenha = new System.Windows.Forms.TextBox();
            lblSenha = new System.Windows.Forms.Label();
            btnNaoCadastrado = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            cbMostarSenha = new System.Windows.Forms.CheckBox();
            btnRecuperrarSenha = new System.Windows.Forms.Button();
            pn_title = new System.Windows.Forms.Panel();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblEmail.ForeColor = System.Drawing.Color.White;
            lblEmail.Location = new System.Drawing.Point(264, 189);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(48, 17);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail:";
            lblEmail.Click += lblEmail_Click;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtEmail.Location = new System.Drawing.Point(313, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(250, 16);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtSenha.Location = new System.Drawing.Point(313, 228);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new System.Drawing.Size(135, 16);
            txtSenha.TabIndex = 1;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            lblSenha.ForeColor = System.Drawing.Color.White;
            lblSenha.Location = new System.Drawing.Point(264, 228);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new System.Drawing.Size(48, 17);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha:";
            lblSenha.Click += lblSenha_Click;
            // 
            // btnNaoCadastrado
            // 
            btnNaoCadastrado.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btnNaoCadastrado.FlatAppearance.BorderSize = 0;
            btnNaoCadastrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnNaoCadastrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNaoCadastrado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnNaoCadastrado.ForeColor = System.Drawing.Color.White;
            btnNaoCadastrado.Location = new System.Drawing.Point(464, 346);
            btnNaoCadastrado.Name = "btnNaoCadastrado";
            btnNaoCadastrado.Size = new System.Drawing.Size(150, 32);
            btnNaoCadastrado.TabIndex = 5;
            btnNaoCadastrado.Text = "Realizar Cadastro";
            btnNaoCadastrado.UseVisualStyleBackColor = false;
            btnNaoCadastrado.Click += btnNaoCadastrado_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnConfirmar.ForeColor = System.Drawing.Color.White;
            btnConfirmar.Location = new System.Drawing.Point(393, 271);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(85, 30);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbMostarSenha
            // 
            cbMostarSenha.AutoSize = true;
            cbMostarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            cbMostarSenha.ForeColor = System.Drawing.Color.White;
            cbMostarSenha.Location = new System.Drawing.Point(455, 227);
            cbMostarSenha.Name = "cbMostarSenha";
            cbMostarSenha.Size = new System.Drawing.Size(115, 21);
            cbMostarSenha.TabIndex = 2;
            cbMostarSenha.Text = "Mostrar senha";
            cbMostarSenha.UseVisualStyleBackColor = true;
            cbMostarSenha.CheckedChanged += cbMostarSenha_CheckedChanged;
            // 
            // btnRecuperrarSenha
            // 
            btnRecuperrarSenha.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btnRecuperrarSenha.FlatAppearance.BorderSize = 0;
            btnRecuperrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 67, 115);
            btnRecuperrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRecuperrarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            btnRecuperrarSenha.ForeColor = System.Drawing.Color.White;
            btnRecuperrarSenha.Location = new System.Drawing.Point(264, 346);
            btnRecuperrarSenha.Name = "btnRecuperrarSenha";
            btnRecuperrarSenha.Size = new System.Drawing.Size(127, 32);
            btnRecuperrarSenha.TabIndex = 4;
            btnRecuperrarSenha.Text = "Recuperar senha";
            btnRecuperrarSenha.UseVisualStyleBackColor = false;
            btnRecuperrarSenha.Click += btnRecuperrarSenha_Click;
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(255, 204, 128);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox1);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(875, 74);
            pn_title.TabIndex = 17;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.Black;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(391, 21);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(78, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "LOGIN";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(31, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new System.Drawing.Point(736, 0);
            nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new System.Drawing.Size(139, 31);
            nightControlBox1.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ForeColor = System.Drawing.Color.Black;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(87, 41);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(96, 21);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // panel1
            // 
            panel1.Location = new System.Drawing.Point(198, 112);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(485, 357);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(255, 224, 192);
            panel2.Location = new System.Drawing.Point(184, 101);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(513, 379);
            panel2.TabIndex = 19;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            ClientSize = new System.Drawing.Size(875, 600);
            Controls.Add(pn_title);
            Controls.Add(btnRecuperrarSenha);
            Controls.Add(cbMostarSenha);
            Controls.Add(btnConfirmar);
            Controls.Add(btnNaoCadastrado);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblTelaLogin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FluxoCondicional";
            Load += Login_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}