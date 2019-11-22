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

using Gm.Core;
using Gm.NET.Reportes;
using DevExpress.XtraReports.UI;
using Gm.NET.Formularios.Sales;
using Gm.Entities;
using Gm.Data;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    public partial class XUCComprasRealizadas : DevExpress.XtraEditors.XtraUserControl
    {
        private List<EnRegistro> lista;
        private List<EnFactura> facturas;

        public XUCComprasRealizadas()
        {
            InitializeComponent();
        }

        void function()
        {
            try
            {
                var resp = new KardexBLL();
                
                facturas = resp.enFacturas;
                gCCompra.DataSource = facturas;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        public void CargarDetalle()
        {
            try
            {
                if (dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                {
                    var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as Factura;

                    dockPanel1.Text = string.Format("{0} -> Detalle", resp.Numero);
                    lista = new DistribucionFlete().GetDistribuir(resp);
                    gCDetalle.DataSource = lista;
                }
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }
        }

        //Impresionde Todo el documentos
        private List<EnRegistro> PreparadoImpresion()
        {
            lista = null;
            var aux = new List<EnRegistro>();

            for (int i = 0; i < gVCompra.RowCount; i++)
            {
                var resp = gVCompra.GetRow(i) as Factura;

                lista = (from row in new FacturaBLL().FacturaDetalle(Convert.ToInt32(resp.IDFactura))
                         select new EnRegistro
                         {
                             IDFactura = Convert.ToInt32(row.IDFactura),
                             IDProduct = Convert.ToInt32(row.IDProducto),
                             Name = row.Producto.Nombre,
                             PrecioUnitario = Convert.ToDecimal(row.Costo),
                             Cantidad = row.Unidades,
                             IdKardex = Convert.ToInt32(row.IDKardex),
                             Fecha = resp.Fecha,
                             Numfactura = resp.Numero
                         }).ToList();

                decimal? subTotal = lista.Sum(x => x.PrecioUnitario * x.Cantidad);

                for (int ii = 0; ii < lista.Count; ii++)
                {
                    lista[ii].Canculos(resp.Flete, Convert.ToDecimal(subTotal));
                    lista[ii].ObtenerIva(lista[ii].IdKardex, lista[ii].IDProduct, resp.IDFactura);
                }
                aux.AddRange(lista);
            }
            return aux;

        }
        public void ImprimirDocumento()
        {
            using (XfCompraOpciones mvc = new XfCompraOpciones())
            {
                if (mvc.ShowDialog() == DialogResult.OK)
                {
                    if (mvc.Opcion == 1)
                    {
                        var aux = new List<EnFactura>();
                        for (int i = 0; i < gVCompra.RowCount; i++)
                        {
                            var item = gVCompra.GetRow(i) as EnFactura;
                            aux.Add(item);
                        }
                        var ultimo = aux.OrderByDescending(x => x.Fecha).First();

                        foreach (var a in aux)
                            a.FechaFin = Convert.ToDateTime(ultimo.Fecha);

                        xfrComprasCondenzado report2 = new xfrComprasCondenzado();
                        report2.DataSource = aux.OrderBy(x => x.Fecha);
                        report2.ShowPreview();

                    }
                    else
                    {
                        var respLista = new List<CompraReporte>();
                        for (int j = 0; j < gVCompra.RowCount; j++)
                        {
                            var lista1 = new List<EnRegistro>();
                            var resp = gVCompra.GetRow(j) as EnFactura;

                            //dockPanel2.Text = string.Format("{0} -> Detalle", resp.Numero);
                            lista1 = (from row in new FacturaBLL().FacturaDetalle(Convert.ToInt32(resp.IDFactura))
                                      select new EnRegistro
                                      {
                                          IDFactura = Convert.ToInt32(row.IDFactura),
                                          IDProduct = Convert.ToInt32(row.IDProducto),
                                          Name = row.Producto.Nombre,
                                          PrecioUnitario = Convert.ToDecimal(row.Costo),
                                          Cantidad = row.Unidades,
                                          IdKardex = Convert.ToInt32(row.IDKardex)
                                      }).ToList();

                            decimal? subTotal = lista1.Sum(x => x.PrecioUnitario * x.Cantidad);

                            for (int i = 0; i < lista1.Count; i++)
                            {
                                lista1[i].Canculos(resp.Flete, Convert.ToDecimal(subTotal));
                                lista1[i].ObtenerIva(lista1[i].IdKardex, lista1[i].IDProduct, resp.IDFactura);
                            }
                            //poblamos con los datos de la cabecera
                            foreach (var item in lista1)
                            {
                                respLista.Add(new CompraReporte
                                {
                                    Idfactura = resp.IDFactura,
                                    Numero = resp.Numero,
                                    Fecha = resp.Fecha,
                                    Monto = Convert.ToDecimal(resp.Monto),
                                    Flete = resp.Flete,
                                    Cliente = resp.Cliente.Nombre,
                                    Cedula = resp.Cliente.Cedula,
                                    Telefono = resp.Cliente.Telefono,
                                    FleteAplicado = item.Flete,
                                    Detalle = item.Name,
                                    Cantidad = item.Cantidad,
                                    PrecioUnitario = item.PrecioUnitario,
                                    Iva = item.Iva,
                                    SubTotal = item.SubTotal,
                                    Inversion = item.Invercion,
                                    PrecioReal = item.PrecioReal
                                });
                            }
                        }

                        var ultimo = respLista.OrderByDescending(x => x.Fecha).First();
                        foreach (var a in respLista)
                            a.FechaFin = ultimo.Fecha;

                        xfrComprasDetallados report2 = new xfrComprasDetallados();
                        report2.DataSource = respLista.OrderBy(x => x.Fecha);
                        report2.ShowPreview();
                        //xfrComprasDetallados report2 = new xfrComprasDetallados();
                        //report2.DataSource = rep;
                        //report2.ShowPreview();
                    }
                }
            }
        }
        public void Fechas()
        {
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            // set required Input Box options 
            args.Caption = "Fecha";
            args.Prompt = "Seleccione Fecha";
            args.DefaultButtonIndex = 0;
            //args.Showing += Args_Showing;
            // initialize a DateEdit editor with custom settings 
            DateEdit editor = new DateEdit();
            editor.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            editor.Properties.Mask.EditMask = "MMMM d, yyyy";
            args.Editor = editor;
            // a default DateEdit value 
            args.DefaultResponse = DateTime.Now.Date.AddDays(3);
            // display an Input Box with the custom editor 
            try
            {
                var result = XtraInputBox.Show(args).ToString();
                gCCompra.DataSource = facturas.Where(x => x.Fecha.Value.ToString("MM/dd/yyyy") == Convert.ToDateTime(result).ToString("MM/dd/yyyy"));

            }
            catch (Exception) { }
        }

        private void XUCComprasRealizadas_Load(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;

            btnImprimirTodo.Enabled = ClaseAcceso.ComprasRealizadasImprimirTodo_;
            btnExportar.Enabled = ClaseAcceso.ComprasExportar_;
            function();
            //using (FrmCargaComponentes frm = new FrmCargaComponentes(function))
            //{
            //    frm.ShowDialog(this);
            //}
        }

        private void gVCompra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CargarDetalle();
        }
        //Calculos que se realiza para imprimir
        private void btnSubir_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ClaseAcceso.ComprasRealizadasImprimirSeleccion_) { 
            var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as EnFactura;


            var aux = PreparadoImpresion();
            var item = aux.FindAll(x => x.IDFactura == resp.IDFactura);
            foreach (var rowx in item)
            {
                rowx.enFactura = resp;
            }

            xfrResumenCompras report2 = new xfrResumenCompras();
            report2.DataSource = item;
            report2.ShowPreview();
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void gVCompra_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var estado = gVCompra.GetRowCellValue(e.RowHandle, gVCompra.Columns["Siclo"]);
            switch (estado)
            {
                case "E":
                    e.Appearance.ForeColor = Color.OrangeRed;
                    break;
                case "I":
                    //e.Appearance.ForeColor = Color.Green;
                    break;
            }
        }
        private void btnBorrar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ClaseAcceso.ComprasRealizadasEliminarCompra_) { 
            var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as EnFactura;
            try
            {
                var f1 = resp.Fecha.Value.ToString("MM/dd/yyyy");
                var f2 = DateTime.Now.ToString("MM/dd/yyyy");
                if (f1.Equals(f2))
                {
                    if (XtraMessageBox.Show("Esta apunto de eliminar la Factura\ndesea continuar", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //Obtenemos los registros de Kardex
                        var Kardex = new Repository<Kardex>();
                        var Facturas = new Repository<Factura>();
                        var Productos = new Repository<Producto>();

                        var f = string.Format("C{0}", resp.IDFactura);
                        var lis = Kardex.Search(x => x.IDFactura == f);
                        //Quitamos las cantidades a existencia actual
                        foreach (var item in lis)
                        {
                            item.Siclo = "E";
                            Kardex.Update(item);

                            //actualizamos la factura
                            var fac = Facturas.Find(x => x.IDFactura == resp.IDFactura);
                            fac.Estado = "E";
                            Facturas.Update(fac);

                            //Devolvemos las cantidades a producto
                            var pro = Productos.Find(x => x.IDProducto == item.IDProducto);
                            pro.ExistenciaActual = pro.ExistenciaActual - item.ProductoSale;
                            Productos.Update(pro);
                        }
                    }
                }
                else
                    throw new Exception("Accion no permitida, no es posible eliminar la factura\nen una fecha distinta a la generada");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            xtraSaveFileDialog1.FileName = string.Format("File");

            xtraSaveFileDialog1.Filter = "XLS Files (*.xls)|*.xls";
            xtraSaveFileDialog1.OverwritePrompt = true;

            if (xtraSaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (gCDetalle.Visible)
                    gCDetalle.ExportToXls(xtraSaveFileDialog1.FileName);
                else
                    gCCompra.ExportToXls(xtraSaveFileDialog1.FileName);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            CargarDetalle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ImprimirDocumento();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as EnFactura;
            
            XfCompraEditar mvc = new XfCompraEditar { IdFactura = resp.IDFactura};
            mvc.Show();
        }
    }
}
