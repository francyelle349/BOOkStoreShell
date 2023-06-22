﻿namespace BOOkStoreShell
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
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.lblCPFCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.lblSenhaCliente = new System.Windows.Forms.Label();
            this.txtTelefoneCliente = new System.Windows.Forms.TextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.txtConfirmarSenhaCliente = new System.Windows.Forms.TextBox();
            this.lblConfirmarSenhaCliente = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnEntrarCliente
            // 
            this.btnEntrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarCliente.FlatAppearance.BorderSize = 0;
            this.btnEntrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnEntrarCliente.Location = new System.Drawing.Point(715, 454);
            this.btnEntrarCliente.Margin = new System.Windows.Forms.Padding(0);
            this.btnEntrarCliente.Name = "btnEntrarCliente";
            this.btnEntrarCliente.Size = new System.Drawing.Size(79, 25);
            this.btnEntrarCliente.TabIndex = 9;
            this.btnEntrarCliente.Text = "Entrar";
            this.btnEntrarCliente.UseVisualStyleBackColor = false;
            this.btnEntrarCliente.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Location = new System.Drawing.Point(454, 325);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(130, 22);
            this.txtCPFCliente.TabIndex = 17;
            // 
            // lblCPFCliente
            // 
            this.lblCPFCliente.AutoSize = true;
            this.lblCPFCliente.Location = new System.Drawing.Point(401, 325);
            this.lblCPFCliente.Name = "lblCPFCliente";
            this.lblCPFCliente.Size = new System.Drawing.Size(36, 16);
            this.lblCPFCliente.TabIndex = 16;
            this.lblCPFCliente.Text = "CPF:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(454, 297);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(340, 22);
            this.txtEmailCliente.TabIndex = 15;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(401, 297);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(48, 16);
            this.lblEmailCliente.TabIndex = 14;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(454, 269);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(340, 22);
            this.txtNomeCliente.TabIndex = 13;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(401, 269);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(47, 16);
            this.lblNomeCadastro.TabIndex = 12;
            this.lblNomeCadastro.Text = "Nome:";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Location = new System.Drawing.Point(454, 353);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(107, 22);
            this.txtSenhaCliente.TabIndex = 21;
            this.txtSenhaCliente.UseSystemPasswordChar = true;
            // 
            // lblSenhaCliente
            // 
            this.lblSenhaCliente.AutoSize = true;
            this.lblSenhaCliente.Location = new System.Drawing.Point(401, 353);
            this.lblSenhaCliente.Name = "lblSenhaCliente";
            this.lblSenhaCliente.Size = new System.Drawing.Size(49, 16);
            this.lblSenhaCliente.TabIndex = 20;
            this.lblSenhaCliente.Text = "Senha:";
            // 
            // txtTelefoneCliente
            // 
            this.txtTelefoneCliente.Location = new System.Drawing.Point(664, 325);
            this.txtTelefoneCliente.Name = "txtTelefoneCliente";
            this.txtTelefoneCliente.Size = new System.Drawing.Size(130, 22);
            this.txtTelefoneCliente.TabIndex = 19;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(590, 325);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(64, 16);
            this.lblTelefoneCliente.TabIndex = 18;
            this.lblTelefoneCliente.Text = "Telefone:";
            // 
            // txtConfirmarSenhaCliente
            // 
            this.txtConfirmarSenhaCliente.Location = new System.Drawing.Point(687, 353);
            this.txtConfirmarSenhaCliente.Name = "txtConfirmarSenhaCliente";
            this.txtConfirmarSenhaCliente.Size = new System.Drawing.Size(107, 22);
            this.txtConfirmarSenhaCliente.TabIndex = 23;
            // 
            // lblConfirmarSenhaCliente
            // 
            this.lblConfirmarSenhaCliente.AutoSize = true;
            this.lblConfirmarSenhaCliente.Location = new System.Drawing.Point(567, 353);
            this.lblConfirmarSenhaCliente.Name = "lblConfirmarSenhaCliente";
            this.lblConfirmarSenhaCliente.Size = new System.Drawing.Size(109, 16);
            this.lblConfirmarSenhaCliente.TabIndex = 22;
            this.lblConfirmarSenhaCliente.Text = "Confirmar Senha:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(714, 410);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(80, 26);
            this.btnCadastrarCliente.TabIndex = 24;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtConfirmarSenhaCliente);
            this.Controls.Add(this.lblConfirmarSenhaCliente);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.lblSenhaCliente);
            this.Controls.Add(this.txtTelefoneCliente);
            this.Controls.Add(this.lblTelefoneCliente);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.lblCPFCliente);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCadastro);
            this.Controls.Add(this.btnEntrarCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOkstore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEntrarCliente;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.Label lblCPFCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Label lblSenhaCliente;
        private System.Windows.Forms.TextBox txtTelefoneCliente;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtConfirmarSenhaCliente;
        private System.Windows.Forms.Label lblConfirmarSenhaCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
    }
}