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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGerente));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.lblDinheiroArrecado = new System.Windows.Forms.Label();
            this.lblQuantidadeVendas = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDinheiroVendas = new System.Windows.Forms.Label();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.lblQtdVendas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(110, 481);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(107, 40);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // lblDinheiroArrecado
            // 
            this.lblDinheiroArrecado.AutoSize = true;
            this.lblDinheiroArrecado.Location = new System.Drawing.Point(116, 146);
            this.lblDinheiroArrecado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDinheiroArrecado.Name = "lblDinheiroArrecado";
            this.lblDinheiroArrecado.Size = new System.Drawing.Size(116, 16);
            this.lblDinheiroArrecado.TabIndex = 8;
            this.lblDinheiroArrecado.Text = "Dinheiro Arrecado";
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(116, 326);
            this.lblQuantidadeVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(146, 16);
            this.lblQuantidadeVendas.TabIndex = 9;
            this.lblQuantidadeVendas.Text = "Quantidade de Vendas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1154, 24);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 31);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(755, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 39);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lista de vendas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1101, 146);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(43, 22);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "->";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(586, 146);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(507, 22);
            this.txtPesquisar.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.TelaGerente;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1268, 678);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblDinheiroVendas
            // 
            this.lblDinheiroVendas.AutoSize = true;
            this.lblDinheiroVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDinheiroVendas.Location = new System.Drawing.Point(123, 173);
            this.lblDinheiroVendas.Name = "lblDinheiroVendas";
            this.lblDinheiroVendas.Size = new System.Drawing.Size(109, 39);
            this.lblDinheiroVendas.TabIndex = 25;
            this.lblDinheiroVendas.Text = "label1";
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AllowUserToAddRows = false;
            this.dataGridViewVendas.AllowUserToDeleteRows = false;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(586, 232);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowHeadersWidth = 51;
            this.dataGridViewVendas.RowTemplate.Height = 24;
            this.dataGridViewVendas.Size = new System.Drawing.Size(558, 395);
            this.dataGridViewVendas.TabIndex = 27;
            // 
            // lblQtdVendas
            // 
            this.lblQtdVendas.AutoSize = true;
            this.lblQtdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblQtdVendas.Location = new System.Drawing.Point(132, 353);
            this.lblQtdVendas.Name = "lblQtdVendas";
            this.lblQtdVendas.Size = new System.Drawing.Size(109, 39);
            this.lblQtdVendas.TabIndex = 28;
            this.lblQtdVendas.Text = "label3";
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lblQtdVendas);
            this.Controls.Add(this.dataGridViewVendas);
            this.Controls.Add(this.lblDinheiroVendas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblQuantidadeVendas);
            this.Controls.Add(this.lblDinheiroArrecado);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.TelaGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Label lblDinheiroArrecado;
        private System.Windows.Forms.Label lblQuantidadeVendas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblDinheiroVendas;
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Label lblQtdVendas;
    }
}