namespace BOOkStoreShell
{
    partial class LoginCliente
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
            this.btnVoltarCliente = new System.Windows.Forms.Button();
            this.btnLoginCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.btnNaoTemCadastroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarCliente
            // 
            this.btnVoltarCliente.Location = new System.Drawing.Point(17, 17);
            this.btnVoltarCliente.Name = "btnVoltarCliente";
            this.btnVoltarCliente.Size = new System.Drawing.Size(62, 23);
            this.btnVoltarCliente.TabIndex = 11;
            this.btnVoltarCliente.Text = "Voltar";
            this.btnVoltarCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCliente.Click += new System.EventHandler(this.btnVoltarCliente_Click);
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.Location = new System.Drawing.Point(324, 298);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(85, 22);
            this.btnLoginCliente.TabIndex = 10;
            this.btnLoginCliente.Text = "Logar";
            this.btnLoginCliente.UseVisualStyleBackColor = true;
            this.btnLoginCliente.Click += new System.EventHandler(this.btnLoginCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Location = new System.Drawing.Point(279, 205);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(226, 20);
            this.txtSenhaCliente.TabIndex = 7;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(279, 158);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(226, 20);
            this.txtEmailCliente.TabIndex = 6;
            // 
            // btnNaoTemCadastroCliente
            // 
            this.btnNaoTemCadastroCliente.Location = new System.Drawing.Point(371, 249);
            this.btnNaoTemCadastroCliente.Name = "btnNaoTemCadastroCliente";
            this.btnNaoTemCadastroCliente.Size = new System.Drawing.Size(134, 20);
            this.btnNaoTemCadastroCliente.TabIndex = 12;
            this.btnNaoTemCadastroCliente.Text = "Não Tem Cadastro?";
            this.btnNaoTemCadastroCliente.UseVisualStyleBackColor = true;
            this.btnNaoTemCadastroCliente.Click += new System.EventHandler(this.btnNaoTemCadastroCliente_Click);
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaoTemCadastroCliente);
            this.Controls.Add(this.btnVoltarCliente);
            this.Controls.Add(this.btnLoginCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Name = "LoginCliente";
            this.Text = "LoginCliente";
            this.Load += new System.EventHandler(this.LoginCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarCliente;
        private System.Windows.Forms.Button btnLoginCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Button btnNaoTemCadastroCliente;
    }
}