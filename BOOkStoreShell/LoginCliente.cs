using System;
using System.Windows.Forms;
using View;
using static Controller.ControllerCliente;

namespace BOOkStoreShell
{
    public partial class LoginCliente : Form
    {

        public LoginCliente()
        {
            InitializeComponent();


        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaMenu();
            frm.Show();
        }

        private void btnLoginCliente_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (loginCliente(txtEmailCliente.Text, txtSenhaCliente.Text))
                {
                    this.Hide();
                    TelaMenuCliente frm = new TelaMenuCliente();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login ou senha invalidos", "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            //} catch (Exception ex)
            //{
            //    //MessageBox.Show("Error ao fazer login, tente novamente" + "Codigo de erro:" + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void btnNaoTemCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaCadastro();
            frm.Show();
        }
    }
}
