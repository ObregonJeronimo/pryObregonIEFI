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
    public partial class frmNuevoSocio : Form
    {
        public frmNuevoSocio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsCliente objClsCliente = new clsCliente();
            objClsCliente.varNombreDelCliente = txtNombreCliente.Text;
            objClsCliente.varApellidoDelCliente = txtApellidoCliente.Text;
            objClsCliente.varDniDelCliente = Convert.ToInt32(mskDniCliente.Text);
            objClsCliente.varBarrioDelCliente = Convert.ToInt32(lstBarrioCliente.SelectedValue);
            objClsCliente.varDireccionDelCliente = txtDireccionCliente.Text;
            objClsCliente.varActividadDelCliente = Convert.ToInt32(lstActividadCliente.SelectedValue);
            objClsCliente.varSaldoDelCliente = Convert.ToDecimal(txtSaldoCliente.Text);
            objClsCliente.Agregar();


            //vaciar
            txtNombreCliente.Text = "";
            txtApellidoCliente.Text = "";
            mskDniCliente.Text = "";
            lstBarrioCliente.SelectedIndex = -1;
            txtDireccionCliente.Text = "";
            lstActividadCliente.SelectedIndex = -1;
            txtSaldoCliente.Text = "";

            txtNombreCliente.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
