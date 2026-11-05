using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;

namespace pryLabBaseDeDatosç
{
    internal class clsClientes
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\Cliente.mdb";
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
            get
            {
                if (cantidad == 0)
                {
                    return 0;
                }

                return deudaTotal / cantidad;
            }
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
                DataSet datos = new DataSet();
                adaptador.Fill(datos, Tabla);

                dgvListado.DataSource = datos.Tables[Tabla];
                dgvListado.ClearSelection();

                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo mostrar la lista de clientes. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deudores(DataGridView dgvListado)
        {
            cantidad = 0;
            deudaTotal = 0;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader lector = comando.ExecuteReader();
                dgvListado.Rows.Clear();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if (lector.GetDecimal(2) > 0)
                        {
                            dgvListado.Rows.Add(
                                lector.GetInt32(0),
                                lector.GetString(1),
                                lector.GetDecimal(2));

                            cantidad++;
                            deudaTotal += lector.GetDecimal(2);
                        }
                    }
                }

                lector.Close();
                conexion.Close();
                dgvListado.ClearSelection();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("Hubo un problema al cargar los clientes con deuda. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarCliente(Int32 codigoBuscado)
        {
            idCliente = 0;
            nombre = "";
            deuda = 0;
            limite = 0;
            idCiudad = 0;

            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader lector = comando.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if (lector.GetInt32(0) == codigoBuscado)
                        {
                            idCliente = lector.GetInt32(0);
                            nombre = lector.GetString(1);
                            deuda = lector.GetDecimal(2);
                            limite = lector.GetDecimal(3);
                            idCiudad = lector.GetInt32(4);
                            break;
                        }
                    }
                }

                lector.Close();
                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo realizar la búsqueda. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Agregar()
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

                DataTable tablaClientes = datos.Tables[Tabla];
                DataRow nuevaFila = tablaClientes.NewRow();

                nuevaFila["Nombre"] = nombre;
                nuevaFila["Deuda"] = 0;
                nuevaFila["Límite"] = limite;
                nuevaFila["idCiudad"] = idCiudad;

                tablaClientes.Rows.Add(nuevaFila);

                OleDbCommandBuilder conciliarCambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(datos, Tabla);

                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo guardar el nuevo cliente. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReporteClientes()
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader lector = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter("ReporteClientes.csv", false, Encoding.UTF8);

                archivo.WriteLine("Listado general de clientes");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");

                Int32 totalClientes = 0;
                Decimal sumaDeudas = 0;

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        archivo.WriteLine(
                            lector.GetInt32(0) + ";" +
                            lector.GetString(1) + ";" +
                            lector.GetDecimal(2));

                        totalClientes++;
                        sumaDeudas += lector.GetDecimal(2);
                    }
                }

                archivo.WriteLine();
                archivo.WriteLine("Cantidad de clientes;;" + totalClientes);
                archivo.WriteLine("Deuda total;;" + sumaDeudas);

                archivo.Close();
                lector.Close();
                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo generar el reporte. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReporteClientesCuadroDialogo(String nombreArchivo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                OleDbDataReader lector = comando.ExecuteReader();
                StreamWriter archivo = new StreamWriter(nombreArchivo, false, Encoding.UTF8);

                archivo.WriteLine("Listado general de clientes");
                archivo.WriteLine();
                archivo.WriteLine("Código;Nombre;Deuda");

                Int32 totalClientes = 0;
                Decimal sumaDeudas = 0;

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        archivo.WriteLine(
                            lector.GetInt32(0) + ";" +
                            lector.GetString(1) + ";" +
                            lector.GetDecimal(2));

                        totalClientes++;
                        sumaDeudas += lector.GetDecimal(2);
                    }
                }

                archivo.WriteLine();
                archivo.WriteLine("Cantidad de clientes;;" + totalClientes);
                archivo.WriteLine("Deuda total;;" + sumaDeudas);

                archivo.Close();
                lector.Close();
                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo guardar el reporte elegido. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ListarDataSet(DataGridView grilla)
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

                grilla.Rows.Clear();

                if (datos.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Tables[Tabla].Rows)
                    {
                        grilla.Rows.Add(
                            fila["Nombre"],
                            fila["idCiudad"],
                            fila["Deuda"]);
                    }
                }

                grilla.ClearSelection();
                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo recorrer el listado. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font letraTexto = new Font("Sans Serif", 12);
                Font letraTitulo = new Font("Sans Serif", 20, FontStyle.Bold);
                Font letraSubtitulo = new Font("Sans Serif", 16, FontStyle.Bold);
                Int32 posicionY = 200;

                reporte.Graphics.DrawString("Listado de clientes", letraTitulo, Brushes.Black, 100, 100);
                reporte.Graphics.DrawString("Código", letraSubtitulo, Brushes.Black, 50, 150);
                reporte.Graphics.DrawString("Nombre", letraSubtitulo, Brushes.Black, 150, 150);
                reporte.Graphics.DrawString("Deuda", letraSubtitulo, Brushes.Black, 320, 150);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet datos = new DataSet();
                adaptador.Fill(datos, Tabla);

                if (datos.Tables[Tabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in datos.Tables[Tabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["IdCLiente"].ToString(), letraTexto,
                            Brushes.Black, 50, posicionY);
                        reporte.Graphics.DrawString(fila["Nombre"].ToString(), letraTexto,
                            Brushes.Black, 150, posicionY);
                        reporte.Graphics.DrawString(fila["Deuda"].ToString(), letraTexto,
                            Brushes.Black, 320, posicionY);

                        posicionY += 20;
                    }
                }

                conexion.Close();
            }
            catch (Exception error)
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                MessageBox.Show("No se pudo preparar la impresión. " + error.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
