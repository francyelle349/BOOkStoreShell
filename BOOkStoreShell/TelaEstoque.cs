using System;
using System.IO;
using System.Windows.Forms;
using Controller;

namespace BOOkStoreShell
{
    public partial class TelaEstoque : Form
    {
        //variaveis de controle
        private static bool eNovo;
        private static bool eEditar;
        
        public TelaEstoque()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtGenero, "1 - terror\n2 - suspense");//colocar para todos

        }
        //Funções para mensagem
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //método limpar campos
        private void Limpar()
        {
            this.txtIdLivro.Text = string.Empty;
            this.txtTitulo.Text = string.Empty;
            this.txtGenero.Text = string.Empty;
            this.txtNumeroEstoque.Text = string.Empty;
            this.txtPreco.Text = string.Empty;

        }

        //Habilitar os text box

        private void Habilitar(bool valor)
        {
            this.txtTitulo.ReadOnly = !valor;
            this.txtGenero.ReadOnly = !valor;
            this.txtNumeroEstoque.ReadOnly = !valor;
            this.txtPreco.ReadOnly = !valor;
        }

        //Habilitar os Botoes

        private void Hbotoes()
        {
            if (eNovo || eEditar)
            {
                Habilitar(true);
                btnNovo.Enabled = false;
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = true;

            }
            else
            {
                Habilitar(false);
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
                
            }
        }

        //ocultar as colunas do grid

        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;

        }
        //mostrar colunas no grid

        private void Mostrar()
        {
            dataLista.DataSource = Controller.ControllerLivro.Exibir_Livro();
            ocultarColunas();
            lblTotalLivros.Text = "Total de Livros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //Buscar pelo nome
        private void Pesquisar_Livro()
        {
            dataLista.DataSource = Controller.ControllerLivro.Pesquisar(this.txtPesquisar.Text);
            ocultarColunas();
            lblTotalLivros.Text = "Total de Registrados: " + Convert.ToString(dataLista.Rows.Count);
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new TelaGerente();
            frm.Show();
        }

        private void btnLivro_Click(object sender, EventArgs e)
        {
            Close();
          
        }

        private void TelaGerenteEstoque_Load(object sender, EventArgs e)
        {
            Mostrar();
            Habilitar(false);
            Hbotoes();
        }
        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
        }

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
        }
        private void btnRelatorios_Click_1(object sender, EventArgs e)
        {
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            //imprimir, nao sei pq ta esse nome kk
            // Cria um objeto SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Define as propriedades do diálogo
            saveFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt";
            saveFileDialog.Title = "Salvar arquivo de texto";

            // Exibe o diálogo e verifica se o usuário selecionou um arquivo
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho completo do arquivo selecionado pelo usuário
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Cria um StreamWriter para escrever no arquivo
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Percorre as linhas e colunas do DataGridView
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                // Verifica se a célula possui um valor
                                if (cell.Value != null)
                                {
                                    // Obtém o valor da célula convertendo para string
                                    string cellValue = Convert.ToString(cell.Value);

                                    // Escreve o valor da célula no arquivo
                                    writer.Write(cellValue + "\t");
                                }
                                else
                                {
                                    // Se a célula estiver vazia, escreve um valor vazio no arquivo
                                    writer.Write("\t");
                                }
                            
                        }

                            // Quebra de linha após cada linha do DataGridView
                            writer.WriteLine();
                        }

                        // Fecha o StreamWriter
                        writer.Close();
                    }

                    MessageBox.Show("Arquivo salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nao sei pq nao muda o nome mas é o btn pesquisar
            Pesquisar_Livro();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar os registros?", "BOOkstore", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach(DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = Controller.ControllerLivro.cDeletar_Estoque(Convert.ToInt32(Codigo));

                            if (RestoreBounds.Equals("Ok"))
                            {
                                MensagemOk("Registro Excluido");
                            }
                            else
                            {
                                MensagemErro(Resp);
                            }

                        }
                    }
                    Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Pesquisar_Livro();
        }

        private void dataGridViewEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nao sei pq ta o nome antigo no dataLista
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }


        }

        private void textQtdAddLivro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalLivros_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            eNovo = true;
            eEditar = false;
            Hbotoes();
            Limpar();
            Habilitar(true);
            txtTitulo.Focus();
            txtIdLivro.Enabled = false;
      }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (txtTitulo.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                    errorIcone.SetError(txtTitulo, "Insira o titulo");
                }
                else
                {
                    if (eNovo)
                    {
                        int genero;
                        int qtdEstoque;
                        float preco;

                        genero = Convert.ToInt32(txtGenero.Text);
                        qtdEstoque = Convert.ToInt32(txtNumeroEstoque.Text);
                        preco = float.Parse(txtPreco.Text);

                        resp = Controller.ControllerLivro.cAdd_Livro(txtTitulo.Text.Trim(),genero,qtdEstoque,preco);
                    }
                    else
                    {
                        int idLivro;
                        int genero;
                        int qtdEstoque;
                        float preco;

                        genero = Convert.ToInt32(txtGenero.Text);
                        qtdEstoque = Convert.ToInt32(txtNumeroEstoque.Text);
                        preco = float.Parse(txtPreco.Text);
                        idLivro =Convert.ToInt32(txtIdLivro.Text);
                        resp = Controller.ControllerLivro.cEditar_Livro(idLivro,txtTitulo.Text.Trim(), genero, qtdEstoque, preco);
                    }
                    if (resp.Equals("Ok"))
                    {
                        if (eNovo)
                        {
                            MensagemOk("LIVRO SALVO COM SUCESSO");
                        }
                        else
                        {
                            MensagemOk("LIVRO EDITADO COM SUCESSO");
                        }
                    }
                    else
                    {
                        MensagemErro(resp);
                    }
                    eNovo = false;
                    eEditar = false;
                    Hbotoes();
                    Limpar();
                    Mostrar();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            txtIdLivro.Text = Convert.ToString(dataLista.CurrentRow.Cells["idLivro"].Value);
            txtTitulo.Text = Convert.ToString(dataLista.CurrentRow.Cells["titulo"].Value);
            txtPreco.Text = Convert.ToString(dataLista.CurrentRow.Cells["precoLivro"].Value);
            txtNumeroEstoque.Text = Convert.ToString(dataLista.CurrentRow.Cells["estoqueLivro"].Value);
            txtGenero.Text = Convert.ToString(dataLista.CurrentRow.Cells["idGenero"].Value);

            tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtIdLivro.Text.Equals(""))
            {
                MensagemErro("Clique 2 vezes em algum item na lista para editar.");
            }
            else
            {
                eEditar = true;
                Hbotoes();
                Habilitar(true);
            }
        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDeletar.Checked) {
                dataLista.Columns[0].Visible = true;
            }
            else
            {
                dataLista.Columns[0].Visible = false;
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            eNovo = false;
            eEditar = false;
            Hbotoes();
            Limpar();
            Mostrar();
        }
    }

}