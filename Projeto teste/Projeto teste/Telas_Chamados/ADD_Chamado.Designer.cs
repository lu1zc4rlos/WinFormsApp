namespace ProjetoTeste.Telas_Chamados
{
    partial class ADD_Chamado
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
            cbx_tipo = new ReaLTaiizor.Controls.ForeverComboBox();
            lbl_tipo = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txt_desc = new ReaLTaiizor.Controls.MaterialRichTextBox();
            cbx_prio = new ReaLTaiizor.Controls.ForeverComboBox();
            label2 = new System.Windows.Forms.Label();
            btn_GerarTicket = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cbx_tipo
            // 
            cbx_tipo.BaseColor = System.Drawing.Color.FromArgb(40, 42, 90);
            cbx_tipo.BGColor = System.Drawing.Color.White;
            cbx_tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbx_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbx_tipo.Font = new System.Drawing.Font("Segoe UI", 8F);
            cbx_tipo.ForeColor = System.Drawing.Color.Black;
            cbx_tipo.FormattingEnabled = true;
            cbx_tipo.HoverColor = System.Drawing.Color.Silver;
            cbx_tipo.HoverFontColor = System.Drawing.Color.White;
            cbx_tipo.ItemHeight = 18;
            cbx_tipo.Items.AddRange(new object[] { "Hardware", "Redes", "Periféricos", "Falhas", "Outros" });
            cbx_tipo.Location = new System.Drawing.Point(199, 70);
            cbx_tipo.Name = "cbx_tipo";
            cbx_tipo.Size = new System.Drawing.Size(269, 24);
            cbx_tipo.TabIndex = 3;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lbl_tipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lbl_tipo.ForeColor = System.Drawing.Color.White;
            lbl_tipo.Location = new System.Drawing.Point(145, 70);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new System.Drawing.Size(37, 17);
            lbl_tipo.TabIndex = 4;
            lbl_tipo.Text = "Tipo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(125, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 17);
            label1.TabIndex = 5;
            label1.Text = "Descrição:";
            // 
            // txt_desc
            // 
            txt_desc.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txt_desc.Depth = 0;
            txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            txt_desc.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            txt_desc.Hint = "";
            txt_desc.Location = new System.Drawing.Point(199, 121);
            txt_desc.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            txt_desc.Name = "txt_desc";
            txt_desc.Size = new System.Drawing.Size(269, 96);
            txt_desc.TabIndex = 6;
            txt_desc.Text = "";
            // 
            // cbx_prio
            // 
            cbx_prio.BaseColor = System.Drawing.Color.FromArgb(40, 42, 90);
            cbx_prio.BGColor = System.Drawing.Color.White;
            cbx_prio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            cbx_prio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbx_prio.Font = new System.Drawing.Font("Segoe UI", 8F);
            cbx_prio.ForeColor = System.Drawing.Color.Black;
            cbx_prio.FormattingEnabled = true;
            cbx_prio.HoverColor = System.Drawing.Color.Silver;
            cbx_prio.HoverFontColor = System.Drawing.Color.White;
            cbx_prio.ItemHeight = 18;
            cbx_prio.Items.AddRange(new object[] { "B" });
            cbx_prio.Location = new System.Drawing.Point(199, 242);
            cbx_prio.Name = "cbx_prio";
            cbx_prio.Size = new System.Drawing.Size(269, 24);
            cbx_prio.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(123, 245);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 8;
            label2.Text = "Prioridade:";
            // 
            // btn_GerarTicket
            // 
            btn_GerarTicket.BackColor = System.Drawing.Color.FromArgb(60, 62, 110);
            btn_GerarTicket.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btn_GerarTicket.FlatAppearance.BorderSize = 0;
            btn_GerarTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 47, 95);
            btn_GerarTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_GerarTicket.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btn_GerarTicket.ForeColor = System.Drawing.Color.White;
            btn_GerarTicket.Location = new System.Drawing.Point(243, 362);
            btn_GerarTicket.Name = "btn_GerarTicket";
            btn_GerarTicket.Size = new System.Drawing.Size(126, 30);
            btn_GerarTicket.TabIndex = 10;
            btn_GerarTicket.Text = "Gerar Ticket";
            btn_GerarTicket.UseVisualStyleBackColor = false;
            btn_GerarTicket.Click += btn_GerarTicket_Click;
            // 
            // ADD_Chamado
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(40, 42, 90);
            ClientSize = new System.Drawing.Size(585, 498);
            Controls.Add(btn_GerarTicket);
            Controls.Add(label2);
            Controls.Add(cbx_prio);
            Controls.Add(txt_desc);
            Controls.Add(label1);
            Controls.Add(lbl_tipo);
            Controls.Add(cbx_tipo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ADD_Chamado";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ADD_Chamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverComboBox cbx_tipo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MaterialRichTextBox txt_desc;
        private ReaLTaiizor.Controls.ForeverComboBox cbx_prio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GerarTicket;
    }
}