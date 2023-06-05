using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaGerenteAddFunc : Form
    {
        public TelaGerenteAddFunc()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteFuncionario();
            frm.Show();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteFuncionario();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
