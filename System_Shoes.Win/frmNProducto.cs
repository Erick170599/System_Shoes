using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
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
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        private Producto producto;
        public frmNProducto()
        {
            InitializeComponent();
        }

        private void frmNProducto_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            Misc.actualiza = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(producto == null)
                {
                    if(productoOperations.Add(new Producto
                    {
                        codigo = txtCodigo.Text,
                        descripcion = txtNombre.Text,
                        costo = (decimal)txtCosto.EditValue,
                        precio = (decimal)txtPrecio.EditValue,
                        idCategoria = (int)lupCategoria.EditValue,
                        idColor = (int)lupColor.EditValue,
                        idMarca = (int)lupMarca.EditValue,
                        stock = (int)txtStock.EditValue
                    }) > 0)
                    {
                        XtraMessageBox.Show("Producto registrado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error al guardar el Producto", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Misc.actualiza = false;
                    }
                }
                this.Close();
            }
        }

        private bool Validar()
        {
            var ban = false;

            if(txtCodigo.EditValue == null || txtCodigo.Text.Equals("") ||
               txtNombre.EditValue == null || txtNombre.Text.Equals("") ||
               txtCosto.EditValue == null || txtCosto.Text.Equals("") ||
               txtPrecio.EditValue == null || txtPrecio.Text.Equals("") ||
               lupCategoria.EditValue == null || lupCategoria.Text.Equals("") ||
               lupColor.EditValue == null || lupColor.Text.Equals("") ||
               lupMarca.EditValue == null || lupMarca.Text.Equals("") ||
               txtStock.EditValue == null || txtStock.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtCodigo.EditValue == null || txtCodigo.Text.Equals(""))
            {
                txtCodigo.ErrorText = "Ingresa el código";
                ban = true;
            }
            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }
            if (txtCosto.EditValue == null || txtCosto.Text.Equals(""))
            {
                txtCosto.ErrorText = "Ingresa el costo";
                ban = true;
            }
            if (txtPrecio.EditValue == null || txtPrecio.Text.Equals(""))
            {
                txtPrecio.ErrorText = "Ingresa el precio";
                ban = true;
            }
            if (lupCategoria.EditValue == null || lupCategoria.Text.Equals(""))
            {
                lupCategoria.ErrorText = "Selecciona la categoría";
                ban = true;
            }
            if (lupColor.EditValue == null || lupColor.Text.Equals(""))
            {
                lupColor.ErrorText = "Selecciona el color";
                ban = true;
            }
            if (lupMarca.EditValue == null || lupMarca.Text.Equals(""))
            {
                lupMarca.ErrorText = "Selecciona la marca";
                ban = true;
            }
            if (txtStock.EditValue == null || txtStock.Text.Equals(""))
            {
                txtStock.ErrorText = "Ingresa el stock";
                ban = true;
            }


            if (ban == true)
                return false;
            else
                return true;
        }

        private void lupCategoria_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit).Width;
        }

        private void lupColor_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit).Width;
        }

        private void lupMarca_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit).Width;
        }

        private void frmNProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Desea cerrar la pantalla?", "System Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }
    }
}