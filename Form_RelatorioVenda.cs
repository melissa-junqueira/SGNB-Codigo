using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGNB_2
{
    public partial class Form_RelatorioVenda : Form
    {
        public Form_RelatorioVenda()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RegistrarVenda_Click(object sender, EventArgs e)
        {
            Form_RegistrarVenda form = new Form_RegistrarVenda();
            form.ShowDialog();
        }
    }
}
