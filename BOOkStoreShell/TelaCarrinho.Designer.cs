using System;

namespace BOOkStoreShell
{
    partial class TelaCarrinho
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFavoritos = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(114, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(62, 23);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(34, 23);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(62, 23);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(178, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 339);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(693, 495);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 42);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(812, 493);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(85, 44);
            this.btnComprar.TabIndex = 21;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(380, 495);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(155, 20);
            this.txtValorTotal.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Valor Total";
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.Location = new System.Drawing.Point(1113, 23);
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(62, 23);
            this.btnFavoritos.TabIndex = 24;
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.UseVisualStyleBackColor = true;
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(1190, 23);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(62, 23);
            this.btnPerfil.TabIndex = 25;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // TelaCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnFavoritos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnVoltar);
            this.Name = "TelaCarrinho";
            this.Text = "TelaCarrinho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFavoritos;
        private System.Windows.Forms.Button btnPerfil;
    }
}