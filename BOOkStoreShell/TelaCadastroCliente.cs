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
    public partial class TelaCadastroCliente : Form
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new LoginCliente();
            frm.Show();
        }

        private void TelaCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
