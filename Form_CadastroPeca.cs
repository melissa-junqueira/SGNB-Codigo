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
    public partial class Form_CadastroPeca : Form
    {
        public Form_CadastroPeca()
        {
            InitializeComponent();
        }

        private void btn_CancelarPeca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SalvarPeca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
