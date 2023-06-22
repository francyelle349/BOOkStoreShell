using BOOkStoreShell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            this.dataGridViewMenu.DataSource = Controller.ControllerLivro.Exibir_Livro();

        }
        private void Pesquisar_Livro()
        {
            this.dataGridViewMenu.DataSource = Controller.ControllerLivro.Pesquisar(this.txtPesquisar.Text);
            
        }


        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginCliente frm = new LoginCliente();
            frm.Show();
        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGerente frm = new LoginGerente();
            frm.Show();
        }

        private void TelaMenu_Load(object sender, EventArgs e)
        {
            Mostrar();

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisar_Livro();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar_Livro();
        }
    }
}
