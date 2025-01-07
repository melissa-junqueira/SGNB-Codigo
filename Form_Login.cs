using SGNB_2;
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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Form_Menu form = new Form_Menu();
            form.Show();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Form_Inicio form_Inicio = new Form_Inicio();
            form_Inicio.Show();
            this.Close();
        }
    }
}
