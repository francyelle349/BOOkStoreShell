using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
        }

        private void btnVoltarGerente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenu();
            frm.Show();
        }

        private void btnLoginGerente_Click(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerente frm = new TelaGerente();


            frm.Show();
        }
    }
}
