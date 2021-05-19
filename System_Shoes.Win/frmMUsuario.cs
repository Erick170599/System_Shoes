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
    public partial class frmMUsuario : DevExpress.XtraEditors.XtraForm
    {
        private int idUsuario;
        private UsuarioOperations usuarioOperations = UsuarioOperations.Instance();
        public frmMUsuario()
        {
            InitializeComponent();
        }

        public frmMUsuario(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void frmMUsuario_Load(object sender, EventArgs e)
        {
            Inicializar();
            Misc.actualiza = true;
        }

        private void Inicializar()
        {
            Usuario usuario = usuarioOperations.GetById(idUsuario);
            txtNombre.EditValue = usuario.nombre;
            txtUsuario.EditValue = usuario.usuario;
            txtContra.EditValue = usuario.password;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario usuario = usuarioOperations.GetById(idUsuario);
                usuario.idUsuario = (int)idUsuario;
                usuario.nombre = (string)txtNombre.EditValue;
                usuario.password = (string)txtContra.EditValue;

                if (usuarioOperations.Update(usuario) > 0)
                {
                    XtraMessageBox.Show("Usuario actualizado correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Misc.actualiza = true;
                }
                else
                {
                    XtraMessageBox.Show("Ocurrió un error al actualizar el Usuario", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Misc.actualiza = false;
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

        private void frmMUsuario_FormClosing(object sender, FormClosingEventArgs e)
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