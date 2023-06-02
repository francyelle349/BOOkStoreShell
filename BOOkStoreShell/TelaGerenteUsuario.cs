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
    public partial class TelaGerenteUsuario : Form
    {
        public TelaGerenteUsuario()
        {
            InitializeComponent();
           
        }

       

        private void TelaGerenteUsuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteLivro();

            frm.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerente();
            frm.Show();

        }

       


       

        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteRelatorio();
            frm.Show();
        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerenteEstoque frm = new TelaGerenteEstoque();


            frm.Show();
        }

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            TelaGerenteFuncionario frm = new TelaGerenteFuncionario();


            frm.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaGerenteAdicionarCliente frm = new TelaGerenteAdicionarCliente();


            frm.ShowDialog();

            frm = null;

            this.Show();
        }
    }
}
