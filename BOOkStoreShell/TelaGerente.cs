using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaGerente : Form
    {
        
        public TelaGerente()
        {
            InitializeComponent();

        }
        private void Mostrar()
        {
            this.dataGridViewVendas.DataSource = Controller.ControllerLivro.Exibir_Livro();
            lblQtdVendas.Text = "Total de Vendas: " + Convert.ToString(dataGridViewVendas.Rows.Count);
           
        }
        private void TelaGerente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new LoginGerente();
            frm.Show();

        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            


        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaEstoque();
            frm.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
