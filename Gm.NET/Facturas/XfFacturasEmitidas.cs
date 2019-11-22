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
using Gm.NET.Formularios.Sales;
using Gm.Data;
using Gm.Entities;
using Gm.NET.Reportes;
using DevExpress.XtraReports.UI;

namespace Gm.NET
{
    public partial class XfFacturasEmitidas : DevExpress.XtraEditors.XtraForm
    {
        private List<FacturaImpresion> lista;
        List<FacturasReporte> _facturasReportes;
        public XfFacturasEmitidas()
        {
            InitializeComponent();
        }

        private void XfFacturasEmitidas_Load(object sender, EventArgs e)
        {
            gridControl1.Visible = false;
            gridControl1.Dock = DockStyle.Fill;
            gCVenta.Dock = DockStyle.Fill;
            function();
        }

        private void gVVenta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                gCDetalle.DataSource = CargarDetalle();
        }

        private void gVVenta_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            var estado = gVVenta.GetRowCellValue(e.RowHandle, gVVenta.Columns["Estado"]);
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

        private void btnImprimirFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void btnBorrarFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            //Obtenemos el detalle de la
            lista = new List<FacturaImpresion>();

            var detalle = new Repository<FacturaDetalle>();
            var cabecera = new Repository<Factura>();
            var cliente = new Repository<Cliente>();

            _facturasReportes = new  List<FacturasReporte>();

            var datos = cabecera.Search(x => x.Tipo == "V" && x.Estado == "A");
            repositoryItemProgressBar1.Maximum = datos.Count;
            progressBar.EditValue = 0;

            foreach (var row in datos)
            {
                var Costo = detalle.Search(x => x.IDFactura == row.IDFactura).Sum(x => x.Costo * x.Unidades).Value;
                var respCa = cabecera.Find(x => x.IDFactura == row.IDFactura);
                var respCl = cliente.Find(x => x.IDCliente == respCa.IDCliente);

                lista.Add(new FacturaImpresion
                {
                    IDFactura = row.IDFactura,
                    Numero = respCa.Numero,
                    Cliente = respCl.Nombre,
                    Dni = respCl.Cedula,
                    Direccion = respCl.Direccion,
                    Telefono = respCl.Telefono,
                    Fecha = respCa.Fecha,
                    Monto = Convert.ToSingle(Costo),
                    Estado = respCa.Estado,
                    Siclo = respCa.Siclo,
                });
                foreach(var fila  in detalle.Search(x => x.IDFactura == row.IDFactura)){
                    _facturasReportes.Add(new FacturasReporte
                    {
                        FacCabera = respCa,
                        FacDetalle = fila
                    });
                }
                progressBar.EditValue = Convert.ToInt16(progressBar.EditValue) + 1;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gCVenta.DataSource = lista.OrderByDescending(x=>x.IDFactura);
            gridControl1.DataSource = _facturasReportes;
        }

