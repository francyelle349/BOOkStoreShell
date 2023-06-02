namespace BOOkStoreShell
{
    partial class TelaGerenteAdicionarEstoque
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtAtualizandoEstoque = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Quantos Livros adicionados ao estoque?";
            // 
            // txtAtualizandoEstoque
            // 
            this.txtAtualizandoEstoque.Location = new System.Drawing.Point(69, 58);
            this.txtAtualizandoEstoque.Name = "txtAtualizandoEstoque";
            this.txtAtualizandoEstoque.Size = new System.Drawing.Size(249, 20);
            this.txtAtualizandoEstoque.TabIndex = 43;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(337, 86);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(65, 22);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // TelaGerenteAdicionarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 120);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAtualizandoEstoque);
            this.Name = "TelaGerenteAdicionarEstoque";
            this.Text = "TelaGerenteAdicionarEstoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAtualizandoEstoque;
        private System.Windows.Forms.Button btnSalvar;
    }
}