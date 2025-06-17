using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class frmCep : Form
    {
        private NegCep nCep = new NegCep();
        public frmCep()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCep();
        }

        private async void BuscarCep()
        {
            if (string.IsNullOrEmpty(mtbCep.Text))
                return;

            var cep = await nCep.BuscarCep(mtbCep.Text);

            if (cep == null)
                return;


        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCep_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
