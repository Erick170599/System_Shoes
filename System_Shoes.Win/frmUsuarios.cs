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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        private int idUsuario;
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNUsuario().ShowDialog();
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMUsuario((int)gvUsuarios.GetFocusedRowCellValue("idUsuario")).ShowDialog();
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            gvUsuarios.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvUsuarios.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el Usuario? \n\n{0}",
                    gvUsuarios.GetFocusedRowCellValue("nombre")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Usuario() { idUsuario = (int)gvUsuarios.GetFocusedRowCellValue("idUsuario") }.idUsuario > 0)
                    {
                        idUsuario = (int)gvUsuarios.GetFocusedRowCellValue("idUsuario");
                        usuarioOperations.Delete(idUsuario);
                        XtraMessageBox.Show("Usuario eliminado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el Usuario \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    usuarioBindingSource.DataSource = usuarioOperations.GetAll();
                    gvUsuarios.BestFitColumns();
                }
        }
    }
}