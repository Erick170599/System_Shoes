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
    public partial class frmColores : DevExpress.XtraEditors.XtraForm
    {
        private int idColor;
        private ColorOperations colorOperations = ColorOperations.Instance();
        public frmColores()
        {
            InitializeComponent();
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNColor().ShowDialog();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMColor((int)gvColores.GetFocusedRowCellValue("idColor")).ShowDialog();
            colorBindingSource.DataSource = colorOperations.GetAll();
            gvColores.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvColores.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el Color? \n\n{0}",
                    gvColores.GetFocusedRowCellValue("descripcion")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Entities.Color() { idColor = (int)gvColores.GetFocusedRowCellValue("idColor") }.idColor > 0)
                    {
                        idColor = (int)gvColores.GetFocusedRowCellValue("idColor");
                        colorOperations.Delete(idColor);
                        XtraMessageBox.Show("Color eliminado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el Color \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    colorBindingSource.DataSource = colorOperations.GetAll();
                    gvColores.BestFitColumns();
                }
        }
    }
}