using BOOkStoreShell;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class TelaFuncionarioEstoque : Form
    {
        public TelaFuncionarioEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaFuncionario();
            frm.Show();
        }
    }
}
