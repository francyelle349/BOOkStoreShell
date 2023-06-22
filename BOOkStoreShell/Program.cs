using System;
using System.Windows.Forms;
using View;

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

            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show();
            Application.Run();

        }
    }
}
