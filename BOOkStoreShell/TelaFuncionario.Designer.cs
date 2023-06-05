namespace BOOkStoreShell
{
    partial class TelaFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaFuncionario));
            this.btnPerfilFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPerfilFuncionario
            // 
            this.btnPerfilFuncionario.Location = new System.Drawing.Point(575, 185);
            this.btnPerfilFuncionario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPerfilFuncionario.Name = "btnPerfilFuncionario";
            this.btnPerfilFuncionario.Size = new System.Drawing.Size(130, 44);
            this.btnPerfilFuncionario.TabIndex = 26;
            this.btnPerfilFuncionario.Text = "Perfil";
            this.btnPerfilFuncionario.UseVisualStyleBackColor = true;
            this.btnPerfilFuncionario.Click += new System.EventHandler(this.btnPerfilFuncionario_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(571, 273);
            this.btnCadastrarLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(134, 49);
            this.btnCadastrarLivro.TabIndex = 27;
            this.btnCadastrarLivro.Text = "CadastrarLivro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Location = new System.Drawing.Point(561, 363);
            this.btnPesquisarLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(130, 54);
            this.btnPesquisarLivro.TabIndex = 28;
            this.btnPesquisarLivro.Text = "Estoque";
            this.btnPesquisarLivro.UseVisualStyleBackColor = true;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.btnPesquisarLivro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(1166, 26);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 28);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1263, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisarLivro);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.btnPerfilFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TelaFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerfilFuncionario;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}