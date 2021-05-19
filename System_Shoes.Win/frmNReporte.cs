using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
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
    public partial class frmNReporte : DevExpress.XtraEditors.XtraForm
    {
        private Reporte reporte;
        private ReporteOperations reporteOperations = ReporteOperations.Instance();
        public frmNReporte()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if(reporte == null)
                {
                    if(reporteOperations.Add(new Reporte
                    {
                        nombre = txtNombre.Text,
                        xml = System.IO.File.ReadAllText(btnArchivo.Text)
                    }) > 0)
                    {
                        XtraMessageBox.Show("Reporte registrado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error al guardar el Reporte", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Misc.actualiza = false;
                    }
                }
                this.Close();
            }
        }

        private bool Validar()
        {
            var ban = false;

            if (txtNombre.EditValue == null || txtNombre.Text.Equals("") ||
                btnArchivo.EditValue == null || btnArchivo.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }
            if (btnArchivo.EditValue == null || btnArchivo.Text.Equals(""))
            {
                btnArchivo.ErrorText = "Selecciona el archivo";
                ban = true;
            }


            if (ban == true)
                return false;
            else
                return true;
        }

        private void btnArchivo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            fd.Filter = "Stimulsoft Report Files (*.mrt)|*.mrt";
            fd.ShowDialog();
            btnArchivo.EditValue = fd.FileName;
        }

        private void frmNReporte_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void frmNReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Desea cerrar la pantalla?", "System Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }
    }
}