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
    public partial class Form_VisualizarServicos : Form
    {
        public Form_VisualizarServicos()
        {
            InitializeComponent();
        }

        private void btn_RegistrarServico_Click(object sender, EventArgs e)
        {
            Form_CadastroServico form = new Form_CadastroServico();
            form.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
