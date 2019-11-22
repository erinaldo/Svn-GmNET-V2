using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class MovimientoKardexBLL
    {
        public string Transaccion { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }

        public MovimientoKardexBLL()
        {   
        }
        public List<MovimientoKardexBLL> Cargar()
        {
            KardexBLL metodo = new KardexBLL();

            List<MovimientoKardexBLL> Datos = new List<MovimientoKardexBLL>();

            var compra = metodo.Datos.Where(a=>a.Estado=="A").GroupBy(a => a.Fecha)
                .Select(l => new MovimientoKardexBLL
                {
                    Transaccion = "Compra",
                    Monto = (decimal)l.Sum(c => c.ProductoEntra * c.ProductoEntraPrecio),
                    Fecha= l.First().Fecha.GetValueOrDefault().Date
                }
                ).ToList();

            var venta = metodo.Datos.Where(a=>a.Estado=="A").GroupBy(a => a.Fecha)
                .Select(l => new MovimientoKardexBLL
                {
                    Transaccion = "Venta",
                    Monto = (decimal)l.Sum(c => c.ProductoSale * c.ProductoSalePrecio),
                    Fecha = l.First().Fecha.GetValueOrDefault().Date
                }
                ).ToList();

            Datos.AddRange(compra.ToList());
            Datos.AddRange(venta.ToList());

            return Datos;
        }
        private void LlenarData()
        {

        }
    }
}
