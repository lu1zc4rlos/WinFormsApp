namespace Projeto_teste.Home
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pn_title = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.lbl_omega = new System.Windows.Forms.Label();
            this.btn_sidebar = new System.Windows.Forms.PictureBox();
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_chamados = new System.Windows.Forms.Button();
            this.btn_chatbot = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.pn_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sidebar)).BeginInit();
            this.sideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_title
            // 
            resources.ApplyResources(this.pn_title, "pn_title");
            this.pn_title.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_title.Controls.Add(this.lbl_titulo);
            this.pn_title.Controls.Add(this.pictureBox2);
            this.pn_title.Controls.Add(this.nightControlBox1);
            this.pn_title.Controls.Add(this.lbl_omega);
            this.pn_title.Controls.Add(this.btn_sidebar);
            this.pn_title.Name = "pn_title";
            // 
            // lbl_titulo
            // 
            resources.ApplyResources(this.lbl_titulo, "lbl_titulo");
            this.lbl_titulo.Name = "lbl_titulo";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // nightControlBox1
            // 
            resources.ApplyResources(this.nightControlBox1, "nightControlBox1");
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            // 
            // lbl_omega
            // 
            resources.ApplyResources(this.lbl_omega, "lbl_omega");
            this.lbl_omega.Name = "lbl_omega";
            // 
            // btn_sidebar
            // 
            resources.ApplyResources(this.btn_sidebar, "btn_sidebar");
            this.btn_sidebar.Name = "btn_sidebar";
            this.btn_sidebar.TabStop = false;
            this.btn_sidebar.Click += new System.EventHandler(this.btn_sidebar_Click);
            // 
            // sideBar
            // 
            resources.ApplyResources(this.sideBar, "sideBar");
            this.sideBar.BackColor = System.Drawing.Color.Black;
            this.sideBar.Controls.Add(this.btn_chamados);
            this.sideBar.Controls.Add(this.btn_chatbot);
            this.sideBar.Name = "sideBar";
            // 
            // btn_chamados
            // 
            this.btn_chamados.BackColor = System.Drawing.Color.Black;
            this.btn_chamados.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_chamados, "btn_chamados");
            this.btn_chamados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_chamados.Name = "btn_chamados";
            this.btn_chamados.UseVisualStyleBackColor = false;
            this.btn_chamados.Click += new System.EventHandler(this.btn_chamados_Click);
            // 
            // btn_chatbot
            // 
            this.btn_chatbot.BackColor = System.Drawing.Color.Black;
            this.btn_chatbot.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_chatbot, "btn_chatbot");
            this.btn_chatbot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_chatbot.Name = "btn_chatbot";
            this.btn_chatbot.UseVisualStyleBackColor = false;
            this.btn_chatbot.Click += new System.EventHandler(this.btn_chatbot_Click);
            // 
            // SideBarTransition
            // 
            this.SideBarTransition.Interval = 20;
            this.SideBarTransition.Tick += new System.EventHandler(this.SideBarTransition_Tick);
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pn_title);
            this.Controls.Add(this.sideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pn_title.ResumeLayout(false);
            this.pn_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sidebar)).EndInit();
            this.sideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_title;
        private System.Windows.Forms.PictureBox btn_sidebar;
        private System.Windows.Forms.Label lbl_omega;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_chamados;
        private System.Windows.Forms.Button btn_chatbot;
        private System.Windows.Forms.Timer SideBarTransition;
        private System.Windows.Forms.Label lbl_titulo;
    }
}