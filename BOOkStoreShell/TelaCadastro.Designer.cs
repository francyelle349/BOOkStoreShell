namespace BOOkStoreShell
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEntrarCliente = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lblConfirmarSenhaCliente = new System.Windows.Forms.Label();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.lblSenhaCliente = new System.Windows.Forms.Label();
            this.txtConfirmarSenhaCliente = new System.Windows.Forms.TextBox();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnEntrarCliente
            // 
            this.btnEntrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrarCliente.FlatAppearance.BorderSize = 0;
            this.btnEntrarCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnEntrarCliente.Location = new System.Drawing.Point(181, 318);
            this.btnEntrarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrarCliente.Name = "btnEntrarCliente";
            this.btnEntrarCliente.Size = new System.Drawing.Size(76, 35);
            this.btnEntrarCliente.TabIndex = 28;
            this.btnEntrarCliente.Text = "Entrar";
            this.btnEntrarCliente.UseVisualStyleBackColor = false;
            this.btnEntrarCliente.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(253, 134);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(406, 24);
            this.txtNomeCliente.TabIndex = 30;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneCliente.ForeColor = System.Drawing.Color.White;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(417, 221);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(93, 19);
            this.lblTelefoneCliente.TabIndex = 35;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneCliente.Location = new System.Drawing.Point(526, 218);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(133, 24);
            this.txtTelefoneCliente.TabIndex = 36;
            this.txtTelefoneCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefoneCliente_KeyPress);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCliente.Location = new System.Drawing.Point(253, 176);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(406, 24);
            this.txtEmailCliente.TabIndex = 32;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCadastro.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCadastro.ForeColor = System.Drawing.Color.White;
            this.lblNomeCadastro.Location = new System.Drawing.Point(177, 137);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(64, 19);
            this.lblNomeCadastro.TabIndex = 29;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // lblConfirmarSenhaCliente
            // 
            this.lblConfirmarSenhaCliente.AutoSize = true;
            this.lblConfirmarSenhaCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenhaCliente.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenhaCliente.Location = new System.Drawing.Point(367, 259);
            this.lblConfirmarSenhaCliente.Name = "lblConfirmarSenhaCliente";
            this.lblConfirmarSenhaCliente.Size = new System.Drawing.Size(165, 19);
            this.lblConfirmarSenhaCliente.TabIndex = 39;
            this.lblConfirmarSenhaCliente.Text = "Confirmar Senha:";
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPFCliente.Location = new System.Drawing.Point(253, 218);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(146, 24);
            this.txtCPFCliente.TabIndex = 34;
            this.txtCPFCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPFCliente_KeyPress);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCliente.ForeColor = System.Drawing.Color.White;
            this.lblEmailCliente.Location = new System.Drawing.Point(177, 176);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(72, 19);
            this.lblEmailCliente.TabIndex = 31;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(550, 318);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(109, 35);
            this.btnCadastrarCliente.TabIndex = 41;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCliente.Location = new System.Drawing.Point(254, 256);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(107, 24);
            this.txtSenhaCliente.TabIndex = 38;
            this.txtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // lblSenhaCliente
            // 
            this.lblSenhaCliente.AutoSize = true;
            this.lblSenhaCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaCliente.ForeColor = System.Drawing.Color.White;
            this.lblSenhaCliente.Location = new System.Drawing.Point(177, 262);
            this.lblSenhaCliente.Name = "lblSenhaCliente";
            this.lblSenhaCliente.Size = new System.Drawing.Size(69, 19);
            this.lblSenhaCliente.TabIndex = 37;
            this.lblSenhaCliente.Text = "Senha:";
            // 
            // txtConfirmarSenhaCliente
            // 
            this.txtConfirmarSenhaCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenhaCliente.Location = new System.Drawing.Point(552, 256);
            this.txtConfirmarSenhaCliente.Name = "txtConfirmarSenhaCliente";
            this.txtConfirmarSenhaCliente.Size = new System.Drawing.Size(107, 24);
            this.txtConfirmarSenhaCliente.TabIndex = 40;
            this.txtConfirmarSenhaCliente.UseSystemPasswordChar = true;
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCliente.ForeColor = System.Drawing.Color.White;
            this.lblCPFCliente.Location = new System.Drawing.Point(177, 221);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(52, 19);
            this.lblCPFCliente.TabIndex = 33;
            this.lblCPFCliente.Text = "CPF:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::View.Properties.Resources.logo2;
            this.pictureBox3.Location = new System.Drawing.Point(679, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(146, 144);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::View.Properties.Resources.fundocinza;
            this.pictureBox2.Location = new System.Drawing.Point(139, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(703, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-161, -135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1311, 742);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 493);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnEntrarCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblNomeCadastro);
            this.Controls.Add(this.lblConfirmarSenhaCliente);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.lblSenhaCliente);
            this.Controls.Add(this.txtConfirmarSenhaCliente);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOkstore";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEntrarCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.Label lblConfirmarSenhaCliente;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Label lblSenhaCliente;
        private System.Windows.Forms.TextBox txtConfirmarSenhaCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}