using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var frm = new TelaDeMenu();
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
