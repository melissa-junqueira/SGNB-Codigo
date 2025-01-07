namespace SGNB_2
{
    partial class Form_RelatorioVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RelatorioVenda));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.grid_Vendas = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_RegistrarVenda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 270);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 18;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // grid_Vendas
            // 
            this.grid_Vendas.AllowUserToAddRows = false;
            this.grid_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Vendas.Location = new System.Drawing.Point(12, 56);
            this.grid_Vendas.Name = "grid_Vendas";
            this.grid_Vendas.Size = new System.Drawing.Size(505, 200);
            this.grid_Vendas.TabIndex = 17;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(6, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(356, 32);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "Relatório de Vendas";
            // 
            // btn_RegistrarVenda
            // 
            this.btn_RegistrarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarVenda.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarVenda.Location = new System.Drawing.Point(187, 262);
            this.btn_RegistrarVenda.Name = "btn_RegistrarVenda";
            this.btn_RegistrarVenda.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarVenda.TabIndex = 19;
            this.btn_RegistrarVenda.Text = "Registrar Venda";
            this.btn_RegistrarVenda.UseVisualStyleBackColor = true;
            this.btn_RegistrarVenda.Click += new System.EventHandler(this.btn_RegistrarVenda_Click);
            // 
            // Form_RelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.btn_RegistrarVenda);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.grid_Vendas);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_RelatorioVenda";
            this.Text = "SGNB - Relatório de Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView grid_Vendas;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_RegistrarVenda;
    }
}