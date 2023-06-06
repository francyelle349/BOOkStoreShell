using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BOOkStoreShell
{
    public partial class TelaMenu : Form
    {
        //img menu
        private PictureBox pictureBox;
        private List<string> imagePaths;
        private int currentIndex;
        //

        public TelaMenu()
        {
            InitializeComponent();
            InitializeImages();

        }

        public void InitializeImages()
        {
            // Caminhos das imagens
            imagePaths = new List<string>
            {
                "C:\\Users\\Amanda\\Desktop\\BOOkstore\\img\\img1.png", // caminho da imagem
                "C:\\Users\\Amanda\\Desktop\\BOOkstore\\img\\img2.png",
                "C:\\Users\\Amanda\\Desktop\\BOOkstore\\img\\img3.png"
            };

            // Configurar o PictureBox
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            pictureBoxC.Image = Image.FromFile(imagePaths[currentIndex]);
            pictureBox.Click += pictureBoxC_Click;
            Controls.Add(pictureBox);
        }

        private void pictureBoxC_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginCliente telaMenuCliente = new LoginCliente();


            telaMenuCliente.Show();

        }

        private void btnGerente_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginGerente frm = new LoginGerente();


            frm.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginFuncionario frm = new LoginFuncionario();


            frm.Show();
        }

        private void TelaDeMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxC_Click_1(object sender, EventArgs e)
        {
            // Avançar para a próxima imagemm
            currentIndex++;
            if (currentIndex >= imagePaths.Count)
                currentIndex = 0;

            // Atualizar a imagem exibida no PictureBox
            pictureBoxC.Image = Image.FromFile(imagePaths[currentIndex]);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void flowLayoutPanelExibirMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
