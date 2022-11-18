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
    public partial class frmConsultaClientePorActividad : Form
    {
        public frmConsultaClientePorActividad()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmConsultaClientePorActividad_Load(object sender, EventArgs e)
        {
            clsActividad objClaseCliente = new clsActividad();
            objClaseCliente.LlenarListaDesplegable(lstActividad);
            lstActividad.SelectedIndex = -1;

            btnImprimir.Enabled = false;
            btnListar.Enabled = false;
            btnReportar.Enabled = false;
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 varActividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsCliente objClaseActividad = new clsCliente();
            objClaseActividad.ListarActividad(varActividad, dgvConsulta);


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

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex != -1)
            {
                btnListar.Enabled = true;

            }
            btnReportar.Enabled = false;
            btnImprimir.Enabled = false;
        }
    }
}
