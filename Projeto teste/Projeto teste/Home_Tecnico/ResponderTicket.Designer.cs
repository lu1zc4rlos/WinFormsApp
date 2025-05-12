namespace ProjetoTeste.Home_Tecnico
{
    partial class ResponderTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponderTicket));
            lblDashboardPrincipal = new System.Windows.Forms.Label();
            flowLayoutPanelDescricao = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanelCard = new System.Windows.Forms.FlowLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            txtResposta = new System.Windows.Forms.TextBox();
            btnConfirmarChamado = new System.Windows.Forms.Button();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            SuspendLayout();
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashboardPrincipal.ForeColor = System.Drawing.Color.White;
            lblDashboardPrincipal.Location = new System.Drawing.Point(39, 135);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new System.Drawing.Size(411, 54);
            lblDashboardPrincipal.TabIndex = 5;
            lblDashboardPrincipal.Text = "Descrição do cliente:";
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.AutoScroll = true;
            flowLayoutPanelDescricao.BackColor = System.Drawing.Color.White;
            flowLayoutPanelDescricao.ForeColor = System.Drawing.Color.Black;
            flowLayoutPanelDescricao.Location = new System.Drawing.Point(39, 209);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new System.Drawing.Size(558, 257);
            flowLayoutPanelDescricao.TabIndex = 6;
            // 
            // flowLayoutPanelCard
            // 
            flowLayoutPanelCard.BackColor = System.Drawing.Color.White;
            flowLayoutPanelCard.ForeColor = System.Drawing.Color.Black;
            flowLayoutPanelCard.Location = new System.Drawing.Point(603, 209);
            flowLayoutPanelCard.Name = "flowLayoutPanelCard";
            flowLayoutPanelCard.Size = new System.Drawing.Size(296, 228);
            flowLayoutPanelCard.TabIndex = 7;
            flowLayoutPanelCard.Paint += flowLayoutPanelCard_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(40, 469);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(410, 54);
            label1.TabIndex = 8;
            label1.Text = "Resposta do técnico:";
            // 
            // txtResposta
            // 
            txtResposta.Location = new System.Drawing.Point(39, 526);
            txtResposta.Multiline = true;
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new System.Drawing.Size(558, 264);
            txtResposta.TabIndex = 9;
            txtResposta.TextChanged += txtResposta_TextChanged;
            // 
            // btnConfirmarChamado
            // 
            btnConfirmarChamado.BackColor = System.Drawing.Color.FromArgb(0, 179, 136);
            btnConfirmarChamado.FlatAppearance.BorderSize = 0;
            btnConfirmarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmarChamado.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnConfirmarChamado.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnConfirmarChamado.Image = (System.Drawing.Image)resources.GetObject("btnConfirmarChamado.Image");
            btnConfirmarChamado.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnConfirmarChamado.Location = new System.Drawing.Point(707, 587);
            btnConfirmarChamado.Name = "btnConfirmarChamado";
            btnConfirmarChamado.Size = new System.Drawing.Size(173, 121);
            btnConfirmarChamado.TabIndex = 10;
            btnConfirmarChamado.Text = "Confirmar chamado ";
            btnConfirmarChamado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnConfirmarChamado.UseVisualStyleBackColor = false;
            btnConfirmarChamado.Click += btnConfirmarChamado_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new System.Drawing.Point(806, 12);
            nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new System.Drawing.Size(139, 31);
            nightControlBox1.TabIndex = 11;
            // 
            // ResponderTicket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(957, 820);
            Controls.Add(nightControlBox1);
            Controls.Add(btnConfirmarChamado);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelCard);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(lblDashboardPrincipal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ResponderTicket";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ResponderTicket";
            Load += ResponderTicket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDashboardPrincipal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescricao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnConfirmarChamado;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}