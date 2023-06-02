namespace BOOkStoreShell
{
    partial class LoginGerente
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
            this.btnVoltarGerente = new System.Windows.Forms.Button();
            this.btnLoginGerente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaGerente = new System.Windows.Forms.TextBox();
            this.txtEmailGerente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVoltarGerente
            // 
            this.btnVoltarGerente.Location = new System.Drawing.Point(22, 29);
            this.btnVoltarGerente.Name = "btnVoltarGerente";
            this.btnVoltarGerente.Size = new System.Drawing.Size(62, 23);
            this.btnVoltarGerente.TabIndex = 17;
            this.btnVoltarGerente.Text = "Voltar";
            this.btnVoltarGerente.UseVisualStyleBackColor = true;
            this.btnVoltarGerente.Click += new System.EventHandler(this.btnVoltarGerente_Click);
            // 
            // btnLoginGerente
            // 
            this.btnLoginGerente.Location = new System.Drawing.Point(348, 286);
            this.btnLoginGerente.Name = "btnLoginGerente";
            this.btnLoginGerente.Size = new System.Drawing.Size(85, 22);
            this.btnLoginGerente.TabIndex = 16;
            this.btnLoginGerente.Text = "Logar";
            this.btnLoginGerente.UseVisualStyleBackColor = true;
            this.btnLoginGerente.Click += new System.EventHandler(this.btnLoginGerente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email";
            // 
            // txtSenhaGerente
            // 
            this.txtSenhaGerente.Location = new System.Drawing.Point(284, 226);
            this.txtSenhaGerente.Name = "txtSenhaGerente";
            this.txtSenhaGerente.Size = new System.Drawing.Size(226, 20);
            this.txtSenhaGerente.TabIndex = 13;
            // 
            // txtEmailGerente
            // 
            this.txtEmailGerente.Location = new System.Drawing.Point(284, 179);
            this.txtEmailGerente.Name = "txtEmailGerente";
            this.txtEmailGerente.Size = new System.Drawing.Size(226, 20);
            this.txtEmailGerente.TabIndex = 12;
            // 
            // LoginGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarGerente);
            this.Controls.Add(this.btnLoginGerente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaGerente);
            this.Controls.Add(this.txtEmailGerente);
            this.Name = "LoginGerente";
            this.Text = "LoginGerente2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarGerente;
        private System.Windows.Forms.Button btnLoginGerente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaGerente;
        private System.Windows.Forms.TextBox txtEmailGerente;
    }
}