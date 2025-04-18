using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_dados;

namespace Regras_de_negócio {
    public class UsuarioBLL {

        private UsuarioDAL _usuariodal = new UsuarioDAL();

        public void AdicionarUsuario(Usuario novoUsuario) {

            if (string.IsNullOrWhiteSpace(novoUsuario.Nome)) {
                string msg = "Nome de usuário obrigatório";
                MessageBox.Show(msg,"Erro", MessageBoxButtons.OK,MessageBoxIcon.Error);
                throw new Exception(msg);
            }
            if (novoUsuario.Data_Nascimento == DateTime.MinValue) {
                string msg = "Data de nascimento obrigatória";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }
            if (string.IsNullOrWhiteSpace(novoUsuario.Email)) {
                string msg = "Email obrigatório";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }
            if (string.IsNullOrWhiteSpace(novoUsuario.Senha)) {
                string msg = "Senha obrigatória";
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(msg);
            }

           _usuariodal.AdicionarUsuario(novoUsuario);
        }
    }
}
