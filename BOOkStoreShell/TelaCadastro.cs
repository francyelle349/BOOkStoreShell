using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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

        }
    }
}
