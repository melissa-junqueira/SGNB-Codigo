namespace SGNB_2
{
    partial class Form_CadastroPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_CadastroPeca));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SalvarPeca = new System.Windows.Forms.Button();
            this.btn_CancelarPeca = new System.Windows.Forms.Button();
            this.txtb_PrecoRevenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txtb_DescricaoPeca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtb_LucroPeca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_CustoPeca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cobox_Fornecedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_QntdPeca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_NomePeca = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(12, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(415, 42);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Cadastro de Peças";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(250, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade em Estoque:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_SalvarPeca);
            this.panel1.Controls.Add(this.btn_CancelarPeca);
            this.panel1.Controls.Add(this.txtb_PrecoRevenda);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_Calcular);
            this.panel1.Controls.Add(this.txtb_DescricaoPeca);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtb_LucroPeca);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtb_CustoPeca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cobox_Fornecedor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtb_QntdPeca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtb_NomePeca);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 240);
            this.panel1.TabIndex = 3;
            // 
            // btn_SalvarPeca
            // 
            this.btn_SalvarPeca.BackColor = System.Drawing.Color.Lime;
            this.btn_SalvarPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarPeca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_SalvarPeca.Location = new System.Drawing.Point(120, 202);
            this.btn_SalvarPeca.Name = "btn_SalvarPeca";
            this.btn_SalvarPeca.Size = new System.Drawing.Size(75, 23);
            this.btn_SalvarPeca.TabIndex = 18;
            this.btn_SalvarPeca.Text = "Salvar";
            this.btn_SalvarPeca.UseVisualStyleBackColor = false;
            this.btn_SalvarPeca.Click += new System.EventHandler(this.btn_SalvarPeca_Click);
            // 
            // btn_CancelarPeca
            // 
            this.btn_CancelarPeca.BackColor = System.Drawing.Color.Red;
            this.btn_CancelarPeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarPeca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CancelarPeca.Location = new System.Drawing.Point(18, 202);
            this.btn_CancelarPeca.Name = "btn_CancelarPeca";
            this.btn_CancelarPeca.Size = new System.Drawing.Size(75, 23);
            this.btn_CancelarPeca.TabIndex = 17;
            this.btn_CancelarPeca.Text = "Cancelar";
            this.btn_CancelarPeca.UseVisualStyleBackColor = false;
            this.btn_CancelarPeca.Click += new System.EventHandler(this.btn_CancelarPeca_Click);
            // 
            // txtb_PrecoRevenda
            // 
            this.txtb_PrecoRevenda.Location = new System.Drawing.Point(139, 161);
            this.txtb_PrecoRevenda.Name = "txtb_PrecoRevenda";
            this.txtb_PrecoRevenda.Size = new System.Drawing.Size(100, 20);
            this.txtb_PrecoRevenda.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Preço de revenda:";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(18, 120);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(120, 23);
            this.btn_Calcular.TabIndex = 14;
            this.btn_Calcular.Text = "Calcular Venda";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            // 
            // txtb_DescricaoPeca
            // 
            this.txtb_DescricaoPeca.Location = new System.Drawing.Point(270, 89);
            this.txtb_DescricaoPeca.Multiline = true;
            this.txtb_DescricaoPeca.Name = "txtb_DescricaoPeca";
            this.txtb_DescricaoPeca.Size = new System.Drawing.Size(220, 137);
            this.txtb_DescricaoPeca.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(189, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrição:";
            // 
            // txtb_LucroPeca
            // 
            this.txtb_LucroPeca.Location = new System.Drawing.Point(120, 86);
            this.txtb_LucroPeca.Name = "txtb_LucroPeca";
            this.txtb_LucroPeca.Size = new System.Drawing.Size(30, 20);
            this.txtb_LucroPeca.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lucro desejado:";
            // 
            // txtb_CustoPeca
            // 
            this.txtb_CustoPeca.Location = new System.Drawing.Point(378, 44);
            this.txtb_CustoPeca.Name = "txtb_CustoPeca";
            this.txtb_CustoPeca.Size = new System.Drawing.Size(100, 20);
            this.txtb_CustoPeca.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(250, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Custo de Compra:";
            // 
            // cobox_Fornecedor
            // 
            this.cobox_Fornecedor.FormattingEnabled = true;
            this.cobox_Fornecedor.Location = new System.Drawing.Point(99, 44);
            this.cobox_Fornecedor.Name = "cobox_Fornecedor";
            this.cobox_Fornecedor.Size = new System.Drawing.Size(121, 21);
            this.cobox_Fornecedor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fornecedor:";
            // 
            // txtb_QntdPeca
            // 
            this.txtb_QntdPeca.Location = new System.Drawing.Point(415, 12);
            this.txtb_QntdPeca.Name = "txtb_QntdPeca";
            this.txtb_QntdPeca.Size = new System.Drawing.Size(63, 20);
            this.txtb_QntdPeca.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // txtb_NomePeca
            // 
            this.txtb_NomePeca.Location = new System.Drawing.Point(63, 12);
            this.txtb_NomePeca.Name = "txtb_NomePeca";
            this.txtb_NomePeca.Size = new System.Drawing.Size(181, 20);
            this.txtb_NomePeca.TabIndex = 0;
            // 
            // Form_CadastroPeça
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SGNB_2.Properties.Resources.imagem_fundo_3;
            this.ClientSize = new System.Drawing.Size(528, 306);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_CadastroPeça";
            this.Text = "SGNB - Cadastro de Peças";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtb_NomePeca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_CustoPeca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cobox_Fornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_QntdPeca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txtb_DescricaoPeca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtb_LucroPeca;
        private System.Windows.Forms.Button btn_SalvarPeca;
        private System.Windows.Forms.Button btn_CancelarPeca;
        private System.Windows.Forms.TextBox txtb_PrecoRevenda;
    }
}