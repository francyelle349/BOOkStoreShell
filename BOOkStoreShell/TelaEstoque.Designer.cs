namespace BOOkStoreShell
{
    partial class TelaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEstoque));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.lblTotalLivros = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Lista = new System.Windows.Forms.TabPage();
            this.chkDeletar = new System.Windows.Forms.CheckBox();
            this.Configuração = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblNumeroEstoque = new System.Windows.Forms.Label();
            this.txtNumeroEstoque = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Lista.SuspendLayout();
            this.Configuração.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1750, 107);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(147, 32);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPesquisar.Location = new System.Drawing.Point(50, 42);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(532, 25);
            this.txtPesquisar.TabIndex = 47;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dataLista.Location = new System.Drawing.Point(50, 155);
            this.dataLista.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1102, 306);
            this.dataLista.TabIndex = 46;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstoque_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 125;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnVoltar.Location = new System.Drawing.Point(1197, 49);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(99, 37);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnImprimir.Location = new System.Drawing.Point(1039, 106);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 32);
            this.btnImprimir.TabIndex = 57;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnExcluir.Location = new System.Drawing.Point(864, 106);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 32);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(594, 42);
            this.btnPesquisarEstoque.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(93, 25);
            this.btnPesquisarEstoque.TabIndex = 59;
            this.btnPesquisarEstoque.Text = "->";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = true;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotalLivros
            // 
            this.lblTotalLivros.AutoSize = true;
            this.lblTotalLivros.Location = new System.Drawing.Point(773, 113);
            this.lblTotalLivros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLivros.Name = "lblTotalLivros";
            this.lblTotalLivros.Size = new System.Drawing.Size(81, 19);
            this.lblTotalLivros.TabIndex = 60;
            this.lblTotalLivros.Text = "Variavel";
            this.lblTotalLivros.Click += new System.EventHandler(this.lblTotalLivros_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Lista);
            this.tabControl1.Controls.Add(this.Configuração);
            this.tabControl1.Location = new System.Drawing.Point(50, 156);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 543);
            this.tabControl1.TabIndex = 61;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.chkDeletar);
            this.Lista.Controls.Add(this.txtPesquisar);
            this.Lista.Controls.Add(this.btnImprimir);
            this.Lista.Controls.Add(this.dataLista);
            this.Lista.Controls.Add(this.lblTotalLivros);
            this.Lista.Controls.Add(this.btnExcluir);
            this.Lista.Controls.Add(this.btnPesquisarEstoque);
            this.Lista.Location = new System.Drawing.Point(4, 28);
            this.Lista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Lista.Size = new System.Drawing.Size(1207, 511);
            this.Lista.TabIndex = 0;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            this.Lista.Click += new System.EventHandler(this.Lista_Click);
            // 
            // chkDeletar
            // 
            this.chkDeletar.AutoSize = true;
            this.chkDeletar.Location = new System.Drawing.Point(50, 106);
            this.chkDeletar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDeletar.Name = "chkDeletar";
            this.chkDeletar.Size = new System.Drawing.Size(97, 23);
            this.chkDeletar.TabIndex = 61;
            this.chkDeletar.Text = "Deletar";
            this.chkDeletar.UseVisualStyleBackColor = true;
            this.chkDeletar.CheckedChanged += new System.EventHandler(this.chkDeletar_CheckedChanged);
            // 
            // Configuração
            // 
            this.Configuração.Controls.Add(this.groupBox1);
            this.Configuração.Location = new System.Drawing.Point(4, 28);
            this.Configuração.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Configuração.Name = "Configuração";
            this.Configuração.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Configuração.Size = new System.Drawing.Size(1207, 511);
            this.Configuração.TabIndex = 1;
            this.Configuração.Text = "Configurações";
            this.Configuração.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.txtIdLivro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblNumeroEstoque);
            this.groupBox1.Controls.Add(this.txtNumeroEstoque);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Location = new System.Drawing.Point(41, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1108, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livros";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(363, 158);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(158, 25);
            this.txtGenero.TabIndex = 94;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Enabled = false;
            this.txtIdLivro.Location = new System.Drawing.Point(648, 158);
            this.txtIdLivro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(139, 25);
            this.txtIdLivro.TabIndex = 93;
            this.txtIdLivro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(567, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Id Livro:";
            this.label2.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnCancelar.Location = new System.Drawing.Point(684, 335);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 26);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnNovo.Location = new System.Drawing.Point(289, 335);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 26);
            this.btnNovo.TabIndex = 90;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnEditar.Location = new System.Drawing.Point(552, 335);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 26);
            this.btnEditar.TabIndex = 89;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("MS UI Gothic", 10.8F);
            this.btnSalvar.Location = new System.Drawing.Point(418, 335);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 26);
            this.btnSalvar.TabIndex = 88;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(285, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Titulo";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenero.Location = new System.Drawing.Point(285, 163);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 20);
            this.lblGenero.TabIndex = 85;
            this.lblGenero.Text = "Genero";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco.Location = new System.Drawing.Point(567, 219);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(53, 20);
            this.lblPreco.TabIndex = 84;
            this.lblPreco.Text = "Preço";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(648, 217);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(139, 25);
            this.txtPreco.TabIndex = 83;
            // 
            // lblNumeroEstoque
            // 
            this.lblNumeroEstoque.AutoSize = true;
            this.lblNumeroEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumeroEstoque.Location = new System.Drawing.Point(285, 219);
            this.lblNumeroEstoque.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroEstoque.Name = "lblNumeroEstoque";
            this.lblNumeroEstoque.Size = new System.Drawing.Size(41, 20);
            this.lblNumeroEstoque.TabIndex = 82;
            this.lblNumeroEstoque.Text = "Qtd:";
            // 
            // txtNumeroEstoque
            // 
            this.txtNumeroEstoque.Location = new System.Drawing.Point(363, 214);
            this.txtNumeroEstoque.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtNumeroEstoque.Name = "txtNumeroEstoque";
            this.txtNumeroEstoque.Size = new System.Drawing.Size(158, 25);
            this.txtNumeroEstoque.TabIndex = 81;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(363, 103);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(424, 25);
            this.txtTitulo.TabIndex = 80;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.fundocinzaclaro;
            this.pictureBox1.Location = new System.Drawing.Point(28, 138);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1265, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::View.Properties.Resources.titulo1;
            this.pictureBox4.Location = new System.Drawing.Point(139, 38);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(309, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources.logo2;
            this.pictureBox3.Location = new System.Drawing.Point(15, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.btnVoltar);
            this.groupBox2.Location = new System.Drawing.Point(-3, -9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1786, 124);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            // 
            // TelaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1325, 738);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "TelaEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaEstoque";
            this.Load += new System.EventHandler(this.TelaGerenteEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            this.Configuração.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.Label lblTotalLivros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Lista;
        private System.Windows.Forms.TabPage Configuração;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.CheckBox chkDeletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblNumeroEstoque;
        private System.Windows.Forms.TextBox txtNumeroEstoque;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}