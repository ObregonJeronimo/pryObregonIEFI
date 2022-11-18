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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void btnListarTotalClientes_Click(object sender, EventArgs e)
        {
            clsCliente objMostrarGrilla = new clsCliente();
            objMostrarGrilla.Listar(dgvConsultaClientes);
            txtCantidadClientes.Text = objMostrarGrilla.varCantidadDeClientes.ToString();
            txtPromedioSaldos.Text = objMostrarGrilla.varPromedioSaldosDeClientes.ToString();
            txtTotalSaldos.Text = objMostrarGrilla.varTotalSaldosDeClientes.ToString();
            txtSaldoMayor.Text = objMostrarGrilla.varMontoMayor.ToString();
            txtSaldoMenor.Text = objMostrarGrilla.varMontoMenor.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
