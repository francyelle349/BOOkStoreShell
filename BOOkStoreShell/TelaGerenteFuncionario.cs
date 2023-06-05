using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaGerenteFuncionario : Form
    {
        public TelaGerenteFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerente();
            frm.Show();
        }

        private void TelaGerenteFuncionario_Load(object sender, EventArgs e)
        {

        }



        private void btnLivro_Click(object sender, EventArgs e)
        {

        }



        private void btnUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteEstoque();
            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteAddFunc frm = new TelaGerenteAddFunc();


            frm.ShowDialog();

            frm = null;

            this.Show();
        }
    }
}
