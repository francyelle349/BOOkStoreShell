using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOOkStoreShell
{
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
        }

        private void btnVoltarGerente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenu();
            frm.Show();
        }

        private void btnLoginGerente_Click(object sender, EventArgs e)
        {
            
            if(txtSenhaGerente.Text ==  "gatinho123")
            {
                this.Hide();
                TelaGerente frm = new TelaGerente();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Ocorreu um erro. Por favor, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void LoginGerente_Load(object sender, EventArgs e)
        {
            txtSenhaGerente.UseSystemPasswordChar = true;
        }
    }
}
