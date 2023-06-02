namespace BOOkStoreShell
{
    partial class TelaGerente
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
            this.btnLivro = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.dataGridViewDinheiroArrecado = new System.Windows.Forms.DataGridView();
            this.dataGridViewQuantidadeVendas = new System.Windows.Forms.DataGridView();
            this.lblDinheiroArrecado = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.btnUsuarioGerente = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDinheiroArrecado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuantidadeVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLivro
            // 
            this.btnLivro.Location = new System.Drawing.Point(72, 106);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(105, 33);
            this.btnLivro.TabIndex = 1;
            this.btnLivro.Text = "Livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Location = new System.Drawing.Point(72, 170);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(105, 33);
            this.btnFuncionario.TabIndex = 2;
            this.btnFuncionario.Text = "Funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(72, 237);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(105, 33);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(72, 302);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(105, 33);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Location = new System.Drawing.Point(72, 367);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(105, 33);
            this.btnRelatorios.TabIndex = 5;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // dataGridViewDinheiroArrecado
            // 
            this.dataGridViewDinheiroArrecado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDinheiroArrecado.Location = new System.Drawing.Point(261, 106);
            this.dataGridViewDinheiroArrecado.Name = "dataGridViewDinheiroArrecado";
            this.dataGridViewDinheiroArrecado.Size = new System.Drawing.Size(516, 336);
            this.dataGridViewDinheiroArrecado.TabIndex = 6;
            // 
            // dataGridViewQuantidadeVendas
            // 
            this.dataGridViewQuantidadeVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuantidadeVendas.Location = new System.Drawing.Point(828, 106);
            this.dataGridViewQuantidadeVendas.Name = "dataGridViewQuantidadeVendas";
            this.dataGridViewQuantidadeVendas.Size = new System.Drawing.Size(516, 336);
            this.dataGridViewQuantidadeVendas.TabIndex = 7;
            // 
            // lblDinheiroArrecado
            // 
            this.lblDinheiroArrecado.AutoSize = true;
            this.lblDinheiroArrecado.Location = new System.Drawing.Point(258, 70);
            this.lblDinheiroArrecado.Name = "lblDinheiroArrecado";
            this.lblDinheiroArrecado.Size = new System.Drawing.Size(92, 13);
            this.lblDinheiroArrecado.TabIndex = 8;
            this.lblDinheiroArrecado.Text = "Dinheiro Arrecado";
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(834, 70);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(116, 13);
            this.lblQuantidadeVendas.TabIndex = 9;
            this.lblQuantidadeVendas.Text = "Quantidade de Vendas";
            // 
            // btnUsuarioGerente
            // 
            this.btnUsuarioGerente.Location = new System.Drawing.Point(1269, 21);
            this.btnUsuarioGerente.Name = "btnUsuarioGerente";
            this.btnUsuarioGerente.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarioGerente.TabIndex = 18;
            this.btnUsuarioGerente.Text = "Usuário";
            this.btnUsuarioGerente.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnUsuarioGerente);
            this.Controls.Add(this.lblQuantidadeVendas);
            this.Controls.Add(this.lblDinheiroArrecado);
            this.Controls.Add(this.dataGridViewQuantidadeVendas);
            this.Controls.Add(this.dataGridViewDinheiroArrecado);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnLivro);
            this.Name = "TelaGerente";
            this.Text = "TelaGerente";
            this.Load += new System.EventHandler(this.TelaGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDinheiroArrecado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuantidadeVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.DataGridView dataGridViewDinheiroArrecado;
        private System.Windows.Forms.DataGridView dataGridViewQuantidadeVendas;
        private System.Windows.Forms.Label lblDinheiroArrecado;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.Button btnUsuarioGerente;
        private System.Windows.Forms.Button btnVoltar;
    }
}