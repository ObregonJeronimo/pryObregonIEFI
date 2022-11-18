using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace pryObregonIEFI
{
    internal class clsActividad
    {

        private OleDbConnection conexionBd = new OleDbConnection();
        private OleDbCommand comandoBd = new OleDbCommand();
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();

        private string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        private string varTabla = "Cod_Actividad";

        public void LlenarListaDesplegable(ComboBox lstClientes)
        {
            try
            {

                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;

                AdaptadorDeDatosBd = new OleDbDataAdapter(comandoBd);

                //objeto que contiene lo que tiene la tabla, es una tabla virtual
                DataSet LectorDataSet = new DataSet();
                //Adaptamos los datos al data set
                AdaptadorDeDatosBd.Fill(LectorDataSet, varTabla);


                //Enviamos los datos del DataSet a la grilla, es 0 porque es la unica tabla que trajo el dataset
                //DataSource sirve para tomar el contenido de un DataSet
                lstClientes.DataSource = LectorDataSet.Tables[varTabla];
                lstClientes.DisplayMember = "Detalle";
                lstClientes.ValueMember = "Codigo_Actividad";

                conexionBd.Close();
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }

        }



        public string Buscar(Int32 CodigoActividad)
        {
            try
            {
                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;
                OleDbDataReader Lector = comandoBd.ExecuteReader();
                string varDetalleActividiad = "";

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoActividad)
                        {
                            varDetalleActividiad = Lector.GetString(1);
                        }
                    }
                }

                conexionBd.Close();
                return varDetalleActividiad;//return finaliza
            }
            catch (Exception message)
            {
                return message.ToString();
            }
        }
    }
}
