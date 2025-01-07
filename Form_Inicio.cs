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
    public partial class Form_Inicio : Form
    {

        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Form_Login form = new Form_Login();
            form.Show();
            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Form_Cadastro form = new Form_Cadastro();
            form.Show();
            this.Hide();
        }
    }
}
