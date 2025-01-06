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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Button_Peça_Click(object sender, EventArgs e)
        {
            Form_CadastroPeça form = new Form_CadastroPeça();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_CadastroCliente form = new Form_CadastroCliente();
            form.ShowDialog();
        }

        private void Button_Fornecedor_Click(object sender, EventArgs e)
        {
            Form_CadastroFornecedor form = new Form_CadastroFornecedor();
            form.ShowDialog();
        }

        private void Button_RegistroVenda_Click(object sender, EventArgs e)
        {
            Form_RegistrarVenda form = new Form_RegistrarVenda();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_CadastroServico form = new Form_CadastroServico();
            form.ShowDialog();
        }

        private void Button_RelatorioVenda_Click(object sender, EventArgs e)
        {
            Form_RelatorioVenda form = new Form_RelatorioVenda();
            form.ShowDialog();
        }

        private void Button_Estoque_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoEstoque form = new Form_VisualizacaoEstoque();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoCliente form = new Form_VisualizacaoCliente();
            form.ShowDialog();
        }

        private void Button_Conserto_Click(object sender, EventArgs e)
        {
            Form_AgendarConserto form = new Form_AgendarConserto();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoFornecedor form = new Form_VisualizacaoFornecedor();
            form.ShowDialog();
        }
    }
}
