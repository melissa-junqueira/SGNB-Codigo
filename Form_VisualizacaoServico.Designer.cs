namespace SGNB_2
{
    partial class Form_VisualizarServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VisualizarServicos));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dataGrid_Servicos = new System.Windows.Forms.DataGridView();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_RegistrarServico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Servicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(424, 32);
            this.lbl_titulo.TabIndex = 14;
            this.lbl_titulo.Text = "Visualização de Serviços";
            // 
            // dataGrid_Servicos
            // 
            this.dataGrid_Servicos.AllowUserToAddRows = false;
            this.dataGrid_Servicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Servicos.Location = new System.Drawing.Point(12, 44);
            this.dataGrid_Servicos.Name = "dataGrid_Servicos";
            this.dataGrid_Servicos.Size = new System.Drawing.Size(500, 200);
            this.dataGrid_Servicos.TabIndex = 15;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.Location = new System.Drawing.Point(12, 269);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(49, 25);
            this.btn_voltar.TabIndex = 16;
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_RegistrarServico
            // 
            this.btn_RegistrarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarServico.ForeColor = System.Drawing.Color.Black;
            this.btn_RegistrarServico.Location = new System.Drawing.Point(173, 261);
            this.btn_RegistrarServico.Name = "btn_RegistrarServico";
            this.btn_RegistrarServico.Size = new System.Drawing.Size(175, 33);
            this.btn_RegistrarServico.TabIndex = 20;
            this.btn_RegistrarServico.Text = "Registrar Serviço";
            this.btn_RegistrarServico.UseVisualStyleBackColor = true;
            this.btn_RegistrarServico.Click += new System.EventHandler(this.btn_RegistrarServico_Click);
            // 
            // Form_VisualizarServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.btn_RegistrarServico);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.dataGrid_Servicos);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_VisualizarServicos";
            this.Text = "SGNB - Serviços";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Servicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dataGrid_Servicos;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_RegistrarServico;
    }
}