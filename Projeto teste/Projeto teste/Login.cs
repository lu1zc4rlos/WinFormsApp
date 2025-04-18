﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Regras_de_negócio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_teste {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) {

            string email = textBox1.Text;
            string senha = textBox2.Text;

            LoginBLL loginBLL = new LoginBLL();

            try {
                if (loginBLL.ValidarLogin(email, senha)) {
                    Exemplo exemplo = new Exemplo();
                    exemplo.ShowDialog();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Email ou senha invalidos!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Erro" + ex.Message);
            }
        }
    }
}
