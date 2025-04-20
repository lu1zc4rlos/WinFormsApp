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

        public bool Verificacoes(Usuario novoUsuario) {

            int validador = 0;
           

            // Validação de dados

            // Verifica se o nome é vazio ou nulo
            if (string.IsNullOrWhiteSpace(novoUsuario.Nome)) {
                string msg = "Nome de usuário obrigatório";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validador = 1;
                throw new Exception(msg);
               
                
            }

            // Verifica se a data de nascimento é válida
            if (novoUsuario.Data_Nascimento == DateTime.MinValue) {
                string msg = "Data de nascimento obrigatória";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validador = 1;
                throw new Exception(msg);
                
            }

            // Verifica se o email é vazio ou nulo
            if (string.IsNullOrWhiteSpace(novoUsuario.Email)) {
                string msg = "Email obrigatório";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validador = 1;
                throw new Exception(msg);
                
            }

            // Verifica se o email é válido
            if (!EmailValido(novoUsuario.Email)) {
                string msg = "Email inválido";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validador = 1;
                throw new Exception(msg);
               
            }

            // Verifica se a senha é vazia ou nula
            if (string.IsNullOrWhiteSpace(novoUsuario.Senha)) {
                string msg = "Senha obrigatória";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validador = 1;
                throw new Exception(msg);
                
            }

            return validador == 0;
        }

        public bool EmailJaCadastrado(Usuario novoUsuario) {

            // Verifica se o email já está cadastrado
            return _usuariodal.EmailJaCadastrado(novoUsuario);

        }


        public void AdicionarUsuario(Usuario novoUsuario) {
            if (!Verificacoes(novoUsuario)) {
                throw new Exception("Erro na validação dos dados do usuário.");
            }
            if (EmailJaCadastrado(novoUsuario)) {
                throw new Exception("Este e-mail já está cadastrado.");
            }
            
                _usuariodal.AdicionarUsuario(novoUsuario);
               
        }

    }
}
