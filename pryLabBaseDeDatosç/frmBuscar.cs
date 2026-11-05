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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {

        }

        clsClientes objCliente = new clsClientes();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objCliente.BuscarCliente(Convert.ToInt32(txtCodigo.Text));

            if (objCliente.IdCliente == 0)
            {
                MessageBox.Show("No se encontró un cliente con ese código.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblNombreDos.Text = "";
                lblDeudaDos.Text = "";
                lblLimiteDos.Text = "";
            }
            else
            {
                lblNombreDos.Text = objCliente.Nombre;
                lblDeudaDos.Text = objCliente.Deuda.ToString();
                lblLimiteDos.Text = objCliente.Limite.ToString();
            }

            txtCodigo.Clear();
            txtCodigo.Focus();
        }
    }
}
