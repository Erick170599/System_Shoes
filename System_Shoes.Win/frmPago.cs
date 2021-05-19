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
    public partial class frmPago : DevExpress.XtraEditors.XtraForm
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            Clean();
            txtTPago.EditValue = Misc.totalPago;
            txtPago.EditValue = Misc.totalPago;
            txtCambio.EditValue = 0;
        }

        private void Clean()
        {
            txtTPago.EditValue = null;
            txtPago.EditValue = null;
            txtCambio.EditValue = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Misc.pago = Convert.ToDecimal(txtPago.EditValue);
            txtCambio.EditValue = (Misc.totalPago - Misc.pago) * -1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
                if(txtPago.EditValue != null)
                    if (Convert.ToDouble(txtPago.EditValue) > 0)
                    {
                        txtCambio.EditValue = (Misc.totalPago - Convert.ToDecimal(txtPago.EditValue)) * -1;
                        btnAceptar.Focus();
                    }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}