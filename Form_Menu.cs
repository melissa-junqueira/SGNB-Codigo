using SGNB;
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

        private void btn_Vendas_Click(object sender, EventArgs e)
        {
            Form_RelatorioVenda form = new Form_RelatorioVenda();
            form.ShowDialog();
        }

        private void btn_Servicos_Click(object sender, EventArgs e)
        {
            Form_VisualizarServicos form = new Form_VisualizarServicos();
            form.ShowDialog();
        }

        private void btn_Agendamento_Click(object sender, EventArgs e)
        {
            Form_VisualizarAgendamento form = new Form_VisualizarAgendamento();
            form.ShowDialog();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoCliente form = new Form_VisualizacaoCliente();
            form.ShowDialog();
        }

        private void btn_Fornecedores_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoFornecedor form = new Form_VisualizacaoFornecedor();
            form.ShowDialog();
        }

        private void btn_Estoque_Click(object sender, EventArgs e)
        {
            Form_VisualizacaoEstoque form = new Form_VisualizacaoEstoque();
            form.ShowDialog();
        }

        private void btn_RelatorioVendas_Click(object sender, EventArgs e)
        {
            Form_RelatorioVenda form = new Form_RelatorioVenda();
            form.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
