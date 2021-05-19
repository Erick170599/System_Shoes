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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        private int idProducto;
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        private ColorOperations colorOperations = ColorOperations.Instance();
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = productoOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = productoOperations.GetAll();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            colorBindingSource.DataSource = colorOperations.GetAll();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNProducto().ShowDialog();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMProducto((int)gvProductos.GetFocusedRowCellValue("idProducto")).ShowDialog();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvProductos.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvProductos.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el Producto? \n\n{0}",
                    gvProductos.GetFocusedRowCellValue("descripcion")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Producto() { idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto") }.idProducto > 0)
                    {
                        idProducto = (int)gvProductos.GetFocusedRowCellValue("idProducto");
                        productoOperations.Delete(idProducto);
                        XtraMessageBox.Show("Producto eliminado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el Producto \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    productoBindingSource.DataSource = productoOperations.GetAll();
                    gvProductos.BestFitColumns();
                }
        }
    }
}