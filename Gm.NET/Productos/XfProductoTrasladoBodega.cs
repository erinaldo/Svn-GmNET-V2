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
    public partial class XfProductoTrasladoBodega : DevExpress.XtraEditors.XtraForm
    {
        public Producto _producto;
        private List<TrasladoCore> traslado;
        readonly Repository<Factura> repositoryFac;
        readonly Repository<FacturaDetalle> repositoryFacDeta;
        public XfProductoTrasladoBodega()
        {
            InitializeComponent();
            repositoryFac = new Repository<Factura>();
            repositoryFacDeta = new Repository<FacturaDetalle>();
        }

        private void XfTrasladoProducto_Load(object sender, EventArgs e)
        {
            this.Text = _producto.Nombre;
            //obtengo todas las compras de ese producto
            var resp = (from a in repositoryFacDeta.Search(x => x.IDProducto == _producto.IDProducto
                       && x.Estado == true && (x.Siclo == "C" || x.Siclo == "I"))
                        select a.IDFactura).ToList();
            traslado = new List<TrasladoCore>();

            foreach(var row in resp)
            {
                var fac = repositoryFac.Find(x => x.IDFactura == row.Value);
                var facDe= repositoryFacDeta.Find(x => x.IDFactura == fac.IDFactura && x.IDProducto == _producto.IDProducto && x.EnAlmacen>0);
                if (facDe != null)
                {
                    traslado.Add(
                    new TrasladoCore
                    {
                        IDFactura = fac.IDFactura,
                        NumeroFactura = fac.Numero,
                        IdProducto = _producto.IDProducto,
                        Nombre = _producto.Nombre,
                        Cantidad = Convert.ToInt16(facDe.EnAlmacen)
                    });
                }
            }
            gridControl1.DataSource = traslado;

            if (traslado.Count == 0)
                btnAplicar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            btnAplicar.Enabled = false;
            progressBarControl1.EditValue = 1;
            progressBarControl1.Properties.Maximum = traslado.Count;
            var trans = new Repository<Traslados>();
            var rowTras = trans.Count();

            for (int i= 0; i < traslado.Count; i++)
            {
                long IdF = traslado[i].IDFactura;
                long IdP = traslado[i].IdProducto;

                var aux = repositoryFacDeta.Find(x=>x.IDFactura== IdF && x.IDProducto == IdP);
                aux.EnAlmacen = traslado[i].Queda;
                aux.EnBodega = aux.EnBodega + traslado[i].Sale;
                repositoryFacDeta.Update(aux);

                if (traslado[i].Sale > 0)
                {
                    trans.Create(new Traslados
                    {
                        IDTraslado = rowTras + i,
                        IDProducto = IdP,
                        Nombre = traslado[i].Nombre,
                        Cantidad = traslado[i].Sale,
                        TrasladoDe = "Almacen -> Bodega",
                        FechaSistema = DateTime.Now,
                        IDUsuario = General.IdUsuario
                    });
                }

                progressBarControl1.EditValue = Convert.ToInt16(progressBarControl1.EditValue) + 1;
            }
        }
    }
}