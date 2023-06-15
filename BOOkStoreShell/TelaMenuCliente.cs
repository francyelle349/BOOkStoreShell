using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaMenuCliente : Form
    {

        public TelaMenuCliente()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {



        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCarrinho frm = new TelaCarrinho();


            frm.Show();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFavoritos frm = new TelaFavoritos();


            frm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfilUsuario frm = new TelaPerfilUsuario();


            frm.Show();
        }
    }
}
