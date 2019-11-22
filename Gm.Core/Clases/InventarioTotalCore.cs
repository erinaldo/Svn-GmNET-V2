using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class InventarioTotalCore
    {
        public int IdProducto { get; set; }
        public string Name { get; set; }
        public int Cantidad { get; set; }
        public string En { get; set; }
        public DateTime Fecha { get; set; }
        
        public List<InventarioTotalCore> Lista()
        {
            var cellar = new Repository<Cellar>().GetAll().FindAll(x => x.Sate == true);
            var product = new Repository<Producto>().GetAll().FindAll(x => x.Estado == "A");
            var medidam = new Repository<MedidaMetrica>().GetAll();
            var factura = new Repository<Factura>().GetAll().FindAll(x => x.Estado == "A");

            var resp = new List<InventarioTotalCore>();

            resp.AddRange((from c in cellar
                           join p in product
                           on c.IDProducto equals p.IDProducto
                           join m in medidam
                           on c.IdPorMayorMedida equals m.IdMedidaMetrica
                           //join f in factura
                           //on c.IDFactura equals f.IDFactura
                           where c.PorMayor > 0
                           select new InventarioTotalCore
                           {
                               IdProducto = Convert.ToInt32(p.IDProducto),
                               Name = p.Nombre,
                               Cantidad = (Convert.ToInt16(c.PorMayor) - Convert.ToInt16(c.SalePorMayor)),
                               En = m.Name,
                           }).ToList());

            resp.AddRange((from c in cellar
                           join p in product
                           on c.IDProducto equals p.IDProducto
                           join m in medidam
                           on c.IdPorMenorMedida equals m.IdMedidaMetrica
                           //join f in factura
                           //on c.IDFactura equals f.IDFactura
                           where c.PorMenor > 0
                           select new InventarioTotalCore
                           {
                               IdProducto = Convert.ToInt32(p.IDProducto),
                               Name = p.Nombre,
                               Cantidad = (Convert.ToInt16(c.PorMenor) - Convert.ToInt16(c.SalePorMenor)),
                               En = m.Name,
                           }).ToList());

            var temp = resp.
                GroupBy(l => new { l.IdProducto, l.En, l.Name }).
                Select(cl => new InventarioTotalCore
                {
                    IdProducto=cl.Key.IdProducto,
                    Name = cl.Key.Name,
                    Cantidad = cl.Sum(x => x.Cantidad),
                    En = cl.Key.En

                }).ToList();

            return temp;
        }

    }
}
