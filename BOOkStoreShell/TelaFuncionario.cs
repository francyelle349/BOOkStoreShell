using System;
using System.Windows.Forms;
using View;

namespace BOOkStoreShell
{
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFuncionarioEstoque frm = new TelaFuncionarioEstoque();


            frm.Show();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFuncionarioAddLivro frm = new TelaFuncionarioAddLivro();


            frm.Show();
        }

        private void btnPerfilFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfilFuncionario frm = new TelaPerfilFuncionario();


            frm.Show();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new LoginFuncionario();
            frm.Show();

        }
    }
}
