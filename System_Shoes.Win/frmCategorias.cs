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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        private int idCategoria;
        private CategoriaOperations categoriaOperations = CategoriaOperations.Instance();
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNCategoria().ShowDialog();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMCategoria((int)gvCategorias.GetFocusedRowCellValue("idCategoria")).ShowDialog();
            categoriaBindingSource.DataSource = categoriaOperations.GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvCategorias.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la Categoría? \n\n{0}",
                    gvCategorias.GetFocusedRowCellValue("descripcion")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Categoria() { idCategoria = (int)gvCategorias.GetFocusedRowCellValue("idCategoria") }.idCategoria > 0)
                    {
                        idCategoria = (int)gvCategorias.GetFocusedRowCellValue("idCategoria");
                        categoriaOperations.Delete(idCategoria);
                        XtraMessageBox.Show("Categoría eliminada correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la Categoría \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    categoriaBindingSource.DataSource = categoriaOperations.GetAll();
                    gvCategorias.BestFitColumns();
                }
        }
    }
}