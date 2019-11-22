using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class DevolucionProducto
    {
        
        public static void _Devolucion(DevolucionCore fila)
        {
            Repository<Factura> repositoryFac = new Repository<Factura>();
            Repository<FacturaDetalle> repositoryFacDet = new Repository<FacturaDetalle>();
            Repository<Kardex> repositoryKar = new Repository<Kardex>();
            Repository<Devolucion> repositoryDev = new Repository<Devolucion>();

            RetornoProducto(fila.IDProducto, fila.Sale);

            var deta = repositoryFacDet.Find(x => x.IDFactura == fila.IDFactura && x.IDProducto == fila.IDProducto);
            deta.Movimiento = "D";
            deta.EnDevolucion = fila.Sale;
            deta.Unidades = fila.Queda;

            repositoryFacDet.Update(deta);

            string IDF = "V" + fila.IDFactura;
            var kar = repositoryKar.Search(x => x.IDFactura == IDF && x.IDProducto == fila.IDProducto);

            foreach (var i in kar)
            {
                i.Siclo = "D";
                repositoryKar.Update(i);
            }

            var coun = repositoryDev.Count();
            //grabamos en historial de devoluciones

            repositoryDev.Create(new Devolucion
            {
                IDDevolucion = coun + 1,
                IDProducto = Convert.ToInt64(fila.IDProducto),
                IDFactura = Convert.ToInt64(fila.IDFactura),
                Costo = fila.Costo,
                Unidad = fila.Sale,
                IDMedida = fila.IdMedidaMetrica,
                IDKardex = fila.IDKardex
            });
        }

        public static bool _Eliminar(long? IDFactura, out string Error)
        {
            Repository<FacturaDetalle> repositoryFacDet = new Repository<FacturaDetalle>();
            Repository<Kardex> repositoryKar = new Repository<Kardex>();
            Repository<Factura> repositoryFac = new Repository<Factura>();
            bool Result = true;
            Error = null;

            try
            {
                var ventas = repositoryFacDet.Search(x => x.IDFactura == IDFactura);
                foreach (var fila in ventas)
                {
                    //devuelvo a existencia lo que estaba vendido
                    RetornoProducto(fila.IDProducto, fila.Unidades);

                    //desabilitamos la linea vendida
                    var det = repositoryFacDet.Find(x => x.IDProducto == fila.IDProducto && x.IDFactura == fila.IDFactura);
                    det.Estado = false;
                    if (!repositoryFacDet.Update(det))
                    {
                        Result = false;
                        throw new Exception(repositoryFacDet.Error);
                    }

                    //desactivamos en kardex la transaccion
                    var kar = repositoryKar.Search(x => x.IDFactura == "V" + fila.IDFactura && x.IDProducto == fila.IDProducto);
                    foreach (var row in kar)
                    {
                        row.Estado = "E";
                        if (!repositoryKar.Update(row))
                        {
                            Result = false;
                            throw new Exception(repositoryKar.Error);
                        }
                    }
                }
                var fac = repositoryFac.Find(x => x.IDFactura == IDFactura);
                fac.Estado = "E";
                if (!repositoryFac.Update(fac))
                {
                    Result = false;
                    throw new Exception(repositoryFac.Error);
                }
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }

            return Result;
        }
        public static bool _EliminarCompra(long? IDFactura, out string Error)
        {
            Repository<FacturaDetalle> repositoryFacDet = new Repository<FacturaDetalle>();
            Repository<Kardex> repositoryKar = new Repository<Kardex>();
            Repository<Factura> repositoryFac = new Repository<Factura>();
            bool Result = true;
            Error = null;

            try
            {
                var compras = repositoryFacDet.Search(x => x.IDFactura == IDFactura);
                foreach (var fila in compras)
                {

                    //desabilitamos la linea vendida
                    var det = repositoryFacDet.Find(x => x.IDProducto == fila.IDProducto && x.IDFactura == fila.IDFactura);
                    det.Estado = false;
                    if (!repositoryFacDet.Update(det))
                    {
                        Result = false;
                        throw new Exception(repositoryFacDet.Error);
                    }

                    //desactivamos en kardex la transaccion
                    var kar = repositoryKar.Search(x => x.IDFactura == "C" + fila.IDFactura && x.IDProducto == fila.IDProducto);
                    foreach (var row in kar)
                    {
                        row.Estado = "E";
                        if (!repositoryKar.Update(row))
                        {
                            Result = false;
                            throw new Exception(repositoryKar.Error);
                        }
                    }
                }
                var fac = repositoryFac.Find(x => x.IDFactura == IDFactura);
                fac.Estado = "E";
                if (!repositoryFac.Update(fac))
                {
                    Result = false;
                    throw new Exception(repositoryFac.Error);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return Result;
        }



        /// <summary>
        /// Realiza el retono de la cantidad de Productos a las facturas compras
        /// </summary>
        /// <param name="IDProducto">Codigo de producto</param>
        /// <param name="Sale">Cantidad que sustraida</param>
        private static void RetornoProducto(long? IDProducto, int? Sale)
        {

            Repository<FacturaDetalle> repositoryFacDet = new Repository<FacturaDetalle>();

            var comprasLista = (from compras in repositoryFacDet.Search(x => x.Siclo != "V" && x.Estado == true)
                                where compras.IDProducto == IDProducto &&
                                compras.Unidades >
                                (
                                (compras.EnAlmacen == null ? 0 : compras.EnAlmacen) +
                                (compras.EnBodega == null ? 0 : compras.EnBodega) +
                                (compras.EnDevolucion == null ? 0 : compras.EnDevolucion)
                                )
                                select compras).OrderByDescending(x => x.IDFacturaDetalle).ToList();

            int? Devolucion = Sale;

            //devuelvo todos los productos a almacen
            for (int i = 0; i < comprasLista.Count; i++)
            {
                int? EnAlmacen = comprasLista[i].EnAlmacen;
                int? EnBodega = comprasLista[i].EnBodega;

                int? residuo = comprasLista[i].Unidades - (EnAlmacen + EnBodega + Devolucion);
                if (residuo > 0)
                {
                    comprasLista[i].EnDevolucion = Devolucion;
                    comprasLista[i].Movimiento = "D";
                    repositoryFacDet.Update(comprasLista[i]);

                    break;
                }
                comprasLista[i].EnDevolucion = residuo * -1;
                comprasLista[i].Movimiento = "D";
                Devolucion = Devolucion + residuo;
                repositoryFacDet.Update(comprasLista[i]);
            }
        }
    }
}
