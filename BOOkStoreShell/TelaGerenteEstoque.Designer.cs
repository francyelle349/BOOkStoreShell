namespace BOOkStoreShell
{
    partial class TelaGerenteEstoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLivrosGerente = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Lista de Estoque";
            // 
            // lblLivrosGerente
            // 
            this.lblLivrosGerente.AutoSize = true;
            this.lblLivrosGerente.Location = new System.Drawing.Point(546, 82);
            this.lblLivrosGerente.Name = "lblLivrosGerente";
            this.lblLivrosGerente.Size = new System.Drawing.Size(46, 13);
            this.lblLivrosGerente.TabIndex = 49;
            this.lblLivrosGerente.Text = "Estoque";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(955, 77);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 48;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPesquisar.Location = new System.Drawing.Point(598, 77);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(335, 20);
            this.txtPesquisar.TabIndex = 47;
            this.txtPesquisar.Text = "Pesquise um titulo";
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(296, 144);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.Size = new System.Drawing.Size(747, 379);
            this.dataGridViewEstoque.TabIndex = 46;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 30);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 45;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(75, 344);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(105, 33);
            this.btnRelatorios.TabIndex = 55;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click_1);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(75, 284);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(105, 33);
            this.btnUsuario.TabIndex = 53;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(75, 217);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(105, 33);
            this.btnFuncionario.TabIndex = 52;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click_1);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(75, 153);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(105, 33);
            this.btnLivro.TabIndex = 51;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(938, 554);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 33);
            this.btnAdicionar.TabIndex = 57;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(804, 554);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 33);
            this.btnExcluir.TabIndex = 56;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLivrosGerente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dataGridViewEstoque);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaGerenteEstoque";
            this.Text = "TelaGerenteEstoque";
            this.Load += new System.EventHandler(this.TelaGerenteEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLivrosGerente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
    }
}