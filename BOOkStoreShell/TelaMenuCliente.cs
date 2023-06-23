using System;
using System.Drawing;
using System.Windows.Forms;
using Controller;
namespace BOOkStoreShell
{
    public partial class TelaMenuCliente : Form
    {

        public TelaMenuCliente()
        {
            InitializeComponent();

        }

        private void Mostrar()
        {
            this.dataListaEstoque.DataSource = Controller.ControllerLivro.Exibir_Livro();

        }

        private void Limpar()
        {
            this.txtIdLivro.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.txtGenero.Text = string.Empty;
            this.txtNumeroEstoque.Text = string.Empty;
            this.txtPreco.Text = string.Empty;

        }
        private void Pesquisar_Livro()
        {
            this.dataListaEstoque.DataSource = Controller.ControllerLivro.Pesquisar(this.txtPesquisarC.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TelaMenuCliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {



        }

        private void btnCarrinho_Click(object sender, EventArgs e)
        {

            this.Hide();
            TelaCarrinho frm = new TelaCarrinho();


            frm.Show();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaFavoritos frm = new TelaFavoritos();


            frm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaPerfilUsuario frm = new TelaPerfilUsuario();
            frm.Show();
        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalLivros_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataListaEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataListaEstoque_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdLivro.Text = Convert.ToString(this.dataListaEstoque.CurrentRow.Cells["idLivro"].Value);
            this.txtTitulo.Text = Convert.ToString(this.dataListaEstoque.CurrentRow.Cells["titulo"].Value);
            this.txtPreco.Text = Convert.ToString(this.dataListaEstoque.CurrentRow.Cells["precoLivro"].Value);
            this.txtNumeroEstoque.Text = Convert.ToString(this.dataListaEstoque.CurrentRow.Cells["estoqueLivro"].Value);
            this.txtGenero.Text = Convert.ToString(this.dataListaEstoque.CurrentRow.Cells["idGenero"].Value);

            this.tabControlCliente.SelectedIndex = 1;
        }

        private void txtPesquisarC_TextChanged(object sender, EventArgs e)
        {
            Pesquisar_Livro();
        }

        private void btnPesquisarEstoque_Click(object sender, EventArgs e)
        {
            Pesquisar_Livro();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtQtdCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtNumeroEstoque.Text) < Convert.ToInt32(txtQtdCompra.Text)) {
                    MessageBox.Show("Quantidade de compra maior que estoque!");
                }
                else { 

                    string resp = "";
                    if (this.txtQtdCompra.Text == string.Empty)
                    {
                        MessageBox.Show("Preencha todos os campos");

                    }

                    else
                    {
                        try
                        {
                            float total = Convert.ToInt32(txtQtdCompra.Text) * float.Parse(txtPreco.Text);
                            string cpf = txtboxCpf.Text;

                            DialogResult Opcao;
                            Opcao = MessageBox.Show(cpf + "\nDeseja efetuar a compra?\n"+ "Total:"+total, "BOOkstore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                           

                            if (Opcao == DialogResult.OK)
                            {
                                int diferenca;
                                string cpfCliente;
                                int idLivro;
                                string nomeLivro;
                                int genero;
                                int estoque;
                                double precoUnitario;
                                int qtdCompra;
                                string data;

                                float preco;
                                cpfCliente = txtboxCpf.Text;
                                idLivro = Convert.ToInt32(txtIdLivro.Text);
                                nomeLivro = txtTitulo.Text;
                                genero = Convert.ToInt32(txtGenero.Text);
                                estoque = Convert.ToInt32(txtNumeroEstoque.Text);
                                precoUnitario = Convert.ToDouble(txtPreco.Text);
                                qtdCompra = Convert.ToInt32(txtQtdCompra.Text);
                                diferenca = Convert.ToInt32(txtNumeroEstoque.Text) - Convert.ToInt32(txtQtdCompra.Text);
                                data = Convert.ToString(DateTime.Now);
                                preco = float.Parse(txtPreco.Text);


                                //usando metedo editar livro
                                resp = Controller.ControllerLivro.cEditar_Livro(idLivro, this.txtTitulo.Text.Trim(), genero, diferenca, preco);

                                // add a pedido resp = Controller.ControllerCarr[bookstore]inho(cpfCliente,idLivro, nomeLivro, genero, estoque, precoUnitario, qtdCompra);
                                if (resp.Equals("Ok"))
                                {
                                    MessageBox.Show("COMPRA FINALIZADA");
                                }
                                else
                                {
                                    MessageBox.Show(resp);
                                }

                                this.Limpar();
                                this.Mostrar();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + ex.StackTrace);
                        }
                    } }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
