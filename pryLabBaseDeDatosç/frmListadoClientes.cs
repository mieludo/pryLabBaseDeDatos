using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLabBaseDeDatosç
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        clsClientes objClientes = new clsClientes();

        private void frmListadoClientes_Load(
            object sender,
            EventArgs e)
        {

        }

        private void btnListar_Click(
            object sender,
            EventArgs e)
        {
            objClientes.Listar(dgvListado);
        }

        private void btnListarDataSet_Click(
            object sender,
            EventArgs e)
        {
            objClientes.ListarDataSet(dgvDataSet);
        }

        private void btnReporte_Click(
            object sender,
            EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();

            objArchivo.Title =
                "Elegí la carpeta y el nombre del archivo";

            objArchivo.RestoreDirectory = true;

            objArchivo.Filter =
                "Archivo CSV (*.csv)|*.csv|" +
                "Archivo de texto (*.txt)|*.txt";

            if (objArchivo.ShowDialog() == DialogResult.OK)
            {
                objClientes.ReporteClientesCuadroDialogo(
                    objArchivo.FileName);

                MessageBox.Show(
                    "El reporte se guardó correctamente.",
                    "Reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnImprimir_Click(
            object sender,
            EventArgs e)
        {
            if (prtVentana.ShowDialog() == DialogResult.OK)
            {
                prtDocumento.PrinterSettings =
                    prtVentana.PrinterSettings;

                prtDocumento.Print();
            }
        }

        private void prtDocumento_PrintPage(
            object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            objClientes.Imprimir(e);
        }
    }
}