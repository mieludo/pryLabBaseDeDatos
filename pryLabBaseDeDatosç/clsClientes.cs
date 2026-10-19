using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryLabBaseDeDatosç
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Cliente.mdb";
        private string Tabla = "Lista";

        private Decimal deudaTotal;
        private Int32 cantidad;

        private Int32 idCliente;
        private String nombre;
        private Decimal deuda;
        private Decimal limite;
        private Int32 idCiudad;

        public Decimal DeudaTotal
        {
            get { return deudaTotal; }
        }

        public Int32 CantidadDeudores
        {
            get { return cantidad; }
        }

        public Decimal PromedioDeuda
        {
            get { return deudaTotal / cantidad; }
        }

        public Int32 IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Decimal Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }

        public Decimal Limite
        {
            get { return limite; }
            set { limite = value; }
        }

        public Int32 IdCiudad
        {
            get { return idCiudad; }
            set { idCiudad = value; }
        }

        public void Listar(DataGridView dgvListado)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet dataSet = new DataSet();

                adaptador.Fill(dataSet, Tabla);

                dgvListado.DataSource = dataSet.Tables[0];

                conexion.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al listar datos: " + excep.Message);
            }
        }

        public void Deudores(DataGridView dgvListado)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dataReader = comando.ExecuteReader();
                dgvListado.Rows.Clear();

                cantidad = 0;
                deudaTotal = 0;

                while (dataReader.Read())
                {
                    if (dataReader.GetDecimal(2) > 0)
                    {
                        dgvListado.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetDecimal(2));
                        cantidad++;
                        deudaTotal += dataReader.GetDecimal(2);
                    }
                }

                conexion.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al listar datos: " + excep.Message);
            }
        }

        public void BuscarCliente(Int32 idClienteRecibido)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader dataReader = comando.ExecuteReader();

                idCliente = 0;

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if (dataReader.GetInt32(0) == idClienteRecibido)
                        {
                            idCliente = dataReader.GetInt32(0);
                            nombre = dataReader.GetString(1);
                            deuda = dataReader.GetDecimal(2);
                            limite = dataReader.GetDecimal(3);
                            idCiudad = dataReader.GetInt32(4);
                        }
                    }
                }

                conexion.Close();

            }
            catch (Exception excep)
            {
                MessageBox.Show("Error al buscar el cliente: " + excep.Message);
            }
        }
    }

}

