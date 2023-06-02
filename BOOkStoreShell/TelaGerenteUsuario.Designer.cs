namespace BOOkStoreShell
{
    partial class TelaGerenteUsuario
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
            this.txtPesquisarUsuario = new System.Windows.Forms.TextBox();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de Usuarios";
            // 
            // lblLivrosGerente
            // 
            this.lblLivrosGerente.AutoSize = true;
            this.lblLivrosGerente.Location = new System.Drawing.Point(547, 66);
            this.lblLivrosGerente.Name = "lblLivrosGerente";
            this.lblLivrosGerente.Size = new System.Drawing.Size(43, 13);
            this.lblLivrosGerente.TabIndex = 39;
            this.lblLivrosGerente.Text = "Usuario";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(956, 61);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisarUsuario
            // 
            this.txtPesquisarUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPesquisarUsuario.Location = new System.Drawing.Point(599, 61);
            this.txtPesquisarUsuario.Name = "txtPesquisarUsuario";
            this.txtPesquisarUsuario.Size = new System.Drawing.Size(335, 20);
            this.txtPesquisarUsuario.TabIndex = 37;
            this.txtPesquisarUsuario.Text = "Pesquise um usuario";
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(296, 145);
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.Size = new System.Drawing.Size(747, 379);
            this.dataGridViewUsuario.TabIndex = 36;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 31);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(71, 347);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(105, 33);
            this.btnRelatorios.TabIndex = 45;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click_1);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(71, 282);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(105, 33);
            this.btnEstoque.TabIndex = 44;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click_1);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(71, 209);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(105, 33);
            this.btnFuncionario.TabIndex = 42;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click_1);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(71, 145);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(105, 33);
            this.btnLivro.TabIndex = 41;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(938, 557);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 33);
            this.btnAdicionar.TabIndex = 49;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(804, 557);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 33);
            this.btnExcluir.TabIndex = 48;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLivrosGerente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisarUsuario);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaGerenteUsuario";
            this.Text = "TelaGerenteUsuario";
            this.Load += new System.EventHandler(this.TelaGerenteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLivrosGerente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisarUsuario;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
    }
}