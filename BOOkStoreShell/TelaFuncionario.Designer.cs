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
            this.btnPerfilFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerfilFuncionario
            // 
            this.btnPerfilFuncionario.Location = new System.Drawing.Point(80, 104);
            this.btnPerfilFuncionario.Name = "btnPerfilFuncionario";
            this.btnPerfilFuncionario.Size = new System.Drawing.Size(200, 78);
            this.btnPerfilFuncionario.TabIndex = 26;
            this.btnPerfilFuncionario.Text = "Perfil";
            this.btnPerfilFuncionario.UseVisualStyleBackColor = true;
            this.btnPerfilFuncionario.Click += new System.EventHandler(this.btnPerfilFuncionario_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(80, 220);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(200, 78);
            this.btnCadastrarLivro.TabIndex = 27;
            this.btnCadastrarLivro.Text = "CadastrarLivro";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Location = new System.Drawing.Point(80, 338);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(200, 78);
            this.btnPesquisarLivro.TabIndex = 28;
            this.btnPesquisarLivro.Text = "Pesquisar Livro";
            this.btnPesquisarLivro.UseVisualStyleBackColor = true;
            this.btnPesquisarLivro.Click += new System.EventHandler(this.btnPesquisarLivro_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(62, 23);
            this.btnVoltar.TabIndex = 29;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPesquisarLivro);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.btnPerfilFuncionario);
            this.Name = "TelaFuncionario";
            this.Text = "TelaFuncionario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerfilFuncionario;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.Button btnVoltar;
    }
}