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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsmFecha.Text = DateTime.Now.ToString();
        }

        private void tsmNuevoCliente_Click(object sender, EventArgs e)
        {
            frmNuevoCliente frmNuevoCliente = new frmNuevoCliente();
            frmNuevoCliente.ShowDialog();
        }

        private void tsmBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frmBuscarCliente = new frmBuscarCliente();
            frmBuscarCliente.ShowDialog();
        }

        private void tsmConsultaDeUnCliente_Click(object sender, EventArgs e)
        {
            frmConsultaDeUnCliente frmConsultaDeUnCliente = new frmConsultaDeUnCliente();
            frmConsultaDeUnCliente.ShowDialog();
        }

        private void tsmConsultaGrlAllClientes_Click(object sender, EventArgs e)
        {
            frmConsultaGrlAllClientes frmConsultaGrlAllClientes = new frmConsultaGrlAllClientes();
            frmConsultaGrlAllClientes.ShowDialog();
        }

        private void tsmConsultaGrlClientesDeudores_Click(object sender, EventArgs e)
        {
            frmConsultaGrlClientesDeudores frmConsultaGrlClientesDeudores = new frmConsultaGrlClientesDeudores();
            frmConsultaGrlClientesDeudores.ShowDialog();
        }

        private void tsmConsultaGrlClientesCiudad_Click(object sender, EventArgs e)
        {
            frmConsultaGrlClientesCiudad frmConsultaGrlClientesCiudad = new frmConsultaGrlClientesCiudad();
            frmConsultaGrlClientesCiudad.ShowDialog();
        }
    }
}
