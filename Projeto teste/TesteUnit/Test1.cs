using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regras_de_negócio;
using Assert = Xunit.Assert;

namespace TesteUnit
{
    [TestClass]
    public class EmailBLLTest
    {
        [TestMethod]
        public void TestarEmailValido_Corretamente()
        {
            bool resultado = EmailBLL.EmailValido("teste@dominio.com");
            Assert.True(resultado);
        }

        [TestMethod]
        public void TestarEmailInvalido_FaltandoArroba()
        {
            bool resultado = EmailBLL.EmailValido("teste.com");
            Assert.False(resultado);
        }

        [TestMethod]
        public void TestarEmailInvalido_Vazio()
        {
            bool resultado = EmailBLL.EmailValido("");
            Assert.False(resultado);
        }
    }
}
