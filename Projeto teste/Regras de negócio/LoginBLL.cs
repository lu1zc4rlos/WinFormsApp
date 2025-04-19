using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_dados;
using Data_Access;

namespace Regras_de_negócio {
    public class LoginBLL {

        private LoginDAL _logindal = new LoginDAL();

        public class Login {
            public string Email { get; set; }
            public string Senha { get; set; }
        }

        //Método de validação do email
        public bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        public bool ValidarLogin(string Email, string Senha) {

            // Verifica se o email é vazio ou nulo
            if (string.IsNullOrWhiteSpace(Email)) {
                string msg = "Email obrigatório";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }

            // Verifica se o email é válido
            if (!EmailValido(Email)) {
                string msg = "Email inválido";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }

            // Verifica se a senha é vazia ou nula
            if (string.IsNullOrWhiteSpace(Senha)) {
                string msg = "Senha obrigatória";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }

            return _logindal.VerificarLogin(Email,Senha);
        }
    }
}
