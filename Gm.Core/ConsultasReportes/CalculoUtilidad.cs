using Gm.Data;
using Gm.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class CalculoUtilidad
    {
        //public readonly List<Kardex> detalle;
        public Stack miPila = new Stack();
        public CalculoUtilidad()
        {
            //detalle = new List<Kardex>();
        }
        public void Calcular(long IDProducto, long IDFactura, int cantidad, decimal PSale, float Iva,out List<Kardex> detalle, long IdMedida)
        {

            var kardex = new Repository<Kardex>();
            detalle = new List<Kardex>();

            Kardex nuevo;

            //)Obtenemos todas las compras realizadas activas
            var Compras = (from a in kardex.GetAll()
                     where a.IDProducto == IDProducto && a.Equivalencia > 0 && a.Movimiento!="F"
                     orderby a.IDKardex
                     select a
                    ).Take(100).ToList();

            
            for(int i = 0; i < Compras.Count; i++)
            {
                //con el codigo de compra obtenemos las ventas realizadas
                var VentaTotal = (from a in kardex.GetAll()
                             where a.IDProducto == IDProducto && a.Referencia == Compras[i].IDKardex
                             select a).Sum(x => x.Equivalencia)*-1;

                if (Compras[i].ProductoEntra == VentaTotal + cantidad)
                {
                    //actualizamos y colocamos los valores en 0
                    Compras[i].Movimiento = "F";
                    Compras[i].Residuo = 0;
                    kardex.Update(Compras[i]);

                    //creamos nueva linea de registro
                    nuevo = new Kardex();
                    nuevo.IDKardex = kardex.Count() + 1;
                    nuevo.IDProducto = IDProducto;
                    nuevo.ProductoSale = cantidad;
                    nuevo.Referencia = Compras[i].IDKardex;
                    nuevo.Equivalencia = cantidad * -1;
                    nuevo.ProductoEntra = 0;
                    nuevo.ProductoEntraPrecio = 0;
                    nuevo.ProductoSalePrecio = PSale;
                    nuevo.IDFactura = "V" + IDFactura;
                    nuevo.IVA = Convert.ToInt16(Iva);
                    nuevo.Estado = "A";
                    nuevo.Fecha = DateTime.Now;
                    nuevo.FechaSistema = DateTime.Now;
                    nuevo.IdMedidaMetrica = IdMedida;

                    //detalle.Add(nuevo);
                    kardex.Create(nuevo);
                    break;
                }

                else
                {
                    if (Compras[i].ProductoEntra > VentaTotal + cantidad)
                    {
                        Compras[i].Movimiento = "A";
                        Compras[i].Residuo = Compras[i].ProductoEntra-(cantidad+VentaTotal);
                        kardex.Update(Compras[i]);

                        nuevo = new Kardex();
                        nuevo.IDKardex = kardex.Count() + 1;
                        nuevo.IDProducto = IDProducto;
                        nuevo.ProductoSale = cantidad;
                        nuevo.Referencia = Compras[i].IDKardex;
                        nuevo.Equivalencia = cantidad * -1;
                        nuevo.ProductoEntra = 0;
                        nuevo.ProductoEntraPrecio = 0;
                        nuevo.ProductoSalePrecio = PSale;
                        nuevo.IDFactura = "V" + IDFactura;
                        nuevo.IVA = Convert.ToInt16(Iva);
                        nuevo.Estado = "A";
                        nuevo.Fecha = DateTime.Now;
                        nuevo.FechaSistema = DateTime.Now;
                        nuevo.IdMedidaMetrica = IdMedida;

                        kardex.Create(nuevo);
                        break;
                    }
                    else
                    {
                        //realizamos el ingreso del residuo
                        nuevo = new Kardex();
                        nuevo.IDKardex = kardex.Count() + 1;
                        nuevo.IDProducto = IDProducto;
                        nuevo.ProductoSale = Compras[i].Residuo;
                        nuevo.Equivalencia = Compras[i].Residuo * -1;
                        nuevo.Referencia = Compras[i].IDKardex;
                        nuevo.ProductoEntra = 0;
                        nuevo.ProductoEntraPrecio = 0;
                        nuevo.ProductoSalePrecio = PSale;
                        nuevo.IDFactura = "V" + IDFactura;
                        nuevo.IVA = Convert.ToInt16(Iva);
                        nuevo.Estado = "A";
                        nuevo.Siclo = "A";
                        nuevo.Fecha = DateTime.Now;
                        nuevo.FechaSistema = DateTime.Now;
                        nuevo.IdMedidaMetrica = IdMedida;
                        kardex.Create(nuevo);

                        //Actualizamos los estados
                        cantidad = cantidad - Convert.ToInt16(Compras[i].Residuo);
                        Compras[i].Movimiento = "F";
                        Compras[i].Residuo = 0;
                        kardex.Update(Compras[i]);

                    }
                }
                
            }

        }
        public void AddKardex(long IDProducto, long IDFactura, int cantidad, decimal PSale, float Iva, List<Kardex> detalle, long IdMedida)
        {
            var repositoryKardex = new Repository<Kardex>();
            var listKardexCompras = (from a in repositoryKardex.Search(x => x.IDProducto == IDProducto)
                                     where a.Equivalencia > 0 && a.Siclo!="F"
                                     select a).ToList();

            for(int i =0; i< listKardexCompras.Count; i++)
            {
                var detalleSuma = (from a in repositoryKardex.GetAll()
                             where a.IDProducto == IDProducto && a.Referencia == listKardexCompras[i].IDKardex
                             select a).Sum(x => x.Equivalencia)*-1;

            }

        }
    }
}
