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
using Gm.NET.Reportes;
using DevExpress.XtraReports.UI;
using Gm.NET.Formularios.Sales;
using Gm.Data;
using Gm.NET.Formularios;
using DevExpress.XtraGrid.Views.Grid;

namespace Gm.NET.Compras
{
    public partial class XfComprasListado : DevExpress.XtraEditors.XtraForm
    {
        private List<EnRegistro> lista;
        private List<EnFactura> _ComprasCabecera;
        private List<FacturaDetalle> _ComprasDetalle;

        Repository<Factura> repositoryfacCabecera;
        Repository<FacturaDetalle> repositoryfacDetalle;

        //KardexBLL kardexBLL;

        public XfComprasListado()
        {
            InitializeComponent();
            repositoryfacCabecera = new Repository<Factura>();
            repositoryfacDetalle = new Repository<FacturaDetalle>();
        }

        private void XfComprasListado_Load(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            gCCompra.Dock = DockStyle.Fill;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Visible = false;
            Actualizar();
        }
        private void gVCompra_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CargaDetalle();
        }
        private void gVCompra_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Siclo"]);
                if (category == "F")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var datos = repositoryfacCabecera.Search(x => x.Tipo == "C" && x.Estado == "A");

            _ComprasCabecera = new List<EnFactura>();
            _ComprasDetalle = new List<FacturaDetalle>();

            repositoryItemProgressBar1.Maximum = datos.Count;
            progressBar.EditValue = 0;

            foreach (var compras in datos)
            {
                //cabecera de compras
                _ComprasCabecera.Add(new EnFactura
                {
                    IDFactura = compras.IDFactura,
                    Numero = compras.Numero,
                    IDCliente = compras.IDCliente,
                    Fecha = compras.Fecha,
                    Estado = compras.Estado,
                    FechaSistema = compras.FechaSistema,
                    IDTerminal = compras.IDTerminal,
                    //Flete = compras.Flete,
                    Flete = repositoryfacDetalle.Search(x => x.IDFactura == compras.IDFactura).Sum(x => x.FleteAplicado),
                    Observacion = compras.Observacion,
                    Cliente = compras.Cliente,
                    FacturaDetalle = compras.FacturaDetalle,
                    Siclo = compras.Siclo,
                    Monto = Convert.ToDouble(compras.FacturaDetalle.Sum(x => x.Costo * x.Unidades))
                });

                //detalle de compras
                _ComprasDetalle.AddRange(
                    repositoryfacDetalle.Search(x => x.IDFactura == compras.IDFactura && x.Movimiento != "D").ToList()
                );

                progressBar.EditValue = Convert.ToInt16(progressBar.EditValue) + 1;
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gCCompra.DataSource = _ComprasCabecera.OrderByDescending(x=>x.IDFactura);
            gridControl1.DataSource = _ComprasDetalle;
        }
        public void Actualizar()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
        }
        public void CargaDetalle()
        {
            try
            {
                var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as Factura;

                dockPanel1.Text = string.Format("{0} -> Detalle", resp.Numero);
                repositoryfacDetalle = new Repository<FacturaDetalle>();

                gCDetalle.DataSource = repositoryfacDetalle.Search(x => x.IDFactura == resp.IDFactura && x.Movimiento != "D").ToList();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
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
        public void Imprimir()
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
                gCCompra.DataSource = _ComprasCabecera.Where(x => x.Fecha.Value.ToString("MM/dd/yyyy") == Convert.ToDateTime(result).ToString("MM/dd/yyyy"));

            }
            catch (Exception) { }
        }
        public void Detalle()
        {
            
            CargaDetalle();
            gCCompra.Visible = true;
            gridControl1.Visible = false;
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
        }
        public void Editar()
        {
            var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as EnFactura;
            if (resp.Siclo == "F" || resp.Siclo == "A")
                XtraMessageBox.Show("La Compra no se puede modificar ya tiene productos vendidos");
            else
            {
                XfCompraEditar mvc = new XfCompraEditar { IdFactura = resp.IDFactura };
                mvc.Show();
            }
        }
        public void Eliminar()
        {
            if (ClaseAcceso.ComprasRealizadasEliminarCompra_)
            {
                var resp = gVCompra.GetRow(gVCompra.FocusedRowHandle) as EnFactura;
                try
                {
                    var f1 = resp.Fecha.Value.ToString("MM/dd/yyyy");
                    var f2 = DateTime.Now.ToString("MM/dd/yyyy");
                    if (f1.Equals(f2))
                    {
                        if (XtraMessageBox.Show("Esta apunto de eliminar la Factura\ndesea continuar", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string Error = null;
                            if (!DevolucionProducto._EliminarCompra(resp.IDFactura, out Error))
                                throw new Exception(Error);
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
        public void ImprimirDocumento()
        {
            if (ClaseAcceso.ComprasRealizadasImprimirSeleccion_)
            {
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
        public void Exportar()
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
        public void Cerrar()
        {
            Close();
        }
        public void Cabeceras()
        {
            gCCompra.Visible = true;
            gridControl1.Visible = false;
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
        public void Detalles()
        {
            gCCompra.Visible = false;
            gridControl1.Visible = true;
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
    }
}