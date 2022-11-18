using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryObregonIEFI
{
    public partial class frmConsultaClientesPorBarrio : Form
    {
        public frmConsultaClientesPorBarrio()
        {
            InitializeComponent();
        }

        private void frmConsultaClientesPorBarrio_Load(object sender, EventArgs e)
        {
            clsBarrios objClaseBarrio = new clsBarrios();
            objClaseBarrio.LlenarListaDesplegable(lstBarrio);
            lstBarrio.SelectedIndex = -1;
            btnImprimir.Enabled = false;
            btnListar.Enabled = false;
            btnReportar.Enabled = false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 varCodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.ListarBarrio(varCodigoBarrio, dgvConsulta);
            if (dgvConsulta.Rows.Count > 1)
            {
                btnImprimir.Enabled = true;
                btnReportar.Enabled = true;
            }
            else
            {
                btnImprimir.Enabled = false;
                btnReportar.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrio.SelectedIndex != -1)
            {
                btnListar.Enabled = true;

            }
            btnReportar.Enabled = false;
            btnImprimir.Enabled = false;
        }
    }
}
