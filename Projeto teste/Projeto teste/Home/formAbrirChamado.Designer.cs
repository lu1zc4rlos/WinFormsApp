namespace ProjetoTeste.Home
{
    partial class formAbrirChamado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            comboBoxTipo = new System.Windows.Forms.ComboBox();
            txtDescricao = new System.Windows.Forms.TextBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            lblTipoOcorencia = new System.Windows.Forms.Label();
            lblPrioridade = new System.Windows.Forms.Label();
            lblMensagem = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Internet Lenta", "Sem Conexão", "Impressora Off", "Problema Login", "Trocar Senha", "Vírus no PC", "Atualizar App", "Instalar Driver", "PC Travando", "Tela Azul", "Sem Áudio", "Sem Vídeo", "Erro Sistema", "", "", "Backup Falhou", "", "", "Email Não Envia" });
            comboBoxTipo.Location = new System.Drawing.Point(451, 129);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new System.Drawing.Size(151, 28);
            comboBoxTipo.TabIndex = 0;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new System.Drawing.Point(307, 289);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new System.Drawing.Size(415, 228);
            txtDescricao.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Baixa", "Média", "Alta" });
            comboBox2.Location = new System.Drawing.Point(451, 189);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(151, 28);
            comboBox2.TabIndex = 2;
            // 
            // lblTipoOcorencia
            // 
            lblTipoOcorencia.AutoSize = true;
            lblTipoOcorencia.Location = new System.Drawing.Point(307, 132);
            lblTipoOcorencia.Name = "lblTipoOcorencia";
            lblTipoOcorencia.Size = new System.Drawing.Size(137, 20);
            lblTipoOcorencia.TabIndex = 3;
            lblTipoOcorencia.Text = "Tipo da ocorrência:";
            // 
            // lblPrioridade
            // 
            lblPrioridade.AutoSize = true;
            lblPrioridade.Location = new System.Drawing.Point(307, 189);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new System.Drawing.Size(138, 20);
            lblPrioridade.TabIndex = 4;
            lblPrioridade.Text = "Grau de prioridade:";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new System.Drawing.Point(307, 251);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new System.Drawing.Size(290, 20);
            lblMensagem.TabIndex = 5;
            lblMensagem.Text = "por favor digite a descrição da ocorrencia:";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(562, 534);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(160, 40);
            button1.TabIndex = 9;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // formAbrirChamado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(957, 707);
            Controls.Add(button1);
            Controls.Add(lblMensagem);
            Controls.Add(lblPrioridade);
            Controls.Add(lblTipoOcorencia);
            Controls.Add(comboBox2);
            Controls.Add(txtDescricao);
            Controls.Add(comboBoxTipo);
            Name = "formAbrirChamado";
            Text = "formAbrirChamado";
            Load += formAbrirChamado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTipoOcorencia;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button button1;
    }
}