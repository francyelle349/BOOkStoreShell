using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaCarrinho : Form
    {
        public TelaCarrinho()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenuCliente();
            frm.Show();

        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFavoritos frm = new TelaFavoritos();


            frm.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfilUsuario frm = new TelaPerfilUsuario();


            frm.Show();
        }

<<<<<<< HEAD
=======
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

>>>>>>> 1fb1bf19a4a1faebc7c23ffa85478a15dd8dcfbb
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void TelaCarrinho_Load(object sender, EventArgs e)
        {

        }
>>>>>>> 1fb1bf19a4a1faebc7c23ffa85478a15dd8dcfbb
    }
}
