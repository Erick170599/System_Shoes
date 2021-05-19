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
    public partial class frmMCliente : DevExpress.XtraEditors.XtraForm
    {
        private int idCliente;
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        public frmMCliente()
        {
            InitializeComponent();
        }

        public frmMCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        private void frmMCliente_Load(object sender, EventArgs e)
        {
            Inicializar();
            Misc.actualiza = true;
        }

        private void Inicializar()
        {
            Cliente cliente = clienteOperations.GetById(idCliente);
            txtNombre.EditValue = cliente.nombre;
            txtAPaterno.EditValue = cliente.apellidoP;
            txtAMaterno.EditValue = cliente.apellidoM;
            txtDireccion.EditValue = cliente.direccion;
            txtTelefono.EditValue = cliente.telefono;
            txtDescuento.EditValue = cliente.descuento;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Cliente cliente = clienteOperations.GetById(idCliente);
                cliente.idCliente = (int)idCliente;
                cliente.nombre = (string)txtNombre.EditValue;
                cliente.apellidoP = (string)txtAPaterno.EditValue;
                cliente.apellidoM = (string)txtAMaterno.EditValue;
                cliente.direccion = (string)txtDireccion.EditValue;
                cliente.telefono = (string)txtTelefono.EditValue;
                cliente.descuento = (decimal)txtDescuento.EditValue;

                if (clienteOperations.Update(cliente) > 0)
                {
                    XtraMessageBox.Show("Cliente actualizado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Misc.actualiza = true;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al actualizar el Cliente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Misc.actualiza = false;
                }
                this.Close();

            }
        }

        private bool Validar()
        {
            var ban = false;

            if (txtNombre.EditValue == null || txtNombre.Text.Equals("") ||
               txtAPaterno.EditValue == null || txtAPaterno.Text.Equals("") ||
               txtAMaterno.EditValue == null || txtAPaterno.Text.Equals("") ||
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
            if (txtAPaterno.EditValue == null || txtAPaterno.Text.Equals(""))
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

        private void frmMCliente_FormClosing(object sender, FormClosingEventArgs e)
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