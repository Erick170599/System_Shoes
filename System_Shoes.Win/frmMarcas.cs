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
    public partial class frmMarcas : DevExpress.XtraEditors.XtraForm
    {
        private int idMarca;
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNMarca().ShowDialog();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMMarca((int)gvMarcas.GetFocusedRowCellValue("idMarca")).ShowDialog();
            marcaBindingSource.DataSource = marcaOperations.GetAll();
            gvMarcas.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvMarcas.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar la Marca? \n\n{0}",
                    gvMarcas.GetFocusedRowCellValue("descripcion")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Marca() { idMarca = (int)gvMarcas.GetFocusedRowCellValue("idMarca") }.idMarca > 0)
                    {
                        idMarca = (int)gvMarcas.GetFocusedRowCellValue("idMarca");
                        marcaOperations.Delete(idMarca);
                        XtraMessageBox.Show("Marca eliminada correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar la Marca \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    marcaBindingSource.DataSource = marcaOperations.GetAll();
                    gvMarcas.BestFitColumns();
                }
        }
    }
}