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
    public partial class frmMCategoria : DevExpress.XtraEditors.XtraForm
    {
        private int idCategoria;
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmMCategoria()
        {
            InitializeComponent();
        }

        public frmMCategoria(int idCategoria)
        {
            InitializeComponent();
            this.idCategoria = idCategoria;
        }

        private void frmMCategoria_Load(object sender, EventArgs e)
        {
            Inicializar();
            Misc.actualiza = true;
        }

        private void Inicializar()
        {
            Categoria categoria = categoriaOperations.GetById(idCategoria);
            txtNombre.EditValue = categoria.descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Categoria categoria = categoriaOperations.GetById(idCategoria);
                categoria.idCategoria = (int)idCategoria;
                categoria.descripcion = (string)txtNombre.EditValue;

                if (categoriaOperations.Update(categoria) > 0)
                {
                    XtraMessageBox.Show("Categoría actualizada correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Misc.actualiza = true;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al actualizar la Categoría", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmMCategoria_FormClosing(object sender, FormClosingEventArgs e)
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