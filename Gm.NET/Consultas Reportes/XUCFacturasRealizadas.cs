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
using Gm.Entities;
using Gm.Data;
using Gm.NET.Reportes;
using DevExpress.XtraReports.UI;
using Gm.NET.Formularios.Sales;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    public partial class XUCFacturasRealizadas : DevExpress.XtraEditors.XtraUserControl
    {
        private List<FacturaImpresion> lista;
        public XUCFacturasRealizadas()
        {
            InitializeComponent();
        }
        void function()
        {
            var resp = new Repository<Kardex>().GetAll();

            List<string> keys = new List<string>();
            //recuperamos los numeros de factura para acceder a los clientes
            foreach (var aux in resp)
            {
                if (!keys.Contains(aux.IDFactura) && aux.IDFactura != null && aux.IDFactura.Contains("V"))
                    keys.Add(aux.IDFactura);
            }

            //Quito el caracter
            List<long> Id = new List<long>();
            foreach (var a in keys)
            {
                if (!Id.Contains(Convert.ToInt64(a.Replace("V", ""))))
                    Id.Add(Convert.ToInt64(a.Replace("V", "")));
            }

            //Obtenemos el detalle de la
            lista = new List<FacturaImpresion>();

            var detalle = new Repository<FacturaDetalle>();
            var cabecera = new Repository<Factura>();
            var cliente = new Repository<Cliente>();

            foreach (var row in Id)
            {
                var Costo = detalle.Search(x => x.IDFactura == row).Sum(x => x.Costo * x.Unidades).Value;
                var respCa = cabecera.Find(x => x.IDFactura == row);
                var respCl = cliente.Find(x => x.IDCliente == respCa.IDCliente);

                lista.Add(new FacturaImpresion
                {
                    IDFactura = row,
                    Numero = respCa.Numero,
                    Cliente = respCl.Nombre,
                    Dni = respCl.Cedula,
                    Direccion = respCl.Direccion,
                    Telefono = respCl.Telefono,
                    Fecha = respCa.Fecha,
                    Monto = Convert.ToSingle(Costo),
                    Estado = respCa.Estado,
                });
            }
            gCVenta.DataSource = lista;
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
                    Iva = Convert.ToInt16(row.Iva)
                });
            }
            return detalle;
        }
        public void MostrarDetalle()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            gCDetalle.DataSource = CargarDetalle();
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
                            //var aux = gVVenta.GetRow(i) as FacturaImpresion;
                            //aux.FechaFin = ultimo.Fecha;
                            //resp.Add(aux);
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

        private void XUCFacturasRealizadas_Load(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            btnImprimirTodo.Enabled = ClaseAcceso.VentasRealizadasImprimirTodo_;
            btnExportar.Enabled = ClaseAcceso.VentasExportar_;

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
            if (ClaseAcceso.VentasRealizadasImprimirSeleccion_)
            {
                xfrFacturaImpresionSecundaria report = new xfrFacturaImpresionSecundaria();
                report.DataSource = CargarDetalle();
                report.ShowPreview();
            }
            
        }

        private void btnBorrarFactura_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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
                        //Obtenemos los registros de Kardex
                        var Kardex = new Repository<Kardex>();
                        var Facturas = new Repository<Factura>();
                        var Productos = new Repository<Producto>();

                        var lis = Kardex.Search(x => x.IDFactura == string.Format("V{0}", resp.IDFactura));
                        //Devolvemos las cantidades a existencia actual
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
                            pro.ExistenciaActual = pro.ExistenciaActual + item.ProductoSale;
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MostrarDetalle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ImprimirDocumento();
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
                    gVVenta.ExportToXls(xtraSaveFileDialog1.FileName);
            }
        }
    }
}
