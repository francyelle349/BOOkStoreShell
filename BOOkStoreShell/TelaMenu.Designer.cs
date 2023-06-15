namespace BOOkStoreShell
{
    partial class TelaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaMenu));
            this.btnGerente = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvListaLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerente
            // 
            this.btnGerente.FlatAppearance.BorderSize = 0;
            this.btnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnGerente.Location = new System.Drawing.Point(870, 22);
            this.btnGerente.Name = "btnGerente";
            this.btnGerente.Size = new System.Drawing.Size(58, 23);
            this.btnGerente.TabIndex = 11;
            this.btnGerente.Text = "Gerente";
            this.btnGerente.UseVisualStyleBackColor = true;
            this.btnGerente.Click += new System.EventHandler(this.btnGerente_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.btnFuncionario.Location = new System.Drawing.Point(784, 24);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(62, 23);
            this.btnFuncionario.TabIndex = 10;
            this.btnFuncionario.Text = "Funcionario";
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCliente.Location = new System.Drawing.Point(704, 24);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(57, 23);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(596, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 18);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "->";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(324, 27);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(266, 20);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::View.Properties.Resources.Homepage;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(951, 550);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxC.Location = new System.Drawing.Point(84, 96);
            this.pictureBoxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(778, 82);
            this.pictureBoxC.TabIndex = 13;
            this.pictureBoxC.TabStop = false;
            this.pictureBoxC.Click += new System.EventHandler(this.pictureBoxC_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dgvListaLivros
            // 
            this.dgvListaLivros.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListaLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaLivros.GridColor = System.Drawing.Color.Gray;
            this.dgvListaLivros.Location = new System.Drawing.Point(84, 210);
            this.dgvListaLivros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaLivros.Name = "dgvListaLivros";
            this.dgvListaLivros.RowHeadersWidth = 51;
            this.dgvListaLivros.RowTemplate.Height = 24;
            this.dgvListaLivros.Size = new System.Drawing.Size(778, 305);
            this.dgvListaLivros.TabIndex = 14;
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.dgvListaLivros);
            this.Controls.Add(this.pictureBoxC);
            this.Controls.Add(this.btnGerente);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOkstore";
            this.Load += new System.EventHandler(this.TelaDeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvListaLivros;
    }
}