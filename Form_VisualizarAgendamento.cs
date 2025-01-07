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
    public partial class Form_VisualizarAgendamento : Form
    {
        public Form_VisualizarAgendamento()
        {
            InitializeComponent();
        }

        private void btn_RegistrarServico_Click(object sender, EventArgs e)
        {
            Form_AgendarConserto form = new Form_AgendarConserto();
            form.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
