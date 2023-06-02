namespace BOOkStoreShell
{
    partial class TelaGerenteFuncionario
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
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Lista de Funcionarios";
            // 
            // lblLivrosGerente
            // 
            this.lblLivrosGerente.AutoSize = true;
            this.lblLivrosGerente.Location = new System.Drawing.Point(525, 78);
            this.lblLivrosGerente.Name = "lblLivrosGerente";
            this.lblLivrosGerente.Size = new System.Drawing.Size(67, 13);
            this.lblLivrosGerente.TabIndex = 39;
            this.lblLivrosGerente.Text = "Funcionarios";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(955, 73);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(80, 23);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPesquisar.Location = new System.Drawing.Point(598, 73);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(335, 20);
            this.txtPesquisar.TabIndex = 37;
            this.txtPesquisar.Text = "Pesquise um Funcionario";
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(296, 140);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(747, 379);
            this.dataGridViewFuncionario.TabIndex = 36;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(74, 380);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(105, 33);
            this.btnRelatorios.TabIndex = 45;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(74, 315);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(105, 33);
            this.btnEstoque.TabIndex = 44;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(74, 250);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(105, 33);
            this.btnUsuario.TabIndex = 43;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(74, 188);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(105, 33);
            this.btnLivro.TabIndex = 41;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(774, 539);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(105, 33);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(908, 539);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 33);
            this.btnAdicionar.TabIndex = 47;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // TelaGerenteFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnLivro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLivrosGerente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaGerenteFuncionario";
            this.Text = "TelaGerenteFuncionario";
            this.Load += new System.EventHandler(this.TelaGerenteFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLivrosGerente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
    }
}