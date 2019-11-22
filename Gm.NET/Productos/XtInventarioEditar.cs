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

namespace Gm.NET
{
    public partial class XtInventarioEditar : DevExpress.XtraEditors.XtraForm
    {
        public Kardex dato;
        public XtInventarioEditar()
        {
            InitializeComponent();
        }

        private void XtInventarioEditar_Load(object sender, EventArgs e)
        {
            this.Text = dato.Producto.Nombre;
            txtCantidadEntra.EditValue = dato.ProductoEntra;
            txtPrecioCompra.EditValue = dato.ProductoEntraPrecio;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtCantidadEntra.Text) && !string.IsNullOrEmpty(txtPrecioCompra.Text))
            {
                if (Convert.ToInt16(txtCantidadEntra.Text) > 0)
                {
                    var resp = new Repository<Kardex>();
                    var aux = resp.Find(x => x.IDKardex == dato.IDKardex);

                    aux.ProductoEntra = Convert.ToInt16(txtCantidadEntra.Text);
                    aux.ProductoEntraPrecio = Convert.ToDecimal(txtPrecioCompra.Text);

                    var facd = new Repository<FacturaDetalle>();
                    long IDf = Convert.ToInt64(aux.IDFactura.Remove(0, 1));

                    var aux1 = facd.Find(x => x.IDFacturaDetalle == IDf && x.IDProducto == aux.IDProducto);
                    aux1.Unidades = Convert.ToInt16(txtCantidadEntra.Text);
                    aux1.Costo = Convert.ToDecimal(txtPrecioCompra.Text);
                    aux1.EnAlmacen = Convert.ToInt16(txtCantidadEntra.Text);

                    if (resp.Update(aux) && facd.Update(aux1))
                        Close();

                    else
                    {
                        this.Hide();
                        XtraMessageBox.Show(resp.Error);
                        this.Visible = true;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}