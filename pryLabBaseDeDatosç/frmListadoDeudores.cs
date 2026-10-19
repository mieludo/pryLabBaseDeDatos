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
    public partial class frmListadoDeudores : Form
    {
        public frmListadoDeudores()
        {
            InitializeComponent();
        }

        clsClientes objClientes = new clsClientes();

        private void frmListadoDeudores_Load(object sender, EventArgs e)
        {
            objClientes.Deudores(dgvListado);
            lblCantidadDos.Text = objClientes.CantidadDeudores.ToString();
            lblTotalDos.Text = objClientes.DeudaTotal.ToString();
            lblPromedioDos.Text = objClientes.PromedioDeuda.ToString();
        }
    }
}
