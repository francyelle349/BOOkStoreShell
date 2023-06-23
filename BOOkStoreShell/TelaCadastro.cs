using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Controller;

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
            LoginCliente LoginCliente = new LoginCliente();
            LoginCliente.Show();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmarSenhaCliente.Text != txtSenhaCliente.Text)
                {
                    MessageBox.Show("As senhas informadas não conferem. Por favor, verifique e tente novamente.");
                } 
                else if (string.IsNullOrWhiteSpace(txtNomeCliente.Text) || string.IsNullOrWhiteSpace(txtEmailCliente.Text) || string.IsNullOrWhiteSpace(txtCPFCliente.Text) || string.IsNullOrWhiteSpace(txtTelefoneCliente.Text) || string.IsNullOrWhiteSpace(txtSenhaCliente.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
                } 
                else
                {
                    new ControllerCliente().CadastrarCliente(txtNomeCliente.Text, txtEmailCliente.Text, txtCPFCliente.Text, txtTelefoneCliente.Text, txtSenhaCliente.Text);
                    MessageBox.Show("Cadastro realizado com sucesso!", "", MessageBoxButtons.OK);
                }
            } catch (SqlException ex)
            {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message.Remove(36));

                var frm = new TelaCadastro();
                frm.Show();
                this.Close();
            }
        }
    }
}
