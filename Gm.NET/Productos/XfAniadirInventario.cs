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
using Gm.Core;

namespace Gm.NET
{
    public partial class XfAniadirInventario : DevExpress.XtraEditors.XtraForm
    {
        public Producto producto_;
        public bool Ok = false;
        public XfAniadirInventario()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var kard = new Repository<Kardex>();
            var prod = new Repository<Producto>();
            var fac = new Repository<Factura>();
            var facDec = new Repository<FacturaDetalle>();


            try
            {
                dxErrorProvider1.SetError(txtInventarioIncial, "");
                dxErrorProvider1.SetError(txtPrecioCompra, "");

                if (string.IsNullOrEmpty(txtInventarioIncial.Text) && string.IsNullOrEmpty(txtPrecioCompra.Text))
                {
                    dxErrorProvider1.SetError(txtInventarioIncial, "Ingrese un valor");
                    dxErrorProvider1.SetError(txtPrecioCompra, "Ingrese un valor");
                    throw new Exception();
                }

                if (string.IsNullOrEmpty(txtPrecioCompra.Text) || Convert.ToDecimal(txtPrecioCompra.Text) <= 0)
                {
                    dxErrorProvider1.SetError(txtPrecioCompra, "Ingrese un valor");
                    throw new Exception();
                }
                if (string.IsNullOrEmpty(txtInventarioIncial.Text) || Convert.ToDecimal(txtInventarioIncial.Text) <= 0)
                {
                    dxErrorProvider1.SetError(txtInventarioIncial, "Ingrese un valor");
                    throw new Exception();
                }

                var tmp1 = kard.GetAll();
                int con1 = 0;
                if (tmp1 == null)
                    con1 = 1;
                else
                    con1 = tmp1.Count + 1;

                int Almacen = string.IsNullOrEmpty(txtInventarioIncial.Text) ? 0 : Convert.ToInt16(txtInventarioIncial.Text);
                int Bodega = string.IsNullOrEmpty(txtParaBodega.Text) ? 0 : Convert.ToInt16(txtParaBodega.Text);
                var CantidadTotal = Almacen + Bodega;

                var aux = kard.Create(new Kardex
                {
                    IDKardex = con1,
                    IDProducto = producto_.IDProducto,
                    ProductoEntra = CantidadTotal,
                    ProductoEntraPrecio = (string.IsNullOrEmpty(txtPrecioCompra.Text)) ? 0 : Convert.ToDecimal(txtPrecioCompra.Text),
                    ProductoSale = 0,
                    ProductoSalePrecio = 0,
                    IVA = producto_.Iva == true ? Convert.ToInt16(General.Iva) : 0,
                    IDFactura = "I" + con1,
                    Estado = "A",
                    Fecha = DateTime.Now,
                    FechaSistema = DateTime.Now,
                    Equivalencia = Convert.ToInt16(txtInventarioIncial.Text),
                    IdMedidaMetrica = producto_.IDMedidaMetrica,
                    Referencia = 0,
                    IDUbicacion = producto_.IDUbicacion,
                    Siclo = "R",
                    Flete = (string.IsNullOrEmpty(txtFlete.Text)) ? 0 : Convert.ToDecimal(txtFlete.Text) / CantidadTotal
                });


                var counF = fac.Count() + 1;
                var f = fac.Create(new Factura
                {
                    IDFactura = counF,
                    Numero = counF.ToString(),
                    IDCliente = 1,
                    Fecha = DateTime.Now,
                    FechaSistema = DateTime.Now,
                    Estado = "A",
                    IDTerminal = Convert.ToInt16(General.Terminal),
                    Tipo = "I",
                });

                var counFD = facDec.Count() + 1;
                facDec.Create(new FacturaDetalle
                {
                    IDFacturaDetalle = counFD,
                    IDProducto = producto_.IDProducto,
                    Costo = aux.ProductoEntraPrecio,
                    Unidades = aux.ProductoEntra,
                    IDFactura = f.IDFactura,
                    FechaSistema = DateTime.Now,
                    IdMedidaMetrica = producto_.IDMedidaMetrica,
                    IDKardex = aux.IDKardex,
                    Iva = aux.IVA,
                    FleteAplicado = aux.Flete,
                    Estado = true,
                    Siclo = "I",
                    EnAlmacen = Almacen,
                    EnBodega = Bodega
                });

                var temp = prod.Find(x => x.IDProducto == producto_.IDProducto);

                temp.ExistenciaActual = ((temp.ExistenciaActual == null) ? 0 : temp.ExistenciaActual) + Convert.ToInt16(txtInventarioIncial.Text);
                prod.Update(temp);
                Ok = true;
                Close();
            }
            catch
            {

            }

        }

        private void XfAniadirInventario_Load(object sender, EventArgs e)
        {
            this.Text = producto_.Nombre;
            
        }

        private void txtInventarioIncial_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //    btnAplicar.Focus();
        }
    }
}