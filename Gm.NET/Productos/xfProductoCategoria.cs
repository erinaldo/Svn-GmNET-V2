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
    public partial class XfProductoCategoria : DevExpress.XtraEditors.XtraForm
    {
        public XfProductoCategoria()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDiscripcion.Text))
            {
                var resp = new Repository<Grupo>();
                int row = resp.GetAll().Count;

                if (resp.Create(new Grupo
                {
                    IDGrupo = row + 1,
                    Nombre = txtDiscripcion.Text,
                    FechaSistema = DateTime.Now,
                    Estado = "A"
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

        private void txtDiscripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtDiscripcion.Text))
            {
                if (Keys.Enter == e.KeyCode)
                    btnGuardar.Focus();
                if (Keys.Escape == e.KeyCode)
                    btnSalir.Focus();
            }
        }
    }
}