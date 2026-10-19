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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsClientes objCliente = new clsClientes();

            Int32 idCliente = Convert.ToInt32(txtCodigo.Text);

            objCliente.BuscarCliente(idCliente);

            if (objCliente.IdCliente == 0)
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}
