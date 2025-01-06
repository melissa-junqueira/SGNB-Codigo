namespace SGNB_2
{
    partial class Form_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subtitulo = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.Button_RegistroVenda = new System.Windows.Forms.Button();
            this.Button_RelatorioVenda = new System.Windows.Forms.Button();
            this.Button_Estoque = new System.Windows.Forms.Button();
            this.Button_Conserto = new System.Windows.Forms.Button();
            this.Button_Peça = new System.Windows.Forms.Button();
            this.Button_Fornecedor = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_subtitulo);
            this.panel1.Controls.Add(this.lbl_titulo);
            this.panel1.Enabled = false;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(81, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 84);
            this.panel1.TabIndex = 1;
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
            // Button_RegistroVenda
            // 
            this.Button_RegistroVenda.Location = new System.Drawing.Point(128, 161);
            this.Button_RegistroVenda.Name = "Button_RegistroVenda";
            this.Button_RegistroVenda.Size = new System.Drawing.Size(84, 40);
            this.Button_RegistroVenda.TabIndex = 3;
            this.Button_RegistroVenda.Text = "Registrar Venda";
            this.Button_RegistroVenda.UseVisualStyleBackColor = true;
            this.Button_RegistroVenda.Click += new System.EventHandler(this.Button_RegistroVenda_Click);
            // 
            // Button_RelatorioVenda
            // 
            this.Button_RelatorioVenda.Location = new System.Drawing.Point(309, 161);
            this.Button_RelatorioVenda.Name = "Button_RelatorioVenda";
            this.Button_RelatorioVenda.Size = new System.Drawing.Size(84, 40);
            this.Button_RelatorioVenda.TabIndex = 6;
            this.Button_RelatorioVenda.Text = "Relatório de Vendas";
            this.Button_RelatorioVenda.UseVisualStyleBackColor = true;
            this.Button_RelatorioVenda.Click += new System.EventHandler(this.Button_RelatorioVenda_Click);
            // 
            // Button_Estoque
            // 
            this.Button_Estoque.Location = new System.Drawing.Point(128, 207);
            this.Button_Estoque.Name = "Button_Estoque";
            this.Button_Estoque.Size = new System.Drawing.Size(84, 40);
            this.Button_Estoque.TabIndex = 7;
            this.Button_Estoque.Text = "Visualizar Estoque";
            this.Button_Estoque.UseVisualStyleBackColor = true;
            this.Button_Estoque.Click += new System.EventHandler(this.Button_Estoque_Click);
            // 
            // Button_Conserto
            // 
            this.Button_Conserto.Location = new System.Drawing.Point(309, 207);
            this.Button_Conserto.Name = "Button_Conserto";
            this.Button_Conserto.Size = new System.Drawing.Size(84, 40);
            this.Button_Conserto.TabIndex = 8;
            this.Button_Conserto.Text = "Agendamento de Conserto";
            this.Button_Conserto.UseVisualStyleBackColor = true;
            this.Button_Conserto.Click += new System.EventHandler(this.Button_Conserto_Click);
            // 
            // Button_Peça
            // 
            this.Button_Peça.Location = new System.Drawing.Point(128, 115);
            this.Button_Peça.Name = "Button_Peça";
            this.Button_Peça.Size = new System.Drawing.Size(84, 40);
            this.Button_Peça.TabIndex = 9;
            this.Button_Peça.Text = "Cadastrar Peça";
            this.Button_Peça.UseVisualStyleBackColor = true;
            this.Button_Peça.Click += new System.EventHandler(this.Button_Peça_Click);
            // 
            // Button_Fornecedor
            // 
            this.Button_Fornecedor.Location = new System.Drawing.Point(309, 115);
            this.Button_Fornecedor.Name = "Button_Fornecedor";
            this.Button_Fornecedor.Size = new System.Drawing.Size(84, 40);
            this.Button_Fornecedor.TabIndex = 10;
            this.Button_Fornecedor.Text = "Cadastrar Fornecedor";
            this.Button_Fornecedor.UseVisualStyleBackColor = true;
            this.Button_Fornecedor.Click += new System.EventHandler(this.Button_Fornecedor_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 12);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cadastrar Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cadastrar Serviço";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 40);
            this.button3.TabIndex = 14;
            this.button3.Text = "Visualizar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(219, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 40);
            this.button4.TabIndex = 15;
            this.button4.Text = "Visualizar Fornecedor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.Button_Fornecedor);
            this.Controls.Add(this.Button_Peça);
            this.Controls.Add(this.Button_Conserto);
            this.Controls.Add(this.Button_Estoque);
            this.Controls.Add(this.Button_RelatorioVenda);
            this.Controls.Add(this.Button_RegistroVenda);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Menu";
            this.Text = "SGNB - Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_subtitulo;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button Button_RegistroVenda;
        private System.Windows.Forms.Button Button_RelatorioVenda;
        private System.Windows.Forms.Button Button_Estoque;
        private System.Windows.Forms.Button Button_Conserto;
        private System.Windows.Forms.Button Button_Peça;
        private System.Windows.Forms.Button Button_Fornecedor;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}