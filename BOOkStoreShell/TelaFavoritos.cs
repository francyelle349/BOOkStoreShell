using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaFavoritos : Form
    {
        public TelaFavoritos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenuCliente();
            frm.Show();

        }



        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfilUsuario frm = new TelaPerfilUsuario();


            frm.Show();
        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaCarrinho frm = new TelaCarrinho();


            frm.Show();
        }

        private void TelaFavoritos_Load(object sender, EventArgs e)
        {

        }
    }
}
