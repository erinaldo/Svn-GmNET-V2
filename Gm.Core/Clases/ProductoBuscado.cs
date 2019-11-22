using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class ProductoBuscado
    {
        public long? IDProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal? PV1 { get; set; }
        public MedidaMetrica medida { get; set; }
        public Marca marca { get; set; }
        public int? Existencia { get; set; }

        public ProductoBuscado()
        {
            medida = new MedidaMetrica();
            marca = new Marca();
        }
        /// <summary>
        /// Obtiene la existencia de productos
        /// </summary>
        /// <returns></returns>
        public List<ProductoBuscado> ProductosList()
        {
            var spFacturas = new Repository<Sp_MovimientoFactura_Result>().SQLQuery("EXEC Sp_MovimientoFactura");

            //Consulta todos los producto comprados
            var resp = spFacturas
                .GroupBy(l => l.IdProducto)
                .Select(cl => new Sp_MovimientoFactura_Result
                {
                    IdProducto = cl.First().IdProducto,
                    Nombre = cl.First().Nombre,
                    Unidades = cl.Sum(c => c.Unidades)
                }).ToList();

            ///Cargamos con el precio de venta actual
            var cosultaP = new Repository<Producto>();

            var listaProductos = (from a in resp
                                  select new ProductoBuscado
                                  {
                                      IDProducto = a.IdProducto,
                                      Descripcion = a.Nombre,
                                      Existencia = a.Unidades,
                                      PV1 = cosultaP.Find(x=>x.IDProducto==a.IdProducto).PVenta1,
                                      medida =  cosultaP.Find(x => x.IDProducto == a.IdProducto).MedidaMetrica,
                                      marca = cosultaP.Find(x=>x.IDProducto ==a.IdProducto).Marca
                                  }).ToList();


            return listaProductos;
        }
    }
}
