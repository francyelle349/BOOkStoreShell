using System;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaPerfilUsuario : Form
    {
        public TelaPerfilUsuario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenuCliente();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new LoginCliente();
            frm.Show();
        }

<<<<<<< HEAD
        private void btnEditarInformacoesUsuario_Click(object sender, EventArgs e)
        {

        }

        private void TelaPerfilUsuario_Load(object sender, EventArgs e)
        {
      
        }
=======
        private void label1_Click(object sender, EventArgs e)
        {

        }
>>>>>>> 1fb1bf19a4a1faebc7c23ffa85478a15dd8dcfbb
    }
}
