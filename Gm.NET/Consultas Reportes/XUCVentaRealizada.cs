using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gm.Data;
using Gm.Entities;
using Gm.Core;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    public partial class XUCVentaRealizada : DevExpress.XtraEditors.XtraUserControl
    {
        DateTime fecha;
        public XUCVentaRealizada()
        {
            InitializeComponent();
            
        }
        private void Mostrar(DateTime fecha)
        {
            gridView1.ViewCaption = string.Format("MOVIENTOS DE ({0})", fecha.ToShortDateString());

            var a1 = fecha.ToShortDateString();

            var Vp = new Repository<Kardex>().GetAll().
                Where(x => x.Equivalencia < 0 && x.Fecha.Value.ToShortDateString() == fecha.ToShortDateString()).ToList();

            List<VistaVentaCore> ventas = new List<VistaVentaCore>();

            if (Vp != null)
            {
                foreach (var a in Vp)
                {

                    var temp = (from item in new Repository<Kardex>().GetAll()
                                where item.IDKardex == a.Referencia && item.IDProducto == a.IDProducto
                                select item
                                ).First();

                    if (temp != null)
                        a.ProductoEntraPrecio = temp.ProductoEntraPrecio;
                }

                ventas = (from a in Vp
                          select new VistaVentaCore
                          {
                              IDProducto = a.IDProducto,
                              Nombre = a.Producto.Nombre,
                              Cantidad = a.ProductoSale,
                              PVenta = a.ProductoSalePrecio,
                              PCompra = a.ProductoEntraPrecio,
                              Fecha = a.Fecha,
                              Venta = a.ProductoSale * a.ProductoSalePrecio,
                              Inversion = a.ProductoEntraPrecio * a.ProductoSale,
                              Ganancia = (a.ProductoSalePrecio - a.ProductoEntraPrecio) * a.ProductoSale
                          }).ToList();
            }

            var aux = ventas.
                GroupBy(x => x.IDProducto).
                Select(cl => new VistaVentaCore
                {
                    Nombre = cl.First().Nombre,
                    Cantidad = cl.Sum(c => c.Cantidad),
                    Venta = cl.Sum(c => c.Venta),
                    Inversion = cl.Sum(c => c.Inversion),
                    Ganancia = cl.Sum(c => c.Ganancia),
                    Fecha = cl.First().Fecha
                }).ToList();

            lcTotalVenta.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Venta));
            lcTotalGanancia.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Ganancia));
            lcInversionRealizada.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Inversion));

            gridControl1.DataSource = aux;
        }
        private void XUCVentaRealizada_Load(object sender, EventArgs e)
        {
            fecha = DateTime.Now;
            Mostrar(fecha);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar(fecha);
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            using (Formularios.XfFecha form = new Formularios.XfFecha { fecha = this.fecha })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    fecha = form.fecha;
                    Mostrar(fecha);
                }
            }
        }
    }
}
