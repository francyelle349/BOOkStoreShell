using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BOOkStoreShell
{
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
            pictureBox2.Paint += PictureBox2_Paint;
            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void btnVoltarGerente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaCadastro();
            frm.Show();
        }

        private void btnLoginGerente_Click(object sender, EventArgs e)
        {

        }

        private void LoginGerente_Load(object sender, EventArgs e)
        {
            txtSenhaGerente.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
