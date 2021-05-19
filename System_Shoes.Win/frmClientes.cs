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
    public partial class frmClientes : DevExpress.XtraEditors.XtraForm
    {
        private int idCliente;
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNCliente().ShowDialog();
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmMCliente((int)gvClientes.GetFocusedRowCellValue("idCliente")).ShowDialog();
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            gvClientes.BestFitColumns();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvClientes.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el Cliente? \n\n{0}",
                    gvClientes.GetFocusedRowCellValue("nombre")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Cliente() { idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente") }.idCliente > 0)
                    {
                        idCliente = (int)gvClientes.GetFocusedRowCellValue("idCliente");
                        clienteOperations.Delete(idCliente);
                        XtraMessageBox.Show("Cliente eliminado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el Cliente \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clienteBindingSource.DataSource = clienteOperations.GetAll();
                    gvClientes.BestFitColumns();
                }
        }
    }
}