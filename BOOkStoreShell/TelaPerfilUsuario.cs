using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaPerfilUsuario : Form
    {
        public TelaPerfilUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenuCliente();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new LoginCliente();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
