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
            SuspendLayout();
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashboardPrincipal.Location = new System.Drawing.Point(39, 135);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new System.Drawing.Size(411, 54);
            lblDashboardPrincipal.TabIndex = 5;
            lblDashboardPrincipal.Text = "Descrição do cliente:";
            // 
            // flowLayoutPanelDescricao
            // 
            flowLayoutPanelDescricao.AutoScroll = true;
            flowLayoutPanelDescricao.Location = new System.Drawing.Point(39, 209);
            flowLayoutPanelDescricao.Name = "flowLayoutPanelDescricao";
            flowLayoutPanelDescricao.Size = new System.Drawing.Size(558, 257);
            flowLayoutPanelDescricao.TabIndex = 6;
            // 
            // flowLayoutPanelCard
            // 
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
            label1.Location = new System.Drawing.Point(39, 452);
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
            // ResponderTicket
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(957, 820);
            Controls.Add(btnConfirmarChamado);
            Controls.Add(txtResposta);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelCard);
            Controls.Add(flowLayoutPanelDescricao);
            Controls.Add(lblDashboardPrincipal);
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
    }
}