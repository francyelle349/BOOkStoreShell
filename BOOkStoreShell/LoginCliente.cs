using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using static Controller.ControllerCliente;

namespace BOOkStoreShell
{
    public partial class LoginCliente : Form
    {

        public LoginCliente()
        {
            InitializeComponent();
            pictureBox2.Paint += PictureBox2_Paint;
            pictureBox1.Paint += PictureBox1_Paint;

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

        private void PictureBox2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            int borderRadius = pictureBox2.Width / 2; // Define o raio do canto igual à metade da largura do PictureBox

            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);

            pictureBox2.Region = new Region(path);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // Define o valor do raio do canto desejado

            RectangleF rect = new RectangleF(0, 0, pictureBox1.Width, pictureBox1.Height);
            path.AddArc(rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90); // Canto superior esquerdo
            path.AddArc(rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90); // Canto superior direito
            path.AddArc(rect.Width - borderRadius * 2, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90); // Canto inferior direito
            path.AddArc(rect.X, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90); // Canto inferior esquerdo

            pictureBox1.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnEntrar_Clic(object sender, EventArgs e)
        {

        }
    }
}
