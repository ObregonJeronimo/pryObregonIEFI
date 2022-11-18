using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;

namespace pryObregonIEFI
{
    internal class clsBarrios
    {

        private OleDbConnection conexionBd = new OleDbConnection();
        private OleDbCommand comandoBd = new OleDbCommand();
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();

        private string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        private string varTabla = "Cod_Barrio";

        //Procedimiento para llenar una lst
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

                DataSet LectorDataSet = new DataSet();

                //Adaptamos los datos al data set
                AdaptadorDeDatosBd.Fill(LectorDataSet, varTabla);

                //DataSource sirve para tomar el contenido de un DataSet
                lstClientes.DataSource = LectorDataSet.Tables[varTabla];
                lstClientes.DisplayMember = "Detalle";
                lstClientes.ValueMember = "Codigo_Barrio";

                conexionBd.Close();
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }

        }

        public string Buscar(Int32 CodigoBarrio)
        {
            try
            {
                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;
                OleDbDataReader Lector = comandoBd.ExecuteReader();
                string Barrio = "";
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == CodigoBarrio)
                        {
                            Barrio = Lector.GetString(1);
                        }
                    }
                }
                conexionBd.Close();
                return Barrio;
            }
            catch (Exception message)
            {
                return message.ToString();
            }
        }
    }
}
