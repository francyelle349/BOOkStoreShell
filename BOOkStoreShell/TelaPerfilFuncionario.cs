using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaPerfilFuncionario : Form
    {
        public TelaPerfilFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaFuncionario();
            frm.Show();


        }

        private void TelaPerfilFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
