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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            stts_coluna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1 = new System.Windows.Forms.Panel();
            btnCarregar = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_chamados).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(255, 204, 128);
            pn_title.Controls.Add(pic_home);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(875, 74);
            pn_title.TabIndex = 21;
            // 
            // pic_home
            // 
            pic_home.Image = (System.Drawing.Image)resources.GetObject("pic_home.Image");
            pic_home.Location = new System.Drawing.Point(10, 16);
            pic_home.Name = "pic_home";
            pic_home.Size = new System.Drawing.Size(32, 37);
            pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic_home.TabIndex = 0;
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
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "CHAMADOS";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(60, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 23;
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
            nightControlBox2.TabIndex = 24;
            // 
            // lbl_omega
            // 
            lbl_omega.AutoSize = true;
            lbl_omega.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(116, 28);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(96, 21);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // dgv_chamados
            // 
            dgv_chamados.AllowUserToAddRows = false;
            dgv_chamados.AllowUserToDeleteRows = false;
            dgv_chamados.AllowUserToResizeColumns = false;
            dgv_chamados.AllowUserToResizeRows = false;
            dgv_chamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chamados.BackgroundColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dgv_chamados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_chamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_chamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_chamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { coluna_ID, coluna_Tipo, coluna_desc, coluna_prio, stts_coluna });
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_chamados.DefaultCellStyle = dataGridViewCellStyle7;
            dgv_chamados.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_chamados.EnableHeadersVisualStyles = false;
            dgv_chamados.Location = new System.Drawing.Point(0, 74);
            dgv_chamados.Name = "dgv_chamados";
            dgv_chamados.ReadOnly = true;
            dgv_chamados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_chamados.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_chamados.RowHeadersVisible = false;
            dgv_chamados.Size = new System.Drawing.Size(875, 478);
            dgv_chamados.TabIndex = 1;
            // 
            // coluna_ID
            // 
            coluna_ID.DataPropertyName = "id_ticket";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            coluna_ID.DefaultCellStyle = dataGridViewCellStyle2;
            coluna_ID.FillWeight = 37.3213577F;
            coluna_ID.HeaderText = "ID";
            coluna_ID.Name = "coluna_ID";
            coluna_ID.ReadOnly = true;
            // 
            // coluna_Tipo
            // 
            coluna_Tipo.DataPropertyName = "tipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            coluna_Tipo.DefaultCellStyle = dataGridViewCellStyle3;
            coluna_Tipo.FillWeight = 62.20227F;
            coluna_Tipo.HeaderText = "TIPO";
            coluna_Tipo.Name = "coluna_Tipo";
            coluna_Tipo.ReadOnly = true;
            // 
            // coluna_desc
            // 
            coluna_desc.DataPropertyName = "descricao";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            coluna_desc.DefaultCellStyle = dataGridViewCellStyle4;
            coluna_desc.FillWeight = 186.6068F;
            coluna_desc.HeaderText = "DESCRIÇÃO";
            coluna_desc.Name = "coluna_desc";
            coluna_desc.ReadOnly = true;
            // 
            // coluna_prio
            // 
            coluna_prio.DataPropertyName = "prioridade";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            coluna_prio.DefaultCellStyle = dataGridViewCellStyle5;
            coluna_prio.FillWeight = 37.3213577F;
            coluna_prio.HeaderText = "PRIORIDADE";
            coluna_prio.Name = "coluna_prio";
            coluna_prio.ReadOnly = true;
            // 
            // stts_coluna
            // 
            stts_coluna.DataPropertyName = "status";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            stts_coluna.DefaultCellStyle = dataGridViewCellStyle6;
            stts_coluna.FillWeight = 36.54822F;
            stts_coluna.HeaderText = "STATUS";
            stts_coluna.Name = "stts_coluna";
            stts_coluna.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCarregar);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 552);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(875, 48);
            panel1.TabIndex = 25;
            // 
            // btnCarregar
            // 
            btnCarregar.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            btnCarregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnCarregar.FlatAppearance.BorderSize = 0;
            btnCarregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            btnCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCarregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnCarregar.ForeColor = System.Drawing.Color.White;
            btnCarregar.Location = new System.Drawing.Point(449, 6);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new System.Drawing.Size(98, 30);
            btnCarregar.TabIndex = 7;
            btnCarregar.Text = "Recarregar";
            btnCarregar.UseVisualStyleBackColor = false;
            btnCarregar.Click += btnCarregar_Click;
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
            button1.Location = new System.Drawing.Point(723, 6);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 30);
            button1.TabIndex = 8;
            button1.Text = "Adicionar Chamado";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(579, 6);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(126, 30);
            button2.TabIndex = 9;
            button2.Text = "Excluir chamado";
            button2.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluna_prio;
        private System.Windows.Forms.DataGridViewTextBoxColumn stts_coluna;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}