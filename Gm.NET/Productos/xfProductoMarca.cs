using System;
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

namespace Gm.NET.Formularios
{
    public partial class XfProductoMarca : DevExpress.XtraEditors.XtraForm
    {
        public XfProductoMarca()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscripcion.Text))
            {
                var resp = new Repository<Marca>();
                int row = resp.GetAll().Count;

                if (resp.Create(new Marca
                {
                    IDMarca = row + 1,
                    NombreMarca = txtDiscripcion.Text,
                    FechaSistema = DateTime.Now,
                    Estado = true
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