using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
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
using System_Shoes.DAL;
using System_Shoes.Entities;

namespace System_Shoes.Win
{
    public partial class frmReportes : DevExpress.XtraEditors.XtraForm
    {
        private int idReporte;
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        private Venta venta;
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            reporteBindingSource.DataSource = reporteOperations.GetAll();
            gvReportes.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reporteBindingSource.DataSource = reporteOperations.GetAll();
            gvReportes.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNReporte().ShowDialog();
            reporteBindingSource.DataSource = reporteOperations.GetAll();
            gvReportes.BestFitColumns();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                StiReport stiReport = new StiReport();
                stiReport.LoadFromString(reporteOperations.GetByName("Ticket").xml);
                stiReport.Dictionary.Databases.Clear();
                stiReport.Dictionary.Databases.Add(new StiSqlDatabase("systemshdb", SystemShoesContext.conString));
                stiReport.Dictionary.Variables.Add(new StiVariable("idVenta", venta.idVenta));
                stiReport.Print(false);
                this.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvReportes.FocusedRowHandle >= 0)
                if (XtraMessageBox.Show(string.Format("¿Está seguro de eliminar el Reporte? \n\n{0}",
                    gvReportes.GetFocusedRowCellValue("nombre")), "System Shoes", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (new Reporte() { idReporte = (int)gvReportes.GetFocusedRowCellValue("idReporte") }.idReporte > 0)
                    {
                        idReporte = (int)gvReportes.GetFocusedRowCellValue("idReporte");
                        reporteOperations.Delete(idReporte);
                        XtraMessageBox.Show("Reporte eliminado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        XtraMessageBox.Show("Ocurrió un error al eliminar el Reporte \nVerifique con el departamento de TI",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    reporteBindingSource.DataSource = reporteOperations.GetAll();
                    gvReportes.BestFitColumns();
                }
        }
    }
}