namespace Gm.NET.Formularios
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Linq;
    using DevExpress.XtraEditors;
    using Gm.Core;
    using Gm.Data;
    using Gm.Entities;
    using System.Drawing;
    using DevExpress.XtraGrid.Columns;
    using Gm.NET.Formularios.Ventas;
    using System.IO;
    using System.Xml.Serialization;

    public partial class XfComprasPlantilla : DevExpress.XtraEditors.XtraForm
    {
        List<PurchasesAbvance> detalle;
        Cliente cliente;

        XfCompraProductoAyuda productoform;
        XfCompraProveedorBuscar clienteform;

        private Color ColorNuevo;
        private Color ColorGrabado;

        string archivoTmp = Environment.CurrentDirectory + "\\v0000d.xml";
        public XfComprasPlantilla()
        {
            InitializeComponent();
            ColorNuevo = sPCentral.BackColor;
            ColorGrabado = Color.FromArgb(255, 192, 192);
        }

        public void NewCompra()
        {

            detalle = new List<PurchasesAbvance>();
            gCProducto.DataSource = detalle;

            cliente = new Repository<Cliente>().Find(x => x.IDCliente == 1);

            txtNumFactura.EditValue = string.Empty;
            txtCodigo.EditValue = cliente.IDCliente;
            txtRuc.EditValue = string.Format("DNI: {0}", cliente.Cedula);
            txtRazonSocial.EditValue = string.Format("PRO: {0}", cliente.Nombre);
            txtDireccion.EditValue = string.Format("DIR: {0}", cliente.Direccion);
            txtTelefono.EditValue = string.Format("TELF: {0}", cliente.Telefono);
            txtFlete.Text = string.Empty;
            txtSTconIva.EditValue = "0,00";
            txtSTsinIva.EditValue = "0,00";
            txtIvaCalculado.EditValue = "0,00";
            txtTotal.Text = "0,00";
            barButtonItem2.Caption = String.Format("N:{0}", detalle.Count);

            var par = new Repository<Parametros>().Find(x => x.Station == 1);
            barButtonItem6.Caption = string.Format("IVA {0}%:", Convert.ToInt16(par.Iva));
            barButtonItem5.Caption = string.Format("SUB. TOTAL IVA {0}%:", Convert.ToInt16(par.Iva));
            sPCentral.BackColor = ColorNuevo;
            dtFecha.DateTime = DateTime.Now;
        }
        private void xfPurchasesAbvance_Load(object sender, EventArgs e)
        {
            NewCompra();
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            Recuperado();
        }
        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            //try
            //{
            //    if (sPCentral.BackColor == ColorGrabado)
            //        throw new Exception();

            //    switch (e.KeyCode)
            //    {
            //        case Keys.Enter:
            //            if (!string.IsNullOrEmpty(txtCodBarras.Text))
            //            {
            //                var resp = new Repository<Producto>().Find(x => x.CodBarra == txtCodBarras.Text);
            //                if (resp != null)
            //                {
            //                    AddRow(new AyudaCore
            //                    {
            //                        IDProducto = resp.IDProducto,
            //                        Nombre = resp.Nombre,
            //                        MedidaMetrica = resp.MedidaMetrica,
            //                        Iva = true,
            //                    });
            //                    gCProducto.RefreshDataSource();
            //                }
            //                else
            //                {
            //                    txtCodBarras.Text = string.Empty;
            //                    txtCodBarras.Focus();
            //                    XtraMessageBox.Show("Codigo no existe");
            //                }
            //            }
            //            break;
            //    }
            //}
            //catch (Exception) { }
            
        }        
        private void xfPurchasesAbvance_SizeChanged(object sender, EventArgs e)
        {
            sPCentral.Location = CenterForm.Function(this.Width, sPCentral.Width);
        }
        private void textoActualiza(object sender, KeyEventArgs e)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                TextEdit aux = (TextEdit)sender;

                if (!string.IsNullOrEmpty(aux.Text))
                {
                    if (e.KeyCode == Keys.Enter)
                        gVProducto.FocusedColumn = gVProducto.Columns[4];
                }
            }
            catch (Exception) { }
            
        }
        private void gVProducto_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            Actualiza();
        }
        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit check = (CheckEdit)sender;
            var resp = gVProducto.GetRow(gVProducto.FocusedRowHandle) as PurchasesAbvance;
            resp.Estado = check.Checked;
            Actualiza();
        }
        private void textoActualiza1(object sender, KeyEventArgs e)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                TextEdit aux = (TextEdit)sender;

                if (!string.IsNullOrEmpty(aux.Text))
                {
                    int fila = gVProducto.FocusedRowHandle;
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (gVProducto.RowCount > fila)
                        {
                            gVProducto.FocusedRowHandle = fila + 1;
                            gVProducto.FocusedColumn = gVProducto.Columns[3];
                        }
                    }
                }
            }
            catch (Exception) { }
            
        }

        public void AddRow(AyudaCore arg)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                if (!detalle.Exists(x => x.IDProducto == arg.IDProducto && x.Iva == arg.Iva))
                {
                    detalle.Add(
                    new PurchasesAbvance
                    {
                        IDProducto = arg.IDProducto,
                        Nombre = arg.Nombre,
                        Cantidad = 0,
                        PrecioUnitario = 0,
                        Medida = arg.MedidaMetrica.Name,
                        IdMedida = arg.MedidaMetrica.IdMedidaMetrica,
                        Marca = (arg.Marca == null) ? "" : arg.Marca.NombreMarca,
                        Iva = Convert.ToBoolean(arg.Iva),
                    }
                    );

                    gCProducto.DataSource = detalle;
                    gCProducto.RefreshDataSource();

                    Actualiza();
                }
                else
                {
                    XtraMessageBox.Show("Producto repetido", "Alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtCodBarras.SelectAll();
                    //txtCodBarras.Focus();
                }
            }
            catch (Exception) { }
            
        }
        private void Actualiza()
        {
            //total de la venta
            var Total = detalle.Sum(x => x.PrecioTotal);
            var SubT1 = detalle.Where(x => x.Iva == false).Sum(x => x.PrecioTotal);
            var Iva = detalle.Sum(x => x.CalculoIva);
            var tmpSubT2 = detalle.Where(x => x.Iva == true).Sum(x => x.PrecioTotal);
            var SubT2 = tmpSubT2 - Iva;
            var fleteTotal = detalle.Sum(x => x.Flete);

            txtSTsinIva.EditValue = string.Format("{0:0.00}", SubT1);
            txtIvaCalculado.EditValue = string.Format("{0:0.00}", Iva);
            txtSTconIva.EditValue = string.Format("{0:0.00}", SubT2);
            txtTotal.Text = string.Format("{0:0.00}", Total);
            txtFlete.Text = string.Format("{0:0.00}",fleteTotal);
            barButtonItem2.Caption = String.Format("N:{0}", detalle.Count);
            Respaldo();
        }
        
        public void QuitarFila()
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                var resp = gVProducto.GetRow(gVProducto.FocusedRowHandle) as PurchasesAbvance;
                detalle.Remove(resp);
                Actualiza();
                gCProducto.RefreshDataSource();
            }
            catch (Exception) { }
            
        }
        public void GuardarCompra()
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception("La compra se encuentra Guardada, no es permitido realizar\nnuevamente esta accion");
                if (detalle.Count == 0)
                    throw new Exception("No hay registros para guardar");
                if (cliente.IDCliente == 1)
                    throw new Exception("Favor cambien el dato de proveedor");
                if (string.IsNullOrEmpty(txtNumFactura.Text))
                    throw new Exception("Favor ingrese el numero de factura");

                XfGrabadoCompra grabadoCompra = new XfGrabadoCompra { detalle_ = detalle};
                
                if(grabadoCompra.ShowDialog()==DialogResult.OK)
                {
                    Int32 idP = Convert.ToInt32(txtCodigo.Text);
                    var cliente = new Repository<Cliente>().Find(x => x.IDCliente == idP);

                    FacturaBLL purchases = new FacturaBLL();

                    if (!purchases.CrearFactura(cliente, dtFecha.DateTime, txtNumFactura.Text, detalle, string.IsNullOrEmpty(txtFlete.Text)?0:Convert.ToDecimal(txtFlete.Text), 'C'))
                        throw new Exception(purchases.error);

                    else
                    {
                        sPCentral.BackColor = ColorGrabado;
                        XtraMessageBox.Show("Gracias, Guardado Correcto","Informativo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        File.Delete(archivoTmp);
                        if (dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                            CargarRegistros();
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void ShowProveedorBuscar()
        {
            clienteform = new XfCompraProveedorBuscar();
            clienteform.DatosCliente += new XfCompraProveedorBuscar.Enviar(ChangeProveedor);
            clienteform.ShowDialog();
        }
        public void ShowProveedorCrear()
        {
            XfComprasProveedor mvc = new XfComprasProveedor();
            mvc.ShowDialog();
        }
        public void ShowProveedorEditar()
        {
            XfComprasProveedorEditar mvc = new XfComprasProveedorEditar { cliente_  = cliente};
            if (mvc.ShowDialog() == DialogResult.OK)
                ChangeProveedor(mvc.cliente_);
        }
        public void ChangeProveedor(Cliente cliente)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                this.cliente = cliente;
                txtCodigo.Text = string.Format("{0}", this.cliente.IDCliente);
                txtRuc.Text = string.Format("DNI: {0}", this.cliente.Cedula);
                txtRazonSocial.Text = string.Format("PRO: {0}", this.cliente.Nombre);
                txtDireccion.Text = string.Format("DIR: {0}", this.cliente.Direccion);
                txtTelefono.Text = string.Format("TEF: {0}", this.cliente.Telefono);
            }
            catch (Exception)
            {

            }
            
        }
        public void ShowProductoCrear()
        {
            XfProductNew mvc = new XfProductNew();
            mvc.ShowDialog();
        }
        public void ShowProductoBuscar()
        {
            productoform = new XfCompraProductoAyuda();
            productoform.DatosProducto += new XfCompraProductoAyuda.Enviar(AddRow);
            productoform.ShowDialog();

        }
        public void ShowProductoEditar()
        {
            if (detalle.Count > 0)
            {
                var resp = gVProducto.GetRow(gVProducto.FocusedRowHandle) as PurchasesAbvance;
                var aux = new Repository<Producto>().Find(x => x.IDProducto == resp.IDProducto);
                XfComprasProductoEditar mvc = new XfComprasProductoEditar { producto_ = aux };
                if (mvc.ShowDialog() == DialogResult.OK)
                {
                    resp.CodBarras = mvc.producto_.CodBarra;
                    resp.Nombre = mvc.producto_.Nombre;
                    
                }
            }
        }
        private void CargarRegistros()
        {
            var resp = (from a in new Repository<Kardex>().GetAll()
                        where a.IDFactura != null && a.IDFactura.Contains("C") && a.Fecha.Value.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")
                        select a).ToList();

            //Almacenamos facturas no repetidas
            List<string> claves = new List<string>();
            foreach (var a in resp)
            {
                if (a.IDFactura.Contains("C") && !claves.Contains(a.IDFactura))
                    claves.Add(a.IDFactura);
            }

            //Realizamos un agrupado por factura
            List<FacturaDetalle> lista = new List<FacturaDetalle>();
            var rep = new Repository<FacturaDetalle>();

            foreach (var aux in claves)
            {
                long idF = Convert.ToInt64(aux.Replace("C", ""));
                lista.AddRange(rep.Search(x => x.IDFactura == idF));
            }

            var tmp = lista.GroupBy(l => l.IDFactura)
                .Select(cl => new RegistroFacturas
                {
                    IdFactura = cl.First().IDFactura,
                    Costo = cl.Sum(c => c.Costo * c.Unidades)
                }).ToList();

            //Procemos a poner los campos faltantes
            var r1 = new Repository<Cliente>();
            var f1 = new Repository<Factura>();

            foreach (var item in tmp)
            {
                var r = f1.Find(x => x.IDFactura == item.IdFactura);
                item.Numero = r.Numero;
                item.Cliente = r1.Find(x => x.IDCliente == r.IDCliente).Nombre;
            }

            gridControl1.DataSource = tmp;
        }
        public void ControlCarga()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            CargarRegistros();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;
            if (keyData == Keys.F5)
            {
                GuardarCompra();
            }
            else if (keyData == Keys.Escape)
            {
                //Cerrar();
            }
            else if (keyData == Keys.F4)
            {
                ShowProductoBuscar();
            }
            else if (keyData == Keys.F2)
            {
                ShowProveedorBuscar();
            }
            else if (keyData == Keys.F6)
            {
                ShowProveedorCrear();
            }
            else if(keyData == Keys.F3)
            {
                ShowProductoCrear();
            }
            else if (keyData == Keys.F10)
            {
                QuitarFila();
            }
            else if (keyData == Keys.F11)
            {
                NewCompra();
            }
            return Result;

        }
        private void Respaldo()
        {
            try
            {
                List<PurchasesData> resp = new List<PurchasesData>();

                foreach (var a in detalle)
                {
                    resp.Add(new PurchasesData
                    {
                        IDProducto = a.IDProducto,
                        Nombre = a.Nombre,
                        Cantidad = a.Cantidad,
                        Medida = a.Medida,
                        Precio = Convert.ToDecimal(a.PrecioUnitario),
                        Iva = a.Iva,
                        IdMedida = a.IdMedida,
                        Marca = a.Marca,
                        CodBarras = a.CodBarras,
                        SubTotal = Convert.ToDecimal(a.PrecioTotal),
                        CalculoIva=Convert.ToDecimal(a.CalculoIva),
                        Flete = a.Flete
                    });
                }
                var respaldo = new RespaldoCompra();
                respaldo.IdCliente = cliente.IDCliente;
                respaldo.Detalle = resp;

                if (detalle.Count > 0)
                {
                    File.Delete(archivoTmp);

                    Stream stream = File.OpenWrite(archivoTmp);
                    XmlSerializer xmlSer = new XmlSerializer(typeof(RespaldoCompra));
                    xmlSer.Serialize(stream, respaldo);
                    stream.Close();
                }
                else
                    File.Delete(archivoTmp);
            }
            catch
            {

            }
        }
        private void XfComprasPlantilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.IO.File.Exists(archivoTmp))
            {
                DialogResult result = XtraMessageBox.Show("La Compra no se encuentra Guardada\ndesea guardarla en papelera para posteriormente continuar",
                    "Informativo Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    File.Delete(archivoTmp);
            }
        }
        private void Recuperado()
        {
            if (System.IO.File.Exists(archivoTmp))
            {
                if (XtraMessageBox.Show("Se encontro un temporal por cierre inesperado\ndesea continuar con el proceso anterior",
                    "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var aux = File.ReadAllText(archivoTmp);
                    XmlSerializer ser = new XmlSerializer(typeof(RespaldoCompra));
                    StringReader sr = new StringReader(aux);

                    RespaldoCompra resp = (RespaldoCompra)ser.Deserialize(sr);

                    cliente = new Repository<Cliente>().Find(x => x.IDCliente == resp.IdCliente);
                    ChangeProveedor(cliente);
                    foreach (var row in resp.Detalle)
                    {
                        detalle.Add(new PurchasesAbvance
                        {
                            //IDFactura= row.IDFactura,
                            IDProducto = row.IDProducto,
                            Nombre = row.Nombre,
                            Cantidad = row.Cantidad,
                            Medida = row.Medida,
                            PrecioUnitario = Convert.ToSingle(row.Precio),
                            Iva = row.Iva,
                            CodBarras = row.CodBarras,
                            IdMedida = row.IdMedida,
                            Marca=row.Marca,
                            Flete = row.Flete,
                            //Ahorra = row.Cantidad
                        });
                    }


                }
            }
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void repositoryItemCheckEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckEdit check = (CheckEdit)sender;
                var resp = gVProducto.GetRow(gVProducto.FocusedRowHandle) as PurchasesAbvance;
                check.CheckState = (check.Checked == false) ? CheckState.Checked : CheckState.Unchecked;
                resp.Iva = check.Checked;
                Actualiza();
            }
        }

        private void txtFleteCalculo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
                SendKeys.Send(",");
            }
        }

        private void txtFlete_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void Cerrar()
        {
            Close();
        }
    }
}