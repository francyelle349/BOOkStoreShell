using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static Controller.ControllerCliente;

namespace BOOkStoreShell
{
    public partial class TelaCadastro : Form
    {
        

        public TelaCadastro()
        {
           InitializeComponent();

        }

        private void backgroundWorker1_DoWork(object sender, EventArgs e)
        {

        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGerente frm = new LoginGerente();


            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginCliente telaMenuCliente = new LoginCliente();
            
            telaMenuCliente.Show();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNomeCliente.Text;
            string emailCliente = txtEmailCliente.Text;
            string cpfCliente = txtCPFCliente.Text;
            string telCliente = txtTelefoneCliente.Text;
            string senhaCliente = txtSenhaCliente.Text;

            Controller.ControllerCliente controller = new Controller.ControllerCliente();
            controller.CadastrarCliente(nomeCliente, emailCliente, cpfCliente, telCliente, senhaCliente);

            this.Close();
            var frm = new TelaCadastro();
            frm.Show();


        }
    }
}
