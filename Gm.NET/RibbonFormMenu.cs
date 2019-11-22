using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using System.IO;
using DevExpress.XtraGrid.Views.Grid;

using Gm.Core;
using Gm.NET.Herramientas;
using Gm.NET.Formularios;
using Gm.Data;
using Gm.Entities;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTabbedMdi;
using Gm.NET.Formularios.VentaCompra;
using Gm.NET.Compras;

namespace Gm.NET
{
    //https://www.youtube.com/watch?v=nqCEBGCQEZQ
    //https://www.smartpuntodeventa.com/
    public partial class RibbonFormMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region variables de formularios
        XfFacturaPlantilla formularioVenta;
        XfProductAdmin formularioProducto;
        XfComprasPlantilla formularioCompra;
        XfCuentasXCobrar formularioCredito;
        XfClientesListado formularioCliente;
        XfProveedorListado formularioProveedor;
        XfInicio XfInicio;
        XrFConsultasReportes formularioConsultasReportes;
        XfComprasListado ComprasListado;
        XfFacturasEmitidas facturasEmitidas;
        XfPermisosyUsuarios permisosyUsuarios;
        XfProductBodega ProductBodega;
        XfAuditoria formularioAuditoria;
        #endregion

        #region Precargar
        private bool Control(string mvc)
        {
            bool Resp = false;
            try
            {
                ModuloBLL metodo = new ModuloBLL();
                var item = metodo.Mostar.Find(a => a.Comando == mvc);
                Resp = Convert.ToBoolean(item.Estado);
                if (Resp == false)
                {
                    XtraMessageBox.Show("El usuario ingresado no esta registrado o sus credenciales fueron cambiados\nfavor comuniquese con sistemas...",
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                return true;
            }
            return Resp;
        }
        private void Mostrar()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                bSIUsuario.Caption = General.Nombre;
                bsiLlave.Caption = General.Login;
                bBITerminal.Caption = string.Format("{0:000}", Convert.ToInt16(General.Terminal));
                bIOficina.Caption = General.Oficina;
                General.MyDataBase = new LecturaBase().myCatalog;
                bSImyBase.Caption = General.MyDataBase;

                var lectura = new LecturaArchivo();
                CargarAccesos();


                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(lectura.GetSkin);
                this.Text = General.MyVersion;
                opcionesMenu();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Cargamos los permisos del usuario
        /// </summary>
        private void CargarAccesos()
        {
            try
            {
                var resp = new Repository<Acceso>().Search(x => x.IDUsuario == General.IdUsuario);

                //factura
                ClaseAcceso.Factura_ = Convert.ToBoolean(resp[0].Estado);
                ClaseAcceso.FacturaGuardar_ = Convert.ToBoolean(resp[1].Estado);
                ClaseAcceso.FacturaImprimir_ = Convert.ToBoolean(resp[2].Estado);
                ClaseAcceso.FacturaCrearCliente_ = Convert.ToBoolean(resp[3].Estado);
                ClaseAcceso.FacturaEditarCliente_ = Convert.ToBoolean(resp[4].Estado);
                ClaseAcceso.FacturasEmitidas_ = Convert.ToBoolean(resp[25].Estado);

                //compra
                ClaseAcceso.Compra_ = Convert.ToBoolean(resp[5].Estado);
                ClaseAcceso.CompraGuardar_ = Convert.ToBoolean(resp[6].Estado);
                ClaseAcceso.CompraCrearProducto_ = Convert.ToBoolean(resp[7].Estado);
                ClaseAcceso.CompraEditarProducto_ = Convert.ToBoolean(resp[8].Estado);
                ClaseAcceso.CompraCrearProveedor_ = Convert.ToBoolean(resp[9].Estado);
                ClaseAcceso.CompraEditarProveedor_ = Convert.ToBoolean(resp[10].Estado);

                //producto
                ClaseAcceso.Productos_ = Convert.ToBoolean(resp[11].Estado);
                ClaseAcceso.ProductosCrear_ = Convert.ToBoolean(resp[12].Estado);
                ClaseAcceso.ProductosEditar_ = Convert.ToBoolean(resp[13].Estado);
                ClaseAcceso.ProductosEliminar_ = Convert.ToBoolean(resp[14].Estado);
                ClaseAcceso.ProductosExporta_ = Convert.ToBoolean(resp[15].Estado);
                ClaseAcceso.ProductosEdicionRapida_ = Convert.ToBoolean(resp[16].Estado);
                ClaseAcceso.ProductosRestablecer_ = Convert.ToBoolean(resp[17].Estado);
                ClaseAcceso.ProductosQuitarMarcas_ = Convert.ToBoolean(resp[18].Estado);

                //cuentas por cobrar
                ClaseAcceso.CuentasporCobrar_ = Convert.ToBoolean(resp[19].Estado);
                ClaseAcceso.CuentasporCobrarNuevoAbono_ = Convert.ToBoolean(resp[20].Estado);
                ClaseAcceso.CuentasporCobrarEliminarAbono_ = Convert.ToBoolean(resp[21].Estado);
                ClaseAcceso.CuentasporCobrarEditarAbono_ = Convert.ToBoolean(resp[22].Estado);
                ClaseAcceso.CuentasporCobrarExportar_ = Convert.ToBoolean(resp[23].Estado);
                ClaseAcceso.ConsultasReportes_ = Convert.ToBoolean(resp[24].Estado);
                
                ClaseAcceso.VentasRealizadasImprimirTodo_ = Convert.ToBoolean(resp[26].Estado);
                ClaseAcceso.VentasRealizadasImprimirSeleccion_ = Convert.ToBoolean(resp[27].Estado);
                ClaseAcceso.VentasRealizadasEliminarFactura_ = Convert.ToBoolean(resp[28].Estado);
                ClaseAcceso.ComprasRealizadas_ = Convert.ToBoolean(resp[29].Estado);

                ClaseAcceso.ComprasRealizadasImprimirTodo_ = Convert.ToBoolean(resp[30].Estado);
                ClaseAcceso.ComprasRealizadasImprimirSeleccion_ = Convert.ToBoolean(resp[31].Estado);
                ClaseAcceso.ComprasRealizadasEliminarCompra_ = Convert.ToBoolean(resp[32].Estado);
                ClaseAcceso.VentasRealizadas_ = Convert.ToBoolean(resp[33].Estado);
                ClaseAcceso.ComprasvsVentas_ = Convert.ToBoolean(resp[34].Estado);
                ClaseAcceso.MovimientoProducto_ = Convert.ToBoolean(resp[35].Estado);
                ClaseAcceso.EstadisticaProducto_ = Convert.ToBoolean(resp[36].Estado);
                ClaseAcceso.AbrirCaja_ = Convert.ToBoolean(resp[37].Estado);
                ClaseAcceso.Clientes_ = Convert.ToBoolean(resp[38].Estado);
                ClaseAcceso.ClientesCrear_ = Convert.ToBoolean(resp[39].Estado);

                ClaseAcceso.ClientesEditar_ = Convert.ToBoolean(resp[40].Estado);
                ClaseAcceso.Proveedores_ = Convert.ToBoolean(resp[41].Estado);
                ClaseAcceso.ProveedoresCrear_ = Convert.ToBoolean(resp[42].Estado);
                ClaseAcceso.ProveedoresEditar_ = Convert.ToBoolean(resp[43].Estado);
                ClaseAcceso.Usuarios_ = Convert.ToBoolean(resp[44].Estado);
                ClaseAcceso.UsuariosNuevo_ = Convert.ToBoolean(resp[45].Estado);
                ClaseAcceso.UsuariosEditar_ = Convert.ToBoolean(resp[46].Estado);
                ClaseAcceso.UsuariosEliminar_ = Convert.ToBoolean(resp[47].Estado);
                ClaseAcceso.Computadoras_ = Convert.ToBoolean(resp[48].Estado);
                ClaseAcceso.ComputadorasNuevo_ = Convert.ToBoolean(resp[49].Estado);

                ClaseAcceso.ComputadorasEditar_ = Convert.ToBoolean(resp[50].Estado);
                ClaseAcceso.ComputadorasEliminar_ = Convert.ToBoolean(resp[51].Estado);
                ClaseAcceso.Categoria_ = Convert.ToBoolean(resp[52].Estado);
                ClaseAcceso.CategoriaNuevo_ = Convert.ToBoolean(resp[53].Estado);
                ClaseAcceso.CategoriaEditar_ = Convert.ToBoolean(resp[54].Estado);
                ClaseAcceso.CategoriaEliminar_ = Convert.ToBoolean(resp[55].Estado);
                ClaseAcceso.Medidas_ = Convert.ToBoolean(resp[56].Estado);
                ClaseAcceso.MedidasNuevo_ = Convert.ToBoolean(resp[57].Estado);
                ClaseAcceso.MedidasEditar_ = Convert.ToBoolean(resp[58].Estado);
                ClaseAcceso.MedidasEliminar_ = Convert.ToBoolean(resp[59].Estado);

                ClaseAcceso.Marcas_ = Convert.ToBoolean(resp[60].Estado);
                ClaseAcceso.MarcasNuevo_ = Convert.ToBoolean(resp[61].Estado);
                ClaseAcceso.MarcasEditar_ = Convert.ToBoolean(resp[62].Estado);
                ClaseAcceso.MarcasEliminar_ = Convert.ToBoolean(resp[63].Estado);
                ClaseAcceso.Administracion_ = Convert.ToBoolean(resp[64].Estado);
                ClaseAcceso.DisenioReporte_ = Convert.ToBoolean(resp[65].Estado);
                ClaseAcceso.CambiarConexion_ = Convert.ToBoolean(resp[66].Estado);
                ClaseAcceso.CopiadeSeguridad_ = Convert.ToBoolean(resp[67].Estado);
                ClaseAcceso.Estilos_ = Convert.ToBoolean(resp[68].Estado);
                ClaseAcceso.ClienteEliminar_ = Convert.ToBoolean(resp[69].Estado);

                ClaseAcceso.ProveedorEliminar_ = Convert.ToBoolean(resp[70].Estado);
                ClaseAcceso.VentasExportar_ = Convert.ToBoolean(resp[71].Estado);
                ClaseAcceso.ComprasExportar_ = Convert.ToBoolean(resp[72].Estado);
                ClaseAcceso.PonerenReserva_ = Convert.ToBoolean(resp[73].Estado);
                ClaseAcceso.BuscarReserva_ = Convert.ToBoolean(resp[74].Estado);
                ClaseAcceso.Modulos_ = Convert.ToBoolean(resp[75].Estado);
                ClaseAcceso.ModulosNuevo_ = Convert.ToBoolean(resp[76].Estado);
                ClaseAcceso.ModulosEditar_ = Convert.ToBoolean(resp[77].Estado);
                ClaseAcceso.ModulosEliminar_ = Convert.ToBoolean(resp[78].Estado);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Usuario actual requiere actualizar Permisos");
            }
        }

        /// <summary>
        /// Habilitamos y desavilitamos los botones
        /// </summary>
        private void opcionesMenu()
        {

            rPFactura.Visible = false;
            rPCompra.Visible = false;
            rPMasOpciones.Visible = false;
            rPProductos.Visible = false;
            rbPCuentasXCobrar.Visible = false;
            rbPClientes.Visible = false;
            rbPProveedores.Visible = false;
            rBPFacturasEmitidas_.Visible = false;
            rRPCompras.Visible = false;
            rBPPermisosUsuarios.Visible = false;
            rBPBodega.Visible = false;

            //Factura
            bBIFacturas_.Enabled = ClaseAcceso.Factura_;
            bBIGrabarFactura.Enabled = ClaseAcceso.FacturaGuardar_;
            bBIImprimirFactura.Enabled = ClaseAcceso.FacturaImprimir_;
            bBIFacturaCrearCliente.Enabled = ClaseAcceso.FacturaCrearCliente_;
            bBIFacturaClienteEditar.Enabled = ClaseAcceso.FacturaEditarCliente_;

            //Compra
            bBICompras_.Enabled = ClaseAcceso.Compra_;
            bBIGrabarFactura.Enabled = ClaseAcceso.CompraGuardar_;
            bBICompraProductoCrear.Enabled = ClaseAcceso.CompraCrearProducto_;
            bBICompraProductoEditar.Enabled = ClaseAcceso.CompraEditarProducto_;
            bBICompraProveedorCrear.Enabled = ClaseAcceso.CompraCrearProveedor_;
            bBICompraProveedorEditar.Enabled = ClaseAcceso.CompraEditarProveedor_;

            //Productos
            bBIProductos_.Enabled = ClaseAcceso.Productos_;
            bBIProductoCrear.Enabled = ClaseAcceso.ProductosCrear_;
            bBIProductoEditar.Enabled = ClaseAcceso.ProductosEditar_;
            bBIProductoEliminar.Enabled = ClaseAcceso.ProductosEliminar_;
            bBIProductoExportar.Enabled = ClaseAcceso.ProductosExporta_;
            bBIProductoQuitarMarcas.Enabled = ClaseAcceso.ProductosQuitarMarcas_;

            //Cuentas por Cobrar
            bBICuentasXCobrar_.Enabled = ClaseAcceso.CuentasporCobrar_;
            bBICuentasCobrarAbono.Enabled = ClaseAcceso.CuentasporCobrarNuevoAbono_;
            bBICuentasCobrarExportraExcel.Enabled = ClaseAcceso.CuentasporCobrarExportar_;

            //Consultas y resportes
            bBIConsultasReportes_.Enabled = ClaseAcceso.ConsultasReportes_;
            bBIFacturas.Enabled = ClaseAcceso.FacturasEmitidas_;
            btnComprasLista.Enabled = ClaseAcceso.ComprasRealizadas_;
            bBIMovimientoVenta.Enabled = ClaseAcceso.MovimientoProducto_;
            bBICompraVSVenta.Enabled = ClaseAcceso.ComprasvsVentas_;
            bBIMovimientoProduto.Enabled = ClaseAcceso.MovimientoProducto_;
            barButtonItem21.Enabled = ClaseAcceso.EstadisticaProducto_;
            bBICaja.Enabled = ClaseAcceso.AbrirCaja_;

            //Clientes
            bBIClientes_.Enabled = ClaseAcceso.Clientes_;
            bBICrearCiente.Enabled = ClaseAcceso.ClientesCrear_;
            barButtonItem9.Enabled = ClaseAcceso.ClientesEditar_;
            barButtonItem1.Enabled = ClaseAcceso.ClienteEliminar_;


            //Proveedores
            bBIProveedores_.Enabled = ClaseAcceso.Proveedores_;
            barButtonItem10.Enabled = ClaseAcceso.ProveedoresCrear_;
            barButtonItem11.Enabled = ClaseAcceso.ProveedoresEditar_;
            barButtonItem8.Enabled = ClaseAcceso.ProveedorEliminar_;

            //Administracion
            rPAdministracion.Visible = ClaseAcceso.Administracion_;
            
            barButtonItem15.Enabled = ClaseAcceso.Computadoras_;
            barButtonItem16.Enabled = ClaseAcceso.Categoria_;
            barButtonItem17.Enabled = ClaseAcceso.Medidas_;
            barButtonItem18.Enabled = ClaseAcceso.Marcas_;
            bBIDiseñoReporte.Enabled = ClaseAcceso.DisenioReporte_;
            bBICambiarTerminal.Enabled = ClaseAcceso.CambiarConexion_;
            bBIBaseDatos.Enabled = ClaseAcceso.CopiadeSeguridad_;
            ribbonPageGroup7.Visible = ClaseAcceso.Estilos_;
            barButtonItem14.Enabled = ClaseAcceso.Modulos_;

            //facturas
            bBIFacturasImprimir.Enabled = ClaseAcceso.VentasRealizadasImprimirTodo_;
            bBIFacturasExportar.Enabled = ClaseAcceso.VentasExportar_;

            //compras
            bBIComprasImpirmirTodo.Enabled = ClaseAcceso.ComprasRealizadasImprimirTodo_;
            bBIComprasExportar.Enabled = ClaseAcceso.ComprasExportar_;

            //Usuarios y Permisos
            bBIPermisosUsuarios_.Enabled = ClaseAcceso.Usuarios_;
            bBIPermisosUsuariosCrear.Enabled = ClaseAcceso.UsuariosNuevo_;
            bBIPermisosUsuariosEditar.Enabled = ClaseAcceso.UsuariosEditar_;
            bBIPermisosUsuariosEliminar.Enabled = ClaseAcceso.UsuariosEliminar_;
        }
        #endregion

        #region Acciones de formularios
        public RibbonFormMenu()
        {
            InitializeComponent();
        }
        private void RibbonFormMenu_Load(object sender, EventArgs e)
        {
            Mostrar();
            CargaInicio();
        }
        private void RibbonFormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close();
            Environment.Exit(1);
        }
        private void bBISalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }
        private void ribbonMenu_SelectedPageChanged(object sender, EventArgs e)
        {
            var resp = (RibbonControl)sender;
            switch (resp.SelectedPage.Text)
            {
                case "Inicio":
                    CargaInicio();
                    break;
                case "Factura":
                    CargaFactura();
                    break;
                case "Administracion":
                    CargarAdministracion();
                    break;
                case "Compra":
                    CargaCompra();
                    break;
                case "Consultas & Reportes":
                    CargaConsultasReportes();
                    break;
                case "Productos":
                    CargaProductos();
                    break;
                case "Cuentas Por Cobrar":
                    CargaCuentasCobrar();
                    break;
                case "Clientes":
                    CargaClientes();
                    break;
                case "Proveedores":
                    CargaProveedores();
                    break;
                case "Facturas":
                    CargaFacturasEmitidas();
                    break;
                case "Compras":
                    CargaComprasRealizadas();
                    break;
                case "Permisos & Usuarios":
                    CargaPermisosUsuarios();
                    break;
                case "Productos en Bodega":
                    CargaBodega();
                    break;
                case "Auditoria":
                    CargaAuditori();
                    break;
            }
        }
        private void xtraTabbedMdiManager1_PageRemoved(object sender, DevExpress.XtraTabbedMdi.MdiTabPageEventArgs e)
        {
            var pagina = (MdiTabPageEventArgs)e;
            switch (pagina.Page.MdiChild.Name)
            {
                case "Inicio":
                    ribbonPage4.Visible = false;
                    break;
                case "XfFacturaPlantilla":
                    rPFactura.Visible = false;
                    break;
                case "XfComprasPlantilla":
                    rPCompra.Visible = false;
                    break;
                case "XfConfiguracion":
                    //rPAdministracion.Visible = false;
                    break;
                case "XrFConsultasReportes":
                    rPMasOpciones.Visible = false;
                    break;
                case "XfClientesListado":
                    rbPClientes.Visible = false;
                    break;
                case "XfProveedorListado":
                    rbPProveedores.Visible = false;
                    break;
                case "XfProductAdmin":
                    rPProductos.Visible = false;
                    break;
                case "XfCuentasXCobrar":
                    rbPCuentasXCobrar.Visible = false;
                    break;
                case "XfFacturasEmitidas":
                    rBPFacturasEmitidas_.Visible = false;
                    break;
                case "XfComprasListado":
                    rRPCompras.Visible = false;
                    break;
                case "XfPermisosyUsuarios":
                    rBPPermisosUsuarios.Visible = false;
                    break;
                case "XfProductBodega":
                    rBPBodega.Visible = false;
                    break;
                case "XfAuditoria":
                    rBPBodega.Visible = false;
                    break;
            }

        }
        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            var pagina = (MdiTabPageEventArgs)e;
            try
            {
                ribbonStatusBar.Visible = false;
                switch (pagina.Page.Text)
                {
                    case "Inicio":
                        ribbonStatusBar.Visible = true;
                        ribbonMenu.SelectPage(ribbonPage4);
                        break;
                    case "Nueva Factura":
                        ribbonMenu.SelectPage(rPFactura);
                        break;
                    case "Nueva Compra":
                        ribbonMenu.SelectPage(rPCompra);
                        break;
                    case "Administracion":
                        ribbonMenu.SelectPage(rPAdministracion);
                        break;
                    case "Consultas & Reportes":
                        ribbonMenu.SelectPage(rPMasOpciones);
                        break;
                    case "Clientes":
                        ribbonMenu.SelectPage(rbPClientes);
                        break;
                    case "Proveedores":
                        ribbonMenu.SelectPage(rbPProveedores);
                        break;
                    case "Productos":
                        ribbonMenu.SelectPage(rPProductos);
                        break;
                    case "Cuentas por Cobrar":
                        ribbonMenu.SelectPage(rbPCuentasXCobrar);
                        break;
                    case "Facturas":
                        ribbonMenu.SelectPage(rBPFacturasEmitidas_);
                        break;
                    case "Compras":
                        ribbonMenu.SelectPage(rRPCompras);
                        break;
                    case "Permisos & Usuarios":
                        ribbonMenu.SelectPage(rBPPermisosUsuarios);
                        break;
                    case "Productos en Bodega":
                        ribbonMenu.SelectPage(rBPBodega);
                        break;
                    case "Auditoria":
                        ribbonMenu.SelectPage(rBPAuditoria);
                        break;
                    default:
                        //rPAdministracion.Visible = true;
                        break;

                }
            }
            catch (Exception) { }

        }
        private void bBIimpresora_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        #endregion

        #region Ventas
        private void bBIAbrirFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaFactura();
        }
        private void bBICarrito_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (formularioVenta != null)
                formularioVenta.NewFactura();

        }
        private void bBIFacturaBuscaProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(formularioVenta!=null)
                formularioVenta.ShowProductoBuscar();
        }
        private void bBICliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowClienteBuscar();
        }
        private void bBIGrabarFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.SaveFactura();
        }
        private void bBIFacturaCrearCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowClienteCrear();
        }
        private void bBIFacturaVentaQuitarFila_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.QuitarFila();
        }
        private void bBIFacturaClienteEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowClienteEditar();
        }
        private void bBIFacturaProductoEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowProductoEditar();
        }
        private void bBIFacturaReservar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowReservar();
        }
        private void bBIFacturaReservacionBuscar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.ShowReservarBuscar();
        }
        private void bBIFacturaRegistros_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.CargaProductos();
        }
        private void bBIImprimirFactura_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.Impresion();
        }
        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.CargaProductos();
        }
        private void bBIFacturaCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioVenta != null)
                formularioVenta.Cerrar();
        }
        #endregion

        #region Producto
        private void bBIProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaProductos();
        }
        private void bBIProductoCrear_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ShowCrearProducto();
        }
        private void bBIProductoEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ShowEditarProducto();
        }
        private void bBIProductoEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ShowEliminarProducto();
        }
        private void bBIProductoActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.Actualizar();
        }
        private void bBIProductoConExistencia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ProductosMayoresA0();
        }

        private void bBIProductoSinExistencia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ProductosMenoressA0();
        }
        XtraFormKardex formKardex;
        private void bBIProductoAuditoria_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
            {
                if (formKardex == null)
                {
                    formKardex = new XtraFormKardex();

                    formKardex.FormClosed += (o, ea) => formKardex = null;
                    formKardex.Show();
                }
                else
                {
                    if (formKardex.IsDisposed)
                    {
                        formKardex = new XtraFormKardex();

                        formKardex.FormClosed += (o, ea) => formKardex = null;
                        formKardex.Show();
                    }
                    else
                    {
                        formKardex.WindowState = FormWindowState.Normal;
                        formKardex.Activate();
                    }
                }
            }
            //formularioProducto.ActivarProductoAuditoria();
        }
        private void bBIProductoMovimiento_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ActivarProductoMovimiento();

        }
        private void bBIProductoExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ProductoExportar();
        }
        private void bBIProductosAvanzadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.ShowActivarColumnas();
        }
        private void btnProductosSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }
        private void bBIProductoQuitarMarcas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.QuitarMarcasEdicionProducto();
        }
        private void bBIProductoTraslado_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        XtProductoInventario productoInventario;
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
            {
                if (productoInventario == null)
                {
                    productoInventario = new XtProductoInventario();

                    productoInventario.FormClosed += (o, ea) => productoInventario = null;
                    productoInventario.Show();
                }
                else
                {
                    if (productoInventario.IsDisposed)
                    {
                        productoInventario = new XtProductoInventario();

                        productoInventario.FormClosed += (o, ea) => productoInventario = null;
                        productoInventario.Show();
                    }
                    else
                    {
                        productoInventario.WindowState = FormWindowState.Normal;
                        productoInventario.Activate();
                    }
                }
            }
        }
        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.Imprimir();
        }
        private void bBIProductoCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.Cerrar();
        }
        private void bBIProductosEnBodega_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProducto != null)
                formularioProducto.EnBodega();
        }
        #endregion

        #region Compras
        private void bBIAbrirCompra_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaCompra();
        }
        private void bBICompraNueva_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.NewCompra();
        }
        private void bBICompraGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.GuardarCompra();
        }
        private void bBICompraImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICompraProductos_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProductoBuscar();
        }
        private void bBICompraProductoCrear_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProductoCrear();
            
        }
        private void bBICompraProductoEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProductoEditar();
        }
        private void bBICompraActualizaInventario_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICompraProductoPorProveedor_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICompraBuscarProveedor_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProveedorBuscar();

        }
        private void bBICompraProveedorCrear_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProveedorCrear();
            
        }
        private void bBICompraProveedorEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.ShowProveedorEditar();
            
        }
        private void bBICompraEliminarFila_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.QuitarFila();
        }
        private void bBICompraRegistros_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }
        private void bBICompraCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCompra != null)
                formularioCompra.Cerrar();
        }
        #endregion

        #region Cuentas por Cobrar
        private void bBICuentasXCobrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaCuentasCobrar();
        }
        private void bBICuentasCobrarAbono_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.ShowAbonar();
        }
        private void bBICuentasCobrarNuevoRecargo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICuentasCobrarActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Actualizar();
        }
        private void bBICuentasCobrarChequesCobrar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICuentasCobrarDetalle_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICuentasCobrarResumen_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICuentasCobrarFacturasVencidas_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Vencidos();
        }
        private void bBICuentasCobrarClienteEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.CambiarCliente();
        }
        private void bBICuentasCobrarFacturaVistaPrevia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.ShowVistaPrevia();
        }
        private void bBICuentasCobrarFechaFiltro_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Fechas();
        }
        private void bBICuentasCobrarExportraExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.DocumentoExportar();
        }
        private void bBICuentasCobrarReportes_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Reporte();
        }
        private void bBICuentaCobrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.ShowHistorial();
        }
        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Imprimir();
        }
        private void barButtonItem13_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.VistaPrevia();
        }
        private void bBICuentasCobrarVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBICuentasCobrarCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCredito != null)
                formularioCredito.Cerrar();
        }
        #endregion

        #region Clientes
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaClientes();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.Crear();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.Editar();
        }
        private void bBIClientesActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.CargaClientes();
        }
        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.Eliminar();
        }
        private void bBIClientesImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.Imprimir();
        }
        private void bBIClientesVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIClientesCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioCliente != null)
                formularioCliente.Cerrar();
        }
        #endregion

        #region Proveedor

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaProveedores();
        }
        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.Crear();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.Editar();
        }
        private void bBIProveedoresActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.CargaClientes();
        }
        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.Eliminar();
        }
        private void bBIProveedorImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.Imprimir();
        }
        private void bBIProveedorVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIProveedorCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioProveedor != null)
                formularioProveedor.Cerrar();
        }
        #endregion

        #region Administracion
        XfConfiguracion formularioConfiguracion;

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
        }
        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            XfParametrizacionFactura mvc = new XfParametrizacionFactura();
            mvc.ShowDialog();
        }
        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Usuarios();

        }
        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Modulos();
        }
        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Terminales();
        }
        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Grupos();
        }
        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Medidas();
        }
        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarAdministracion();
            if (formularioConfiguracion != null)
                formularioConfiguracion.Marcas();
        }

        private void bBIConfiguracion_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        private void bBICambiarConexion_ItemClick(object sender, ItemClickEventArgs e)
        {
            var resp = new xfCambiarConexion
            {
                Text = e.Item.Caption
            };

            resp.ShowDialog();
        }
        private void bBIBaseDatos_ItemClick(object sender, ItemClickEventArgs e)
        {
            var resp = new XfCopiaBDD
            {
                Text = e.Item.Caption
            };

            resp.Show();
        }
        private void bBIDiseñoReporte_ItemClick(object sender, ItemClickEventArgs e)
        {
            XfDiseniadorReportes mvc = new XfDiseniadorReportes();
            mvc.Show();
        }
        private void skinRGB_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(new LecturaArchivo().mySkinSave((string)e.Item.Tag));
        }
        private void bBIAdministracionVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConfiguracion != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIAdministracionCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConfiguracion != null)
                formularioConfiguracion.Salir();
        }
        #endregion

        #region Consultas & Reportes
        private void bBIFacturas_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void btnComprasSinInventariar_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
        
        private void bBIMovimientoVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                formularioConsultasReportes.VentaRealizada();



        }
        
        private void bBICompraVSVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                formularioConsultasReportes.ComprasvsVentas();
        }
        
        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                formularioConsultasReportes.EstadisticaProducto();

        }
        
        private void bBIMovimientoProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                formularioConsultasReportes.MovimientoProducto();

        }
        
        private void btnInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            var resp = new Formularios.Inventario.XfVistaExistencia
            {
                MdiParent = this,
                Text = e.Item.Caption
            };

            resp.Show();
        }

        private void bBIAforo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var resp = new XtraFormAforo
            {
                Text = e.Item.Caption
            };

            if (Control(resp.Name))
                resp.Show();
        }

        private void bBICaja_ItemClick(object sender, ItemClickEventArgs e)
        {
            var resp = new XtraFormCaja
            {
                Text = e.Item.Caption
            };

            if (Control(resp.Name))
                resp.ShowDialog();
        }
        private void bBIConsultasReportesVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBICerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioConsultasReportes != null)
                formularioConsultasReportes.Cerrar();
        }
        #endregion

        #region Usuarios & Permisos


        private void bBIPermisosUsuariosCrear_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                permisosyUsuarios.Nuevo();
        }

        private void bBIPermisosUsuariosEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                permisosyUsuarios.Editar();
        }

        private void bBIPermisosUsuariosEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                permisosyUsuarios.Eliminar();
        }

        private void bBIPermisosUsuariosActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                permisosyUsuarios.function();
        }
        private void bBIPermisiosVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIPermisiosCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (permisosyUsuarios != null)
                permisosyUsuarios.Cerrar();
        }
        #endregion

        #region Cargar por Defecto
        private void CargaInicio()
        {
            if (XfInicio != null)
            {
                XfInicio.WindowState = FormWindowState.Normal;
                XfInicio.Focus();
            }
            else
            {
                XfInicio = new XfInicio()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                //XfInicio.FormClosed += (o, ea) => formularioCliente = null;
                XfInicio.FormClosed += (o, ea) => XfInicio = null;
                XfInicio.Show();
            }
        }
        private void CargaFactura()
        {
            if (formularioVenta != null)
            {
                formularioVenta.WindowState = FormWindowState.Normal;
                formularioVenta.Focus();
            }
            else
            {
                formularioVenta = new XfFacturaPlantilla
                {
                    MdiParent = this,
                    Text = "Nueva Factura"
                };
                formularioVenta.FormClosed += (o, ea) => formularioVenta = null;
                formularioVenta.Show();
            }
        }
        private void CargarAdministracion()
        {
            if (formularioConfiguracion != null)
            {
                formularioConfiguracion.WindowState = FormWindowState.Normal;
                formularioConfiguracion.Focus();
            }
            else
            {
                formularioConfiguracion = new XfConfiguracion
                {
                    MdiParent = this,
                    //Text = "Configuracion"
                };
                formularioConfiguracion.FormClosed += (o, ea) => formularioConfiguracion = null;
                formularioConfiguracion.Show();
            }
        }
        private void CargaCompra()
        {
            if (formularioCompra != null)
            {
                formularioCompra.WindowState = FormWindowState.Normal;
                formularioCompra.Focus();
            }
            else
            {
                formularioCompra = new XfComprasPlantilla
                {
                    MdiParent = this,
                    Text = "Nueva Compra"
                };
                formularioCompra.FormClosed += (o, ea) => formularioCompra = null;
                formularioCompra.Show();
            }
        }
        private void CargaProductos()
        {
            if (formularioProducto != null)
            {
                formularioProducto.WindowState = FormWindowState.Normal;
                formularioProducto.Focus();
            }
            else
            {
                formularioProducto = new XfProductAdmin
                {
                    MdiParent = this,
                    Text = "Productos"
                };
                formularioProducto.FormClosed += (o, ea) => formularioProducto = null;
                formularioProducto.Show();
            }
        }
        private void CargaCuentasCobrar()
        {
            if (formularioCredito != null)
            {
                formularioCredito.WindowState = FormWindowState.Normal;
                formularioCredito.Focus();
            }
            else
            {
                formularioCredito = new XfCuentasXCobrar
                {
                    MdiParent = this,
                    Text = "Cuentas por Cobrar"
                };

                formularioCredito.FormClosed += (o, ea) => formularioCredito = null;
                formularioCredito.Show();
            }
        }
        private void CargaClientes()
        {
            if (formularioCliente != null)
            {
            formularioCliente.WindowState = FormWindowState.Normal;
            formularioCliente.Focus();
        }
        else
        {
            formularioCliente = new XfClientesListado()
            {
                MdiParent = this,
                //Text = "Listado Clientes"
            };
            formularioCliente.FormClosed += (o, ea) => formularioCliente = null;
            formularioCliente.Show();
        }
        }
        private void CargaProveedores()
        {
            if (formularioProveedor != null)
            {
                formularioProveedor.WindowState = FormWindowState.Normal;
                formularioProveedor.Focus();
            }
            else
            {
                formularioProveedor = new XfProveedorListado()
                {
                    MdiParent = this
                };
                formularioProveedor.FormClosed += (o, ea) => formularioProveedor = null;
                formularioProveedor.Show();
            }
        }
        private void CargaConsultasReportes()
        {
            if (formularioConsultasReportes != null)
            {
                formularioConsultasReportes.WindowState = FormWindowState.Normal;
                formularioConsultasReportes.Focus();
            }
            else
            {
                formularioConsultasReportes = new XrFConsultasReportes()
                {
                    MdiParent = this
                    //Text = "Listado Proveedor"
                };
                formularioConsultasReportes.FormClosed += (o, ea) => formularioConsultasReportes = null;
                formularioConsultasReportes.Show();
            }
        }
        private void CargaFacturasEmitidas()
        {
            
            if (facturasEmitidas != null)
            {
                facturasEmitidas.WindowState = FormWindowState.Normal;
                facturasEmitidas.Focus();
            }
            else
            {
                facturasEmitidas = new XfFacturasEmitidas()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                facturasEmitidas.FormClosed += (o, ea) => facturasEmitidas = null;
                facturasEmitidas.Show();
            }
        }
        private void CargaComprasRealizadas()
        {
            if (ComprasListado != null)
            {
                ComprasListado.WindowState = FormWindowState.Normal;
                ComprasListado.Focus();
            }
            else
            {
                ComprasListado = new XfComprasListado()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                ComprasListado.FormClosed += (o, ea) => ComprasListado = null;
                ComprasListado.Show();
            }
        }
        private void CargaPermisosUsuarios()
        {
            if (permisosyUsuarios != null)
            {
                permisosyUsuarios.WindowState = FormWindowState.Normal;
                permisosyUsuarios.Focus();
            }
            else
            {
                permisosyUsuarios = new XfPermisosyUsuarios()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                permisosyUsuarios.FormClosed += (o, ea) => permisosyUsuarios = null;
                permisosyUsuarios.Show();
            }
        }
        private void CargaBodega()
        {
            if (ProductBodega != null)
            {
                ProductBodega.WindowState = FormWindowState.Normal;
                ProductBodega.Focus();
            }
            else
            {
                ProductBodega = new XfProductBodega()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                ProductBodega.FormClosed += (o, ea) => ProductBodega = null;
                ProductBodega.Show();
            }
        }
        private void CargaAuditori()
        {
            if (formularioAuditoria != null)
            {
                formularioAuditoria.WindowState = FormWindowState.Normal;
                formularioAuditoria.Focus();
            }
            else
            {
                formularioAuditoria = new XfAuditoria()
                {
                    MdiParent = this,
                    //Text = "Listado Clientes"
                };
                formularioAuditoria.FormClosed += (o, ea) => formularioAuditoria = null;
                formularioAuditoria.Show();
            }
        }
        #endregion

        #region Facturas Emitidas
        private void bBIFacturasImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.ImprimirDocumento();
        }

        private void bBIFacturasExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.Exportar();
        }

        private void bBIFacturasDetalle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.VerDetalle();

            //facturasEmitidas.MostrarDetalle();
        }

        private void bBIFacturasActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.function();
        }
        private void bBIFacturasImprimirSeleccion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.ImprimirSeleccion();
        }
        private void bBIFacturasEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.Editar();
        }

        private void bBIFacturasEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.Borrar();
        }
        private void bBIDevolucion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.Devolucion();
        }
        private void bBIDevolucionCambio_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.DevolucionCambio();
        }
        private void bBIFacturasVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }
        private void bBIFacturasCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.Cerrar();
        }
        private void bBIFacturasCabeceras_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.VerCabecera();
        }
        private void bBIFacturaVentanaDetalle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (facturasEmitidas != null)
                facturasEmitidas.MostrarDetalle();
        }
        #endregion

        #region Compras Realizadas
        private void bBIComprasImprimirSeleccion_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Imprimir();
        }

        private void bBIComprasEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Editar();
        }

        private void bBIComprasEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Eliminar();
        }

        private void bBIComprasImpirmirTodo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.ImprimirDocumento();
        }

        private void bBIComprasExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Exportar();
        }

        private void bBIComprasActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Actualizar();
        }

        private void bBIComprasVerDetalle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Detalle();
        }
        private void bBIComprasVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIComprasCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Cerrar();
        }
        private void bBIComprasCabecera_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Cabeceras();
        }

        private void bBIComprasDetalles_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ComprasListado != null)
                ComprasListado.Detalles();
        }
        #endregion


        #region Menu Principal
        private void bBIFacturas__ItemClick(object sender, ItemClickEventArgs e)
        {
            rPFactura.Visible = true;
            CargaFactura();
        }
        private void bBICompras__ItemClick(object sender, ItemClickEventArgs e)
        {
            rPCompra.Visible = true;
            CargaCompra();
        }
        private void bBIProductos__ItemClick(object sender, ItemClickEventArgs e)
        {
            rPProductos.Visible = true;
            CargaProductos();
        }
        private void bBIConsultasReportes__ItemClick(object sender, ItemClickEventArgs e)
        {
            rPMasOpciones.Visible = true;
            CargaConsultasReportes();
        }
        private void bBICuentasXCobrar__ItemClick(object sender, ItemClickEventArgs e)
        {
            rbPCuentasXCobrar.Visible = true;
            CargaCuentasCobrar();
        }
        private void bBIClientes__ItemClick(object sender, ItemClickEventArgs e)
        {
            rbPClientes.Visible = true;
            CargaClientes();
        }
        private void bBIProveedores__ItemClick(object sender, ItemClickEventArgs e)
        {
            rbPProveedores.Visible = true;
            CargaProveedores();
        }
        private void bBIFacturasEmitidas_ItemClick(object sender, ItemClickEventArgs e)
        {
            rBPFacturasEmitidas_.Visible = true;
            CargaFacturasEmitidas();
        }
        private void bBIComprasRealizadas_ItemClick(object sender, ItemClickEventArgs e)
        {
            rRPCompras.Visible = true;
            CargaComprasRealizadas();
        }
        private void bBIPermisosUsuarios__ItemClick(object sender, ItemClickEventArgs e)
        {
            rBPPermisosUsuarios.Visible = true;
            CargaPermisosUsuarios();
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            rBPBodega.Visible = true;
            CargaBodega();
        }



        #endregion

        #region Bodega
        private void bBIBodegaCrearProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void bBIBodegaEditarProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ProductBodega != null)
                ProductBodega.Movimiento();
        }
        private void barButtonItem24_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ProductBodega != null)
                ProductBodega.Actualizar();
        }

        private void bBIBodegaEliminarProducto_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void bBIBodegaAgregarExistencia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ProductBodega != null)
                ProductBodega.AnadirExistencia();
        }
        private void bBIBodegaVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ProductBodega != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIBodegaCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ProductBodega != null)
                ProductBodega.Cerrar();
        }
        #endregion
        private void bBISalir__ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
        #region Auditoria
        private void bBIAuditoria__ItemClick(object sender, ItemClickEventArgs e)
        {
            CargaAuditori();
        }

        private void bBIAuditoriRegistrosMaximo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioAuditoria != null)
                formularioAuditoria.Filas();
        }

        private void bBIAuditoriaActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioAuditoria != null)
                formularioAuditoria.Actualizar();
        }

        private void bBIAuditoriaVolver_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioAuditoria != null)
                ribbonMenu.SelectPage(ribbonPage4);
        }

        private void bBIAuditoriaCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (formularioAuditoria != null)
                formularioAuditoria.Cerrar();
        }

















        #endregion

        
    }
}