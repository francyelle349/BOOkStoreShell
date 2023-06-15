using System;
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
            var frm = new TelaGerenteAddLivro();
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


        }


        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textQtdAddLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}