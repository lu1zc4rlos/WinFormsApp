using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Banco_de_dados;
using Datai_Accesso;

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
        private UsuarioDAL usuarioDAL = new UsuarioDAL();
        public Usuario ObterUsuarioPorEmail(string email)
        {
           
            return usuarioDAL.BuscarPorEmail(email);
        }

        public Usuario ObterUsuarioPorEmaileSenha(string email, string senha)
        {

            return usuarioDAL.BuscarPorEmaileSenha(email,senha);
        }

         /*public static bool VerificarSenha(string senhaDigitada, string hashArmazenado)
         {
             string hashDigitado = CriptografiaDAL.GerarHashSenha(senhaDigitada);
             return hashDigitado == hashArmazenado;
         }*/

    }
}
