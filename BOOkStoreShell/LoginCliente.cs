using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class LoginCliente : Form
    {

        public LoginCliente()
        {
            InitializeComponent();


        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenu();
            frm.Show();
        }

        private void btnLoginCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaMenuCliente frm = new TelaMenuCliente();


            frm.Show();
        }

        private void btnNaoTemCadastroCliente_Click(object sender, EventArgs e)
        {



        }
    }
}
