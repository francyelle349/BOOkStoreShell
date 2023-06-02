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
    public partial class TelaDeMenu : Form
    {

        public TelaDeMenu()
        {
            InitializeComponent();
        }

       

        private void btnCliente_Click(object sender, EventArgs e) {
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
            this.Hide();
            LoginFuncionario frm = new LoginFuncionario();


            frm.Show();
        }

        private void TelaDeMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
