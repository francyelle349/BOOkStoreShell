namespace BOOkStoreShell
{
    partial class TelaGerenteAdicionarLivro
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblNumeroPaginas = new System.Windows.Forms.Label();
            this.lblNumeroEstoque = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.txtNumeroEstoque = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.pictureBoxCapa = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 54;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(575, 377);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 53;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(630, 374);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(270, 20);
            this.txtGenero.TabIndex = 52;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(575, 337);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 51;
            this.lblPreco.Text = "Preço";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(630, 334);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(270, 20);
            this.txtPreco.TabIndex = 50;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(568, 496);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 49;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.Click += new System.EventHandler(this.lblDescricao_Click);
            // 
            // lblNumeroPaginas
            // 
            this.lblNumeroPaginas.AutoSize = true;
            this.lblNumeroPaginas.Location = new System.Drawing.Point(523, 290);
            this.lblNumeroPaginas.Name = "lblNumeroPaginas";
            this.lblNumeroPaginas.Size = new System.Drawing.Size(100, 13);
            this.lblNumeroPaginas.TabIndex = 48;
            this.lblNumeroPaginas.Text = "Número de Páginas";
            this.lblNumeroPaginas.Click += new System.EventHandler(this.lblNumeroPaginas_Click);
            // 
            // lblNumeroEstoque
            // 
            this.lblNumeroEstoque.AutoSize = true;
            this.lblNumeroEstoque.Location = new System.Drawing.Point(523, 233);
            this.lblNumeroEstoque.Name = "lblNumeroEstoque";
            this.lblNumeroEstoque.Size = new System.Drawing.Size(101, 13);
            this.lblNumeroEstoque.TabIndex = 47;
            this.lblNumeroEstoque.Text = "Número de Estoque";
            this.lblNumeroEstoque.Click += new System.EventHandler(this.lblNumeroEstoque_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(575, 184);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 46;
            this.lblAutor.Text = "Autor";
            this.lblAutor.Click += new System.EventHandler(this.lblAutor_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(575, 140);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 45;
            this.lblCodigo.Text = "Código";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Location = new System.Drawing.Point(630, 287);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(270, 20);
            this.txtNumeroPaginas.TabIndex = 44;
            this.txtNumeroPaginas.TextChanged += new System.EventHandler(this.txtNumeroPaginas_TextChanged);
            // 
            // txtNumeroEstoque
            // 
            this.txtNumeroEstoque.Location = new System.Drawing.Point(630, 230);
            this.txtNumeroEstoque.Name = "txtNumeroEstoque";
            this.txtNumeroEstoque.Size = new System.Drawing.Size(270, 20);
            this.txtNumeroEstoque.TabIndex = 43;
            this.txtNumeroEstoque.TextChanged += new System.EventHandler(this.txtNumeroEstoque_TextChanged);
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(630, 184);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(270, 20);
            this.txtAutor.TabIndex = 42;
            this.txtAutor.TextChanged += new System.EventHandler(this.txtAutor_TextChanged);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(630, 456);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(270, 104);
            this.txtDescricao.TabIndex = 41;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(630, 137);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(270, 20);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(255, 421);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(158, 20);
            this.txtTitulo.TabIndex = 39;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // pictureBoxCapa
            // 
            this.pictureBoxCapa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxCapa.Location = new System.Drawing.Point(240, 168);
            this.pictureBoxCapa.Name = "pictureBoxCapa";
            this.pictureBoxCapa.Size = new System.Drawing.Size(190, 226);
            this.pictureBoxCapa.TabIndex = 38;
            this.pictureBoxCapa.TabStop = false;
            this.pictureBoxCapa.Click += new System.EventHandler(this.pictureBoxCapa_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(815, 606);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 681);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNumeroPaginas);
            this.Controls.Add(this.lblNumeroEstoque);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.txtNumeroEstoque);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.pictureBoxCapa);
            this.Name = "TelaGerenteCadastrarLivro";
            this.Text = "TelaGerenteCadastrarLivro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCapa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblNumeroPaginas;
        private System.Windows.Forms.Label lblNumeroEstoque;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.TextBox txtNumeroEstoque;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.PictureBox pictureBoxCapa;
        private System.Windows.Forms.Button btnSalvar;
    }
}