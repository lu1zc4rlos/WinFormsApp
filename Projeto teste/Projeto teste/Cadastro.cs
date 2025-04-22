using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 22);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(226, 287);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(155, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar senha: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tela de Cadastro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(411, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 156);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 22);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(351, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Mostrar senha";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(155, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Senha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 35);
            this.button2.TabIndex = 16;
            this.button2.Text = "Voltar para tela de login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cadastro
            // 
            this.ClientSize = new System.Drawing.Size(540, 424);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();

        private void button1_Click(object sender, EventArgs e) {

            DateTime Data = dateTimePicker1.Value.Date;
          
            Usuario novo = new Usuario();
            novo.Nome = textBox1.Text;
            novo.Data_Nascimento = Data;
            novo.Email = textBox3.Text;
            novo.Senha = textBox4.Text;

            try {

                if (_usuarioBLL.EmailJaCadastrado(novo)) {
                    label6.Text = "Email já cadastrado";
                    label6.ForeColor = Color.Red;
                    label6.Visible = true;
                    _usuarioBLL.Verificacoes(novo);
                }
                if (textBox2.Text != novo.Senha) {
                    label8.Text = "Senha diferente";
                    label8.ForeColor = Color.Red;
                    label8.Visible = true;
                    _usuarioBLL.Verificacoes(novo);
                }
                else {

                    label6.Visible = false;
                    label8.Visible = false;


                    _usuarioBLL.AdicionarUsuario(novo);

                    EmailBLL.EnviarEmailBLL("Olá, " + novo.Nome + "\r\n\r\n" +
                     "Seja bem-vindo ao AtendeTech, o seu novo assistente virtual de ajuda e suporte técnico.\r\n\r\n" +
                     "Estamos muito contentes em tê-lo como usuário da nossa plataforma. O AtendeTech foi desenvolvido para tornar seu atendimento mais rápido, eficiente e acessível, sempre que você precisar de suporte técnico.\r\n\r\n" +
                     "Com o AtendeTech, você pode:\r\n\r\nObter respostas para dúvidas técnicas com agilidade\r\n\r\nReceber instruções passo a passo para resolver problemas\r\n\r\nAcessar suporte a qualquer hora, de forma simples e intuitiva\r\n\r\n" +
                     "Contar com um serviço confiável e sempre disponível\r\n\r\nSe tiver qualquer dúvida ou sugestão, nossa equipe está à disposição para ajudá-lo.\r\n\r\nAtenciosamente,\r\nEquipe AtendeTech\r\nsuporte@atendetech.com.br",
                     novo.Email,
                     "Sua conta foi criada com sucesso - seja bem-vindo(a)!",
                     button1);

                    MessageBox.Show("Usuário Adicionado com sucesso!");

                    this.Hide();
                    Exemplo exemplo = new Exemplo();
                    exemplo.ShowDialog();
                    this.Hide();

                }

            }
            catch{

                if (_usuarioBLL.EmailJaCadastrado(novo)) {
                    label6.Text = "Email já cadastrado";
                    label6.ForeColor = Color.Red;
                    label6.Visible = true;
                    _usuarioBLL.Verificacoes(novo);
                }


            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void Cadastro_Load(object sender, EventArgs e) {
            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

            dateTimePicker1.MaxDate = DateTime.Today;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            textBox4.PasswordChar = checkBox1.Checked ? '\0' : '*';
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button2_Click(object sender, EventArgs e) {

            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
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
