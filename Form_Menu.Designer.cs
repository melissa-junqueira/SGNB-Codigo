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
            this.btn_Vendas = new System.Windows.Forms.Button();
            this.btn_RelatorioVendas = new System.Windows.Forms.Button();
            this.btn_Estoque = new System.Windows.Forms.Button();
            this.btn_Agendamento = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_Servicos = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_Fornecedores = new System.Windows.Forms.Button();
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
            // btn_Vendas
            // 
            this.btn_Vendas.Location = new System.Drawing.Point(126, 115);
            this.btn_Vendas.Name = "btn_Vendas";
            this.btn_Vendas.Size = new System.Drawing.Size(87, 40);
            this.btn_Vendas.TabIndex = 3;
            this.btn_Vendas.Text = "Registrar Vendas";
            this.btn_Vendas.UseVisualStyleBackColor = true;
            this.btn_Vendas.Click += new System.EventHandler(this.btn_Vendas_Click);
            // 
            // btn_RelatorioVendas
            // 
            this.btn_RelatorioVendas.Location = new System.Drawing.Point(219, 207);
            this.btn_RelatorioVendas.Name = "btn_RelatorioVendas";
            this.btn_RelatorioVendas.Size = new System.Drawing.Size(84, 40);
            this.btn_RelatorioVendas.TabIndex = 6;
            this.btn_RelatorioVendas.Text = "Relatório de Vendas";
            this.btn_RelatorioVendas.UseVisualStyleBackColor = true;
            this.btn_RelatorioVendas.Click += new System.EventHandler(this.btn_RelatorioVendas_Click);
            // 
            // btn_Estoque
            // 
            this.btn_Estoque.Location = new System.Drawing.Point(219, 161);
            this.btn_Estoque.Name = "btn_Estoque";
            this.btn_Estoque.Size = new System.Drawing.Size(84, 40);
            this.btn_Estoque.TabIndex = 7;
            this.btn_Estoque.Text = "Estoque";
            this.btn_Estoque.UseVisualStyleBackColor = true;
            this.btn_Estoque.Click += new System.EventHandler(this.btn_Estoque_Click);
            // 
            // btn_Agendamento
            // 
            this.btn_Agendamento.Location = new System.Drawing.Point(309, 115);
            this.btn_Agendamento.Name = "btn_Agendamento";
            this.btn_Agendamento.Size = new System.Drawing.Size(87, 40);
            this.btn_Agendamento.TabIndex = 8;
            this.btn_Agendamento.Text = "Agendamentos";
            this.btn_Agendamento.UseVisualStyleBackColor = true;
            this.btn_Agendamento.Click += new System.EventHandler(this.btn_Agendamento_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 236);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 11;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_Servicos
            // 
            this.btn_Servicos.Location = new System.Drawing.Point(219, 115);
            this.btn_Servicos.Name = "btn_Servicos";
            this.btn_Servicos.Size = new System.Drawing.Size(84, 40);
            this.btn_Servicos.TabIndex = 13;
            this.btn_Servicos.Text = "Serviços";
            this.btn_Servicos.UseVisualStyleBackColor = true;
            this.btn_Servicos.Click += new System.EventHandler(this.btn_Servicos_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(126, 161);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(87, 40);
            this.btn_Clientes.TabIndex = 14;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_Fornecedores
            // 
            this.btn_Fornecedores.Location = new System.Drawing.Point(309, 161);
            this.btn_Fornecedores.Name = "btn_Fornecedores";
            this.btn_Fornecedores.Size = new System.Drawing.Size(87, 40);
            this.btn_Fornecedores.TabIndex = 15;
            this.btn_Fornecedores.Text = "Lista de Fornecedores";
            this.btn_Fornecedores.UseVisualStyleBackColor = true;
            this.btn_Fornecedores.Click += new System.EventHandler(this.btn_Fornecedores_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(498, 273);
            this.Controls.Add(this.btn_Fornecedores);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Servicos);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_Agendamento);
            this.Controls.Add(this.btn_Estoque);
            this.Controls.Add(this.btn_RelatorioVendas);
            this.Controls.Add(this.btn_Vendas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btn_Vendas;
        private System.Windows.Forms.Button btn_RelatorioVendas;
        private System.Windows.Forms.Button btn_Estoque;
        private System.Windows.Forms.Button btn_Agendamento;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_Servicos;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_Fornecedores;
    }
}