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
    public partial class TelaGerenteEstoque : Form
    {
        public TelaGerenteEstoque()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerente();
            frm.Show();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteLivro();
            frm.Show();
        }

        private void TelaGerenteEstoque_Load(object sender, EventArgs e)
        {

        }









        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerenteFuncionario frm = new TelaGerenteFuncionario();


            frm.Show();
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerenteUsuario frm = new TelaGerenteUsuario();


            frm.Show();
        }


        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerenteRelatorio frm = new TelaGerenteRelatorio();


            frm.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteAdicionarEstoque frm = new TelaGerenteAdicionarEstoque();


            frm.ShowDialog();

            frm = null;

            this.Show();

        }
    }

}