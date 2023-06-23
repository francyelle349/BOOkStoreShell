using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaGerente : Form
    {
        
        public TelaGerente()
        {
            InitializeComponent();

        }

        private void SomarPedido()
        {
            string connectionString = "Data Source=DESKTOP-JMUCA02;Initial Catalog=bookstore;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT SUM(valorTotalPedido) FROM Pedido;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal total = Convert.ToDecimal(result);
                        lblDinheiroVendas.Text = total.ToString("C");
                    }
                    else
                    {
                        lblDinheiroVendas.Text = "Não há registros.";
                    }
                }
            }
        }
        private void Mostrar()
        {
            this.dataGridViewVendas.DataSource = Controller.ControllerPedidos.Exibir_Pedido();
            lblQtdVendas.Text = Convert.ToString(dataGridViewVendas.Rows.Count);
            SomarPedido();


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
