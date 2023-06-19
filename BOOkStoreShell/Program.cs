using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TelaCadastro telaDeCadastro = new TelaCadastro();
            telaDeCadastro.Show();
            Application.Run();

        }
    }
}
