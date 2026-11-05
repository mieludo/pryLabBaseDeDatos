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
    internal class clsCiudad
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Cliente.mdb";
        private string Tabla = "Ciudad";

        public void Listar(DataGridView dgvCiudades)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet datos = new DataSet();
                adaptador.Fill(datos, Tabla);

                dgvCiudades.DataSource = datos.Tables[Tabla];
                dgvCiudades.ClearSelection();

                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudieron cargar las ciudades. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Listar(ComboBox cboCiudades)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet datos = new DataSet();
                adaptador.Fill(datos, Tabla);

                cboCiudades.DataSource = datos.Tables[Tabla];
                cboCiudades.DisplayMember = "Nombre";
                cboCiudades.ValueMember = "idCiudad";
                cboCiudades.SelectedIndex = -1;

                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo completar la lista de ciudades. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
