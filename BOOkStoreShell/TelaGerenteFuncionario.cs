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
            this.Hide();
            TelaGerenteLivro frm = new TelaGerenteLivro();


            frm.Show();

        }

       

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteUsuario frm = new TelaGerenteUsuario();


            frm.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteEstoque();
            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteRelatorio frm = new TelaGerenteRelatorio();


            frm.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteAdicionarFuncionario frm = new TelaGerenteAdicionarFuncionario();


            frm.ShowDialog();

            frm = null;

            this.Show();
        }
    }
}
