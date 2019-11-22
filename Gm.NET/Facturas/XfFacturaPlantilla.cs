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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

using Gm.Core;
using Gm.Entities;
using Gm.Data;
using Gm.Core.Generales;
using Gm.NET.Formularios.Ventas;
using DevExpress.XtraGrid.Views.Tile;
using DevExpress.XtraReports.UI;
using Gm.NET.Properties;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Gm.NET.Formularios
{
    public partial class XfFacturaPlantilla : DevExpress.XtraEditors.XtraForm 
    {
        #region Variables
        long IdReservacion = 0;
        

        VistaVentaBLL inventario;
        Cliente cliente;

        List<BillCore> facturaDetalle;
        List<Grupo> categorias;
        XfFacturaProductoAyuda productoform;
        XfFacturaClienteBuscar clienteform;

        string archivoTmp = Environment.CurrentDirectory + "\\v0000f.xml";
        List<Producto> _ProductosEnVenta;
        Repository<Producto> repositoryProducto = new Repository<Producto>();

        private Color ColorNuevo;
        private Color ColorGrabado;
        #endregion
        public XfFacturaPlantilla()
        {
            InitializeComponent();
            ColorNuevo = sPCentral.BackColor;
            ColorGrabado = Color.FromArgb(255, 192, 192);
        }
        
        #region Eventos Form
        private void xfSales_Load(object sender, EventArgs e)
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            NewFactura();
            CargaProductos();
            Recuperado();
        }
        private void txtUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                TextEdit aux = (TextEdit)sender;
                int fila = 0;
                GridColumn column;
                bool Resul = true;

                switch (e.KeyCode)
                {
                    case Keys.Enter:
                    case Keys.Tab:
                    case Keys.Down:
                        if (aux.EditValue != null)
                        {
                            var resp = gVFacturaDetalle.GetRow(gVFacturaDetalle.FocusedRowHandle) as BillCore;

                            var facde = new Repository<FacturaDetalle>();
                            int? Al = facde.Search(x => x.IDProducto == resp.IdProducto && x.Estado == true && x.Siclo == "C").Sum(x => x.EnAlmacen);
                            int? D = facde.Search(x => x.IDProducto == resp.IdProducto && x.Estado == true && x.Siclo == "C").Sum(x => x.EnDevolucion);
                            int? I = facde.Search(x => x.IDProducto == resp.IdProducto && x.Estado == true && x.Siclo == "I").Sum(x => x.EnAlmacen);

                            var valor = Al + D+I;
                            if (valor > 0)
                            {
                                if (Convert.ToInt32(aux.EditValue) <= valor)
                                {
                                    fila = gVFacturaDetalle.FocusedRowHandle + 1;
                                    column = gVFacturaDetalle.Columns[1];
                                    gVFacturaDetalle.FocusedRowHandle = fila;
                                    gVFacturaDetalle.ShowEditor();
                                    gVFacturaDetalle.EndInit();
                                    actualizaCalculos();
                                }
                                else
                                {
                                    Resul = false;
                                    aux.EditValue = string.Empty;
                                }
                            }
                            else
                                Resul = false;
                        }
                        break;
                }
                if (!Resul)
                    throw new Exception("No hay en suficiencia el producto elijido");
                    
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
        private void btnCredito_Click(object sender, EventArgs e)
        {
            float? Total = facturaDetalle.Sum(x => x.Total);
            if (Total > 0)
            {
                var aux = new Repository<Cliente>().Find(x => x.IDCliente == 1);

                if (string.IsNullOrEmpty(txtCedula.Text) || txtCedula.Text == aux.Cedula)
                    XtraMessageBox.Show("Agrege Datos de comprador", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    
                }
            }
            else
                XtraMessageBox.Show("Para continuar con una nueva venta\npresione en el boton Nuevo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
    
        }
        private void xfBill_SizeChanged(object sender, EventArgs e)
        {
            sPCentral.Location = CenterForm.Function(this.Width, sPCentral.Width);
        }
        private void txtIvaCalculado_KeyDown(object sender, KeyEventArgs e)
        {
            var resp = gVFacturaDetalle.GetRow(gVFacturaDetalle.FocusedRowHandle) as BillCore;
            if (!string.IsNullOrEmpty(resp.Detalle) && Keys.Enter==e.KeyCode)
            {
                actualizaCalculos();
            }
        }
        private void txtCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    var p = new Repository<Producto>().Find(x => x.CodBarra == txtCodigoBarra.Text);
                    if (p != null)
                    {
                        //Obtenemos el valor de existencia de producto
                        var valor = _ProductosEnVenta.Find(x => x.IDProducto == p.IDProducto).ExistenciaActual;

                        if (valor > 0)
                        {
                            AddRow(new AyudaCore
                            {
                                IDProducto = p.IDProducto,
                                CodBarra = p.CodBarra,
                                Nombre = p.Nombre,
                                PVenta1 = p.PVenta1,
                                PVenta2 = p.PVenta2,
                                MedidaMetrica = p.MedidaMetrica,
                                Marca = p.Marca,
                                Iva = p.Iva,
                                //Opcion1 = true
                            });
                        }
                        else
                            XtraMessageBox.Show("El producto seleccionado no hay en existencia...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        private void repositoryItemCheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit check = (CheckEdit)sender;
            var aux = gVFacturaDetalle.GetRow(gVFacturaDetalle.FocusedRowHandle) as BillCore;
            aux.IvaAplica = check.Checked;
            actualizaCalculos();
        }
        private void cbxTipoTransaccion_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            Validador(e.Value.ToString());
        }
        private void tileView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var resp = tileView1.GetFocusedRowCellValue("IDProducto");
                long ID = Convert.ToInt64(resp);

                var p = new Repository<Producto>().Find(x => x.IDProducto == ID);
                if (p.ExistenciaActual > 0)
                {
                    AddRow(new AyudaCore
                    {
                        IDProducto = p.IDProducto,
                        CodBarra = p.CodBarra,
                        Nombre = p.Nombre,
                        PVenta1 = p.PVenta1,
                        PVenta2 = p.PVenta2,
                        PVenta3 = p.PVenta3,
                        PVenta4 = p.PVenta4,
                        MedidaMetrica = p.MedidaMetrica,
                        Marca = p.Marca,
                        Iva = p.Iva,
                        //Opcion1 = true
                    }
                    );
                }
                else
                    XtraMessageBox.Show("El producto seleccionado no hay en existencia...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
                SendKeys.Send(",");
            }
        }
        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                QuitarFila();
        }
        private void XfFacturaPlantilla_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.IO.File.Exists(archivoTmp))
            {
                DialogResult result = XtraMessageBox.Show("La factura no se encuentra Guardada\ndesea guardarla en papelera para posteriormete continuar",
                    "Informativo Facturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ShowReservar();
                    File.Delete(archivoTmp);
                }
                if (result == DialogResult.No)
                    File.Delete(archivoTmp);
            }
        }
        private void tileView2_ItemClick(object sender, TileViewItemClickEventArgs e)
        {
            var resp = tileView2.GetFocusedRowCellValue("IDGrupo");
            long ID = Convert.ToInt64(resp);

            if (ID == 0)
                gCGaleriaProductos.DataSource = _ProductosEnVenta;
            else
            {
                //gridControl3.DataSource = null;
                gCGaleriaProductos.DataSource = _ProductosEnVenta.Where(x => x.IDGrupo == ID).ToList();
            }

        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tileView1_ItemCustomize(object sender, TileViewItemCustomizeEventArgs e)
        {

            var existenciaMinima = string.IsNullOrEmpty(e.Item.Elements[8].Text) ? 0 : Convert.ToInt16(e.Item.Elements[8].Text);
            var existenciaActual = string.IsNullOrEmpty(e.Item.Elements[3].Text) ? 0 : Convert.ToInt16(e.Item.Elements[3].Text);
            var resp = _ProductosEnVenta[e.RowHandle];
            //var resp = repositoryProducto.Find(x => x.IDProducto == pro.IdProducto);

            var pv1 = resp.PVenta1;
            var pv2 = resp.PVenta2;
            var pv3 = resp.PVenta3;
            var pv4 = resp.PVenta4;

            if (existenciaActual < 0)
                e.Item.Elements[3].Appearance.Normal.ForeColor = Color.Red;
            else if (existenciaMinima > existenciaActual)
                e.Item.Elements[3].Appearance.Normal.ForeColor = Color.CadetBlue;
            else if (existenciaMinima <= existenciaActual && existenciaActual == 0)
                e.Item.Elements[3].Appearance.Normal.ForeColor = Color.Red;

            switch (cliente.PrecioAplicado)
            {
                case 2:
                    if (pv2 > 0)
                    {
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Strikeout;
                        e.Item.Elements[5].Appearance.Normal.ForeColor = Color.Red;
                        e.Item.Elements[6].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                        e.Item.Elements[6].TextLocation = new Point(220, 120);
                        e.Item.Elements[7].TextLocation = new Point(-100, 120);
                    }
                    else
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                    break;
                case 3:
                    if (pv3 > 0)
                    {
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Strikeout;
                        e.Item.Elements[5].Appearance.Normal.ForeColor = Color.Red;
                        e.Item.Elements[7].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                        e.Item.Elements[7].TextLocation = new Point(220, 120);
                        e.Item.Elements[6].TextLocation = new Point(-100, 120);
                    }
                    else
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                    break;
                case 4:
                    if (pv4 > 0)
                    {
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Strikeout;
                        e.Item.Elements[5].Appearance.Normal.ForeColor = Color.Red;
                        e.Item.Elements[9].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                        e.Item.Elements[9].TextLocation = new Point(220, 120);
                        e.Item.Elements[6].TextLocation = new Point(-100, 120);
                    }
                    else
                        e.Item.Elements[5].Appearance.Normal.FontStyleDelta = FontStyle.Regular;
                    break;
            }

        }

        private void tileView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var resp = tileView1.GetFocusedRowCellValue("IDProducto");
                    long ID = Convert.ToInt64(resp);

                    var p = new Repository<Producto>().Find(x => x.IDProducto == ID);
                    if (p.ExistenciaActual > 0)
                    {
                        AddRow(new AyudaCore
                        {
                            IDProducto = p.IDProducto,
                            CodBarra = p.CodBarra,
                            Nombre = p.Nombre,
                            PVenta1 = p.PVenta1,
                            PVenta2 = p.PVenta2,
                            MedidaMetrica = p.MedidaMetrica,
                            Marca = p.Marca,
                            Iva = p.Iva,
                            //Opcion1 = true
                        }
                        );
                    }
                    else
                        XtraMessageBox.Show("El producto seleccionado no hay en existencia...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        //arracamos la tarrea de carga
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var productos = new Repository<Producto>().GetAll().OrderBy(x => x.Nombre);
                var facturaDetalle = new Repository<FacturaDetalle>();
                _ProductosEnVenta = new List<Producto>();

                ProgresoBar.EditValue = 0;
                foreach (var fila in productos)
                {
                    int? EnAlmacen = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && x.Estado == true && x.Siclo=="C").Sum(x => x.EnAlmacen);
                    int? EnDevolucion = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && x.Estado == true && x.Siclo == "C").Sum(x => x.EnDevolucion);
                    int? EnInventario = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && x.Estado == true && x.Siclo == "I").Sum(x => x.EnAlmacen);
                    int? EnInventario1 = facturaDetalle.Search(x => x.IDProducto == fila.IDProducto && x.Estado == true && x.Siclo == "I").Sum(x => x.EnDevolucion);

                    _ProductosEnVenta.Add(new Producto
                    {
                        IDProducto = fila.IDProducto,
                        Nombre = fila.Nombre,
                        PVenta1 = fila.PVenta1,
                        PVenta2 = fila.PVenta2,
                        PVenta3 = fila.PVenta3,
                        PVenta4 = fila.PVenta4,
                        FotoProducto = fila.FotoProducto,
                        ExistenciaActual = EnAlmacen + EnDevolucion + EnInventario+EnInventario1,
                        IDGrupo = fila.IDGrupo
                    });
                    ProgresoBar.EditValue = Convert.ToInt16(ProgresoBar.EditValue) + 1;
                }
                
                //Utilizamos para los filtros
                categorias = (from a in new Repository<Grupo>().GetAll()
                              where a.Estado == "A"
                              select a).ToList();

                categorias.Insert(0, new Grupo
                {
                    IDGrupo = 0,
                    Nombre = "TODOS",
                    Estado = "A"
                });

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        //cerramos la carga
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridControl4.DataSource = categorias;
            gCGaleriaProductos.DataSource = _ProductosEnVenta;
        }
        #endregion
        public void NewFactura()
        {
            inventario = new VistaVentaBLL();
            inventario.RespExistencia();

            facturaDetalle = new List<BillCore>();
            gCFacturaDetalle.DataSource = facturaDetalle;

            try
            {
                cliente = new Repository<Cliente>().Find(x => x.IDCliente == 1);
                var fac = new ParametrosBLL();

                txtID.EditValue = cliente.IDCliente;
                txtCedula.EditValue = string.Format("DNI: {0}", cliente.Cedula);
                txtNombre.EditValue = string.Format("CLI: {0}", cliente.Nombre);
                txtDireccion.EditValue = string.Format("DIR: {0}", cliente.Direccion);
                txtTelefono.EditValue = string.Format("TELF: {0}", cliente.Telefono);
                txtFactura.EditValue = string.Format("FACT: {0}", Convert.ToInt32(fac.numFactura));
                dtFechaVence.EditValue = string.Empty;
                txtPrecioVenta.EditValue = string.Empty;

                txtSubTotal.Text = "000.00";
                txtIva.Text = "000.00";
                txtTotal.Text = "000.00";

                lbel12.Text = string.Format("Iva {0}%:", General.Iva);
                dateEdit1.EditValue = DateTime.Now;

                cbxTipoTransaccion.SelectedIndex = 0;

                sPCentral.BackColor = ColorNuevo;

            }
            catch { }
        }
        private void actualizaCalculos()
        {
            if (facturaDetalle != null)
            {
                //Todos lo producto que aplican Iva
                var subT = facturaDetalle.Sum(x => x.SubTotal);
                //Todos los producto que no aplican Iva

                //
                var total = facturaDetalle.Sum(x => x.Total);
                
                var ivaT = facturaDetalle.Sum(x => x.Iva);

                txtSubTotal.Text = string.Format("{0:0.000}", subT);
                txtIva.Text = string.Format("{0:0.000}", ivaT);
                txtTotal.Text = string.Format("{0:0.000}", total);
                Respaldo();
            }
            gCFacturaDetalle.RefreshDataSource();
        }
        public void SaveFactura()
        {
            BillCore metodo = new BillCore();
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception("La factura ya se encuentra guardada");

                if (facturaDetalle.Sum(x => x.Total) > 0)
                {
                    using (XfFacturaPagar mvc = new XfFacturaPagar
                    {
                        total = Convert.ToDecimal(facturaDetalle.Sum(x => x.Total))
                    })
                    {
                        long? IdFactura = null;
                        bool respuesta = false;
                        //Guardamos la parte de pago en efectivo
                        if (mvc.ShowDialog() == DialogResult.OK)
                        {
                            switch (cbxTipoTransaccion.EditValue)
                            {
                                case "EFECTIVO":
                                    if (mvc.saldo == 0)
                                    {
                                        if (!metodo.Save(cliente, facturaDetalle, Convert.ToInt32(txtFactura.Text.Replace("FACT: ", "")), out IdFactura,txtObservacion.Text))
                                            throw new Exception(metodo.Error);
                                        else
                                            respuesta = true;
                                    }
                                    else
                                        throw new Exception("Transaccion EFECTIVO, no permitida");
                                    break;
                                case "CREDITO":
                                    if (mvc.saldo < mvc.total && cliente.IDCliente!=1)
                                    {
                                        if (Validador("CREDITO") && metodo.Save(cliente, facturaDetalle, Convert.ToInt32(txtFactura.Text.Replace("FACT: ", "")), out IdFactura, txtObservacion.Text))
                                        {
                                            var resp = new Repository<Credito>();
                                            int contador = 0;
                                            var cre = resp.GetAll();
                                            if (cre == null)
                                                contador = 1;
                                            else
                                                contador = cre.Count + 1;

                                            if (resp.Create(new Credito
                                            {
                                                IDCredito = Convert.ToInt64(contador),
                                                IDFactura = IdFactura,
                                                IDUsaurio = General.IdUsuario,
                                                Fecha = DateTime.Now,
                                                Abona = mvc.abonar,
                                                State = true,
                                                Estado = "A",
                                                FechaVence = (string.IsNullOrEmpty(dtFechaVence.Text)) ? DateTime.Now : dtFechaVence.DateTime
                                            }) == null)
                                                throw new Exception(resp.Error);

                                            respuesta = true;
                                        }
                                        else
                                            throw new Exception(metodo.Error);
                                    }
                                    else
                                        throw new Exception("Transaccion CREDITO, no permitida");
                                    break;
                            }
                            if (respuesta)
                            {
                                ReservarEliminar();
                                //pictureEdit1.EditValue = imageCollection1.Images[1];
                                if(dockPanel1.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                                    CargarRegistros();

                                CargaProductos();
                                sPCentral.BackColor = ColorGrabado;
                                //borramos temporales
                                File.Delete(archivoTmp);

                                //XtraMessageBox.Show("Gracias por su compra\n"+cliente.Nombre,"Guardado correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                xfMessageThankYou msm = new xfMessageThankYou();
                                msm.ShowDialog();
                            }
                            else
                                throw new Exception("Transaccion No completada favor revise");
                        }
                    }
                }
                else
                    throw new Exception("No hay productos que guardar");
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public void ShowClienteBuscar()
        {
            clienteform = new XfFacturaClienteBuscar();
            clienteform.DatosCliente += new XfFacturaClienteBuscar.Enviar(ChangeCliente);
            clienteform.ShowDialog();
        }
        public void ShowClienteCrear()
        {
            XfFacturaClienteCrear mvc = new XfFacturaClienteCrear();
            mvc.ShowDialog();
        }
        public void ShowClienteEditar()
        {
            if (cliente != null)
            {
                XfFacturaClienteEditar mvc = new XfFacturaClienteEditar { cliente_ = cliente };
                if (mvc.ShowDialog() == DialogResult.OK)
                    ChangeCliente(mvc.cliente_);
            }
        }
        public void ChangeCliente(Cliente cliente)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                this.cliente = cliente;
                txtID.Text = string.Format("{0}", this.cliente.IDCliente);
                txtCedula.Text = string.Format("DNI: {0}", this.cliente.Cedula);
                txtNombre.Text = string.Format("CLI: {0}", this.cliente.Nombre);
                txtDireccion.Text = string.Format("DIR: {0}", this.cliente.Direccion);
                txtTelefono.Text = string.Format("TEF: {0}", this.cliente.Telefono);
                txtPrecioVenta.EditValue = string.Format("PRECION DE VENTA {0}", this.cliente.PrecioAplicado);
                ActualizaPrecio();
                gCFacturaDetalle.RefreshDataSource();

                if (cliente.PrecioAplicado > 1)
                    barButtonItem2.Caption = "PRECIO PREFERENCIAL";
                else
                    barButtonItem2.Caption = "PRECIO NORMAL";


                tileView1.RefreshData();
            }
            catch (Exception) { }
            
        }
        private void ActualizaPrecio()
        {
            var produc = new Repository<Producto>();
            foreach(var row in facturaDetalle)
            {
                var arg = produc.Find(x=>x.IDProducto==row.IdProducto);

                switch (cliente.PrecioAplicado)
                {
                    case 1:
                        row.Precio = Convert.ToSingle(arg.PVenta1);
                        break;
                    case 2:
                        var pv2 = (arg.PVenta2 == null || arg.PVenta2==0) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta2);
                        row.Precio = Convert.ToSingle(pv2);
                        break;
                    case 3:
                        var pv3 = (arg.PVenta3 == null || arg.PVenta3 == 0) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta3);
                        row.Precio = Convert.ToSingle(pv3);
                        break;
                    case 4:
                        var pv4 = (arg.PVenta4 == null || arg.PVenta4 == 0) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta4);
                        row.Precio = Convert.ToSingle(pv4);
                        break;
                    default:
                        row.Precio = Convert.ToSingle(arg.PVenta1);
                        break;
                }
            }
        }
        public void QuitarFila()
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                if (facturaDetalle.Count > 0)
                {
                    facturaDetalle.RemoveAt(gVFacturaDetalle.FocusedRowHandle);
                    //detalle.Add(new BillCore());

                    var total = facturaDetalle.Sum(x => x.Total);
                    var subT = facturaDetalle.Sum(x => x.SubTotal);
                    var ivaT = facturaDetalle.Sum(x => x.Iva);
                    if (total != null)
                    {
                        txtSubTotal.Text = string.Format("{0:0.000}", subT);
                        txtIva.Text = string.Format("{0:0.000}", ivaT);
                        txtTotal.Text = string.Format("{0:0.000}", total);
                        gCFacturaDetalle.RefreshDataSource();
                    }
                    actualizaCalculos();
                }
            }
            catch (Exception) { }
            
            
        }
        private void AddRow(AyudaCore arg)
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                if (facturaDetalle.Count > 0)
                {
                    var EnDetalle = facturaDetalle.Find(x => x.IdProducto == arg.IDProducto);
                    if (EnDetalle != null)
                    {
                        var EnVenta = _ProductosEnVenta.Find(x => x.IDProducto == arg.IDProducto).ExistenciaActual;
                        if (EnVenta < EnDetalle.Unidades)
                        {
                            XtraMessageBox.Show("No existe cantidad suficiente en venta, favor revise");
                            throw new Exception();
                        }
                    }
                }

                var resp = facturaDetalle.Exists(x => x.IdProducto == arg.IDProducto && x.IvaAplica == arg.Iva);
                if (resp)
                {
                    var aux = facturaDetalle.Find(x => x.IdProducto == arg.IDProducto && x.IvaAplica == arg.Iva);
                    aux.CodBarras = arg.CodBarra;
                    aux.Unidades++;
                }
                else
                {
                    var nuevo = new BillCore();
                    nuevo.IdProducto = arg.IDProducto;
                    nuevo.CodBarras = arg.CodBarra;
                    nuevo.Detalle = arg.Nombre;
                    switch (cliente.PrecioAplicado)
                    {
                        case 1:
                            nuevo.Precio = Convert.ToSingle(arg.PVenta1);
                            break;
                        case 2:
                            var pv2= (arg.PVenta2 == null) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta2);
                            nuevo.Precio = Convert.ToSingle(pv2) ;
                            break;
                        case 3:
                            var pv3 = (arg.PVenta3 == null) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta3);
                            nuevo.Precio = Convert.ToSingle(pv3);
                            break;
                        case 4:
                            var pv4 = (arg.PVenta4 == null) ? arg.PVenta1 : Convert.ToDecimal(arg.PVenta4);
                            nuevo.Precio = Convert.ToSingle(pv4);
                            break;
                        default:
                            nuevo.Precio = Convert.ToSingle(arg.PVenta1);
                            break;
                    }
                    nuevo.Unidades = 1;
                    nuevo.IvaAplica = arg.Iva;
                    nuevo.Medida = arg.MedidaMetrica;
                    nuevo.Marca_ = arg.Marca;


                    facturaDetalle.Add(nuevo);
                    //Respaldo();
                }
                actualizaCalculos();
                txtCodigoBarra.SelectAll();
                gCFacturaDetalle.RefreshDataSource();
            }
            catch (Exception) { }
            
        }
        private bool Validador(string arg)
        {
            bool Result = true;
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception();

                if (arg.Equals("CREDITO"))
                {
                    if (cliente.IDCliente > 1)
                    {
                        dxErrorProvider1.SetError(txtID, "");
                        dxErrorProvider1.SetError(txtNombre, "");
                        dxErrorProvider1.SetError(txtCedula, "");
                        dxErrorProvider1.SetError(txtDireccion, "");
                        dxErrorProvider1.SetError(txtTelefono, "");
                    }
                    if (cliente == null || cliente.IDCliente == 1)
                    {
                        dxErrorProvider1.SetError(txtID, "Dato incorrecto");
                        dxErrorProvider1.SetError(txtNombre, "Dato incorrecto");
                        dxErrorProvider1.SetError(txtCedula, "Dato incorrecto");
                        dxErrorProvider1.SetError(txtDireccion, "Dato incorrecto");
                        dxErrorProvider1.SetError(txtTelefono, "Dato incorrecto");
                        Result = false;
                    }
                }
                else
                {
                    dxErrorProvider1.SetError(txtID, "");
                    dxErrorProvider1.SetError(txtNombre, "");
                    dxErrorProvider1.SetError(txtCedula, "");
                    dxErrorProvider1.SetError(txtDireccion, "");
                    dxErrorProvider1.SetError(txtTelefono, "");
                }
            }
            catch (Exception) { }
            
            return Result;
        }
        public void ShowProductoBuscar()
        {
            productoform = new XfFacturaProductoAyuda();
            productoform.DatosProducto += new XfFacturaProductoAyuda.Enviar(GetBuscados);
            productoform.ShowDialog();
            if (productoform.bOk)
            {

                long ID = Convert.ToInt64(productoform.seleccion.IDProducto);

                var p = new Repository<Producto>().Find(x => x.IDProducto == ID);
                if (p.ExistenciaActual > 0)
                {
                    AddRow(new AyudaCore
                    {
                        IDProducto = p.IDProducto,
                        CodBarra = p.CodBarra,
                        Nombre = p.Nombre,
                        PVenta1 = p.PVenta1,
                        PVenta2 = p.PVenta2,
                        MedidaMetrica = p.MedidaMetrica,
                        Marca = p.Marca,
                        Iva = p.Iva,
                        //Opcion1 = true
                    }
                    );
                }
                else
                    XtraMessageBox.Show("El producto seleccionado no hay en existencia...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GetBuscados(List<Producto> arg)
        {
            gCGaleriaProductos.DataSource = null;
            gCGaleriaProductos.DataSource = arg;
        }
        public void CargaProductos()
        {
            repositoryItemProgressBar1.Maximum = new Repository<Producto>().Count();
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            
        }
        public void ShowProductoEditar()
        {
            if (facturaDetalle.Count >0)
            {
                var resp = gVFacturaDetalle.GetRow(gVFacturaDetalle.FocusedRowHandle) as BillCore;
                var aux = new Repository<Producto>().Find(x => x.IDProducto == resp.IdProducto);
                XfFacturaProductoEditar mvc = new XfFacturaProductoEditar { producto_ = aux };
                if (mvc.ShowDialog() == DialogResult.OK)
                {
                    resp.CodBarras = mvc.producto_.CodBarra;
                    resp.Detalle = mvc.producto_.Nombre;
                }
            }
        }
        public void Impresion()
        {
            var resp = new List<FacturaImpresionVenta>();
            foreach(var row in facturaDetalle)
            {
                resp.Add(new FacturaImpresionVenta
                {
                    Cliente = cliente.Nombre,
                    Cedula= cliente.Cedula,
                    Direccion = cliente.Direccion,
                    Telefono = cliente.Telefono,
                    NumeroFactura = "",
                    Fecha = dateEdit1.DateTime.ToString(),
                    Cantidad = Convert.ToInt16(row.Unidades),
                    Detalle = row.Detalle,
                    VUnitario = Convert.ToSingle(row.Precio),
                    VTotal = Convert.ToSingle(row.Total),
                    SubTotal = Convert.ToSingle(txtSubTotal.Text),
                    Iva = Convert.ToSingle(txtIva.Text),
                    Total = Convert.ToSingle(txtTotal.Text)
                });
            }
            if (resp.Count > 0)
            {
                //XtraReport report = new XtraReport();
                string path = Directory.GetCurrentDirectory();

                // A temporary path to save a report to.  
                string filePath = string.Format("{0}\\Reportes\\ReporteFacturaVenta.repx", path);

                XtraReport report = XtraReport.FromFile(filePath, true);
                ReportPrintTool tool = new ReportPrintTool(report);
                report.DataSource = resp;
                tool.ShowRibbonPreviewDialog();

            }
        }
        public void ShowReservar()
        {
            try
            {
                if (sPCentral.BackColor == ColorGrabado)
                    throw new Exception("Factura guardada, no es permitido poner en reserva");

                XtraInputBoxArgs args = new XtraInputBoxArgs();
                args.Caption = "Poner en Papelera";
                args.Prompt = "Comentario:";
                args.DefaultButtonIndex = 0;
                TextEdit editor = new TextEdit();
                args.Editor = editor;

                if (facturaDetalle.Count > 0)
                {
                    var box = XtraInputBox.Show(args);
                    if (box != null)
                    {
                        using (var resp = new Repository<Reservacion>())
                        {
                            var aux = resp.GetAll();
                            int rowReserva = 0;
                            if (aux == null)
                                rowReserva = 1;
                            else
                                rowReserva = aux.Count + 1;

                            //Realizamos la depuracion de productos comprados en caso de que se repita
                            List<BillCore> miDetalle = new List<BillCore>();
                            foreach (var row in facturaDetalle)
                            {
                                if (!miDetalle.Exists(x => x.IdProducto == row.IdProducto && x.IvaAplica == row.IvaAplica))
                                    miDetalle.Add(row);
                                else
                                {
                                    var temp = miDetalle.Find(x => x.IdProducto == row.IdProducto && x.IvaAplica == row.IvaAplica);
                                    temp.Unidades = temp.Unidades + row.Unidades;
                                }
                            }

                            //Grabamos los productos en reservaciones
                            foreach (var row in miDetalle)
                            {
                                resp.Add(new Reservacion
                                {
                                    IDReservacion = rowReserva,
                                    IDProducto = row.IdProducto,
                                    Precio = Convert.ToDecimal(row.Precio),
                                    Cantidad = row.Unidades,
                                    AplicaIva = Convert.ToBoolean(row.IvaAplica),
                                    IDCliente = cliente.IDCliente,
                                    Fecha = DateTime.Now,
                                    Estado = "A",
                                    IDMedida = row.Medida.IdMedidaMetrica,
                                    IDUsuario = General.IdUsuario,
                                    Comentario = string.Format("<{0}> {1}:", rowReserva, box.ToString())
                                });
                            }

                            if (resp.Save())
                                XtraMessageBox.Show("Guardado en Papelera");
                            else
                                throw new Exception(resp.Error);
                        }
                    }
                }
            }
            catch (Exception ex) {
                XtraMessageBox.Show(ex.Message,"Informativo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
        public void ShowReservarBuscar()
        {
            XfFacturaReservacioBuscar mvc = new XfFacturaReservacioBuscar();
            mvc.ShowDialog();
            if (mvc.Ok)
            {
                if (facturaDetalle.Count > 0 && XtraMessageBox.Show("Va remplazar la factura actual\ndesea continuar","Informativo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    IdReservacion = mvc.IdReservacion;
                    facturaDetalle.Clear();
                    facturaDetalle.AddRange(mvc.detalle);
                    ChangeCliente(mvc.cliente);
                    actualizaCalculos();
                }
                else
                {
                    IdReservacion = mvc.IdReservacion;
                    facturaDetalle.Clear();
                    facturaDetalle.AddRange(mvc.detalle);
                    ChangeCliente(mvc.cliente);
                    actualizaCalculos();
                }
            }
        }
        private void ReservarEliminar()
        {
            if (IdReservacion != 0)
            {
                using (var resp = new Repository<Reservacion>())
                {
                    var aux = resp.Search(x => x.IDReservacion == IdReservacion);
                    foreach (var row in aux)
                    {
                        row.Estado = "E";
                        if (!resp.Update(row))
                            break;
                    }
                }
            }
        }
        public void RegistrosFacturas()
        {
            dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            CargarRegistros();
            
        }
        private void CargarRegistros()
        {
            var resp = (from a in new Repository<Kardex>().GetAll()
                        where a.IDFactura != null && a.IDFactura.Contains("V") && a.Fecha.Value.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")
                        select a).ToList();

            //Almacenamos facturas no repetidas
            List<string> claves = new List<string>();
            foreach (var a in resp)
            {
                if (a.IDFactura.Contains("V") && !claves.Contains(a.IDFactura))
                    claves.Add(a.IDFactura);
            }

            //Realizamos un agrupado por factura
            List<FacturaDetalle> lista = new List<FacturaDetalle>();
            var rep = new Repository<FacturaDetalle>();

            foreach (var aux in claves)
            {
                long idF = Convert.ToInt64(aux.Replace("V", ""));
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

            gridControl2.DataSource = tmp;
        }
        private void Respaldo()
        {
            try
            {
                List<BillData> resp = new List<BillData>();

                foreach (var a in facturaDetalle)
                {
                    resp.Add(new BillData
                    {
                        IDFactura = 0,
                        IdProducto = a.IdProducto,
                        CodBarras = a.CodBarras,
                        Detalle = a.Detalle,
                        Precio = a.Precio,
                        Unidades = a.Unidades,
                        Iva = a.Iva,
                        IvaAplica = a.IvaAplica,
                        SubTotal = a.SubTotal,
                        Total = a.Total,
                        IdMarca = a.Marca_.IDMarca,
                        IdMedida = a.Medida.IdMedidaMetrica
                    });
                }
                var respaldo = new RespadoFactura();
                respaldo.IDCliente = cliente.IDCliente;
                respaldo.Nombre = cliente.Nombre;
                respaldo.Detalle = resp;

                if (facturaDetalle.Count > 0)
                {
                    File.Delete(archivoTmp);

                    Stream stream = File.OpenWrite(archivoTmp);
                    XmlSerializer xmlSer = new XmlSerializer(typeof(RespadoFactura));
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
        private void Recuperado()
        {
            if (System.IO.File.Exists(archivoTmp))
            {
                if (XtraMessageBox.Show("Se encontro un temporal por cierre inesperado\ndesea continuar con el proceso anterior", 
                    "Informativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    var aux = File.ReadAllText(archivoTmp);
                    XmlSerializer ser = new XmlSerializer(typeof(RespadoFactura));
                    StringReader sr = new StringReader(aux);

                    RespadoFactura resp = (RespadoFactura)ser.Deserialize(sr);

                    cliente = new Repository<Cliente>().Find(x => x.IDCliente == resp.IDCliente);
                    ChangeCliente(cliente);
                    foreach (var row in resp.Detalle)
                    {
                        facturaDetalle.Add(new BillCore
                        {
                            //IDFactura= row.IDFactura,
                            IdProducto= row.IdProducto,
                            CodBarras= row.CodBarras,
                            Detalle= row.Detalle,
                            Precio=row.Precio,
                            Unidades=row.Unidades,
                            IvaAplica = row.IvaAplica,
                            Medida = new Repository<MedidaMetrica>().Find(x=>x.IdMedidaMetrica==row.IdMedida),
                            Marca_ = new Repository<Marca>().Find(x=>x.IDMarca==row.IdMarca)
                        });
                    }
                }
            }
        }
        public void Cerrar()
        {
            Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;
            if (keyData == Keys.F5)
            {
                SaveFactura();
            }
            else if (keyData == Keys.F8)
            {

            }
            else if (keyData == Keys.F4)
            {
                ShowProductoBuscar();
            }
            else if (keyData == Keys.F2)
            {
                ShowClienteBuscar();
            }
            else if (keyData == Keys.F6)
            {
                ShowClienteCrear();
            }
            else if (keyData == Keys.F10)
            {
                QuitarFila();
            }
            else if (keyData == Keys.F11)
            {
                NewFactura();
            }
            //if (keyData == (Keys.Control | Keys.N))
            //{
            //    NewFactura();
            //    return true;
            //}

            return Result;

        }

    }
}