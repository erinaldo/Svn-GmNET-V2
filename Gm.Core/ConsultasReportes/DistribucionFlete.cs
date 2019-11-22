using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class DistribucionFlete
    {
        public List<EnRegistro> GetDistribuir(Factura resp)
        {
            var lista = new List<EnRegistro>();
            
            lista = (from row in new FacturaBLL().FacturaDetalle(Convert.ToInt32(resp.IDFactura))
                     where row.Estado==true
                     select new EnRegistro
                     {
                         IDFactura = Convert.ToInt32(row.IDFactura),
                         IDProduct = Convert.ToInt32(row.IDProducto),
                         Name = row.Producto.Nombre,
                         PrecioUnitario = Convert.ToDecimal(row.Costo),
                         Cantidad = row.Unidades,
                         IdKardex = Convert.ToInt32(row.IDKardex)
                     }).ToList();

            decimal? subTotal = lista.Sum(x => x.PrecioUnitario * x.Cantidad);

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Canculos(resp.Flete, Convert.ToDecimal(subTotal));
                lista[i].ObtenerIva(lista[i].IdKardex, lista[i].IDProduct, resp.IDFactura);
            }

            return lista;
        }

        /// <summary>
        /// Distribucion de Flete al producto y Actualizado de factura detalle compra
        /// </summary>
        /// <param name="resp">Factura</param>
        public void Distribuir(Factura resp)
        {
            var lista = new List<EnRegistro>();

            lista = (from row in new FacturaBLL().FacturaDetalle(Convert.ToInt32(resp.IDFactura))
                     select new EnRegistro
                     {
                         IDFactura = Convert.ToInt32(row.IDFactura),
                         IDProduct = Convert.ToInt32(row.IDProducto),
                         Name = row.Producto.Nombre,
                         PrecioUnitario = Convert.ToDecimal(row.Costo),
                         Cantidad = row.Unidades,
                         IdKardex = Convert.ToInt32(row.IDKardex)
                     }).ToList();

            decimal? subTotal = lista.Sum(x => x.PrecioUnitario * x.Cantidad);

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Canculos(resp.Flete, Convert.ToDecimal(subTotal));
                lista[i].ObtenerIva(lista[i].IdKardex, lista[i].IDProduct, resp.IDFactura);
            }

            //Actualizamos la factura detalle con el flete
            var detalle = new Repository<FacturaDetalle>();
            var product = new Repository<Producto>();
            var kadex = new Repository<Kardex>();

            foreach (var aux in lista)
            {
                var de = detalle.Find(x=>x.IDFactura==aux.IDFactura && x.IDProducto == aux.IDProduct);
                de.FleteAplicado = aux.Flete;

                var pr = product.Find(x=>x.IDProducto==aux.IDProduct);
                pr.PCAnterior = aux.PrecioReal;

                var ka = kadex.Find(x => x.IDProducto == aux.IDProduct && x.IDFactura == "C" + aux.IDFactura);
                ka.PrecioReal = ka.ProductoEntraPrecio;
                ka.ProductoEntraPrecio = aux.PrecioReal;

                //guardamos los valores nuevos
                detalle.Update(de);
                product.Update(pr);
                kadex.Update(ka);
                
            }


            //return lista;
        }
    }
}
