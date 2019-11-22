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
using Gm.Entities;
using Gm.Data;
using Gm.Core;

namespace Gm.NET
{
    public partial class XUCCompraDetalle : DevExpress.XtraEditors.XtraUserControl
    {
        public Factura factura;
        //private Repository<Factura> repositoryFactura;
        private Repository<FacturaDetalle> repositoryFacturaDetalle;
        private Repository<Kardex> repositoryKardex;
        private List<PurchasesAbvance> detalleFactura;
        private List<PurchasesAbvance> eliminados;
        private Repository<Producto> productos;

        bool Editar = false;
        public XUCCompraDetalle()
        {
            InitializeComponent();
            repositoryFacturaDetalle = new Repository<FacturaDetalle>();
            repositoryKardex = new Repository<Kardex>();
            
        }

        private void XUCCompraDetalle_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        private void Cargar()
        {
            detalleFactura = new List<PurchasesAbvance>();
            eliminados = new List<PurchasesAbvance>();
            productos = new Repository<Producto>();

            var resultadoFacturaDetalle = repositoryFacturaDetalle.Search(x => x.IDFactura == factura.IDFactura && x.Estado == true);

            foreach (var row in resultadoFacturaDetalle)
            {
                detalleFactura.Add(new PurchasesAbvance
                {
                    IDProducto = Convert.ToInt64(row.IDProducto),
                    Nombre = row.Producto.Nombre,
                    PrecioUnitario = Convert .ToSingle(row.Costo),
                    Cantidad = Convert.ToInt16(row.Unidades),
                    Iva = Convert.ToBoolean(row.Iva),
                    Medida = row.MedidaMetrica.Name,
                    IdMedida = Convert.ToInt64(row.IdMedidaMetrica),
                    Marca = row.Producto.Marca.NombreMarca,
                    Estado = Convert.ToBoolean(row.Estado),
                    Flete = Convert.ToSingle(row.FleteAplicado)
                });
            }
            gridControl1.DataSource = detalleFactura;

            btnGrabar.Enabled = Editar;
            btnEliminar.Enabled = Editar;
            btnAgregar.Enabled = Editar;
            gridView1.Columns["Cantidad"].OptionsColumn.AllowEdit = Editar;
            gridView1.Columns["PrecioUnitario"].OptionsColumn.AllowEdit = Editar;
            gridView1.Columns["Iva"].OptionsColumn.AllowEdit = Editar;

        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Editar = true;
            btnGrabar.Enabled = Editar;
            btnEliminar.Enabled = Editar;
            btnAgregar.Enabled = Editar;
            gridView1.Columns["Cantidad"].OptionsColumn.AllowEdit = Editar;
            gridView1.Columns["PrecioUnitario"].OptionsColumn.AllowEdit = Editar;
            gridView1.Columns["Iva"].OptionsColumn.AllowEdit = Editar;
            gridView1.Columns["Flete"].OptionsColumn.AllowEdit = Editar;
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            detalleFactura[gridView1.FocusedRowHandle].Estado = false;
            eliminados.Add(detalleFactura[gridView1.FocusedRowHandle]);
            detalleFactura.RemoveAt(gridView1.FocusedRowHandle);
            gridControl1.RefreshDataSource();
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XfCompraProductoAyuda mvc = new XfCompraProductoAyuda();
            mvc.ShowDialog();
            if (mvc.ProductoSeleccion != null)
            {
                var p = mvc.ProductoSeleccion;
                var nuevo = new PurchasesAbvance
                {
                    IDProducto = p.IDProducto,
                    Nombre = p.Nombre,
                    Cantidad = 0,
                    PrecioUnitario = 0,
                    Flete=0,
                    Medida = p.MedidaMetrica.Name,
                    IdMedida = p.MedidaMetrica.IdMedidaMetrica,
                    Marca = (p.Marca == null) ? "" : p.Marca.NombreMarca,
                    Iva = Convert.ToBoolean(p.Iva)
                };

                detalleFactura.Add(nuevo);
                
                gridControl1.RefreshDataSource();
            }
            
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            repositoryKardex = new Repository<Kardex>();
            try
            {

                //actualizamos los eliminado
                foreach (var row in eliminados)
                {
                    var resp = repositoryFacturaDetalle.Find(x => x.IDFactura == factura.IDFactura && x.IDProducto == row.IDProducto);
                    var kar = repositoryKardex.Find(x => x.IDProducto == row.IDProducto && x.IDFactura == "C" + factura.IDFactura);

                    if (resp != null)
                    {
                        resp.Estado = row.Estado;
                        if (!repositoryFacturaDetalle.Update(resp))
                            throw new Exception(repositoryFacturaDetalle.Error);

                        kar.Estado = "E";
                        if (!repositoryKardex.Update(kar))
                            throw new Exception(repositoryKardex.Error);
                    }
                }

                foreach (var row in detalleFactura)
                {
                    var resp = repositoryFacturaDetalle.Find(x => x.IDFactura == factura.IDFactura && x.IDProducto == row.IDProducto);
                    var repositoryProduct = new Repository<Producto>();
                    var pro = repositoryProduct.Find(x => x.IDProducto == row.IDProducto);

                    if (resp != null)
                    {
                        resp.Costo = Convert.ToDecimal(row.PrecioUnitario);
                        resp.Unidades = row.Cantidad;
                        resp.Iva = (Convert.ToBoolean(row.Iva) == true) ? Convert.ToInt16(General.Iva) : 0;
                        resp.FleteAplicado = Convert.ToDecimal(row.Flete);

                        if (!repositoryFacturaDetalle.Update(resp))
                            throw new Exception(repositoryFacturaDetalle.Error);

                        //actualizamos el producto
                        pro.PCAnterior = Convert.ToDecimal(row.PrecioUnitario);
                        repositoryProduct.Update(pro);
                        //actualizamos el kardex

                        var kar = repositoryKardex.Find(x=>x.IDProducto == resp.IDProducto && x.IDKardex == resp.IDKardex);
                        kar.ProductoEntra = row.Cantidad;
                        kar.ProductoEntraPrecio= Convert.ToDecimal(row.PrecioUnitario);
                        kar.Flete = Convert.ToDecimal(row.Flete);
                        repositoryKardex.Update(kar);

                    }
                    else
                    {
                        int contadorFacturaDetalle = repositoryFacturaDetalle.Count() + 1;
                        int contadorKardex = repositoryKardex.GetAll().Count + 1;

                        if (repositoryFacturaDetalle.Create(new FacturaDetalle
                        {
                            IDFacturaDetalle = contadorFacturaDetalle,
                            IDProducto = row.IDProducto,
                            Costo = Convert.ToDecimal(row.PrecioUnitario),
                            Unidades = row.Cantidad,
                            IDFactura = factura.IDFactura,
                            IDKardex = contadorKardex,
                            Iva = Convert.ToBoolean(row.Iva) ? Convert.ToInt16(General.Iva) : 0,
                            FleteAplicado = Convert.ToDecimal(row.Flete),
                            Estado = true,
                            FechaSistema = DateTime.Now,
                            IdMedidaMetrica = row.IdMedida,
                            EnAlmacen = row.Cantidad,
                            Siclo="C",
                            EnBodega=0
                        }) == null)
                            throw new Exception(repositoryFacturaDetalle.Error);

                        pro.PCAnterior = Convert.ToDecimal(row.PrecioUnitario);
                        repositoryProduct.Update(pro);

                        //actualizamos en kardex
                        if (repositoryKardex.Create(new Kardex
                        {
                            IDKardex = contadorKardex,
                            IDProducto = row.IDProducto,
                            ProductoEntra = row.Cantidad,
                            ProductoEntraPrecio = Convert.ToDecimal(row.PrecioUnitario),
                            ProductoSale = 0,
                            ProductoSalePrecio = 0,
                            IDFactura = "C" + factura.IDFactura,
                            IVA = Convert.ToBoolean(row.Iva) ? Convert.ToInt16(General.Iva) : 0,
                            Fecha = factura.Fecha,
                            FechaSistema = DateTime.Now,
                            Equivalencia = row.Cantidad,
                            Siclo = "R",
                            IdMedidaMetrica = row.IdMedida,
                            Flete = Convert.ToDecimal(row.Flete),
                            PrecioReal = Convert.ToDecimal((row.Flete+row.PrecioTotal)/row.Cantidad),
                            Estado = "A"
                        }) == null)
                            throw new Exception(repositoryKardex.Error);
                    }
                }
                
                XtraMessageBox.Show("Actualizado correcto");
                Editar = false;

                btnGrabar.Enabled = Editar;
                btnEliminar.Enabled = Editar;
                btnAgregar.Enabled = Editar;
                gridView1.Columns["Cantidad"].OptionsColumn.AllowEdit = Editar;
                gridView1.Columns["PrecioUnitario"].OptionsColumn.AllowEdit = Editar;
                gridView1.Columns["Iva"].OptionsColumn.AllowEdit = Editar;
            }
            catch(Exception ex)
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
    }
}
