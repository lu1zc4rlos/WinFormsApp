namespace Projeto_teste {
    partial class ChatBot {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtEnviarMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviarMensagem = new System.Windows.Forms.Button();
            this.flowExibirChat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtEnviarMensagem
            // 
            this.txtEnviarMensagem.Location = new System.Drawing.Point(205, 655);
            this.txtEnviarMensagem.Multiline = true;
            this.txtEnviarMensagem.Name = "txtEnviarMensagem";
            this.txtEnviarMensagem.Size = new System.Drawing.Size(828, 33);
            this.txtEnviarMensagem.TabIndex = 0;
            this.txtEnviarMensagem.TextChanged += new System.EventHandler(this.txtEnviarMensagem_TextChanged);
            // 
            // btnEnviarMensagem
            // 
            this.btnEnviarMensagem.Location = new System.Drawing.Point(1039, 655);
            this.btnEnviarMensagem.Name = "btnEnviarMensagem";
            this.btnEnviarMensagem.Size = new System.Drawing.Size(109, 34);
            this.btnEnviarMensagem.TabIndex = 2;
            this.btnEnviarMensagem.Text = "Enviar";
            this.btnEnviarMensagem.UseVisualStyleBackColor = true;
            this.btnEnviarMensagem.Click += new System.EventHandler(this.btnEnviarMensagem_Click);
            // 
            // flowExibirChat
            // 
            this.flowExibirChat.AutoScroll = true;
            this.flowExibirChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowExibirChat.Location = new System.Drawing.Point(205, 12);
            this.flowExibirChat.Name = "flowExibirChat";
            this.flowExibirChat.Size = new System.Drawing.Size(943, 637);
            this.flowExibirChat.TabIndex = 3;
            this.flowExibirChat.WrapContents = false;
            // 
            // ChatBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1160, 700);
            this.Controls.Add(this.flowExibirChat);
            this.Controls.Add(this.btnEnviarMensagem);
            this.Controls.Add(this.txtEnviarMensagem);
            this.Name = "ChatBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo";
            this.Load += new System.EventHandler(this.Exemplo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnviarMensagem;
        private System.Windows.Forms.Button btnEnviarMensagem;
        private System.Windows.Forms.FlowLayoutPanel flowExibirChat;
    }
}