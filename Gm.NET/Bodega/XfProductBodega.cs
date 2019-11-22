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
using Gm.Core;
using Gm.Entities;
using System.Threading;
using Gm.NET.Formularios;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Gm.Data;
using DevExpress.Office.Utils;
using System.IO;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace Gm.NET
{
    public partial class XfProductBodega : DevExpress.XtraEditors.XtraForm
    {
        private ProductoBLL metodo;
        List<Producto> datosProductos;
        Repository<Producto> repositoryPro;
        public Dictionary<string,bool> col;
        public XfProductBodega()
        {
            InitializeComponent();
            repositoryPro = new Repository<Producto>();
        }
        
        private void XtraFormProductoAdmin_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        public void Actualizar()
        {
            try
            {
                metodo = new ProductoBLL();
                var resp = new Repository<FacturaDetalle>().Search(x => x.Estado == true && (x.Siclo == "C" || x.Siclo == "I") && x.EnBodega>0);

                var indices = (from a in resp
                               select a.IDProducto).Distinct();

                datosProductos = new List<Producto>();

                foreach (var aux in indices)
                {
                    long IDp = aux.Value;
                    var row = repositoryPro.Find(x=>x.IDProducto==IDp);
                    row.EnBodega = resp.Where(x => x.IDProducto == IDp).Sum(x => x.EnBodega);
                    datosProductos.Add(row);
                }

                //datosProductos = metodo.Lista.Where(x => x.EnBodega>0).ToList();
                //foreach (var a in datosProductos)
                //    a.Iva = false;

                gCProductos.DataSource = datosProductos;


            }
            catch {  }
        }
        
        public void Movimiento()
        {
            XfBodegaMovimiento mvc = new XfBodegaMovimiento();
            mvc.ShowDialog();
        }
        

        public void ActivarProductoMovimiento()
        {
            //dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }
       
      
        public void Imprimir()
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gCProductos;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;
            if (keyData == Keys.F5)
            {
                Actualizar();
            }
            return Result;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //var row =  gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;

            //if (row != null)
            //{

            //    barButtonItem3.Caption = row.Nombre;
            //    barButtonItem1.Caption = string.Format("COD{0}:", row.IDProducto);

            //    pictureEdit1.Image = null;
            //    if (row.FotoProducto!=null)
            //        pictureEdit1.Image = Convertir_Bytes_Imagen(row.FotoProducto);

            //    #region Auditoria Inventario
            //    var kardex1 = (new KardexBLL().Datos.
            //        Where(x => x.IDProducto == row.IDProducto)).Take(50).ToList();
            //    gCAuditoriaInventario.DataSource = kardex1;
            //    #endregion


            //    #region Producto Historial
            //    gCMovimientoProducto.DataSource = new Ajustes().Seguimiento(row.IDProducto);
            //    #endregion
            //}
        }

        private void gVProductos_RowStyle(object sender, RowStyleEventArgs e)
        {
        
        }

        private void gVProductos_MouseUp(object sender, MouseEventArgs e)
        {
        
        }

        private void bButtonItemRestablecer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ClaseAcceso.ProductosRestablecer_)
            {
                var resp = new Repository<Producto>();
                var item = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
                var aux = resp.Find(x => x.IDProducto == item.IDProducto);
                if (aux.NombreAnterior != null)
                {
                    aux.Nombre = aux.NombreAnterior;
                    aux.NombreAnterior = null;
                    aux.EdNombre = false;
                    resp.Update(aux);
                }
            }
            
        }
       
    
     
        public void Editar() { }
        public void Eliminar() { }
        public void AnadirExistencia()
        {
            var pro = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            if (pro != null)
            {
                XfBodegaAnadirExistencia mvc = new XfBodegaAnadirExistencia { producto_ = pro };
                if (mvc.ShowDialog() == DialogResult.OK)
                {
                    Actualizar();
                }
            }
        }

        private void chEnviar_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit check = (CheckEdit)sender;
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            resp.Iva = check.Checked;
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var pro = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            XfBodegaTraladoAlmacen mvc = new XfBodegaTraladoAlmacen { _producto = pro };
            mvc.ShowDialog();
        }

        private void gVProductos_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
        }
        public void Cerrar()
        {
            Close();
        }
    }
}