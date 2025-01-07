namespace SGNB_2
{
    partial class Form_VisualizacaoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VisualizacaoCliente));
            this.grid_Cliente = new System.Windows.Forms.DataGridView();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_RegistrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Cliente
            // 
            this.grid_Cliente.AllowUserToAddRows = false;
            this.grid_Cliente.AllowUserToOrderColumns = true;
            this.grid_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Cliente.Location = new System.Drawing.Point(12, 56);
            this.grid_Cliente.Name = "grid_Cliente";
            this.grid_Cliente.Size = new System.Drawing.Size(498, 200);
            this.grid_Cliente.TabIndex = 14;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(6, 12);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(421, 32);
            this.lbl_titulo.TabIndex = 13;
            this.lbl_titulo.Text = "Visualização de Clientes";
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(6, 270);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 15;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_RegistrarCliente
            // 
            this.btn_RegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarCliente.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarCliente.Location = new System.Drawing.Point(188, 262);
            this.btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            this.btn_RegistrarCliente.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarCliente.TabIndex = 20;
            this.btn_RegistrarCliente.Text = "Registrar Cliente";
            this.btn_RegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // Form_VisualizacaoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.btn_RegistrarCliente);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.grid_Cliente);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_VisualizacaoCliente";
            this.Text = "SGNB - Visualização de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView grid_Cliente;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_RegistrarCliente;
    }
}