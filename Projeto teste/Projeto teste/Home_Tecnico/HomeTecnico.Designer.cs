namespace ProjetoTeste.Home_Técnico
{
    partial class HomeTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeTecnico));
            btnTicketsTotais = new System.Windows.Forms.Button();
            btnTicketsFechados = new System.Windows.Forms.Button();
            btnEmAtendimento = new System.Windows.Forms.Button();
            btnTicketsAbertos = new System.Windows.Forms.Button();
            lblDashboardPrincipal = new System.Windows.Forms.Label();
            lblUltimosTickets = new System.Windows.Forms.Label();
            flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnTicketsTotais
            // 
            btnTicketsTotais.BackColor = System.Drawing.Color.FromArgb(28, 58, 120);
            btnTicketsTotais.FlatAppearance.BorderSize = 0;
            btnTicketsTotais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsTotais.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsTotais.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsTotais.Image = (System.Drawing.Image)resources.GetObject("btnTicketsTotais.Image");
            btnTicketsTotais.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsTotais.Location = new System.Drawing.Point(283, 211);
            btnTicketsTotais.Name = "btnTicketsTotais";
            btnTicketsTotais.Size = new System.Drawing.Size(150, 121);
            btnTicketsTotais.TabIndex = 0;
            btnTicketsTotais.Text = "Tickets totais";
            btnTicketsTotais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsTotais.UseVisualStyleBackColor = false;
            btnTicketsTotais.Click += btnTicketsTotais_Click;
            // 
            // btnTicketsFechados
            // 
            btnTicketsFechados.BackColor = System.Drawing.Color.FromArgb(0, 179, 136);
            btnTicketsFechados.FlatAppearance.BorderSize = 0;
            btnTicketsFechados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsFechados.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsFechados.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsFechados.Image = (System.Drawing.Image)resources.GetObject("btnTicketsFechados.Image");
            btnTicketsFechados.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsFechados.Location = new System.Drawing.Point(919, 211);
            btnTicketsFechados.Name = "btnTicketsFechados";
            btnTicketsFechados.Size = new System.Drawing.Size(150, 121);
            btnTicketsFechados.TabIndex = 1;
            btnTicketsFechados.Text = "Tickets fechados";
            btnTicketsFechados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsFechados.UseVisualStyleBackColor = false;
            // 
            // btnEmAtendimento
            // 
            btnEmAtendimento.BackColor = System.Drawing.Color.FromArgb(51, 160, 204);
            btnEmAtendimento.FlatAppearance.BorderSize = 0;
            btnEmAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEmAtendimento.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnEmAtendimento.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnEmAtendimento.Image = (System.Drawing.Image)resources.GetObject("btnEmAtendimento.Image");
            btnEmAtendimento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEmAtendimento.Location = new System.Drawing.Point(707, 211);
            btnEmAtendimento.Name = "btnEmAtendimento";
            btnEmAtendimento.Size = new System.Drawing.Size(150, 121);
            btnEmAtendimento.TabIndex = 2;
            btnEmAtendimento.Text = "Em atendimento";
            btnEmAtendimento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEmAtendimento.UseVisualStyleBackColor = false;
            btnEmAtendimento.Click += btnEmAtendimento_Click;
            // 
            // btnTicketsAbertos
            // 
            btnTicketsAbertos.BackColor = System.Drawing.Color.FromArgb(255, 0, 102);
            btnTicketsAbertos.FlatAppearance.BorderSize = 0;
            btnTicketsAbertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnTicketsAbertos.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnTicketsAbertos.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnTicketsAbertos.Image = (System.Drawing.Image)resources.GetObject("btnTicketsAbertos.Image");
            btnTicketsAbertos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnTicketsAbertos.Location = new System.Drawing.Point(495, 211);
            btnTicketsAbertos.Name = "btnTicketsAbertos";
            btnTicketsAbertos.Size = new System.Drawing.Size(150, 121);
            btnTicketsAbertos.TabIndex = 3;
            btnTicketsAbertos.Text = "Tickets abertos";
            btnTicketsAbertos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnTicketsAbertos.UseVisualStyleBackColor = false;
            btnTicketsAbertos.Click += btnTicketsAbertos_Click;
            // 
            // lblDashboardPrincipal
            // 
            lblDashboardPrincipal.AutoSize = true;
            lblDashboardPrincipal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblDashboardPrincipal.Location = new System.Drawing.Point(265, 124);
            lblDashboardPrincipal.Name = "lblDashboardPrincipal";
            lblDashboardPrincipal.Size = new System.Drawing.Size(404, 54);
            lblDashboardPrincipal.TabIndex = 4;
            lblDashboardPrincipal.Text = "Dashboard principal";
            lblDashboardPrincipal.Click += lblDashboardPrincipal_Click;
            // 
            // lblUltimosTickets
            // 
            lblUltimosTickets.AutoSize = true;
            lblUltimosTickets.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblUltimosTickets.Location = new System.Drawing.Point(265, 406);
            lblUltimosTickets.Name = "lblUltimosTickets";
            lblUltimosTickets.Size = new System.Drawing.Size(210, 37);
            lblUltimosTickets.TabIndex = 5;
            lblUltimosTickets.Text = "Últimos tickets";
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.AutoScroll = true;
            flowLayoutPanelCards.Location = new System.Drawing.Point(265, 468);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new System.Drawing.Size(836, 375);
            flowLayoutPanelCards.TabIndex = 6;
            flowLayoutPanelCards.Paint += flowLayoutPanelCards_Paint;
            // 
            // HomeTecnico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1123, 917);
            Controls.Add(flowLayoutPanelCards);
            Controls.Add(lblUltimosTickets);
            Controls.Add(lblDashboardPrincipal);
            Controls.Add(btnTicketsAbertos);
            Controls.Add(btnEmAtendimento);
            Controls.Add(btnTicketsFechados);
            Controls.Add(btnTicketsTotais);
            Name = "HomeTecnico";
            Text = "HomeTecnico";
            Load += HomeTecnico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnTicketsTotais;
        private System.Windows.Forms.Button btnTicketsFechados;
        private System.Windows.Forms.Button btnEmAtendimento;
        private System.Windows.Forms.Button btnTicketsAbertos;
        private System.Windows.Forms.Label lblDashboardPrincipal;
        private System.Windows.Forms.Label lblUltimosTickets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
    }
}