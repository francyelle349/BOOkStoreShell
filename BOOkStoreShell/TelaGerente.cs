using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Controller.ControllerPedidos;

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
            this.dataGridViewVendas.DataSource = Exibir_Pedido();
            lblQtdVendas.Text = Convert.ToString(dataGridViewVendas.Rows.Count);
            lblDinheiroVendas.Text = SomarPedido();


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
    }
}
