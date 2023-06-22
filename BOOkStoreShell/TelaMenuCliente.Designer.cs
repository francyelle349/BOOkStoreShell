namespace BOOkStoreShell
{
    partial class TelaMenuCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenuCliente));
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAddCarrinho = new System.Windows.Forms.Button();
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.Vitrine = new System.Windows.Forms.TabPage();
            this.txtPesquisarC = new System.Windows.Forms.TextBox();
            this.dataListaEstoque = new System.Windows.Forms.DataGridView();
            this.btnPesquisarEstoque = new System.Windows.Forms.Button();
            this.Livro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdCompra = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtIdLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblNumeroEstoque = new System.Windows.Forms.Label();
            this.txtNumeroEstoque = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlCliente.SuspendLayout();
            this.Vitrine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoque)).BeginInit();
            this.Livro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(1048, 27);
            this.btnCarrinho.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(69, 28);
            this.btnCarrinho.TabIndex = 15;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(1153, 27);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(78, 28);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnAddCarrinho
            // 
            this.btnAddCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCarrinho.Location = new System.Drawing.Point(165, 361);
            this.btnAddCarrinho.Name = "btnAddCarrinho";
            this.btnAddCarrinho.Size = new System.Drawing.Size(205, 41);
            this.btnAddCarrinho.TabIndex = 19;
            this.btnAddCarrinho.Text = "AddCarrinho";
            this.btnAddCarrinho.UseVisualStyleBackColor = true;
            this.btnAddCarrinho.Click += new System.EventHandler(this.btnAddCarrinho_Click);
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.Vitrine);
            this.tabControlCliente.Controls.Add(this.Livro);
            this.tabControlCliente.Location = new System.Drawing.Point(108, 150);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(1030, 486);
            this.tabControlCliente.TabIndex = 62;
            // 
            // Vitrine
            // 
            this.Vitrine.BackColor = System.Drawing.Color.Silver;
            this.Vitrine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vitrine.Controls.Add(this.txtPesquisarC);
            this.Vitrine.Controls.Add(this.dataListaEstoque);
            this.Vitrine.Controls.Add(this.btnPesquisarEstoque);
            this.Vitrine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vitrine.Location = new System.Drawing.Point(4, 25);
            this.Vitrine.Name = "Vitrine";
            this.Vitrine.Padding = new System.Windows.Forms.Padding(3);
            this.Vitrine.Size = new System.Drawing.Size(1022, 457);
            this.Vitrine.TabIndex = 0;
            this.Vitrine.Text = "Vitrine";
            // 
            // txtPesquisarC
            // 
            this.txtPesquisarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPesquisarC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPesquisarC.Location = new System.Drawing.Point(303, 25);
            this.txtPesquisarC.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisarC.Name = "txtPesquisarC";
            this.txtPesquisarC.Size = new System.Drawing.Size(388, 24);
            this.txtPesquisarC.TabIndex = 47;
            this.txtPesquisarC.TextChanged += new System.EventHandler(this.txtPesquisarC_TextChanged);
            // 
            // dataListaEstoque
            // 
            this.dataListaEstoque.AllowUserToAddRows = false;
            this.dataListaEstoque.AllowUserToDeleteRows = false;
            this.dataListaEstoque.AllowUserToOrderColumns = true;
            this.dataListaEstoque.BackgroundColor = System.Drawing.Color.Gray;
            this.dataListaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEstoque.Location = new System.Drawing.Point(35, 76);
            this.dataListaEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.dataListaEstoque.MultiSelect = false;
            this.dataListaEstoque.Name = "dataListaEstoque";
            this.dataListaEstoque.ReadOnly = true;
            this.dataListaEstoque.RowHeadersWidth = 51;
            this.dataListaEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaEstoque.Size = new System.Drawing.Size(957, 374);
            this.dataListaEstoque.TabIndex = 46;
            this.dataListaEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaEstoque_CellContentClick);
            this.dataListaEstoque.DoubleClick += new System.EventHandler(this.dataListaEstoque_DoubleClick);
            // 
            // btnPesquisarEstoque
            // 
            this.btnPesquisarEstoque.Location = new System.Drawing.Point(690, 25);
            this.btnPesquisarEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisarEstoque.Name = "btnPesquisarEstoque";
            this.btnPesquisarEstoque.Size = new System.Drawing.Size(37, 24);
            this.btnPesquisarEstoque.TabIndex = 59;
            this.btnPesquisarEstoque.Text = "->";
            this.btnPesquisarEstoque.UseVisualStyleBackColor = true;
            this.btnPesquisarEstoque.Click += new System.EventHandler(this.btnPesquisarEstoque_Click);
            // 
            // Livro
            // 
            this.Livro.BackColor = System.Drawing.Color.Silver;
            this.Livro.Controls.Add(this.groupBox1);
            this.Livro.Location = new System.Drawing.Point(4, 25);
            this.Livro.Name = "Livro";
            this.Livro.Padding = new System.Windows.Forms.Padding(3);
            this.Livro.Size = new System.Drawing.Size(1022, 457);
            this.Livro.TabIndex = 1;
            this.Livro.Text = "Livro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQtdCompra);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.txtIdLivro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAddCarrinho);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.lblPreco);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblNumeroEstoque);
            this.groupBox1.Controls.Add(this.txtNumeroEstoque);
            this.groupBox1.Controls.Add(this.txtTitulo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÁREA DE COMPRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(675, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 32);
            this.label5.TabIndex = 99;
            this.label5.Text = "COMPRA AÍ VAI...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(29, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 29);
            this.label4.TabIndex = 98;
            this.label4.Text = "Quantidade da Compra:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(667, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 187);
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 96;
            this.label3.Text = "DESEJA COMPRAR?";
            // 
            // txtQtdCompra
            // 
            this.txtQtdCompra.Location = new System.Drawing.Point(317, 270);
            this.txtQtdCompra.Name = "txtQtdCompra";
            this.txtQtdCompra.Size = new System.Drawing.Size(159, 22);
            this.txtQtdCompra.TabIndex = 95;
            this.txtQtdCompra.TextChanged += new System.EventHandler(this.txtQtdCompra_TextChanged);
            // 
            // txtGenero
            // 
            this.txtGenero.Enabled = false;
            this.txtGenero.Location = new System.Drawing.Point(100, 107);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(94, 22);
            this.txtGenero.TabIndex = 94;
            // 
            // txtIdLivro
            // 
            this.txtIdLivro.Enabled = false;
            this.txtIdLivro.Location = new System.Drawing.Point(384, 107);
            this.txtIdLivro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdLivro.Name = "txtIdLivro";
            this.txtIdLivro.Size = new System.Drawing.Size(92, 22);
            this.txtIdLivro.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(307, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Id Livro:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(894, 398);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 41);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 86;
            this.label1.Text = "Titulo";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenero.Location = new System.Drawing.Point(28, 107);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 20);
            this.lblGenero.TabIndex = 85;
            this.lblGenero.Text = "Genero";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco.Location = new System.Drawing.Point(307, 168);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(58, 20);
            this.lblPreco.TabIndex = 84;
            this.lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(384, 168);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(92, 22);
            this.txtPreco.TabIndex = 83;
            // 
            // lblNumeroEstoque
            // 
            this.lblNumeroEstoque.AutoSize = true;
            this.lblNumeroEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumeroEstoque.Location = new System.Drawing.Point(28, 170);
            this.lblNumeroEstoque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroEstoque.Name = "lblNumeroEstoque";
            this.lblNumeroEstoque.Size = new System.Drawing.Size(41, 20);
            this.lblNumeroEstoque.TabIndex = 82;
            this.lblNumeroEstoque.Text = "Qtd:";
            // 
            // txtNumeroEstoque
            // 
            this.txtNumeroEstoque.Enabled = false;
            this.txtNumeroEstoque.Location = new System.Drawing.Point(100, 168);
            this.txtNumeroEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroEstoque.Name = "txtNumeroEstoque";
            this.txtNumeroEstoque.Size = new System.Drawing.Size(94, 22);
            this.txtNumeroEstoque.TabIndex = 81;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(100, 42);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(376, 22);
            this.txtTitulo.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.TelaLogado;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 683);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TelaMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.tabControlCliente);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaMenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOkstore";
            this.Load += new System.EventHandler(this.TelaMenuCliente_Load);
            this.tabControlCliente.ResumeLayout(false);
            this.Vitrine.ResumeLayout(false);
            this.Vitrine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoque)).EndInit();
            this.Livro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddCarrinho;
        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage Vitrine;
        private System.Windows.Forms.TextBox txtPesquisarC;
        private System.Windows.Forms.DataGridView dataListaEstoque;
        private System.Windows.Forms.Button btnPesquisarEstoque;
        private System.Windows.Forms.TabPage Livro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtIdLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblNumeroEstoque;
        private System.Windows.Forms.TextBox txtNumeroEstoque;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdCompra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}