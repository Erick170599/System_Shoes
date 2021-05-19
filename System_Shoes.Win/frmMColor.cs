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

namespace System_Shoes.Win
{
    public partial class frmMColor : DevExpress.XtraEditors.XtraForm
    {
        private int idColor;
        private ColorOperations colorOperations = ColorOperations.Instance();
        public frmMColor()
        {
            InitializeComponent();
        }

        public frmMColor(int idColor)
        {
            InitializeComponent();
            this.idColor = idColor;
        }

        private void frmMColor_Load(object sender, EventArgs e)
        {
            Inicializar();
            Misc.actualiza = true;
        }

        private void Inicializar()
        {
            Entities.Color color = colorOperations.GetById(idColor);
            txtNombre.EditValue = color.descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Entities.Color color = colorOperations.GetById(idColor);
                color.idColor = (int)idColor;
                color.descripcion = (string)txtNombre.EditValue;

                if (colorOperations.Update(color) > 0)
                {
                    XtraMessageBox.Show("Color actualizado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Misc.actualiza = true;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al actualizar el Color", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Misc.actualiza = false;
                }
                this.Close();
            }
        }

        private bool Validar()
        {
            var ban = false;

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }

            if (ban == true)
                return false;
            else
                return true;
        }

        private void frmMColor_FormClosing(object sender, FormClosingEventArgs e)
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