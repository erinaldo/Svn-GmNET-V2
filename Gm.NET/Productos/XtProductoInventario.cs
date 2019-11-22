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

using DevExpress.XtraPrinting;
using Gm.Data;
using Gm.Entities;
using DevExpress.XtraGrid.Views.Grid;

namespace Gm.NET
{
    public partial class XtProductoInventario : DevExpress.XtraEditors.XtraForm
    {
        public XtProductoInventario()
        {
            InitializeComponent();
        }
        private void MostrarDato()
        {
            var resp = new Repository<FacturaDetalle>();

            //var dato = (from a in resp.GetAll()
            //            where a.IDFactura!=null && a.IDFactura.Contains('I') && a.Estado=="A"
            //            select a).ToList();

            var dato = (from a in resp.Search(x => x.Estado == true && x.Siclo == "I")
                        select new Kardex
                        {
                            IDKardex= Convert.ToInt64(a.IDKardex),
                         IDFactura = "I"+a.IDFactura,
                         Producto = a.Producto,
                         ProductoEntra = a.Unidades,
                         ProductoEntraPrecio=a.Costo,
                         Fecha=a.FechaSistema,
                         Siclo=a.Siclo,
                         IDProducto=a.IDProducto,
                        }).ToList();

            gridControl1.DataSource = dato;
        }

        private void XtraFormProducto_Load(object sender, EventArgs e)
        {
            MostrarDato();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Editar();
        }
        private void Editar()
        {
            try
            {
                var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Kardex;
                if (resp.Movimiento != "F")
                {
                    XtInventarioEditar mvc = new XtInventarioEditar { dato = resp };
                    if (mvc.ShowDialog() == DialogResult.OK)
                        MostrarDato();
                }
                else
                    XtraMessageBox.Show("No se puede alterar los datos, ya tienen novimiento");
            }
            catch { }
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gridControl1;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MostrarDato();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Movimiento"]);
                if (category == "F")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //buscamos en detalle 
            var aux = gridView1.GetRow(gridView1.FocusedRowHandle) as Kardex;
            if (aux != null && 
                XtraMessageBox.Show("Esta Seguro de querer eliminar el registro\n"+aux.Producto.Nombre+"\nCantidad: "+aux.ProductoEntra,"Alerta",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                var facCabecera = new Repository<Factura>();
                var facDetalle = new Repository<FacturaDetalle>();
                var kardex = new Repository<Kardex>();

                var resp = facDetalle.Find(x => x.IDKardex == aux.IDKardex && x.IDProducto == aux.IDProducto);
                var resp1 = facCabecera.Find(x => x.IDFactura == resp.IDFactura);
                var resp2 = kardex.Find(x => x.IDKardex == resp.IDKardex && x.IDProducto == aux.IDProducto);

                var listado = facDetalle.Search(x => x.IDFactura == resp.IDFactura);

                resp.Estado = false;
                resp2.Estado = "E";

                facDetalle.Update(resp);
                kardex.Update(resp2);


                if (listado.Count == 1)
                {
                    resp1.Estado = "E";
                    facCabecera.Update(resp1);
                }
            }
            
        }
    }
}