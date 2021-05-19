﻿using DevExpress.XtraEditors;
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
    public partial class frmNMarca : DevExpress.XtraEditors.XtraForm
    {
        private MarcaOperations marcaOperations = MarcaOperations.Instance();
        private Marca marca;
        public frmNMarca()
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
                if (marca == null)
                {
                    if (marcaOperations.Add(new Marca
                    {
                        descripcion = txtNombre.Text
                    }) > 0)
                    {
                        XtraMessageBox.Show("Marca registrada correctamente", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Misc.actualiza = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("Ocurrió un error al guardar la Marca", "System Shoes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Misc.actualiza = false;
                    }
                }
                this.Close();
            }
        }

        private bool Validar()
        {
            var ban = false;

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                XtraMessageBox.Show("Favor de llenar todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                ban = true;
            }

            if (txtNombre.EditValue == null || txtNombre.Text.Equals(""))
            {
                txtNombre.ErrorText = "Ingresa el nombre";
                ban = true;
            }


            if (ban == true)
                return false;
            else
                return true;
        }

        private void frmNMarca_Load(object sender, EventArgs e)
        {
            Misc.actualiza = true;
        }

        private void frmNMarca_FormClosing(object sender, FormClosingEventArgs e)
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