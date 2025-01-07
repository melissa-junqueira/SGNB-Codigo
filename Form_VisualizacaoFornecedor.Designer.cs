namespace SGNB_2
{
    partial class Form_VisualizacaoFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VisualizacaoFornecedor));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.grid_Fornecedor = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_RegistrarFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(516, 32);
            this.lbl_titulo.TabIndex = 8;
            this.lbl_titulo.Text = "Visualização de Fornecedores";
            // 
            // grid_Fornecedor
            // 
            this.grid_Fornecedor.AllowUserToAddRows = false;
            this.grid_Fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Fornecedor.Location = new System.Drawing.Point(18, 55);
            this.grid_Fornecedor.Name = "grid_Fornecedor";
            this.grid_Fornecedor.Size = new System.Drawing.Size(498, 200);
            this.grid_Fornecedor.TabIndex = 9;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 269);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 12;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_RegistrarFornecedor
            // 
            this.btn_RegistrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarFornecedor.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarFornecedor.Location = new System.Drawing.Point(177, 261);
            this.btn_RegistrarFornecedor.Name = "btn_RegistrarFornecedor";
            this.btn_RegistrarFornecedor.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarFornecedor.TabIndex = 20;
            this.btn_RegistrarFornecedor.Text = "Registrar Fornecedor";
            this.btn_RegistrarFornecedor.UseVisualStyleBackColor = true;
            this.btn_RegistrarFornecedor.Click += new System.EventHandler(this.btn_RegistrarFornecedor_Click);
            // 
            // Form_VisualizacaoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.btn_RegistrarFornecedor);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.grid_Fornecedor);
            this.Controls.Add(this.lbl_titulo);
            this.Name = "Form_VisualizacaoFornecedor";
            this.Text = "SGNB - Visualização de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView grid_Fornecedor;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_RegistrarFornecedor;
    }
}