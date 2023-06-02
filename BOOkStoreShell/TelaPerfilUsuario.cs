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
    }
}
