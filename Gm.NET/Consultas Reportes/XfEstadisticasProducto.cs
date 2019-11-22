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
using DevExpress.XtraGrid;
using Gm.Entities;
using Gm.Core;
using DevExpress.XtraGrid.Views.Grid;
using Gm.Data;
using DevExpress.Spreadsheet.Charts;
using DevExpress.XtraPrinting;

namespace Gm.NET.Formularios.VentaCompra
{
    public partial class XfEstadisticasProducto : DevExpress.XtraEditors.XtraForm
    {
        private KardexBLL metodo;
        public XfEstadisticasProducto()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            Dictionary<string, Series> seriesList = new Dictionary<string, Series>();
            try
            {
                metodo = new KardexBLL();
                var de = new Repository<Sp_ProcedureKardex_Result>();
                var aux = de.SQLQuery("EXEC Sp_ProcedureKardex");
                List<VistaKardex> vista = (from a in aux
                                           select new VistaKardex
                                           {
                                               IDKardex = Convert.ToInt32(a.IDKardex),
                                               IDProducto = a.IDProducto,
                                               Producto = a.Producto,
                                               ProductoEntra = a.ProductoEntra,
                                               ProductoEntraPrecio = a.ProductoEntraPrecio,
                                               ProductoSale = a.ProductoSale,
                                               ProductoSalePrecio = a.ProductoSalePrecio,
                                               IVA = a.IVA,
                                               Fecha = a.Fecha,
                                               Estado = a.Estado,
                                               Medida = a.Medida
                                           }).ToList();

                pivotGridControl1.DataSource = vista;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }


            //https://www.youtube.com/watch?v=f3w4RAyBbhg
        }
        private void xfClientEditQuick_Load(object sender, EventArgs e)
        {
            using (FrmCargaComponentes frm = new FrmCargaComponentes(Mostrar))
            {
                frm.ShowDialog(this);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = pivotGridControl1;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
    }
}