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
using Gm.Data;
using Gm.Entities;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using Gm.NET.Formularios.Ventas;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace Gm.NET.Formularios
{
    public partial class XfCuentasXCobrar : DevExpress.XtraEditors.XtraForm
    {
        List<CreditoBLL> lista;
        public XfCuentasXCobrar()
        {
            InitializeComponent();
            
        }
        public void Actualizar()
        {

            CreditoBLL datos = new CreditoBLL();
            lista= datos.CuentasXCobrar();
            gCCuentasCobrar.DataSource = lista;

        }

        private void xfAbonoAdmin_Load(object sender, EventArgs e)
        {
            Actualizar();
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            btnEditarAbono.Enabled = ClaseAcceso.CuentasporCobrarEditarAbono_;
            btnEliminarAbono.Enabled = ClaseAcceso.CuentasporCobrarEliminarAbono_;
        }
        public void ShowAbonar()
        {
            try
            {
                var resp = gVCuentasCobrar.GetRow(gVCuentasCobrar.FocusedRowHandle) as CreditoBLL;
                if (resp.SaldoActual > 0)
                {
                    var resul = XtraInputBox.Show("Ingrese Abono", "Factura->" + resp.NumFactura, "0,00");
                    if (!string.IsNullOrEmpty(resul))
                    {
                        decimal valor = 0;
                        if (decimal.TryParse(resul, out valor) && Convert.ToDecimal(valor) > 0 && Convert.ToDecimal(valor) <= resp.SaldoActual)
                        {

                            CreditoBLL aux = new CreditoBLL();
                            try
                            {
                                if (!aux.Save(new Gm.Entities.Credito
                                {
                                    IDCredito = new Repository<Credito>().GetAll().Count + 1,
                                    IDFactura = resp.IDFactura,
                                    IDUsaurio = General.IdUsuario,
                                    Fecha = DateTime.Now,
                                    Abona = Convert.ToDecimal(resul),
                                    State = true,
                                    Estado = "A"
                                }))
                                    throw new Exception(aux.Error);

                                if (!aux.Update(Convert.ToDecimal(resp.Saldo), Convert.ToInt32(resp.IDFactura)))
                                    throw new Exception(aux.Error);

                                Actualizar();

                            }
                            catch (Exception ex)
                            {
                                this.Hide();
                                XtraMessageBox.Show(ex.Message);
                                this.Visible = true;
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Valores no permitidos, revise e intente nueva mente");
                        }
                    }

                    //using (xfAbono mvc = new xfAbono { Saldo = Convert.ToDecimal(resp.SaldoActual) })
                    //{
                    //    if (mvc.ShowDialog() == DialogResult.OK)
                    //    {
                    //        CreditoBLL aux = new CreditoBLL();
                    //        try
                    //        {
                    //            if (!aux.Save(new Gm.Entities.Credito
                    //            {
                    //                IDCredito = new Repository<Credito>().GetAll().Count + 1,
                    //                IDFactura = resp.IDFactura,
                    //                IDUsaurio = General.IdUsuario,
                    //                Fecha = DateTime.Now,
                    //                Abona = mvc.Abonar,
                    //                State = true
                    //            }))
                    //                throw new Exception(aux.Error);

                    //            if (!aux.Update(Convert.ToDecimal(resp.Saldo), Convert.ToInt32(resp.IDFactura)))
                    //                throw new Exception(aux.Error);

                    //            Actualizar();

                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            this.Hide();
                    //            XtraMessageBox.Show(ex.Message);
                    //            this.Visible = true;
                    //        }
                    //    }
                    //}
                }
            }
            catch (Exception) { }
            
        }
        public void ShowHistorial()
        {

            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            CargaGrid();
        }
        public void ShowVistaPrevia()
        {
            dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            CargaDetalle();
        }
        private void CargaGrid()
        {
            var resp = gVCuentasCobrar.GetRow(gVCuentasCobrar.FocusedRowHandle) as CreditoBLL;
            if (resp != null)
            {
                long key = Convert.ToInt64(resp.IDFactura);
                var credito = new Repository<Credito>().Search(x => x.IDFactura == key && x.State==true);
                gCCuentasCobrarHistorial.DataSource = credito;
            }
            
        }
        private void CargaDetalle()
        {
            var resp = gVCuentasCobrar.GetRow(gVCuentasCobrar.FocusedRowHandle) as CreditoBLL;
            if (resp != null)
            {
                long key = Convert.ToInt64(resp.IDFactura);
                var detalle = new Repository<FacturaDetalle>().Search(x => x.IDFactura == key);
                gCDetalle.DataSource = detalle;
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                CargaGrid();

            if (dockPanel2.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                CargaDetalle();
        }

        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            var row = gVCuentasCobrarHistorial.GetRow(gVCuentasCobrarHistorial.FocusedRowHandle) as Credito;
            if (row!=null)
            {
                var resp = new Repository<Credito>();
                var aux = resp.Find(x=>x.IDCredito == row.IDCredito);
                if (XtraMessageBox.Show("Desea eliminar este registro","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    aux.State = false;
                    resp.Update(aux);
                    CargaGrid();
                }
                
            }
        }

        private void btnEditarAbono_Click(object sender, EventArgs e)
        {
            var row = gVCuentasCobrarHistorial.GetRow(gVCuentasCobrarHistorial.FocusedRowHandle) as Credito;
            if (row != null)
            {
                var resp = new Repository<Credito>();
                var aux = resp.Find(x => x.IDCredito == row.IDCredito);
                var result = XtraInputBox.Show("Ingrese el valor:", "Editar Abono", "0,00");
                int ejem = 0;
                
                if (int.TryParse(result, out ejem))
                {
                    var data = gVCuentasCobrarHistorial.DataSource as List<Credito>;

                    var suma = data.Sum(x => x.Abona);

                    if (Convert.ToDecimal(result) > 0 && Convert.ToDecimal(result) <= suma)
                    {
                        aux.Abona = Convert.ToDecimal(result);
                        resp.Update(aux);
                        CargaGrid();
                    }
                    else
                        XtraMessageBox.Show("Valores no permitidos, revise e intente nueva mente");

                }
                //else
                //{
                //    XtraMessageBox.Show("Caracteres invalidos");
                //}
                
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
                gCCuentasCobrar.DataSource = lista.Where(x => x.Fecha.Value.ToString("MM/dd/yyyy") == Convert.ToDateTime(result).ToString("MM/dd/yyyy"));

            }
            catch (Exception) { }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Form.Icon = this.Icon;
        }
        public void Vencidos()
        {
            try
            {
                var result = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                gCCuentasCobrar.DataSource =
                    lista.Where(x => x.FechaVence != null &&
                    x.FechaVence.Value <= result
                    ).ToList();
            }
            catch (Exception) { }
            
        }
        public void DocumentoExportar()
        {
            xtraSaveFileDialog1.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
            if (xtraSaveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string exportFilePath = xtraSaveFileDialog1.FileName;
                string fileExtenstion = new FileInfo(exportFilePath).Extension;

                switch (fileExtenstion)
                {
                    case ".xls":
                        gCCuentasCobrar.ExportToXls(exportFilePath);
                        break;
                    case ".xlsx":
                        gCCuentasCobrar.ExportToXlsx(exportFilePath);
                        break;
                    case ".rtf":
                        gCCuentasCobrar.ExportToRtf(exportFilePath);
                        break;
                    case ".pdf":
                        gCCuentasCobrar.ExportToPdf(exportFilePath);
                        break;
                    case ".html":
                        gCCuentasCobrar.ExportToHtml(exportFilePath);
                        break;
                    case ".mht":
                        gCCuentasCobrar.ExportToMht(exportFilePath);
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
        private void gVCuentasCobrar_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Estado"]);
                if (category == "T")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    e.HighPriority = true;
                }
            }
        }
        public void CambiarCliente()
        {
            var aux = gVCuentasCobrar.GetRow(gVCuentasCobrar.FocusedRowHandle) as CreditoBLL;
            XfCuentasXCobrarEditarCliente mvc = new XfCuentasXCobrarEditarCliente {
                factura_ = aux.IDFactura,
                cliente_ = aux.IdCliente,
                Text = aux.Nombre};
            if (mvc.ShowDialog() == DialogResult.OK)
                Actualizar();
        }
        public void Imprimir()
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gCCuentasCobrar;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
        public void VistaPrevia()
        {
            var resp1 = gVCuentasCobrar.GetRow(gVCuentasCobrar.FocusedRowHandle) as CreditoBLL;
            try
            {
                long key = Convert.ToInt64(resp1.IDFactura);
                var credito = new Repository<Credito>().Search(x => x.IDFactura == key && x.State == true);
                var fa = new Repository<Factura>().Find(x => x.IDFactura == resp1.IDFactura);
                var fad = new Repository<FacturaDetalle>().Search(x => x.IDFactura == resp1.IDFactura).Sum(x => x.Costo * x.Unidades);
                var resp = new List<CreditoBLL>();
                foreach (var row in credito)
                {
                    resp.Add(new CreditoBLL
                    {
                        IdCliente = row.IDCredito,
                        Nombre = fa.Cliente.Nombre,
                        Factura = fa,
                        Abona = row.Abona,
                        Fecha = row.Fecha,
                        SaldoActual = fad,
                        NumFactura = fa.Numero
                    });
                }
                if (resp.Count > 0)
                {
                    //XtraReport report = new XtraReport();
                    string path = Directory.GetCurrentDirectory();

                    // A temporary path to save a report to.  
                    string filePath = string.Format("{0}\\Reportes\\ReporteHistorialPagos.repx", path);

                    XtraReport report = XtraReport.FromFile(filePath, true);
                    ReportPrintTool tool = new ReportPrintTool(report);
                    report.DataSource = resp;
                    tool.ShowRibbonPreviewDialog();
                }
            }
            catch { }
            
        }
        public void Reporte()
        {
            //XtraReport report = new XtraReport();
            var credito = new List<CreditoBLL>();
            var resp = new Repository<Credito>();
            foreach(var a in (List<CreditoBLL>)gCCuentasCobrar.DataSource)
            {
                var aux = (from c in resp.GetAll()
                           where c.IDFactura == a.IDFactura
                           select new CreditoBLL
                           {
                               IdCliente = a.IdCliente,
                               IDCredito = c.IDCredito,
                               IDFactura = a.IDFactura,
                               Nombre = a.Nombre,
                               Saldo = a.Saldo,
                               SaldoActual = a.SaldoActual,
                               Abona = c.Abona,
                               Fecha = c.Fecha,
                               NumFactura = a.NumFactura,
                               
                           }).ToList();
                credito.AddRange(aux);
            }

            string path = Directory.GetCurrentDirectory();

            // A temporary path to save a report to.  
            string filePath = string.Format("{0}\\Reportes\\ReporteCuentasXCobrar.repx", path);

            XtraReport report = XtraReport.FromFile(filePath, true);
            ReportPrintTool tool = new ReportPrintTool(report);
            report.DataSource = credito;
            tool.ShowRibbonPreviewDialog();
        }
        public void Cerrar()
        {
            Close();
        }

    }
}