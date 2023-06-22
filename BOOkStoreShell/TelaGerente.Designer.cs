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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(122, 528);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(122, 40);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // lblDinheiroArrecado
            // 
            this.lblDinheiroArrecado.AutoSize = true;
            this.lblDinheiroArrecado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDinheiroArrecado.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiroArrecado.Location = new System.Drawing.Point(155, 159);
            this.lblDinheiroArrecado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDinheiroArrecado.Name = "lblDinheiroArrecado";
            this.lblDinheiroArrecado.Size = new System.Drawing.Size(173, 19);
            this.lblDinheiroArrecado.TabIndex = 8;
            this.lblDinheiroArrecado.Text = "Dinheiro Arrecado";
            // 
            // lblQuantidadeVendas
            // 
            this.lblQuantidadeVendas.AutoSize = true;
            this.lblQuantidadeVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblQuantidadeVendas.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidadeVendas.Location = new System.Drawing.Point(155, 348);
            this.lblQuantidadeVendas.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQuantidadeVendas.Name = "lblQuantidadeVendas";
            this.lblQuantidadeVendas.Size = new System.Drawing.Size(209, 19);
            this.lblQuantidadeVendas.TabIndex = 9;
            this.lblQuantidadeVendas.Text = "Quantidade de Vendas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1269, 37);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(94, 36);
            this.btnVoltar.TabIndex = 19;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(849, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Lista de vendas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(1213, 153);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(54, 25);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "->";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(655, 153);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(532, 25);
            this.txtPesquisar.TabIndex = 23;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::View.Properties.Resources.TelaGerente;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1400, 754);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // lblDinheiroVendas
            // 
            this.lblDinheiroVendas.AutoSize = true;
            this.lblDinheiroVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDinheiroVendas.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinheiroVendas.Location = new System.Drawing.Point(154, 208);
            this.lblDinheiroVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDinheiroVendas.Name = "lblDinheiroVendas";
            this.lblDinheiroVendas.Size = new System.Drawing.Size(90, 30);
            this.lblDinheiroVendas.TabIndex = 25;
            this.lblDinheiroVendas.Text = "label1";
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Location = new System.Drawing.Point(646, 253);
            this.dataGridViewVendas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.RowHeadersWidth = 51;
            this.dataGridViewVendas.RowTemplate.Height = 24;
            this.dataGridViewVendas.Size = new System.Drawing.Size(621, 437);
            this.dataGridViewVendas.TabIndex = 27;
            // 
            // lblQtdVendas
            // 
            this.lblQtdVendas.AutoSize = true;
            this.lblQtdVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblQtdVendas.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVendas.Location = new System.Drawing.Point(154, 399);
            this.lblQtdVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtdVendas.Name = "lblQtdVendas";
            this.lblQtdVendas.Size = new System.Drawing.Size(90, 30);
            this.lblQtdVendas.TabIndex = 28;
            this.lblQtdVendas.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.btnVoltar);
            this.groupBox1.Location = new System.Drawing.Point(-1, -11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1585, 115);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::View.Properties.Resources.titulo1;
            this.pictureBox4.Location = new System.Drawing.Point(139, 37);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(281, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources.logo2;
            this.pictureBox3.Location = new System.Drawing.Point(34, 22);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(95, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // TelaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblQtdVendas);
            this.Controls.Add(this.dataGridViewVendas);
            this.Controls.Add(this.lblDinheiroVendas);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantidadeVendas);
            this.Controls.Add(this.lblDinheiroArrecado);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "TelaGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.TelaGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}