using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Shoes.BLL;
using System_Shoes.Entities;

namespace System_Shoes.Win
{
    public partial class frmNCliente : DevExpress.XtraEditors.XtraForm
    {
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private Cliente cliente;
        private decimal descuento;
        public frmNCliente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (cliente == null)
                {
                    descuento = (decimal)txtDescuento.EditValue;
                    if (clienteOperations.Add(new Cliente
                    {
                        nombre = txtNombre.Text,
                        apellidoP = txtAPaterno.Text,
                        apellidoM = txtAMaterno.Text,
                        direccion = txtDireccion.Text,
                        telefono = txtTelefono.Text,
                        descuento = descuento
                    }) > 0)
                    {
                        XtraMessageBox.Show("Cliente registrado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error al guardar el Cliente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Misc.actualiza = false;
                    }
                }
                this.Close();
            }
        }

        private bool Validar()
        {
            var ban = false;

            if (txtNombre.EditValue == null || txtNombre.Text.Equals("") ||
               txtAPaterno.EditValue == null || txtAPaterno.Text.Equals("") ||
               txtAMaterno.EditValue == null || txtAMaterno.Text.Equals("") ||
               txtDireccion.EditValue == null || txtDireccion.Text.Equals("") ||
               txtTelefono.EditValue == null || txtTelefono.Text.Equals("") ||
               txtDescuento.EditValue == null || txtDescuento.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }
            if (txtAPaterno.EditValue == null || txtAMaterno.Text.Equals(""))
            {
                txtAPaterno.ErrorText = "Ingresa el apellido paterno";
                ban = true;
            }
            if (txtAMaterno.EditValue == null || txtAMaterno.Text.Equals(""))
            {
                txtAMaterno.ErrorText = "Ingresa el apellido materno";
                ban = true;
            }
            if (txtDireccion.EditValue == null || txtDireccion.Text.Equals(""))
            {
                txtDireccion.ErrorText = "Ingresa la dirección";
                ban = true;
            }
            if (txtTelefono.EditValue == null || txtTelefono.Text.Equals(""))
            {
                txtTelefono.ErrorText = "Ingresa el telefono";
                ban = true;
            }
            if (txtDescuento.EditValue == null || txtDescuento.Text.Equals(""))
            {
                txtDescuento.ErrorText = "Ingresa el descuento";
                ban = true;
            }

            if (ban == true)
                return false;
            else
                return true;
        }

        private void frmNCliente_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void frmNCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Desea cerrar la pantalla?", "System Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }
    }
}