﻿namespace SGNB
{
    partial class Form_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_SenhaLoja = new System.Windows.Forms.TextBox();
            this.txtb_NomeLoja = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lbl_senhaL = new System.Windows.Forms.Label();
            this.lbl_nomeL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(78, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 84);
            this.panel1.TabIndex = 0;
            // 
            // lbl_subtitulo
            // 
            this.lbl_subtitulo.AutoSize = true;
            this.lbl_subtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_subtitulo.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtitulo.ForeColor = System.Drawing.Color.White;
            this.lbl_subtitulo.Location = new System.Drawing.Point(16, 59);
            this.lbl_subtitulo.Name = "lbl_subtitulo";
            this.lbl_subtitulo.Size = new System.Drawing.Size(327, 18);
            this.lbl_subtitulo.TabIndex = 1;
            this.lbl_subtitulo.Text = "Sistema de Gerenciamento de Negócios para Bicicleta";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(119, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(119, 42);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "SGNB";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_voltar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtb_SenhaLoja);
            this.panel2.Controls.Add(this.txtb_NomeLoja);
            this.panel2.Controls.Add(this.btn_entrar);
            this.panel2.Controls.Add(this.lbl_senhaL);
            this.panel2.Controls.Add(this.lbl_nomeL);
            this.panel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(156, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 160);
            this.panel2.TabIndex = 2;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(17, 124);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // txtb_SenhaLoja
            // 
            this.txtb_SenhaLoja.Location = new System.Drawing.Point(96, 87);
            this.txtb_SenhaLoja.Name = "txtb_SenhaLoja";
            this.txtb_SenhaLoja.Size = new System.Drawing.Size(100, 20);
            this.txtb_SenhaLoja.TabIndex = 4;
            // 
            // txtb_NomeLoja
            // 
            this.txtb_NomeLoja.Location = new System.Drawing.Point(96, 54);
            this.txtb_NomeLoja.Name = "txtb_NomeLoja";
            this.txtb_NomeLoja.Size = new System.Drawing.Size(100, 20);
            this.txtb_NomeLoja.TabIndex = 3;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Location = new System.Drawing.Point(107, 124);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(78, 25);
            this.btn_entrar.TabIndex = 2;
            this.btn_entrar.Text = "Confirmar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lbl_senhaL
            // 
            this.lbl_senhaL.AutoSize = true;
            this.lbl_senhaL.Location = new System.Drawing.Point(49, 90);
            this.lbl_senhaL.Name = "lbl_senhaL";
            this.lbl_senhaL.Size = new System.Drawing.Size(41, 13);
            this.lbl_senhaL.TabIndex = 1;
            this.lbl_senhaL.Text = "Senha:";
            // 
            // lbl_nomeL
            // 
            this.lbl_nomeL.AutoSize = true;
            this.lbl_nomeL.Location = new System.Drawing.Point(14, 57);
            this.lbl_nomeL.Name = "lbl_nomeL";
            this.lbl_nomeL.Size = new System.Drawing.Size(76, 13);
            this.lbl_nomeL.TabIndex = 0;
            this.lbl_nomeL.Text = "Nome da Loja:";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGNB - Login";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtb_SenhaLoja;
        private System.Windows.Forms.TextBox txtb_NomeLoja;
        private System.Windows.Forms.Button btn_entrar;
        private System.Windows.Forms.Label lbl_senhaL;
        private System.Windows.Forms.Label lbl_nomeL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_voltar;
    }
}

