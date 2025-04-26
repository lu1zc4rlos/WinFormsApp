using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Data_Access;

namespace Regras_de_negócio {
    public class LoginBLL {

        private LoginDAL _logindal = new LoginDAL();

        //Método de validação do email
        public bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        public bool ValidarLogin(string email, string senha) {

            // Verifica se o email é vazio ou nulo
            if (string.IsNullOrWhiteSpace(email)) {
                throw new ArgumentException("Email obrigatório");
            }

            // Verifica se o email é válido
            if (!EmailValido(email)) {
                throw new ArgumentException("Email inválido.");
            }

            // Verifica se a senha é vazia ou nula
            if (string.IsNullOrWhiteSpace(senha)) {
                throw new ArgumentException("Senha obrigatória");
            }

            return _logindal.VerificarLogin(email,senha);
        }
    }
}
