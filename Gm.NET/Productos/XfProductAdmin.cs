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
    public partial class XfProductAdmin : DevExpress.XtraEditors.XtraForm
    {
        readonly ProductoBLL metodo;
        public Dictionary<string,bool> col;
        public List<Producto> productosListado;
        public XfProductAdmin()
        {
            InitializeComponent();
            productosListado = new List<Producto>();
            metodo = new ProductoBLL();
        }
        
        private void XtraFormProductoAdmin_Load(object sender, EventArgs e)
        {
            CargaDatosIniciales();
            if (!backgroundWorker1.IsBusy)
            {
                repositoryItemProgressBar2.Maximum = new Repository<Producto>().Count(x => x.Estado == "A");
                Control.CheckForIllegalCrossThreadCalls = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ClaseAcceso.ProductosEdicionRapida_)
            {
                if (e.KeyCode == Keys.Enter && gVProductos.RowCount > 0)
                {
                    XfProductEditQuick formulario = null;
                    formulario = XfProductEditQuick.Instance();
                    formulario.unEvento += new XfProductEditQuick.Enviar(
                        delegate (GridControl t, int i)
                        { gCProductos.DataSource = t.DataSource; gVProductos.FocusedRowHandle = i; }
                        );
                    formulario.dt = gCProductos;
                    formulario.row = gVProductos.FocusedRowHandle;
                    formulario.Show();
                }
            }
        }

        private void txtPrecio1_KeyDown(object sender, KeyEventArgs e)
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            TextEdit text = (sender) as TextEdit;  
        }

        private void txtPrecio2_KeyDown(object sender, KeyEventArgs e)
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            TextEdit text = (sender) as TextEdit;

            if (e.KeyCode == Keys.Enter)
            {
                using (var aux = new Repository<Producto>())
                {
                    var item = aux.Find(x => x.IDProducto == resp.IDProducto);
                    resp.PVenta2 = Convert.ToDecimal(text.EditValue);
                    resp.EdPVenta2 = true;

                    item.PVenta2 = resp.PVenta2;
                    item.EdPVenta2 = resp.EdPVenta2;

                    if (!aux.Update(item))
                        XtraMessageBox.Show(aux.Error);
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var row = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;

            if (row != null)
            {

                barButtonItem3.Caption = row.Nombre;
                barButtonItem1.Caption = string.Format("COD{0}:", row.IDProducto);

                pictureEdit1.Image = null;
                if (row.FotoProducto != null)
                    pictureEdit1.Image = TratadoImagen.Convertir_Bytes_Imagen(row.FotoProducto);

                #region Auditoria Inventario
                var kardex1 = (new KardexBLL().Datos.
                    Where(x => x.IDProducto == row.IDProducto)).Take(50).ToList();
                gCAuditoriaInventario.DataSource = kardex1;
                #endregion


                #region Producto Historial
                gCMovimientoProducto.DataSource = new Ajustes().Movimiento(row.IDProducto);
                #endregion
            }
        }

        private void gVProductos_RowStyle(object sender, RowStyleEventArgs e)
        {
            string estado = Convert.ToString(gVProductos.GetRowCellValue(e.RowHandle, "Estado"));

            if (estado == "E")
            {
                e.Appearance.BackColor = Color.Salmon;
                e.Appearance.BackColor2 = Color.SeaShell;
            }
            //e.HighPriority = true;
        }

        private void gVProductos_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
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

        private void btnVerSeguimiento_Click(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }
             
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resp = (from a in new Repository<Proveedor>().GetAll()
                        where a.IDCliente == Convert.ToInt64(lookUpEdit1.EditValue)
                        select a.IDProducto).ToList();

            string cadena = string.Empty;
            for (int i = 0; i < resp.Count; i++)
            {
                if (i + 1 < resp.Count)
                    cadena += "'COD" + resp[i] + "',";
                else
                    cadena += "'" + resp[i] + "'";
            }
            if (!string.IsNullOrEmpty(cadena))
            {
                var FILTRO = string.Format("({0})", cadena);
                gVProductos.Columns["IDProducto"].FilterInfo = new ColumnFilterInfo("[IDProducto] IN " + FILTRO);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            XfAniadirInventario mvc = new XfAniadirInventario { producto_ = resp };
            mvc.ShowDialog();
            if ( mvc.Ok)
                Actualizar();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                productosListado = new List<Producto>();
                var productos = metodo.Lista.OrderBy(x => x.Nombre).ToList();
                var facturaDetalle = new Repository<FacturaDetalle>();

                int? Almacen = 0;
                int? Devolucion = 0;

                foreach (var fila in productos)
                {
                    Almacen = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && (x.Siclo == "C" || x.Siclo == "I") && x.Estado==true).Sum(x=>x.EnAlmacen);
                    Devolucion = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && (x.Siclo == "C" || x.Siclo == "I") && x.Estado==true).Sum(x => x.EnDevolucion);

                    fila.ExistenciaActual = Almacen + Devolucion;

                    productosListado.Add(fila);

                    progressBar.EditValue = Convert.ToInt16(progressBar.EditValue) + 1;
                }
            }
            catch(Exception ex)
            {
                backgroundWorker1.CancelAsync();
                XtraMessageBox.Show(ex.Message);
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CargaProductos();
        }

        public void CargaDatosIniciales()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            try
            {
                var persona = new Repository<Cliente>();
                var proveedores = new Repository<Proveedor>().GetAll().Select(x => x.IDCliente).Distinct();

                List<BusquedaPorProveedor> listaProveedor = new List<BusquedaPorProveedor>();

                foreach (var row in proveedores)
                {
                    listaProveedor.Add(
                        new BusquedaPorProveedor
                        {
                            IDProveedor = row,
                            Nombre = persona.Find(x => x.IDCliente == row).Nombre
                        }
                        );
                }

                lookUpEdit1.Properties.DataSource = listaProveedor;
                lookUpEdit1.Properties.ValueMember = "IDProveedor";
                lookUpEdit1.Properties.DisplayMember = "Nombre";
                lookUpEdit1.Properties.PopulateColumns();
                lookUpEdit1.Properties.Columns[0].Visible = false;
            }
            catch { }
        }

        public void CargaProductos()
        {
            try
            {
                gCProductos.DataSource = productosListado;

                PropiedadesColumna();
                CargarColumnas();
            }
            catch { }
        }

        public void ProductosMayoresA0()
        {
            gCProductos.DataSource = metodo.Lista.Where(x=>x.ExistenciaActual>0);
        }

        public void ProductosMenoressA0()
        {
            gCProductos.DataSource = metodo.Lista.Where(x => x.ExistenciaActual == 0 || x.ExistenciaActual == null);
        }

        public void ShowCrearProducto()
        {
            XfProductNew formulario = null;
            formulario = XfProductNew.Instance();
            formulario.unEvento += new XfProductNew.Enviar(
                delegate (GridControl t, int i)
                { gCProductos.DataSource = t.DataSource; gVProductos.FocusedRowHandle = i; }
                );
            formulario.dt = gCProductos;
            formulario.Show();
        }

        public void ShowEditarProducto()
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle)as Producto;
            XfProductoEditar mvc = new XfProductoEditar { producto_ = resp};
            if (mvc.ShowDialog() == DialogResult.OK)
                backgroundWorker1.RunWorkerAsync();
                //Actualizar();
        }

        public void Actualizar()
        {
            progressBar.EditValue = 0;
            backgroundWorker1.RunWorkerAsync();
        }

        private void PropiedadesColumna()
        {
            var aux = new Repository<Usuarios>().Find(x => x.IDUsuario == General.IdUsuario);
            col = new Dictionary<string, bool>();

            col.Add("CCodBarra", Convert.ToBoolean(aux.CCodBarra));
            col.Add("CIvaA", Convert.ToBoolean(aux.CIvaA));
            col.Add("CPv2A", Convert.ToBoolean(aux.CPv2A));
            col.Add("CPv3A", Convert.ToBoolean(aux.CPv3A));
            col.Add("CEqui1A", Convert.ToBoolean(aux.CEqui1A));
            col.Add("CEqui2A", Convert.ToBoolean(aux.CEqui2A));
            col.Add("CEqui3A", Convert.ToBoolean(aux.CEqui3A));
            col.Add("CUltimaVentaA", Convert.ToBoolean(aux.CUltimaVentaA));
            col.Add("CUltimaCompraA", Convert.ToBoolean(aux.CUltimaCompraA));
            col.Add("CPrecioAnteriorVenta1", Convert.ToBoolean(aux.CPrecioAnteriorVenta1));
            col.Add("CPrecioAnteriorVenta2", Convert.ToBoolean(aux.CPrecioAnteriorVenta2));
            col.Add("CPrecioAnteriorVenta3", Convert.ToBoolean(aux.CPrecioAnteriorVenta3));
            col.Add("CNombreAnterior", Convert.ToBoolean(aux.CNombreAnterior));
            col.Add("CCodigoRapido", Convert.ToBoolean(aux.CCodigoRapido));
            col.Add("CExistenciaMinima", Convert.ToBoolean(aux.CExistenciaMinima));
            col.Add("CMarca", Convert.ToBoolean(aux.CMarca));
            col.Add("CCategoria", Convert.ToBoolean(aux.CCategoria));
            col.Add("CEstado", Convert.ToBoolean(aux.CEstado));
            col.Add("CExistenciaActual", Convert.ToBoolean(aux.CExistenciaActual));
            col.Add("CFotoProducto", Convert.ToBoolean(aux.CFotoProducto));
            col.Add("CPCAnterior", Convert.ToBoolean(aux.CPCAnterior));
        }
        private void CargarColumnas()
        {
            gVProductos.Columns["IDProducto"].Visible = true;
            gVProductos.Columns["Nombre"].Visible = true;
            gVProductos.Columns["PVenta1"].Visible = true;
            gVProductos.Columns["PVenta4"].Visible = true;
            gVProductos.Columns["MedidaMetrica.Name"].Visible = true;

            gVProductos.Columns["CodBarra"].Visible = col["CCodBarra"];
            gVProductos.Columns["Iva"].Visible = col["CIvaA"];
            gVProductos.Columns["PVenta2"].Visible = col["CPv2A"];
            gVProductos.Columns["PVenta3"].Visible = col["CPv3A"];
            gVProductos.Columns["Equivalencia1"].Visible = col["CEqui1A"];
            gVProductos.Columns["Equivalencia2"].Visible = col["CEqui2A"];
            gVProductos.Columns["Equivalencia3"].Visible = col["CEqui3A"];
            gVProductos.Columns["FechaUltimaVenta"].Visible = col["CUltimaVentaA"];
            gVProductos.Columns["FechaUltimaCompra"].Visible = col["CUltimaCompraA"];
            gVProductos.Columns["PVAnterior1"].Visible = col["CPrecioAnteriorVenta1"];
            gVProductos.Columns["PVAnterior2"].Visible = col["CPrecioAnteriorVenta2"];
            gVProductos.Columns["PVAnterior3"].Visible = col["CPrecioAnteriorVenta3"];
            gVProductos.Columns["NombreAnterior"].Visible = col["CNombreAnterior"];
            gVProductos.Columns["CodRapido"].Visible = col["CCodigoRapido"];
            gVProductos.Columns["ExistenciaMinima"].Visible = col["CExistenciaMinima"];
            gVProductos.Columns["Marca.NombreMarca"].Visible = col["CMarca"];
            gVProductos.Columns["Grupo.Nombre"].Visible = col["CCategoria"];
            gVProductos.Columns["Estado"].Visible = col["CEstado"];            
            gVProductos.Columns["ExistenciaActual"].Visible = col["CExistenciaActual"];
            gVProductos.Columns["FotoProducto"].Visible = col["CFotoProducto"];
            gVProductos.Columns["PCAnterior"].Visible = col["CPCAnterior"];
        }
        public void SeleccionarMarcas()
        {
            var aux = (from a in metodo.Lista
                       where a.EdPVenta1 == true || a.EdPVenta2 == true
                       select a).ToList();
            gCProductos.DataSource = aux;
        }
        public void SeleccionarNoMarcas()
        {
            var aux = (from a in metodo.Lista
                       where a.EdPVenta1 == null || a.EdPVenta2 == null
                       select a).ToList();
            gCProductos.DataSource = aux;
        }
        public void ShowEdicionRapida()
        {
            if (gVProductos.RowCount > 0)
            {
                XfProductEditQuick formulario = null;
                formulario = XfProductEditQuick.Instance();
                formulario.unEvento += new XfProductEditQuick.Enviar(
                    delegate (GridControl t, int i)
                    { gCProductos.DataSource = t.DataSource; gVProductos.FocusedRowHandle = i; }
                    );
                formulario.dt = gCProductos;
                formulario.Show();
            }
        }
        public void ShowActivarColumnas()
        {
            PropiedadesColumna();
            XfProductoActivaColumnas mvc = new XfProductoActivaColumnas { col_=col};
            
            if (mvc.ShowDialog() == DialogResult.OK)
            {
                col = mvc.col_;
                CargarColumnas();
            }
        }
        public void ActivarProductoAuditoria()
        {
            XtraFormKardex mvc = new XtraFormKardex();
            mvc.Show();
        }
        public void ActivarProductoMovimiento()
        {
            dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }
        public void QuitarMarcasEdicionProducto()
        {
            var resp = new Repository<Producto>();
            foreach(var aux in resp.GetAll().Where(x=>x.EdNombre == true || x.EdPVenta1==true || x.EdPVenta2==true || x.EdPVenta3==true).ToList())
            {
                aux.EdNombre = null;
                aux.EdPVenta1 = null;
                aux.EdPVenta2 = null;
                aux.EdPVenta3 = null;
                resp.Update(aux);
            }
            Actualizar();
        }
        public void ShowEliminarProducto()
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            if (XtraMessageBox.Show("Esta por eliminar el producto: " + resp.Nombre, "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (resp.ExistenciaActual == 0 || resp.ExistenciaActual == null)
                {
                    var aux = new Repository<Producto>();
                    var tmp = aux.Find(x => x.IDProducto == resp.IDProducto);
                    tmp.Estado = "E";
                    aux.Update(tmp);
                }
                else
                    XtraMessageBox.Show("No es posible elimnar el Producto, proceso cancelado\nEn existencia Tine: ("+resp.ExistenciaActual+')' , "Informacion");
            }
                
        }
        public void ProductoExportar()
        {
            xtraSaveFileDialog1.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (xtraSaveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = xtraSaveFileDialog1.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gCProductos.ExportToXls(exportFilePath);
                        break;
                    case ".xlsx":
                        gCProductos.ExportToXlsx(exportFilePath);
                        break;
                    case ".rtf":
                        gCProductos.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gCProductos.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gCProductos.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gCProductos.ExportToMht(exportFilePath);
                        break;
                    default:
                        break;
                }

                if (File.Exists(exportFilePath))
                {
                    try
                    {
                        //Try to open the file and let windows decide how to open it.
                        System.Diagnostics.Process.Start(exportFilePath);
                    }
                    catch
                    {
                        String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                    MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Imprimir()
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gCProductos;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
        
        public void ShowInventarioInicial()
        {
            XtProductoInventario mvc = new XtProductoInventario();
            mvc.Show();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var resp = gVProductos.GetRow(gVProductos.FocusedRowHandle) as Producto;
            if (resp != null)
            {
                XfProductoTrasladoBodega mvc = new XfProductoTrasladoBodega { _producto = resp };
                mvc.ShowDialog();
            }
            
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
        public void Cerrar()
        {
            Close();
        }
        public void EnBodega()
        {
            XfProductBodega mvc = new XfProductBodega();
            mvc.ShowDialog();
        }

        private void gVProductos_DragObjectDrop(object sender, DragObjectDropEventArgs e)
        {
            GridColumn column = (e.DragObject as GridColumn);
            if(column.Visible == false)
            {
                var repository = new Repository<Usuarios>();
                var aux = repository.Find(x => x.IDUsuario == General.IdUsuario);

                aux.CCodBarra = gVProductos.Columns["CodBarra"].Visible;
                aux.CIvaA = gVProductos.Columns["Iva"].Visible;
                aux.CPv2A = gVProductos.Columns["PVenta2"].Visible;
                aux.CPv3A = gVProductos.Columns["PVenta3"].Visible;
                aux.CEqui1A = gVProductos.Columns["Equivalencia1"].Visible;
                aux.CEqui2A = gVProductos.Columns["Equivalencia2"].Visible;
                aux.CEqui3A = gVProductos.Columns["Equivalencia3"].Visible;
                aux.CUltimaVentaA = gVProductos.Columns["FechaUltimaVenta"].Visible;
                aux.CUltimaCompraA = gVProductos.Columns["FechaUltimaCompra"].Visible;
                aux.CPrecioAnteriorVenta1 = gVProductos.Columns["PVAnterior1"].Visible;
                aux.CPrecioAnteriorVenta2 = gVProductos.Columns["PVAnterior2"].Visible;
                aux.CPrecioAnteriorVenta3 = gVProductos.Columns["PVAnterior3"].Visible;
                aux.CNombreAnterior = gVProductos.Columns["NombreAnterior"].Visible;
                aux.CCodigoRapido = gVProductos.Columns["CodRapido"].Visible;
                aux.CExistenciaMinima = gVProductos.Columns["ExistenciaMinima"].Visible;
                aux.CMarca = gVProductos.Columns["Marca.NombreMarca"].Visible;
                aux.CCategoria = gVProductos.Columns["Grupo.Nombre"].Visible;
                aux.CEstado = gVProductos.Columns["Estado"].Visible;
                aux.CExistenciaActual = gVProductos.Columns["ExistenciaActual"].Visible;
                aux.CFotoProducto = gVProductos.Columns["FotoProducto"].Visible;
                aux.CPCAnterior = gVProductos.Columns["PCAnterior"].Visible;
                repository.Update(aux);

            }
            //if (column == null)
            //    return;

            //if (e.DropInfo.Index <= 100 && !column.Visible)
            //    gridView1.Columns.Remove(column);
        }
    }
}