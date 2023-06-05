using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class LoginFuncionario : Form
    {

        public LoginFuncionario()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            this.Close();
            var frm = new TelaMenu();
            frm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFuncionario frm = new TelaFuncionario();


            frm.Show();
        }

        private void LoginFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
