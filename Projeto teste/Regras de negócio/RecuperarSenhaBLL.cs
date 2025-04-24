using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_dados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Regras_de_negócio {
    public class RecuperarSenhaBLL {

        private RecuperarSenhaDAL _recuperarsenhadal = new RecuperarSenhaDAL();
        private RecuperarSenhaDAL _alterarsenhadal = new RecuperarSenhaDAL();
        private RecuperarSenhaDAL _retornarnomedal = new RecuperarSenhaDAL();

        public class Recuperacao {
            public string Email { get; set; }
            public string Senha { get; set; }
        }

        //Método de validação do email
        public bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        public bool RecuperarSenha(string Email, string Senha) {

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

            return _recuperarsenhadal.RecuperarSenha(Email, Senha);
        }

        public bool AlterarSenha(string Email, string Senha) {

            return _alterarsenhadal.AlterarSenha(Email, Senha);
        }
        public string RetornoNome(string Email) {

            if(string.IsNullOrEmpty(Email)) {
                throw new ArgumentException("O e-mail não pode ser vazio.");
            }

            return _retornarnomedal.RetornoNome(Email);
        }
    }
}
