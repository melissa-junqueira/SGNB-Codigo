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
    public partial class Form_VisualizacaoFornecedor : Form
    {
        public Form_VisualizacaoFornecedor()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RegistrarFornecedor_Click(object sender, EventArgs e)
        {
            Form_CadastroFornecedor form = new Form_CadastroFornecedor();
            form.ShowDialog();
        }
    }
}
