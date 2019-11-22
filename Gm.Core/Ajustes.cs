using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class Ajustes
    {
        public string NumFactura { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Entro { get; set; }
        public int? LoqueHay { get; set; }
        public int? EnBodega { get; set; }
        public Ajustes()
        {

        }

        //Controla si en la compra hay en existencia y lo pone en cero si no lo hay
        public void Ajustar(long IDProducto)
        {
            var kardex = new Repository<Kardex>();

            //consultamos el producto que aun no este ajustado
            var resp = (from a in kardex.GetAll()
                        where a.IDProducto == IDProducto && a.Movimiento != "F" && a.Equivalencia > 0 && a.Estado=="A"
                        orderby a.IDKardex 
                        select a).ToList();

            //Realizamos una subconsulta por la medio de las referencias, compramos lo que sale versus lo que entro
            foreach(var row in resp)
            {
                var total = (from a in kardex.GetAll()
                             where a.Referencia == row.IDKardex && a.IDProducto == IDProducto && a.Estado=="A"
                             select a).Sum(x => x.Equivalencia) * -1;

                if(row.ProductoEntra == total)
                {
                    row.Residuo = 0;
                    row.Movimiento = "F";
                    kardex.Update(row);
                }
                else 
                {
                    if (row.ProductoEntra > total)
                    {
                        //row.Residuo = row.ProductoEntra - (total + sale);
                        row.Residuo = row.ProductoEntra - (total);
                        row.Movimiento = "A";
                        kardex.Update(row);
                        break;
                    }
                }
            }
        }
        //Obtenemos el seguimiento del producto en las facturas
        public List<Ajustes> Seguimiento(long IDProducto)
        {
            var resp = new Repository<Kardex>().Search(x => x.IDProducto == IDProducto && x.Equivalencia > 0);
            List<Ajustes> ajustes = new List<Ajustes>();
            var fac = new Repository<Factura>();


            foreach(var a in resp)
            {
                string num = string.Empty;

                if (a.IDFactura.Contains('I'))
                    num = a.IDFactura;
                else
                {
                    long IDF = Convert.ToInt64(a.IDFactura.Remove(0, 1));
                    var r = fac.Find(x => x.IDFactura == IDF);
                    num = "C" + r.Numero;
                }
                    

                ajustes.Add(new Ajustes
                {
                    NumFactura = num,
                    Fecha = a.Fecha,
                    Entro = a.ProductoEntra,
                    LoqueHay = (a.Residuo==null)?a.ProductoEntra:a.Residuo
                });
            }

            return ajustes;
        }
        public List<Ajustes> Movimiento(long IDProducto)
        {
            var _facturaDetalle = new Repository<FacturaDetalle>().Search(x => x.IDProducto == IDProducto && (x.Siclo == "C" || x.Siclo == "I") && x.Estado == true);
            var _facturaCabecera = new Repository<Factura>();

            List<Ajustes> lista=new List<Ajustes>();

            foreach(var fila in _facturaDetalle)
            {
                var aux = _facturaCabecera.Find(x=>x.IDFactura==fila.IDFactura);
                lista.Add(new Ajustes
                {
                    NumFactura = aux.Numero,
                    Fecha= aux.Fecha,
                    Entro = fila.Unidades,
                    LoqueHay = (fila.EnAlmacen==null?0:fila.EnAlmacen)+(fila.EnDevolucion==null?0:fila.EnDevolucion),
                    EnBodega = fila.EnBodega
                });
            }
            return lista.Take(10).ToList();
        }
    }
}
