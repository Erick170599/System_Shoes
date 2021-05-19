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
    public partial class frmNUsuario : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        private Usuario usuario;
        public frmNUsuario()
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
                if (usuario == null)
                {
                    if (usuarioOperations.Add(new Usuario
                    {
                        nombre = txtNombre.Text,
                        usuario = txtUsuario.Text,
                        password = txtContra.Text
                    }) > 0)
                    {
                        XtraMessageBox.Show("Usuario registrado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error al guardar el Usuario", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                txtUsuario.EditValue == null || txtUsuario.Text.Equals("") ||
                txtContra.EditValue == null || txtContra.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }
            if (txtUsuario.EditValue == null || txtUsuario.Text.Equals(""))
            {
                txtUsuario.ErrorText = "Ingresa el usuario";
                ban = true;
            }
            if (txtContra.EditValue == null || txtContra.Text.Equals(""))
            {
                txtContra.ErrorText = "Ingresa la contraseña";
                ban = true;
            }

            if (ban == true)
                return false;
            else
                return true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Misc.actualiza = false;
        }

        private void frmNUsuario_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void frmNUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Misc.actualiza == false)
                if (XtraMessageBox.Show("¿Desea cerrar la pantalla?", "System Shoes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
        }
    }
}