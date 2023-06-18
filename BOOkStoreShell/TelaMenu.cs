using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaMenu : Form
    {
        

        public TelaMenu()
        {
           InitializeComponent();

        }
        
        
        private void Pesquisar_Livro()
        {
            this.dgvListaLivros.DataSource = Controller.ControllerLivro.Pesquisar(this.txtPesquisar.Text);
            this.ocultarColunas();
            
        }
        //ocultar as colunas do grid
        private void ocultarColunas()
        {
            this.dgvListaLivros.Columns[0].Visible = false;

        }
        //mostrar colunas no grid
        private void Mostrar()
        {
            this.dgvListaLivros.DataSource = Controller.ControllerLivro.Exibir_Livro();
            this.ocultarColunas();

        }

        private void pictureBoxC_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginCliente telaMenuCliente = new LoginCliente();


            telaMenuCliente.Show();

        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGerente frm = new LoginGerente();


            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
          
        }

        private void TelaDeMenu_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar_Livro();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            this.Pesquisar_Livro();
        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxC_Click_1(object sender, EventArgs e)
        {
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void flowLayoutPanelExibirMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvListaLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
