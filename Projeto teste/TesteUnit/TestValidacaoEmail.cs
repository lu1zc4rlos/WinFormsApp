using Regras_de_negócio;

namespace TesteUnit
{
    public class UsuarioBLLTests
    {
        [Theory]
        [InlineData("teste@dominio.com", true)]
        [InlineData("usuario@gmail.com", true)]
        [InlineData("emailinvalido", false)]
        [InlineData("outroemail@", false)]
        public void EmailValido_DeveValidarCorretamente(string email, bool esperado)
        {
            var usuarioBLL = new UsuarioBLL();

            var resultado = usuarioBLL.EmailValido(email);

            Assert.Equal(esperado, resultado);
        }
    }
}
