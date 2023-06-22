using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Controller;

namespace BOOkStoreShell
{
    public partial class TelaCadastro : Form
    {
        

        public TelaCadastro()
        {
           InitializeComponent();
            pictureBox2.Paint += PictureBox2_Paint;

        }

        private void backgroundWorker1_DoWork(object sender, EventArgs e)
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

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // Define o valor do raio do canto desejado

            RectangleF rect = new RectangleF(0, 0, pictureBox2.Width, pictureBox2.Height);
            path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90); // Canto superior esquerdo
            path.AddArc(rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90); // Canto superior direito
            path.AddArc(rect.Width - borderRadius * 2, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Canto inferior direito
            path.AddArc(rect.X, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Canto inferior esquerdo

            pictureBox2.Region = new Region(path);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Clic(object sender, EventArgs e)
        {

        }

        private void txtCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número ou não é a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela o evento de pressionar a tecla
                e.Handled = true;
            }

        }

        private void txtTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um número ou não é a tecla Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancela o evento de pressionar a tecla
                e.Handled = true;
            }
        }
    }
    
}
