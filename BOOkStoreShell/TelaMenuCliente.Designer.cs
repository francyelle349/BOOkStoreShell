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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(768, 180);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(187, 183);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(563, 20);
            this.txtPesquisar.TabIndex = 13;
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(140, 223);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.Size = new System.Drawing.Size(747, 379);
            this.dataGridViewMenu.TabIndex = 12;
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Location = new System.Drawing.Point(968, 24);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(75, 23);
            this.btnCarrinho.TabIndex = 15;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Location = new System.Drawing.Point(1064, 24);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(75, 23);
            this.btnFavoritos.TabIndex = 16;
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(1161, 24);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 17;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(31, 24);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaMenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 741);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnFavoritos);
            this.Controls.Add(this.btnCarrinho);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dataGridViewMenu);
            this.Name = "TelaMenuCliente";
            this.Text = "TelaMenuCliente";
            this.Load += new System.EventHandler(this.TelaMenuCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnVoltar;
    }
}