        private void gVDetalle_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            var estado = gVDetalle.GetRowCellValue(e.RowHandle, gVVenta.Columns["Siclo"]);
            if (estado != null)
            {
                //e.Appearance.ForeColor = Color.OrangeRed;
                switch (estado)
                {
                    case "D":
                        e.Appearance.ForeColor = Color.OrangeRed;
                        break;
                        //case "I":
                        //    //e.Appearance.ForeColor = Color.Green;
                        //    break;
                }
            }

        }

        public void function()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            if (!backgroundWorker1.IsBusy)
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                backgroundWorker1.RunWorkerAsync();
            }
        }
        private List<FacturaImpresion> CargarDetalle()
        {
            var detalle = new List<FacturaImpresion>();

            var factura = gVVenta.GetRow(gVVenta.FocusedRowHandle) as FacturaImpresion;
            var respDetalle = new Repository<FacturaDetalle>().Search(x => x.IDFactura == factura.IDFactura);

            dockPanel1.Text = string.Format("{0}->Detalle", factura.Numero);

            foreach (var row in respDetalle)
            {
                detalle.Add(new FacturaImpresion
                {
                    IDFactura = factura.IDFactura,
                    Numero = factura.Numero,
                    Cliente = factura.Cliente,
                    Dni = factura.Dni,
                    Direccion = factura.Direccion,
                    Telefono = factura.Telefono,
                    Fecha = factura.Fecha,
                    Estado = factura.Estado,
                    Producto = row.Producto.Nombre,
                    Cantidad = Convert.ToInt16(row.Unidades),
                    Precio = Convert.ToSingle(row.Costo),
                    Iva = Convert.ToInt16(row.Iva),
                    Siclo=row.Siclo
                });
            }
            return detalle;
        }
        public void MostrarDetalle()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            gCDetalle.DataSource = CargarDetalle();
            gridControl1.Visible = false;
            gCVenta.Visible = true;
        }
        public void ImprimirDocumento()
        {
            using (XfVentaOpciones mvc = new XfVentaOpciones())
            {
                if (mvc.ShowDialog() == DialogResult.OK)
                {
                    //Impresion de cabeceras
                    if (mvc.Opcion == 1)
                    {

                        List<FacturaImpresion> resp = new List<FacturaImpresion>();

                        for (int i = 0; i < gVVenta.RowCount; i++)
                        {
                            var aux = gVVenta.GetRow(i) as FacturaImpresion;
                            resp.Add(aux);
                        }

                        var ultimo = resp.OrderByDescending(x => x.Fecha).First();
                        foreach (var a in resp)
                            a.FechaFin = ultimo.Fecha;

                        xfrFacturaVentaCondenzado report = new xfrFacturaVentaCondenzado();
                        report.DataSource = resp.OrderBy(x => x.Fecha);
                        report.ShowPreview();
                    }
                    //Mostramos todo detalladamente
                    else
                    {
                        var tmp = new List<FacturaImpresion>();
                        for (int i = 0; i < gVVenta.RowCount; i++)
                        {
                            tmp.Add(gVVenta.GetRow(i) as FacturaImpresion);
                        }

                        var ultimo = tmp.OrderByDescending(x => x.Fecha).First();


                        List<FacturaImpresion> resp = new List<FacturaImpresion>();

                        //recorremos la grilla para sacar los detalles
                        for (int i = 0; i < gVVenta.RowCount; i++)
                        {
                            var factura = gVVenta.GetRow(i) as FacturaImpresion;
                            var respDetalle = new Repository<FacturaDetalle>().Search(x => x.IDFactura == factura.IDFactura);

                            //Obtenemos los detalles de la factura
                            foreach (var row in respDetalle)
                            {
                                resp.Add(new FacturaImpresion
                                {
                                    IDFactura = factura.IDFactura,
                                    Numero = factura.Numero,
                                    Cliente = factura.Cliente,
                                    Dni = factura.Dni,
                                    Direccion = factura.Direccion,
                                    Telefono = factura.Telefono,
                                    Fecha = factura.Fecha,
                                    Estado = factura.Estado,
                                    Producto = row.Producto.Nombre,
                                    Cantidad = Convert.ToInt16(row.Unidades),
                                    Precio = Convert.ToSingle(row.Costo),
                                    Iva = Convert.ToInt16(row.Iva),
                                    FechaFin = ultimo.Fecha
                                });
                            }
                        }
                        xfrFacturaVentaDetallada report = new xfrFacturaVentaDetallada();
                        report.DataSource = resp.OrderBy(x => x.Fecha);
                        report.ShowPreview();

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
                //gCVenta.DataSource = facturas.Where(x => x.Fecha.Value.ToString("MM/dd/yyyy") == Convert.ToDateTime(result).ToString("MM/dd/yyyy"));

            }
            catch (Exception) { }
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
                    gVVenta.ExportToXls(xtraSaveFileDialog1.FileName);
            }
        }
        public void ImprimirSeleccion()
        {
            if (ClaseAcceso.VentasRealizadasImprimirSeleccion_)
            {
                xfrFacturaImpresionSecundaria report = new xfrFacturaImpresionSecundaria();
                report.DataSource = CargarDetalle();
                report.ShowPreview();
            }
        }
        public void Borrar()
        {
            if (ClaseAcceso.VentasRealizadasEliminarFactura_)
            {
                var resp = gVVenta.GetRow(gVVenta.FocusedRowHandle) as FacturaImpresion;
                try
                {
                    var f1 = resp.Fecha.Value.ToString("MM/dd/yyyy");
                    var f2 = DateTime.Now.ToString("MM/dd/yyyy");

                    if (f1.Equals(f2))
                    {
                        if (XtraMessageBox.Show("Esta apunto de eliminar la Factura\ndesea continuar", "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string Error = null;
                            if (!DevolucionProducto._Eliminar(resp.IDFactura, out Error))
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
        public void Editar()
        {

        }
        public void Devolucion()
        {
            var factura = gVVenta.GetRow(gVVenta.FocusedRowHandle) as FacturaImpresion;
            try
            {
                var cabecera = new Repository<Factura>().Find(x => x.IDFactura == factura.IDFactura);

                XfDevolucion mvc = new XfDevolucion { _factura=cabecera};
                mvc.ShowDialog();
            }
            catch { }
            
        }
        public void DevolucionCambio()
        {
            XfDevolucionesFacturas mvc = new XfDevolucionesFacturas();
            mvc.ShowDialog();
        }
        public void Cerrar()
        {
            Close();
        }

        public void VerDetalle()
        {
            gCVenta.Visible = false;
            gridControl1.Visible = true;
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
        public void VerCabecera()
        {
            gCVenta.Visible = true;
            gridControl1.Visible = false;
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;
            if (keyData == Keys.F5)
            {
                function();
            }
            

            return Result;

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var factura = gVVenta.GetRow(gVVenta.FocusedRowHandle) as FacturaImpresion;
            try
            {
                var cabecera = new Repository<Factura>().Find(x => x.IDFactura == factura.IDFactura);

                XfFacturaDevolucion mvc = new XfFacturaDevolucion { _factura = cabecera };
                mvc.ShowDialog();
            }
            catch { }

        }

        private void gVVenta_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}