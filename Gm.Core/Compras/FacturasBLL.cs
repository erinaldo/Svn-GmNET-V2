using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;
using Gm.Core.Generales;

namespace Gm.Core
{
    public class FacturaBLL
    {
        public event EventHandler ProgressStatus;
        public event EventHandler MessageText;
        public string error;
        public virtual void  onProcess(ProcessEventArgs e)
        {
            ProgressStatus?.Invoke(this, e);
        }
        public virtual void onMessageTex(MesageEventArg e)
        {
            MessageText?.Invoke(this, e);
        }

        private List<FacturaDetalleBLL> detalle;
        public char tipoMovimiento =default(char);

        //private readonly char Venta;
        private readonly char Compra = 'C';
        private readonly List<FacturaDetalle> facturaDetalles = new List<FacturaDetalle>();
        private readonly List<Kardex> kardices = new List<Kardex>();

        
        public FacturaBLL()
        {
            detalle = new List<FacturaDetalleBLL>();
            for (int i = 0; i < 30; i++)
                Detalle.Add(new FacturaDetalleBLL());
        }

        public List<FacturaDetalleBLL> Detalle { get => detalle; set => detalle = value; }
        public bool Grabar(Cliente arg, string Nfactura, DateTime fecha, ref string error)
        {
            try
            {
                //grabamos la cabecera
                Factura fca = new Factura();
                fca.IDCliente = arg.IDCliente;
                fca.Numero = Nfactura;
                fca.Estado = "A";
                fca.Fecha = fecha;
                fca.FechaSistema = DateTime.Now;
                fca.IDTerminal = Convert.ToInt16(General.Terminal);

                var repsF = new Repository<Factura>();
                fca = repsF.Create(fca);
                if (fca == null)
                    throw new Exception("Creacion de Cabecera: "+repsF.Error);

                int TotalLineas = Detalle.Count(a => a.Unidades > 0);
                int LineaGrabada = 0;


                foreach (FacturaDetalleBLL d in Detalle)
                {
                    if (d.producto.IDProducto > 0)
                    {
                        Repository<FacturaDetalle> de = new Repository<FacturaDetalle>();

                        if (!de.SQLQuery<FacturaDetalle>("EXEC Sp_FacturaDetalleGrabar {0}, {1}, {2}, {3}, {4}",
                            new object[] {
                            d.producto.IDProducto,
                            d.Costo,
                            d.Unidades,
                            fca.IDFactura,
                            tipoMovimiento
                            }))
                            throw new Exception("Creacion de Detalle: "+de.Error);
                        onProcess(new ProcessEventArgs(++LineaGrabada, TotalLineas));
                    }
                    else
                        break;
                }
                return true;
            }
            catch(Exception ex)
            {
                error = ex.Message;
            }
            return false;
        }
        public bool Grabar(Cliente arg, string Nfactura, DateTime fecha)
        {
            try
            {
                //grabamos la cabecera
                Factura fca = new Factura();
                fca.IDCliente = arg.IDCliente;
                fca.Numero = Nfactura;
                fca.Estado = "A";
                fca.Fecha = fecha;
                fca.FechaSistema = DateTime.Now;
                fca.IDTerminal = Convert.ToInt16(General.Terminal);

                var repsF = new Repository<Factura>();
                fca = repsF.Create(fca);
                if (fca == null)
                    throw new Exception("Creacion de Cabecera: " + repsF.Error);

                int TotalLineas = Detalle.Count(a => a.Unidades > 0);
                int LineaGrabada = 0;


                foreach (FacturaDetalleBLL d in Detalle)
                {
                    if (d.producto.IDProducto > 0)
                    {
                        Repository<FacturaDetalle> de = new Repository<FacturaDetalle>();

                        if (!de.SQLQuery<FacturaDetalle>("EXEC Sp_FacturaDetalleGrabar {0}, {1}, {2}, {3}, {4}",
                            new object[] {
                            d.producto.IDProducto,
                            d.Costo,
                            d.Unidades,
                            fca.IDFactura,
                            tipoMovimiento
                            }))
                            throw new Exception("Creacion de Detalle: " + de.Error);
                        onProcess(new ProcessEventArgs(++LineaGrabada, TotalLineas));
                    }
                    else
                        break;
                }
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return false;
        }
        public Producto Find(string codigo)
        {
            var resp = new Repository<Producto>();
            Producto item = resp.Find(a => a.CodBarra == codigo);
            return item;
        }
        public Producto Find(int id)
        {
            var resp = new Repository<Producto>();
            Producto item = resp.Find(a => a.IDProducto == id);
            return item;
        }
        public void Add(FacturaDetalleBLL item, Producto arg)
        {
            FacturaDetalleBLL resp = detalle.Find(a => a.producto.IDProducto == arg.IDProducto);
            if (resp==null)
             {
                item.producto.IDProducto = arg.IDProducto;
                item.Costo = arg.PVenta1;
                item.Unidades = 1;
                item.SubTotal = item.Costo * item.Unidades;
            }
            else
            {
                resp.producto.IDProducto = arg.IDProducto;
                //resp.Costo = resp.Costo;
                resp.Unidades +=  1;
                resp.SubTotal = arg.PVenta1 * resp.Unidades;
                item.CodBarra = "";
            }
            

        }
        //Compras 
        public List<VistaFacturaCompra> MostrarCompras()
        {
            var resp = new Repository<VistaFacturaCompra>().GetAll();
            
            return resp;
        }
        public void Grabar(VistaFacturaCompra arg)
        {
            var resp = new Repository<VistaFacturaCompra>();
            VistaFacturaCompra item = resp.Find(a => a.IDFactura == arg.IDFactura);
            item.Estado = arg.Estado;

            resp.Update();
        }
        //Ventas
        public List<VistaFacturaVenta> MostrarVentas()
        {
            var resp = new Repository<VistaFacturaVenta>();
            return resp.GetAll(); 
        }
        public void Grabar(VistaFacturaVenta arg)
        {
            var resp = new Repository<VistaFacturaVenta>();
            VistaFacturaVenta item = resp.Find(a => a.IDFactura == arg.IDFactura);
            item.Estado = arg.Estado;

            resp.Update();
        }
        public List<FacturaDetalle> FacturaDetalle(int IDFactura)
        {
            var resp = new Repository<FacturaDetalle>();
            return resp.Search(a => a.IDFactura == IDFactura);
        }
        public List<FacturaDetalle> FacturaDetalle(List<int> Facturas)
        {
            
            var resp = new List<FacturaDetalle>();

            foreach (int row in Facturas)
            {
                var aux = new Repository<FacturaDetalle>();
                resp.AddRange(aux.Search(a => a.IDFactura == row));
            }

            return resp;
        }
        public List<Factura> Faturas()
        {
            var resp = new Repository<Factura>();
            return resp.Search(a => a.Estado=="A");
        }
        public bool Delete(Factura arg)
        {
            bool Resp = true;

            using (var resp = new Repository<Factura>())
            {
                Factura item = resp.Find(a => a.IDFactura == arg.IDFactura);
                item.Estado = arg.Estado;
                if (!string.IsNullOrEmpty(arg.Observacion))
                    item.Observacion = arg.Observacion;

                if (!resp.Update(item))
                {
                    Resp = false;
                    error = resp.Error;   
                }
            }
            return Resp;   
        }

        public bool CrearFactura(Cliente cliente, DateTime fecha, string numFactura, List<PurchasesAbvance> detalle, decimal? flete, char Tipo)
        {
            bool Result = true;
            Cliente cli = cliente;
            Factura fac = null;
            long IdFactura;
            long IDFactura;

            var repositoryFactura = new Repository<Factura>();
            var repositoryDetalle = new Repository<FacturaDetalle>();
            var repositoryKardex = new Repository<Kardex>();
            var repositoryProvee = new Repository<Proveedor>();
            var repositoryProduct = new Repository<Producto>();

            try
            {
                //grabamos la cabecera factura
                int rowFactura = repositoryFactura.Count() + 1;

                fac = repositoryFactura.Create(new Factura
                {
                    IDFactura = rowFactura,
                    IDCliente = cli.IDCliente,
                    Numero = String.Format("{0:00000}", numFactura),
                    Estado = "A",
                    Fecha = fecha,
                    FechaSistema = DateTime.Now,
                    IDTerminal = Convert.ToInt16(General.Terminal),
                    Flete = flete,
                    Tipo="C"
                });
                IDFactura = fac.IDFactura;
                IdFactura = IDFactura;
                if (fac == null)
                    throw new Exception(repositoryFactura.Error);

                //grabamos el detalle
                int rowDetalle = repositoryDetalle.Count() + 1;
                int rowKardex = repositoryKardex.Count() + 1;

                foreach (PurchasesAbvance de in detalle)
                {

                    facturaDetalles.Add(new FacturaDetalle
                    {
                        IDFacturaDetalle = rowDetalle++,
                        IDProducto = de.IDProducto,
                        Costo = Convert.ToDecimal(de.PrecioUnitario),
                        Unidades = de.Cantidad,
                        IDFactura = fac.IDFactura,
                        FechaSistema = DateTime.Now,
                        IdMedidaMetrica = de.IdMedida,
                        IDKardex = rowKardex,
                        Iva = de.Iva? Convert.ToInt16(General.Iva):0,
                        Estado = true,
                        FleteAplicado = Convert.ToDecimal(de.Flete),
                        EnAlmacen = de.Ahorra,
                        EnBodega = de.ParaBodega,
                        Siclo="C"
                    });

                    //Obtenemos las compras
                    kardices.Add(new Kardex
                    {
                        IDKardex = rowKardex++,
                        IDProducto = de.IDProducto,
                        ProductoEntra = de.Cantidad+de.ParaBodega,
                        ProductoEntraPrecio =Convert.ToDecimal( de.PrecioUnitario),
                        ProductoSale = 0,
                        ProductoSalePrecio = 0,
                        IDFactura = string.Format("{0}{1}", Compra, fac.IDFactura),
                        IVA = Convert.ToInt16(new ParametrosBLL().myIva),
                        Fecha = fac.Fecha,
                        Estado = "A",
                        FechaSistema = DateTime.Now,
                        Equivalencia = de.Cantidad,
                        //Referencia = Convert.ToInt32(item.IDFactura.Replace(Compra, ' ')),
                        IdMedidaMetrica = de.IdMedida,
                        Siclo = "R",
                        Flete= Convert.ToDecimal(de.Flete),
                        PrecioReal = Convert.ToDecimal(de.PrecioCompraUnitario)
                    });

                    //creamos el registro de proveedor
                    var au = repositoryProvee.Find(x => x.IDCliente == cliente.IDCliente && x.IDProducto == de.IDProducto);
                    if(au==null)
                    {
                        repositoryProvee.Create(new Proveedor
                        {
                            IDProducto = de.IDProducto,
                            IDCliente = cliente.IDCliente
                        });
                    }
                    
                    //Obtenemos la existencia actual y sumamos los que se compra
                    var pro = repositoryProduct.Find(x=>x.IDProducto==de.IDProducto);
                    pro.ExistenciaActual = pro.ExistenciaActual + de.Cantidad;
                    pro.EnBodega = ((pro.EnBodega==null)?0:pro.EnBodega) + de.ParaBodega;
                    pro.PCAnterior = Convert.ToDecimal(de.PrecioCompraUnitario);
                    repositoryProduct.Update(pro);

                    
                }

                repositoryDetalle.AddRange(facturaDetalles);
                if (!repositoryDetalle.Save())
                    throw new Exception(repositoryDetalle.Error);

                repositoryKardex.AddRange(kardices);
                if (!repositoryKardex.Save())
                    throw new Exception(repositoryKardex.Error);

                //Realizamos la distribucion de Flete al producto comprado
                //new DistribucionFlete().Distribuir(fac);
                //Realizamos el ajuste
                //foreach (var row in detalle)
                //    new Ajustes().Ajustar(row.IDProducto);
                
            }
            catch (Exception ex)
            {
                //realizamos el rolbak
                repositoryDetalle.RemoveRange(facturaDetalles);
                repositoryKardex.RemoveRange(kardices);
                repositoryFactura.Remove(fac);

                error = ex.Message.ToString();
                Result = false;
            }

            return Result;
        }
        
    }
}
