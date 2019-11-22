using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class ProductoAdmin
    {
        

        /// <summary>
        /// Obtiene la existencia de los productos
        /// </summary>
        /// <returns>List<VistaExistenciaCore></returns>
        public List<VistaExistenciaCore> GetInventario()
        {
            AyudaCore ayuda = new AyudaCore();

            //var inventario = (from a in ayuda.ProductosList()
            //                                        select new VistaExistenciaCore
            //                                        {
            //                                            IDProducto = a.IDProducto,
            //                                            Nombre = a.Nombre,
            //                                            Cantidad1 = a.Existencia1,
            //                                            //Cantidad2 = a.Existencia2,
            //                                            Medida1 = a.IDMedidaMetrica.ToString(),
            //                                            //Meidad2 = a.NameMedida2
            //                                        }).ToList();

            //var keys = (from a in inventario
            //            select a.IDProducto).ToList();

            //var resp = (from a in new Repository<Producto>().GetAll()
            //            where !keys.Contains(a.IDProducto)
            //            select a).ToList();

            //foreach (var row in resp)
            //{
            //    inventario.Add(new VistaExistenciaCore
            //    {
            //        IDProducto = row.IDProducto,
            //        Nombre = row.Nombre,
            //        Cantidad1 = 0,
            //        Cantidad2 = 0,
            //        Medida1 = row.IDMedidaMetrica.ToString(),
            //        //Meidad2 = row.NameMedida2
            //    });
            //}

            return null;
        }

        /// <summary>
        /// Obtiene la existencia del producto
        /// </summary>
        /// <param name="IdProducto">Int32</param>
        /// <param name="Medida">string</param>
        /// <returns>int</returns>
        public int GetExistencia(Int32 IdProducto, string Medida)
        {
            int Result = 0;
            var aux = GetInventario().Find(x => x.IDProducto == IdProducto);
            if (aux != null)
            {
                if (!string.IsNullOrEmpty(aux.Medida1) && aux.Medida1.Equals(Medida))
                    Result = Convert.ToInt32(aux.Cantidad1);
                else if (!string.IsNullOrEmpty(aux.Meidad2) && aux.Meidad2.Equals(Medida))
                    Result = Convert.ToInt32(aux.Cantidad2);
            }
            return Result;
        }
    }
}
