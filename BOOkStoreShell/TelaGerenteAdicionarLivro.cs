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
    public partial class TelaGerenteAdicionarLivro : Form
    {
        public TelaGerenteAdicionarLivro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerenteLivro();
            frm.Show();
        }

        private void lblGenero_Click(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescricao_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroPaginas_Click(object sender, EventArgs e)
        {

        }

        private void lblNumeroEstoque_Click(object sender, EventArgs e)
        {

        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void txtNumeroPaginas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxCapa_Click(object sender, EventArgs e)
        {

        }
    }
}
