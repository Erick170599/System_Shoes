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
    public partial class frmMReporte : DevExpress.XtraEditors.XtraForm
    {
        private int idReporte;
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        public frmMReporte()
        {
            InitializeComponent();
        }

        public frmMReporte(int idReporte)
        {
            InitializeComponent();
            this.idReporte = idReporte;
        }

        private void frmMReporte_Load(object sender, EventArgs e)
        {

        }
    }
}