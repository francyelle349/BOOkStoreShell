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
            var frm = new TelaDeMenu();
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
            this.Hide();
            TelaCadastroCliente frm = new TelaCadastroCliente();


            frm.Show();
        }
    }
}
