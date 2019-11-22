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
using Gm.Entities;
using Gm.Data;

namespace Gm.NET.Formularios
{
    public partial class XfComprasProductoEditar : DevExpress.XtraEditors.XtraForm
    {
        public Producto producto_;
        public XfComprasProductoEditar()
        {
            InitializeComponent();
        }

        private void xfFacturaProductoEditar_Load(object sender, EventArgs e)
        {
            txtCodigo.EditValue = producto_.IDProducto;
            txtCodigoBarra.EditValue = producto_.CodBarra;
            txtNombre.EditValue = producto_.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    using (var resp = new Repository<Producto>())
                    {
                        var aux = resp.Find(x => x.IDProducto == producto_.IDProducto);
                        aux.CodBarra = txtCodigoBarra.Text;
                        aux.Nombre = txtNombre.Text;
                        if (resp.Update(aux))
                        {
                            producto_ = aux;
                            Close();
                        }
                        else
                            throw new Exception(resp.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                this.Hide();
                XtraMessageBox.Show(ex.Message);
                this.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}