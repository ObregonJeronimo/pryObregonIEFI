using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace pryObregonIEFI
{
    internal class clsCliente
    {

        private OleDbConnection conexionBd = new OleDbConnection();
        private OleDbCommand comandoBd = new OleDbCommand();
        private OleDbDataAdapter AdaptadorDeDatosBd = new OleDbDataAdapter();//adapta los datos de la BD que reconozca por .NET

        string varRutaAccesoBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "BD_Clientes.accdb";
        private string varTabla = "Clientes";


        //Declaracion de campos
        private Int32 varCantidadClientes;
        private Decimal varPromedioSaldos;
        private Decimal varTotalSaldos;
        private string varNombreCliente;
        private string varApellidoCliente;
        private Int32 varDniCliente;
        private Int32 varBarrioCliente;
        private string varDireccionCliente;
        private Int32 varActividadCliente;
        private Decimal varSaldoCliente;

        public Decimal varMontoMayor = 0;
        public Decimal varMontoMenor = 0;



        //Declaracion de propiedades
        public string varNombreDelCliente
        {
            get { return varNombreCliente; }
            set { varNombreCliente = value; }
        }
        public string varApellidoDelCliente
        {
            get { return varApellidoCliente; }
            set { varApellidoCliente = value; }
        }
        public Int32 varDniDelCliente
        {
            get { return varDniCliente; }
            set { varDniCliente = value; }
        }
        public Int32 varBarrioDelCliente
        {
            get { return varBarrioCliente; }
            set { varBarrioCliente = value; }
        }
        public string varDireccionDelCliente
        {
            get { return varDireccionCliente; }
            set { varDireccionCliente = value; }

        }
        public Int32 varActividadDelCliente
        {
            get { return varActividadCliente; }
            set { varActividadCliente = value; }
        }

        public Decimal varSaldoDelCliente
        {
            get { return varSaldoCliente; }
            set { varSaldoCliente = value; }
        }

        public Int32 varCantidadDeClientes
        {
            get { return varCantidadClientes; }
        }
        public Decimal varPromedioSaldosDeClientes
        {
            get { return varPromedioSaldos; }
        }
        public Decimal varTotalSaldosDeClientes
        {
            get { return varTotalSaldos; }
        }

        public void BusquedaCliente(Int32 variableCliente)
        {
            try
            {

                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;

                //Indicamos el tipo de comando
                //Trae una tabla el comando
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;

                OleDbDataReader DR = comandoBd.ExecuteReader();


                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    //Mientras hayan datos para leer en el Datareader
                    while (DR.Read())
                    {
                        //si el dni coincide entonces muestra la informacion
                        if (DR.GetInt32(2) == variableCliente)
                        {
                            varNombreCliente = DR.GetString(0);
                            varApellidoCliente = DR.GetString(1);
                            varDniCliente = DR.GetInt32(2);
                            varBarrioCliente = DR.GetInt32(3);
                            varDireccionCliente = DR.GetString(4);
                            varActividadCliente = DR.GetInt32(5);
                            varSaldoCliente = DR.GetDecimal(6);
                        }
                    }
                }
                conexionBd.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        public void ListarClientes(DataGridView dgvClientes)
        {
            try
            {
                //Recibe la ruta de la BD para conectarse
                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();

                comandoBd.Connection = conexionBd;//comando se conecta a bdd para recibir tareas y accionar sobre bdd


                //tipo de comando
                //Trae una tabla el comando
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;


                //El adaptador recibe los datos de la BD(lectura)
                AdaptadorDeDatosBd = new OleDbDataAdapter(comandoBd);


                //objeto que contiene lo que tiene la tabla, es una tabla virtual
                DataSet LectorDataSet = new DataSet();

                //Adaptamos los datos al data set
                AdaptadorDeDatosBd.Fill(LectorDataSet);
                //DataSource sirve para tomar el contenido de un DataSet
                dgvClientes.DataSource = LectorDataSet.Tables[0];

                conexionBd.Close();
                //cerrar bdd
            }
            catch (Exception mensaje)
            {

                MessageBox.Show(mensaje.Message);
            }

        }


        public void Agregar()
        {
            try
            {
                string sql = "INSERT INTO" + " CLIENTES ([NOMBRE], [APELLIDO], [DNI], [BARRIO],[DIRECCION], [ACTIVIDAD], [SALDO])" + " VALUES ('" + varNombreCliente + "','" + varApellidoCliente + "','" + varDniCliente.ToString() + "','"
                    + varBarrioCliente.ToString() + "','" + varDireccionCliente + "','" + varActividadCliente.ToString() + "','" + varSaldoCliente.ToString() + "')";

                conexionBd = new OleDbConnection(varRutaAccesoBD);
                conexionBd.Open();

                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.Text;
                comandoBd.CommandText = sql;

                //ExcecuteNonQuery ejecuta el comando
                comandoBd.ExecuteNonQuery();
                MessageBox.Show("Cliente Cargado");
            }
            catch (Exception)
            {

                MessageBox.Show("El DNI ya existe, porfavor vuelva a intentarlo.");
            }
            conexionBd.Close();



        }

        public void Modificar(Int32 Dni)
        {
            //instruccion sql                                                                                                             
            string Sql = "UPDATE CLIENTES SET [BARRIO] = " + varBarrioCliente + ", [DIRECCION] = '" + varDireccionCliente + "', [ACTIVIDAD] = " + varActividadCliente + ", [SALDO] = " + varSaldoCliente + "  WHERE [DNI] = " + Dni + "";

            conexionBd.ConnectionString = varRutaAccesoBD;
            conexionBd.Open();
            comandoBd.Connection = conexionBd;


            //Se indica el tipo de comando, el tipo Text es para instrucciones sql
            comandoBd.CommandType = CommandType.Text;

            //Se pasa la instruccion sql al comando
            comandoBd.CommandText = Sql;

            //ejecuta el comando
            comandoBd.ExecuteNonQuery();
            conexionBd.Close();

            MessageBox.Show("Cambios Guardados");
        }

        public void Eliminar(Int32 Dni)
        {
            try
            {
                //Instruccion sql
                string Sql = "DELETE FROM CLIENTES WHERE (" + Dni + " = [DNI])";


                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;


                comandoBd.CommandType = CommandType.Text;
                comandoBd.CommandText = Sql;
                comandoBd.ExecuteNonQuery();

                conexionBd.Close();

                MessageBox.Show("Cliente Eliminado");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show(Convert.ToString(mensaje));
            }




        }


        public void Listar(DataGridView dgvGrilla)
        {
            

            try
            {

                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;

                //Indicamos el tipo de comando
                //el comando trae una tabla "virtual" en la ram
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;

                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                OleDbDataReader DR = comandoBd.ExecuteReader();
                dgvGrilla.Rows.Clear();
                string varDetalleBarrio = "";
                string varDetalleActividad = "";
                varCantidadClientes = 0;
                varTotalSaldos = 0;
                varPromedioSaldos = 0;

                //declarando objetos de clsbarrio y clsactividad
                clsBarrios objClaseBarrio = new clsBarrios();
                clsActividad objClaseActividad = new clsActividad();

                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    
                    DR.Read();
                    varMontoMenor = DR.GetDecimal(6);//agarro el sueldo para empezar con un monto sino 100pre=0

                    //Mientras se pueda leer en el Datareader
                    while (DR.Read())

                    {

                        varDetalleBarrio = objClaseBarrio.Buscar(DR.GetInt32(3));
                        varDetalleActividad = objClaseActividad.Buscar(DR.GetInt32(5));

                        //Añade filas a la grilla tomando las posiciones de los campos de la tabla socios
                        dgvGrilla.Rows.Add(DR.GetInt32(2), DR.GetString(0), DR.GetString(1), varDetalleBarrio, DR.GetString(4), varDetalleActividad, DR.GetDecimal(6));
                        ///////////////////////dni////////////nombre///////////apellido//////////detalle///////////direccion//////////detalle////////////saldo/////////
                        
                        varCantidadClientes++;
                        varTotalSaldos = varTotalSaldos + DR.GetDecimal(6);

                        if (DR.GetDecimal(6) > varMontoMayor)
                        {
                            varMontoMayor = DR.GetDecimal(6);
                        }

                        if (varMontoMenor > DR.GetDecimal(6))
                        {
                            varMontoMenor = DR.GetDecimal(6);
                        }


                    }
                    varPromedioSaldos = varTotalSaldos / varCantidadClientes;
                }
                conexionBd.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

            }


        }


        

        

        public void ListarActividad(Int32 Actividad, DataGridView dgvActividad)
        {

            try
            {

                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;
                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;

                //Creacion del objeto datareader que toma lo del comando una vez ejecutado el comando
                //Es una tabla virtual que esta en la ram
                OleDbDataReader DR = comandoBd.ExecuteReader();
                dgvActividad.Rows.Clear();

                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    //Mientras hayan datos para leer en el Datareader
                    DR.Read();
                    varMontoMenor = DR.GetDecimal(6);
                    while (DR.Read())
                    {

                        if (DR.GetInt32(5) == Actividad)
                        {
                            //Añade filas a la grilla tomando las posiciones de los campos de la tabla clientes
                            dgvActividad.Rows.Add(DR.GetInt32(2), DR.GetString(0), DR.GetString(1));
                        }
                    }

                }
                conexionBd.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

            }


        }
        
        
        public void ListarBarrio(Int32 Barrio, DataGridView dgvBarrio)
        {

            try
            {

                conexionBd.ConnectionString = varRutaAccesoBD;
                conexionBd.Open();
                comandoBd.Connection = conexionBd;

                comandoBd.CommandType = CommandType.TableDirect;
                comandoBd.CommandText = varTabla;

                OleDbDataReader DR = comandoBd.ExecuteReader();

                //vaciar filas dgvbarrio
                dgvBarrio.Rows.Clear();

                //Si hay filas en el DataReader entra el if
                if (DR.HasRows)
                {
                    //Mientras hayan datos para leer en el Datareader                 
                    while (DR.Read())
                    {

                        if (DR.GetInt32(3) == Barrio)
                        {
                            //Añade filas a la grilla tomando las posiciones de los campos de la tabla clientes
                            dgvBarrio.Rows.Add(DR.GetInt32(2), DR.GetString(0), DR.GetString(1));
                        }///////////////////////////dni/////////////nombre//////////apellido////////
                    }

                }
                conexionBd.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);

            }


        }
        

        
     
        
    }


}