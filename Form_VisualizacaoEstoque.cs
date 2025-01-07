using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGNB_2
{
    public partial class Form_VisualizacaoEstoque : Form
    {
        public Form_VisualizacaoEstoque()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RegistrarPeca_Click(object sender, EventArgs e)
        {
            Form_CadastroPeca form = new Form_CadastroPeca();
            form.ShowDialog();
        }

        private void btn_RegistrarBicicleta_Click(object sender, EventArgs e)
        {
            Form_CadastroBike form = new Form_CadastroBike();
            form.ShowDialog();
        }
    }
}
