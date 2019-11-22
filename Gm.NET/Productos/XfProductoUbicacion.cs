﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gm.Data;
using Gm.Entities;
using Gm.Core;

namespace Gm.NET.Formularios
{
    public partial class XfProductoUbicacion : DevExpress.XtraEditors.XtraForm
    {
        public XfProductoUbicacion()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscripcion.Text))
            {
                var resp = new Repository<Ubicacion>();
                int row = resp.GetAll().Count;

                if (resp.Create(new Ubicacion
                {
                    IDUbicacion = row + 1,
                    Nombre = txtDiscripcion.Text,
                    FechaSystema = DateTime.Now,
                    Estado = true,
                    IDUsuario = General.IdUsuario
                }) == null)
                {
                    this.Hide();
                    XtraMessageBox.Show(resp.Error);
                    this.Visible = true;
                }
                else
                    Close();
            }
            else
                txtDiscripcion.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDiscripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscripcion.Text))
            {
                if (Keys.Enter == e.KeyCode)
                    btnGuardar.Focus();
                if (Keys.Escape == e.KeyCode)
                    btnSalir.Focus();
            }
        }
    }
}