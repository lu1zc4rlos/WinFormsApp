namespace ProjetoTeste.Home
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(194, 378);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Resposta tecnico:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(194, 73);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 20);
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
            label3.Location = new System.Drawing.Point(194, 113);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(194, 420);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 20);
            label4.TabIndex = 5;
            // 
            // formRespostaTecnico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(965, 676);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "formRespostaTecnico";
            Text = "formRespostaTecnico";
            Load += formRespostaTecnico_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}