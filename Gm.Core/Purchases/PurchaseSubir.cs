using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class PurchaseSubir
    {
        public long? IdFactura
        {
            get;
            set;
        }
        public long? IdProducto
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int? Cantidad
        {
            get;
            set;
        }
        public decimal? PrecioReal
        {
            get;
            set;
        }
        public string En
        {
            get;
            set;
        }
        public decimal? PrecioPorMayor
        {
            get;
            set;
        }
        public int Nivel
        {
            get;
            set;
        }
        public float? PrecioVenta
        {
            get;
            set;
        }

        public List<PurchaseSubir> Lista(List<EnRegistro> detalle)
        {
            var datos = new List<PurchaseSubir>();

            ////Creamos la primera liena de informacion, maestros Rollos y Cajas
            //datos = (from row in detalle
            //         select new PurchaseSubir
            //         {
            //             IdFactura = row.IDFactura,
            //             IdProducto = row.IDProduct,
            //             Name = row.Name,
            //             Cantidad = row.Cantidad,
            //             PrecioReal = row.PrecioReal,
            //             En = row.Medida
            //         }).ToList();

            ////sumamos los productos que esten duplicados como ejemplo iva
            //var lista = new List<PurchaseSubir>();

            //foreach (PurchaseSubir row in datos)
            //{
            //    if (lista.Exists(x => x.IdProducto == row.IdProducto && x.En == row.En))
            //    {
            //        var resp = lista.Find(x => x.IdProducto == row.IdProducto && x.En == row.En);
            //        resp.Cantidad += row.Cantidad;
            //        resp.PrecioReal = (resp.PrecioReal > row.PrecioReal) ? resp.PrecioReal : row.PrecioReal;
            //    }
            //    else
            //        lista.Add(row);
            //}

            ////asignamos las medidas metricas a los productos
            //var respal = new List<PurchaseSubir>();

            //foreach (PurchaseSubir row in lista)
            //{
            //    string medida = string.Empty;

            //    if (lista.Exists(x => x.IdProducto == row.IdProducto && (x.En == "ROLLOS" || x.En == "METROS")))
            //    {
            //        if (!lista.Exists(x => x.IdProducto == row.IdProducto && x.En == "ROLLOS"))
            //            medida = "ROLLOS";

            //        else if (!lista.Exists(x => x.IdProducto == row.IdProducto && x.En == "METROS"))
            //            medida = "METROS";
            //    }
            //    else if (lista.Exists(x => x.IdProducto == row.IdProducto && (x.En == "CAJAS" || x.En == "UNIDAD")))
            //    {
            //        if (!lista.Exists(x => x.IdProducto == row.IdProducto && x.En == "CAJAS"))
            //            medida = "CAJAS";

            //        else if (!lista.Exists(x => x.IdProducto == row.IdProducto && x.En == "UNIDAD"))
            //            medida = "UNIDAD";
            //    }

            //    if (!string.IsNullOrEmpty(medida))
            //    {
            //        respal.Add(new PurchaseSubir
            //        {
            //            IdProducto = row.IdProducto,
            //            Name = row.Name,
            //            En = medida
            //        });
            //    }
            //}

            //foreach (PurchaseSubir row in respal)
            //{
            //    lista.Add(new PurchaseSubir
            //    {
            //        IdProducto = row.IdProducto,
            //        Name = row.Name,
            //        En = row.En
            //    });
            //}

            ////creamos los niveles de visualizacion
            //foreach (PurchaseSubir row in lista)
            //{
            //    switch (row.En)
            //    {
            //        case "ROLLOS":
            //        case "CAJAS":
            //            row.Nivel = 1;
            //            break;
            //        case "METROS":
            //        case "UNIDAD":
            //            row.Nivel = 2;
            //            break;
            //    }
            //}

            ////realizamos los calculos de precio para los paquetes de productos
            //for (int i = 0; i < detalle.Count; i++)
            //{
            //    var mp = lista.Find(x => x.IdProducto == detalle[i].IDProduct && x.Nivel == 1);
            //    var np = lista.Find(x => x.IdProducto == detalle[i].IDProduct && x.Nivel == 2);

            //    var pro = new Repository<Producto>().GetAll();

            //    var p = pro.Find(x => x.IDProducto == detalle[i].IDProduct);

            //    int? cantidad1 = mp.Cantidad;
            //    int? cantidad2 = np.Cantidad;
            //    int? equivalenciamp, equivalencianp;

            //    if (Convert.ToBoolean(p.Rollos))
            //        equivalenciamp = p.EqRollos;
            //    if (Convert.ToBoolean(p.Caja))
            //        equivalenciamp = p.EqCaja;

            //    if (Convert.ToBoolean(p.Metros))
            //        equivalencianp = p.EqMetros;

            //    if (Convert.ToBoolean(p.Unidades))
            //        equivalencianp = p.EqUnidades;


            //    //preguntamos si el hijo tiene cantidad
            //    if (mp.Cantidad == null && np.Cantidad != null)
            //    {
            //        if (Convert.ToBoolean(p.Unidades))
            //        {
            //            cantidad1 = cantidad2 / p.EqCaja;
            //            mp.Cantidad = cantidad1;
            //            np.Cantidad = cantidad2 - (cantidad1 * p.EqCaja);
            //            mp.PrecioReal = np.PrecioReal * p.EqCaja;
            //        }
            //        if (Convert.ToBoolean(p.Metros))
            //        {
            //            cantidad1 = cantidad2 / p.EqRollos;
            //            mp.Cantidad = cantidad1;
            //            np.Cantidad = cantidad2 - (cantidad1 * p.EqRollos);
            //            mp.PrecioReal = np.PrecioReal * p.EqRollos;
            //        }
            //    }
                
            //    //preguntamos si ambos tienen cantidades
            //    if (mp.Cantidad != null && np.Cantidad != null)
            //    {
            //        if (Convert.ToBoolean(p.Unidades))
            //        {
            //            cantidad2 = mp.Cantidad * p.EqCaja + np.Cantidad;
            //            cantidad1 = cantidad2 / p.EqCaja;
            //            mp.Cantidad = cantidad1;
            //            np.Cantidad = cantidad2 - (cantidad1 * p.EqCaja);
            //        }
            //        if (Convert.ToBoolean(p.Metros))
            //        {
            //            cantidad2 = mp.Cantidad * p.EqRollos + np.Cantidad;
            //            cantidad1 = cantidad2 / p.EqRollos;
            //            mp.Cantidad = cantidad1;
            //            np.Cantidad = cantidad2 - (cantidad2 * p.EqRollos);
            //        }
            //    }
            //    //preguntamos si solo el padre tiene datos
            //    if (mp.Cantidad != null && np.Cantidad == null)
            //    {
            //        if (Convert.ToBoolean(p.Unidades))
            //        {
            //            np.Cantidad = 0;
            //            np.PrecioReal = Convert.ToDecimal(string.Format("{0:0.0000}", mp.PrecioReal / p.EqCaja));
            //        }
            //        if (Convert.ToBoolean(p.Metros))
            //        {
            //            np.Cantidad = 0;
            //            np.PrecioReal = Convert.ToDecimal(string.Format("{0:0.0000}", mp.PrecioReal / p.EqRollos));
            //        }
            //    }
            //}

            //lista = lista.OrderBy(a => a.IdProducto).ThenBy(b => b.Name).ThenBy(c => c.En).ThenBy(c => c.Nivel).ToList();

            return null;
        }
    }
}
