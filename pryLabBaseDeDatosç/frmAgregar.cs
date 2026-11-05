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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        clsCiudad objCiudad = new clsCiudad();
        clsClientes objClientes = new clsClientes();

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            objCiudad.Listar(cboCiudad);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show(
                    "Ingresá el nombre del cliente.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtNombre.Focus();
            }
            else
            {
                if (txtLimite.Text == "")
                {
                    MessageBox.Show(
                        "Ingresá el límite de crédito.",
                        "Datos incompletos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtLimite.Focus();
                }
                else
                {
                    if (cboCiudad.SelectedIndex == -1)
                    {
                        MessageBox.Show(
                            "Seleccioná una ciudad.",
                            "Datos incompletos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        cboCiudad.Focus();
                    }
                    else
                    {
                        try
                        {
                            objClientes.Nombre = txtNombre.Text;
                            objClientes.Limite =
                                Convert.ToDecimal(txtLimite.Text);
                            objClientes.IdCiudad =
                                Convert.ToInt32(cboCiudad.SelectedValue);

                            objClientes.Agregar();

                            txtNombre.Clear();
                            txtLimite.Clear();
                            cboCiudad.SelectedIndex = -1;
                            txtNombre.Focus();
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(
                                "Revisá el límite ingresado. " + error.Message,
                                "Dato incorrecto",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );

                            txtLimite.Focus();
                        }
                    }
                }
            }
        }
    }
}