using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = usuarioOperations.GetAll();
            txtContraseña.Properties.PasswordChar = '*';
            Misc.actualiza = true;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Misc.usuario = usuarioOperations.Login(new Usuario
                {
                    usuario = lupUsuario.Text,
                    password= txtContraseña.Text
                });
                //SplashScreenManager.CloseDefaultWaitForm();
                if (Misc.usuario != null)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    XtraMessageBox.Show("Credenciales incorrectas", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContraseña.SelectAll();
                    txtContraseña.Focus();
                }
            }
        }

        private bool Validar()
        {
            var ban = false;
            if(lupUsuario.EditValue == null || lupUsuario.Text.Equals(""))
            {
                lupUsuario.ErrorText = "Selecciona un Usuario";
                lupUsuario.Focus();
                ban = true;
            }
            if (txtContraseña.EditValue == null || txtContraseña.Text.Equals(""))
            {
                txtContraseña.ErrorText = "Ingresa una Contraseña";
                if (ban == false)
                {
                    txtContraseña.Focus();
                    ban = true;
                }
            }

            if (ban == true)
                return false;
            else
                return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lupUsuario_Popup(object sender, EventArgs e)
        {
            (((sender as LookUpEdit) as IPopupControl).PopupWindow as PopupLookUpEditForm).Width = (sender as LookUpEdit).Width;
        }

        private void lupUsuario_EditValueChanged(object sender, EventArgs e)
        {
            txtContraseña.EditValue = null;
        }

        private void lupUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }

        private void lupUsuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Misc.actualiza == false)
            //    if (XtraMessageBox.Show("¿Desea cerrar la pantalla?", "System Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    {
            //        e.Cancel = true;
            //        return;
            //    }
        }
    }
}