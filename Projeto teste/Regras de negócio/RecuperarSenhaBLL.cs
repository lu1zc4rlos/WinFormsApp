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
using System.Security.Cryptography;

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

        public bool ValidarEmail(string Email) {

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

            return _recuperarsenhadal.ValidarEmail(Email);
        }

        public bool AlterarSenha(string Email, string novaSenha) {

            return _alterarsenhadal.AlterarSenha(Email, novaSenha);
        }
        public string RetornoNome(string Email) {

            if(string.IsNullOrEmpty(Email)) {
                throw new ArgumentException("O e-mail não pode ser vazio.");
            }

            return _retornarnomedal.RetornoNome(Email);
        }

        public string GerarCodigoSeguro(int tamanho = 8) {
           const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
           var bytes = new byte[tamanho];
           using (var rng = RandomNumberGenerator.Create()) {
            rng.GetBytes(bytes);
            }

            var result = new StringBuilder(tamanho);
            foreach (byte b in bytes) {
            result.Append(chars[b % chars.Length]);
            }

             return result.ToString();
        }
    }
}
