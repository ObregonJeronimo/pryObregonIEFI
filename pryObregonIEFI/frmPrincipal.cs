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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsmFecha.Text = DateTime.Now.ToString();
        }

        private void tsmNuevoCliente_Click(object sender, EventArgs e)
        {
            frmNuevoSocio frmNuevoCliente = new frmNuevoSocio();
            frmNuevoCliente.ShowDialog();
        }


        private void tsmConsultaDeUnCliente_Click(object sender, EventArgs e)
        {
            frmGestionSocio frmBuscarCliente = new frmGestionSocio();
            frmBuscarCliente.ShowDialog();
        }

        private void tsmConsultaGrlAllClientes_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frmConsultaGrlAllClientes = new frmConsultaClientes();
            frmConsultaGrlAllClientes.ShowDialog();
        }

        private void tsmConsultaGrlClientesCiudad_Click(object sender, EventArgs e)
        {
            frmConsultaClientesPorBarrio frmConsultaGrlClientesCiudad = new frmConsultaClientesPorBarrio();
            frmConsultaGrlClientesCiudad.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listadoDeSociosPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientePorActividad frmAct = new frmConsultaClientePorActividad();
            frmAct.ShowDialog();
        }

        private void tsmBuscarCliente_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frmCli = new frmConsultaClientes();
            frmCli.ShowDialog();

        }
    }
}
