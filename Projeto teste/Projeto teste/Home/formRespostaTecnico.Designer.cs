﻿namespace ProjetoTeste.Home
{
    partial class formRespostaTecnico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRespostaTecnico));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pn_title = new System.Windows.Forms.Panel();
            lbl_titulo = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            nightControlBox2 = new ReaLTaiizor.Controls.NightControlBox();
            lbl_omega = new System.Windows.Forms.Label();
            pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(183, 376);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 20);
            label1.TabIndex = 1;
            label1.Text = "Resposta tecnico:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(183, 159);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Descrição:";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new System.Drawing.Point(194, 110);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(0, 0);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(209, 189);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(209, 421);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 20);
            label4.TabIndex = 5;
            // 
            // pn_title
            // 
            pn_title.BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            pn_title.Controls.Add(lbl_titulo);
            pn_title.Controls.Add(pictureBox2);
            pn_title.Controls.Add(nightControlBox2);
            pn_title.Controls.Add(lbl_omega);
            pn_title.Dock = System.Windows.Forms.DockStyle.Top;
            pn_title.Location = new System.Drawing.Point(0, 0);
            pn_title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pn_title.Name = "pn_title";
            pn_title.Size = new System.Drawing.Size(965, 99);
            pn_title.TabIndex = 23;
            // 
            // lbl_titulo
            // 
            lbl_titulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            lbl_titulo.ForeColor = System.Drawing.Color.White;
            lbl_titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_titulo.Location = new System.Drawing.Point(317, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new System.Drawing.Size(310, 37);
            lbl_titulo.TabIndex = 22;
            lbl_titulo.Text = "RESPOSTA DO TECNICO";
            lbl_titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            pictureBox2.Location = new System.Drawing.Point(71, 16);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(64, 58);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            nightControlBox2.Location = new System.Drawing.Point(826, 0);
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
            lbl_omega.ForeColor = System.Drawing.Color.White;
            lbl_omega.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lbl_omega.Location = new System.Drawing.Point(415, 46);
            lbl_omega.Name = "lbl_omega";
            lbl_omega.Size = new System.Drawing.Size(119, 28);
            lbl_omega.TabIndex = 20;
            lbl_omega.Text = "OmegaTech\r\n";
            // 
            // formRespostaTecnico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            ClientSize = new System.Drawing.Size(965, 676);
            Controls.Add(pn_title);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "formRespostaTecnico";
            Text = "formRespostaTecnico";
            Load += formRespostaTecnico_Load;
            pn_title.ResumeLayout(false);
            pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox2;
        private System.Windows.Forms.Label lbl_omega;
    }
}