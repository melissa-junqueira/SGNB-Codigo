namespace SGNB_2
{
    partial class Form_VisualizacaoEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VisualizacaoEstoque));
            this.btn_voltar = new System.Windows.Forms.Button();
            this.grid_Estoque = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_RegistrarPeca = new System.Windows.Forms.Button();
            this.btn_RegistrarBicicleta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 270);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 21;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // grid_Estoque
            // 
            this.grid_Estoque.AllowUserToAddRows = false;
            this.grid_Estoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Estoque.Location = new System.Drawing.Point(18, 56);
            this.grid_Estoque.Name = "grid_Estoque";
            this.grid_Estoque.Size = new System.Drawing.Size(498, 200);
            this.grid_Estoque.TabIndex = 20;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(420, 32);
            this.lbl_titulo.TabIndex = 19;
            this.lbl_titulo.Text = "Visualização de Estoque";
            // 
            // btn_RegistrarPeca
            // 
            this.btn_RegistrarPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarPeca.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarPeca.Location = new System.Drawing.Point(160, 261);
            this.btn_RegistrarPeca.Name = "btn_RegistrarPeca";
            this.btn_RegistrarPeca.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarPeca.TabIndex = 22;
            this.btn_RegistrarPeca.Text = "Registrar Peça";
            this.btn_RegistrarPeca.UseVisualStyleBackColor = true;
            this.btn_RegistrarPeca.Click += new System.EventHandler(this.btn_RegistrarPeca_Click);
            // 
            // btn_RegistrarBicicleta
            // 
            this.btn_RegistrarBicicleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarBicicleta.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarBicicleta.Location = new System.Drawing.Point(341, 261);
            this.btn_RegistrarBicicleta.Name = "btn_RegistrarBicicleta";
            this.btn_RegistrarBicicleta.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarBicicleta.TabIndex = 23;
            this.btn_RegistrarBicicleta.Text = "Registrar Bicicleta";
            this.btn_RegistrarBicicleta.UseVisualStyleBackColor = true;
            this.btn_RegistrarBicicleta.Click += new System.EventHandler(this.btn_RegistrarBicicleta_Click);
            // 
            // Form_VisualizacaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.btn_RegistrarBicicleta);
            this.Controls.Add(this.btn_RegistrarPeca);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.grid_Estoque);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_VisualizacaoEstoque";
            this.Text = "SGNB - Visualização de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Estoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView grid_Estoque;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_RegistrarPeca;
        private System.Windows.Forms.Button btn_RegistrarBicicleta;
    }
}