using Data_Access;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Regras_de_negócio {
    public class RecuperarSenhaBLL {

        private readonly RecuperarSenhaDAL _recuperarSenhaDAL = new RecuperarSenhaDAL();

        public class Recuperacao {
            public string Email { get; set; }
            public string Senha { get; set; }
        }

        private bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

        public bool ValidarEmail(string email) {
            if (string.IsNullOrWhiteSpace(email)) {
                throw new ArgumentException("Email obrigatório.");
            }

            if (!EmailValido(email)) {
                throw new FormatException("Formato de email inválido.");
            }

            return _recuperarSenhaDAL.ValidarEmail(email);
        }

        public bool AlterarSenha(string email, string novaSenha) {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(novaSenha)) {
                throw new ArgumentException("Email e nova senha são obrigatórios.");
            }

            return _recuperarSenhaDAL.AlterarSenha(email, novaSenha);
        }

        public string RetornoNome(string email) {
            if (string.IsNullOrWhiteSpace(email)) {
                throw new ArgumentException("O e-mail não pode ser vazio.");
            }

            return _recuperarSenhaDAL.RetornoNome(email);
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