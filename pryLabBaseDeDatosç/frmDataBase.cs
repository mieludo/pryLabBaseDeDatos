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
    public partial class frmDataBase : Form
    {
        public frmDataBase()
        {
            InitializeComponent();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmListadoClientes();
            formulario.Show();
        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new frmBuscar();
            formulario.Show();
        }
    }
}
