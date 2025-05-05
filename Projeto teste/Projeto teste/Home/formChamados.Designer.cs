namespace Projeto_teste.Home
{
    partial class formChamados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formChamados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            pn_title = new System.Windows.Forms.Panel();
            pic_home = new System.Windows.Forms.PictureBox();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            dgv_chamados = new System.Windows.Forms.DataGridView();
            coluna_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coluna_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coluna_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            coluna_prio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            btn_attchamados = new ReaLTaiizor.Controls.AirButton();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chamados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.WhiteSmoke;
            pn_title.Controls.Add(pic_home);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(875, 74);
            pn_title.TabIndex = 2;
            // 
            // pic_home
            // 
            pic_home.Image = (System.Drawing.Image)resources.GetObject("pic_home.Image");
            pic_home.Location = new System.Drawing.Point(10, 16);
            pic_home.Name = "pic_home";
            pic_home.Size = new System.Drawing.Size(32, 37);
            pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 3;
            pic_home.TabStop = false;
            pic_home.Click += pic_home_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(390, 18);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(138, 30);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "CHAMADOS";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(60, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // nightControlBox2
            // 
            nightControlBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            nightControlBox2.BackColor = System.Drawing.Color.Transparent;
            nightControlBox2.CloseHoverColor = System.Drawing.Color.FromArgb(199, 80, 80);
            nightControlBox2.CloseHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            nightControlBox2.DefaultLocation = true;
            nightControlBox2.DisableMaximizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox2.DisableMinimizeColor = System.Drawing.Color.FromArgb(105, 105, 105);
            nightControlBox2.EnableCloseColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMaximizeButton = true;
            nightControlBox2.EnableMaximizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.EnableMinimizeButton = true;
            nightControlBox2.EnableMinimizeColor = System.Drawing.Color.FromArgb(160, 160, 160);
            nightControlBox2.Location = new System.Drawing.Point(736, 0);
            nightControlBox2.MaximizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MaximizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.MinimizeHoverColor = System.Drawing.Color.FromArgb(15, 255, 255, 255);
            nightControlBox2.MinimizeHoverForeColor = System.Drawing.Color.White;
            nightControlBox2.Name = "nightControlBox2";
            nightControlBox2.Size = new System.Drawing.Size(139, 31);
            nightControlBox2.TabIndex = 1;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(116, 28);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(96, 21);
            lbl_omega.TabIndex = 1;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // dgv_chamados
            // 
            dgv_chamados.AllowUserToAddRows = false;
            dgv_chamados.AllowUserToDeleteRows = false;
            dgv_chamados.AllowUserToResizeColumns = false;
            dgv_chamados.AllowUserToResizeRows = false;
            dgv_chamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chamados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_chamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_chamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { coluna_ID, coluna_Tipo, coluna_desc, coluna_prio });
            dgv_chamados.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_chamados.Location = new System.Drawing.Point(0, 74);
            dgv_chamados.Name = "dgv_chamados";
            dgv_chamados.ReadOnly = true;
            dgv_chamados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dgv_chamados.RowHeadersVisible = false;
            dgv_chamados.Size = new System.Drawing.Size(875, 478);
            dgv_chamados.TabIndex = 3;
            // 
            // coluna_ID
            // 
            coluna_ID.DataPropertyName = "id";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            coluna_ID.DefaultCellStyle = dataGridViewCellStyle4;
            coluna_ID.FillWeight = 30F;
            coluna_ID.HeaderText = "ID";
            coluna_ID.Name = "coluna_ID";
            coluna_ID.ReadOnly = true;
            // 
            // coluna_Tipo
            // 
            coluna_Tipo.DataPropertyName = "tipo";
            coluna_Tipo.FillWeight = 50F;
            coluna_Tipo.HeaderText = "TIPO";
            coluna_Tipo.Name = "coluna_Tipo";
            coluna_Tipo.ReadOnly = true;
            // 
            // coluna_desc
            // 
            coluna_desc.DataPropertyName = "descricao";
            coluna_desc.FillWeight = 150F;
            coluna_desc.HeaderText = "DESCRIÇÃO";
            coluna_desc.Name = "coluna_desc";
            coluna_desc.ReadOnly = true;
            // 
            // coluna_prio
            // 
            coluna_prio.DataPropertyName = "prioridade";
            coluna_prio.FillWeight = 30F;
            coluna_prio.HeaderText = "PRIORIDADE";
            coluna_prio.Name = "coluna_prio";
            coluna_prio.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            panel1.Controls.Add(btn_attchamados);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 552);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(875, 48);
            panel1.TabIndex = 4;
            // 
            // btn_attchamados
            // 
            btn_attchamados.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btn_attchamados.Font = new System.Drawing.Font("Segoe UI", 9F);
            btn_attchamados.Image = null;
            btn_attchamados.Location = new System.Drawing.Point(718, 6);
            btn_attchamados.Name = "btn_attchamados";
            btn_attchamados.NoRounding = false;
            btn_attchamados.Size = new System.Drawing.Size(145, 31);
            btn_attchamados.TabIndex = 0;
            btn_attchamados.Text = "Atualizar Chamados";
            btn_attchamados.Transparent = false;
            btn_attchamados.Click += btn_attchamados_Click;
            // 
            // formChamados
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(875, 600);
            Controls.Add(dgv_chamados);
            Controls.Add(pn_title);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "formChamados";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "formChamados";
            Load += formChamados_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chamados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
        private System.Windows.Forms.PictureBox pic_home;
        private System.Windows.Forms.DataGridView dgv_chamados;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_prio;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.AirButton btn_attchamados;
    }
}