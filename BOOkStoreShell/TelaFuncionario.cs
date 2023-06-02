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
    public partial class TelaFuncionario : Form
    {
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPesquisaFuncionario frm = new TelaPesquisaFuncionario();


            frm.Show();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadastrarLivroFuncionario frm = new CadastrarLivroFuncionario();


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
