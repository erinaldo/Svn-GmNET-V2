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
using Gm.Core;
using Gm.Data;

namespace Gm.NET
{
    public partial class XfBodegaTraladoAlmacen : DevExpress.XtraEditors.XtraForm
    {
        public Producto _producto;
        private List<TrasladoCore> traslado;
        readonly Repository<Factura> repositoryFac;
        readonly Repository<FacturaDetalle> repositoryFacDeta;


        public bool oK = false;
        public XfBodegaTraladoAlmacen()
        {
            InitializeComponent();
            repositoryFac = new Repository<Factura>();
            repositoryFacDeta = new Repository<FacturaDetalle>();
        }
      

        private void XfProductoTraslado_Load(object sender, EventArgs e)
        {
            this.Text = _producto.Nombre;
            //obtengo todas las compras de ese producto
            var resp = (from a in repositoryFacDeta.Search(x => x.IDProducto == _producto.IDProducto
                       && x.Estado == true && (x.Siclo == "C" || x.Siclo == "I"))
                        select a.IDFactura).ToList();
            traslado = new List<TrasladoCore>();

            foreach (var row in resp)
            {
                var fac = repositoryFac.Find(x => x.IDFactura == row.Value);
                var facDe = repositoryFacDeta.Find(x => x.IDFactura == fac.IDFactura && x.IDProducto == _producto.IDProducto && x.EnBodega > 0);
                if (facDe != null)
                {
                    traslado.Add(
                    new TrasladoCore
                    {
                        IDFactura = fac.IDFactura,
                        NumeroFactura = fac.Numero,
                        IdProducto = _producto.IDProducto,
                        Nombre = _producto.Nombre,
                        Cantidad = Convert.ToInt16(facDe.EnBodega)
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

            for (int i = 0; i < traslado.Count; i++)
            {
                long IdF = traslado[i].IDFactura;
                long IdP = traslado[i].IdProducto;

                var aux = repositoryFacDeta.Find(x => x.IDFactura == IdF && x.IDProducto == IdP);
                aux.EnBodega = traslado[i].Queda;
                aux.EnAlmacen = aux.EnAlmacen + traslado[i].Sale;
                repositoryFacDeta.Update(aux);

                if (traslado[i].Sale > 0)
                {
                    trans.Create(new Traslados
                    {
                        IDTraslado = rowTras + i,
                        IDProducto = IdP,
                        Nombre = traslado[i].Nombre,
                        Cantidad = traslado[i].Sale,
                        TrasladoDe = "Bodega -> Almacen",
                        FechaSistema = DateTime.Now,
                        IDUsuario = General.IdUsuario
                    });
                }
                
                progressBarControl1.EditValue = Convert.ToInt16(progressBarControl1.EditValue) + 1;
            }
        }
    }
}