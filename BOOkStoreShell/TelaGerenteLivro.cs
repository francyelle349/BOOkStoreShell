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
    public partial class TelaGerenteLivro : Form
    {
        public TelaGerenteLivro()
        {
            InitializeComponent();
          
        }

        private void TelaGerenteLivro_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerente();
            frm.Show();

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteFuncionario frm = new TelaGerenteFuncionario();


            frm.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteEstoque frm = new TelaGerenteEstoque();


            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteRelatorio frm = new TelaGerenteRelatorio();


            frm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteUsuario frm = new TelaGerenteUsuario();


            frm.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteAdicionarLivro frm = new TelaGerenteAdicionarLivro();


            frm.ShowDialog();

            frm = null;

            this.Show();

        }
    }
}
