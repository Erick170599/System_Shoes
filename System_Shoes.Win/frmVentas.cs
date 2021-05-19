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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        private VentaOperations ventaOperations = VentaOperations.Instance();
        private ClienteOperations clienteOperations = ClienteOperations.Instance();
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        private ProductoOperations productoOperations = ProductoOperations.Instance();
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        private Venta venta;

        public frmVentas()
        {
            InitializeComponent();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNVenta().ShowDialog();
            ventaBindingSource.DataSource = ventaOperations.GetAll();
            gvVentas.BestFitColumns();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            ventaBindingSource.DataSource = ventaOperations.GetAll();
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clienteBindingSource.DataSource = clienteOperations.GetAll();
            ventaBindingSource.DataSource = ventaOperations.GetAll();
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            productoBindingSource.DataSource = productoOperations.GetAll();
            gvVentas.BestFitColumns();
        }

        private void btnImpTickect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gvVentas.FocusedRowHandle < 0)
                return;

            try
            {
                SplashScreenManager.ShowDefaultWaitForm("Por favor espere", "Cargando reporte...");
                StiReport stiReport = new StiReport();
                stiReport.LoadFromString(reporteOperations.GetByName("Ticket").xml);
                stiReport.Dictionary.Databases.Clear();
                stiReport.Dictionary.Databases.Add(new StiSqlDatabase("SystemShoes", SystemShoesContext.conString));
                stiReport.Dictionary.Variables.Add(new StiVariable("idVenta", gvVentas.GetFocusedRowCellValue("idVenta")));
                stiReport.Print(false);
                SplashScreenManager.CloseDefaultWaitForm();
                stiReport.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error " + ex.Message);
            }
        }
    }
}