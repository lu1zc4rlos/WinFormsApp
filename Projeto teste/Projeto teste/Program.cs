using System;
using System.Windows.Forms;

namespace Projeto_teste {
    internal static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());


            //Application.Run(new ProjetoTeste.Home_Técnico.HomeTecnico());
        }
    }
}
