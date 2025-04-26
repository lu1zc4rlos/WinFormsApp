using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_dados;

namespace Regras_de_negócio {
    public class UsuarioBLL {

        private UsuarioDAL _usuariodal = new UsuarioDAL();

        //Método de validação do email
        public bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        private void VerificarDadosUsuario(Usuario novoUsuario) {
            if (string.IsNullOrWhiteSpace(novoUsuario.Nome)) {
                throw new Exception("Nome de usuário obrigatório.");
            }

            if (novoUsuario.Data_Nascimento == DateTime.MinValue) {
                throw new Exception("Data de nascimento obrigatória.");
            }

            if (string.IsNullOrWhiteSpace(novoUsuario.Email)) {
                throw new Exception("Email obrigatório.");
            }

            if (!EmailValido(novoUsuario.Email)) {
                throw new Exception("Email inválido.");
            }

            if (string.IsNullOrWhiteSpace(novoUsuario.Senha)) {
                throw new Exception("Senha obrigatória.");
            }
        }

        public bool EmailJaCadastrado(Usuario novoUsuario) {

            // Verifica se o email já está cadastrado
            return _usuariodal.EmailJaCadastrado(novoUsuario);

        }

        public void AdicionarUsuario(Usuario novoUsuario) {
            VerificarDadosUsuario(novoUsuario);

            if (EmailJaCadastrado(novoUsuario)) {
                throw new Exception("Este e-mail já está cadastrado.");
            }

            _usuariodal.AdicionarUsuario(novoUsuario);
        }

    }
}
