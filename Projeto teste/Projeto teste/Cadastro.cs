using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regras_de_negócio;

namespace Projeto_teste {
    public partial class Cadastro : Form {
        public Cadastro() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 227);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 267);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Senha:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tela de Cadastro";
            // 
            // Cadastro
            // 
            this.ClientSize = new System.Drawing.Size(540, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();

        private void button1_Click(object sender, EventArgs e) {

            string data = textBox2.Text;
            DateTime Data = DateTime.ParseExact(data, "dd/MM/yyyy", CultureInfo.InvariantCulture);



            /*
            try {
                Data = DateTime.Parse(data);
            }
            catch (FormatException){
                MessageBox.Show("Data inválida. Use o formato aaaa/mm/dd");
                return;
            }
            */

            Usuario novo = new Usuario();
            novo.Nome = textBox1.Text;
            novo.Data_Nascimento = Data;
            novo.Email = textBox3.Text;
            novo.Senha = textBox4.Text;

            try {
                _usuarioBLL.AdicionarUsuario(novo);
                MessageBox.Show("Usuário Adicionado com sucesso!");
            }
            catch{
                MessageBox.Show("Erro ao adicionar usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Exemplo exemplo = new Exemplo();
            exemplo.ShowDialog();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
    }

    [Serializable]
    internal class FormaException : Exception {
        public FormaException() {
        }

        public FormaException(string message) : base(message) {
        }

        public FormaException(string message, Exception innerException) : base(message, innerException) {
        }

        protected FormaException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
