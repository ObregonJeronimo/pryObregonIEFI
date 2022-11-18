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
    public partial class frmGestionSocio : Form
    {
        public frmGestionSocio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGestionSocio_Load(object sender, EventArgs e)
        {
            clsBarrios objClaseBarriosLst = new clsBarrios();
            objClaseBarriosLst.LlenarListaDesplegable(lstBarrio);
            lstBarrio.SelectedIndex = -1;
            clsActividad objClaseActividad = new clsActividad();
            objClaseActividad.LlenarListaDesplegable(lstActividad);
            lstActividad.SelectedIndex = -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            Int32 varDNI = Convert.ToInt32(txtDni.Text);

            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.BusquedaCliente(varDNI);

            if (objClaseCliente.varDniDelCliente != varDNI)
            {
                MessageBox.Show("No existe ese cliente.");
                
                txtDni.Text = "";
            }
            else
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;


                txtNombre.Text = objClaseCliente.varNombreDelCliente;
                txtApellido.Text = objClaseCliente.varApellidoDelCliente;
                txtDni.Text = Convert.ToString(objClaseCliente.varDniDelCliente);



                clsBarrios objClaseBarrio = new clsBarrios();
                Int32 varCodigoBarrio = objClaseCliente.varBarrioDelCliente;
                lstBarrio.Text = objClaseBarrio.Buscar(varCodigoBarrio);
                txtDireccion.Text = objClaseCliente.varDireccionDelCliente;


                
                clsActividad objClaseActividad = new clsActividad();
                Int32 varCodigoActividad = objClaseCliente.varActividadDelCliente;
                lstActividad.Text = objClaseActividad.Buscar(varCodigoActividad);
                mskSaldo.Text = Convert.ToString(objClaseCliente.varSaldoDelCliente);


            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int SocioID = Convert.ToInt32(txtDni.Text);
                clsCliente ModificarCliente = new clsCliente();
                ModificarCliente.varNombreDelCliente = txtNombre.Text;
                ModificarCliente.varApellidoDelCliente = txtApellido.Text;
                ModificarCliente.varDireccionDelCliente = txtDireccion.Text;
                ModificarCliente.varBarrioDelCliente = Convert.ToInt32(lstBarrio.SelectedValue);
                ModificarCliente.varActividadDelCliente = Convert.ToInt32(lstActividad.SelectedValue);
                ModificarCliente.varSaldoDelCliente = Convert.ToInt32(mskSaldo.Text);
                ModificarCliente.Modificar(SocioID);
                Limpiar();
            }
            catch (Exception message)
            {

                
            }
            
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 varDNI = Convert.ToInt32(txtDni.Text);
            clsCliente objClaseCliente = new clsCliente();
            objClaseCliente.Eliminar(varDNI);

            

            Limpiar();
        }

        public void Limpiar()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;
            mskSaldo.Text = "";
        }

    }

}
