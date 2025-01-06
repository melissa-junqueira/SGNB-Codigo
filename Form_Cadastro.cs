using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGNB
{
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form_Inicio form_Inicio = new Form_Inicio();
            form_Inicio.Show();
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Form_Inicio form_Inicio = new Form_Inicio();
            form_Inicio.Show();
            this.Close();
        }
    }
}
