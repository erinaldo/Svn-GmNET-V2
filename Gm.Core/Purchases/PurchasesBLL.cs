using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class PurchasesBLL
    {
        public long IDProducto
        {
            get;
            set;
        }
        public string CodBarras
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int? UconIva
        {
            get;
            set;
        }
        public float? PUconIva
        {
            get;
            set;
        }
        public int? UsinIva
        {
            get;
            set;
        }
        public float? PUsinIva
        {
            get;
            set;
        }
        public long? IdMedidaMetrica
        {
            get;
            set;
        }

        public float? ST1
        {
            get
            {
                return UconIva * PUconIva;
            }
        }
        public float? ST2
        {
            get
            {
                return UsinIva * PUsinIva;
            }
        }
        public float? SubTota {
            get
            {
                if(ST1!=null && ST2!=null)
                    return ST1 + ST2;
                else if (ST1 != null && ST2 == null)
                    return ST1;
                else if (ST1 == null && ST2 != null)
                    return ST2;
                return null;
            }
        }

        public string error
        {
            get;
            set;
        }

        public bool CrearCompra(Cliente arg, DateTime fecha, string NumFacura,List<PurchasesBLL> detalle, decimal? flete)
        {
            bool Resul = true;
            Cliente cliente;
            using (var resp = new Repository<Cliente>())
            {
                cliente = resp.Find(x=>x.Cedula==arg.Cedula);
                if (cliente == null)
                {
                    var row = resp.GetAll().Count;
                    row++;
                    arg.IDCliente = row;
                    cliente = resp.Create(arg);
                }
                if(cliente==null)
                {
                    Resul = false;
                    error = resp.Error;
                }
            }

            Factura factura=null;
            if (Resul)
            {
                using (var resp = new Repository<Factura>())
                {
                    var row = resp.GetAll().Count;
                    row++;
                    factura = resp.Create(new Factura
                    {
                        IDFactura=row,
                        IDCliente=cliente.IDCliente,
                        Numero=NumFacura,
                        Fecha=fecha,
                        Estado="A",
                        IDTerminal=Convert.ToInt16(General.Terminal),
                        FechaSistema=DateTime.Now,
                        Flete = flete
                    });
                    if (factura == null)
                    {
                        Resul = false;
                        error = resp.Error;
                    }
                }
            }
            ParametrosBLL p = new ParametrosBLL();
            if (Resul)
            {
                //con iva
                foreach(PurchasesBLL d in detalle)
                {
                    if (d.IDProducto != 0)
                    {
                        Repository<FacturaDetalle> de = new Repository<FacturaDetalle>();
                        if (d.UconIva > 0 && d.PUconIva>0)
                        {
                            if (!de.SQLQuery<FacturaDetalle>("EXEC Sp_FacturaDetalleGrabar {0}, {1}, {2}, {3}, {4}, {5}",
                            new object[] {
                            d.IDProducto,
                            d.PUconIva,
                            d.UconIva,
                            factura.IDFactura,
                            "C",
                            p.myIva
                            }))
                            {
                                Resul = false;
                                error = de.Error;
                                break;
                            }   
                        }
                        if (d.UsinIva > 0 && d.PUsinIva>0)
                        {
                            if (!de.SQLQuery<FacturaDetalle>("EXEC Sp_FacturaDetalleGrabar {0}, {1}, {2}, {3}, {4}, {5}",
                            new object[] {
                            d.IDProducto,
                            d.PUconIva,
                            d.UconIva,
                            factura.IDFactura,
                            "C",
                            0
                            }))
                            {
                                Resul = false;
                                error = de.Error;
                                break;
                            }
                        }
                    }
                }
            }

            return Resul;
        }
        public bool CrearCompra(Cliente arg, DateTime fecha, string NumFacura, List<PurchasesAbvance> detalle, decimal? flete)
        {
            bool Resul = true;
            Cliente cliente;
            using (var resp = new Repository<Cliente>())
            {
                cliente = resp.Find(x => x.Cedula == arg.Cedula);
                if (cliente == null)
                {
                    var row = resp.GetAll().Count;
                    row++;
                    arg.IDCliente = row;
                    arg.Estado = "A";
                    arg.FechaSistema = DateTime.Now;
                    cliente = resp.Create(arg);
                }
                if (cliente == null)
                {
                    Resul = false;
                    error = resp.Error;
                }
            }

            Factura factura = null;
            if (Resul)
            {
                using (var resp = new Repository<Factura>())
                {
                    var row = resp.GetAll().Count;
                    row++;
                    factura = resp.Create(new Factura
                    {
                        IDFactura = row,
                        IDCliente = cliente.IDCliente,
                        Numero = NumFacura,
                        Fecha = fecha,
                        Estado = "A",
                        IDTerminal = Convert.ToInt16(General.Terminal),
                        FechaSistema = DateTime.Now,
                        Flete = flete
                    });
                    if (factura == null)
                    {
                        Resul = false;
                        error = resp.Error;
                    }
                }
            }
            ParametrosBLL p = new ParametrosBLL();
            if (Resul)
            {
                //con iva
                foreach (PurchasesAbvance d in detalle)
                {
                    Repository<FacturaDetalle> de = new Repository<FacturaDetalle>();

                    if (!de.SQLQuery<FacturaDetalle>("EXEC Sp_FacturaDetalleGrabar {0}, {1}, {2}, {3}, {4}, {5}, {6}",
                        new object[] {
                            d.IDProducto,
                            //d.Precio,
                            d.Cantidad,
                            factura.IDFactura,
                            "C",
                            d.Iva,
                            d.IdMedida
                        }))
                    {
                        Resul = false;
                        error = de.Error;
                        break;
                    }
                }
            }

            return Resul;
        }
    }
}
