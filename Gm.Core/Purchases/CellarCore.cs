using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class CellarCore : Cellar
    {
        public string Medida
        {
            get;
            set;
        }
        public string Error
        {
            get;
            set;
        }
        public bool Subir(List<PurchaseSubir> detalle, long IdFactura)
        {
            bool Resul = true;

            var pResp = detalle.FindAll(x => x.Nivel == 1);
            var hResp = detalle.FindAll(x => x.Nivel == 2);


            #region clonamos solo las cabezas
            var lista = new List<CellarCore>();
            foreach(var row in pResp)
            {
                var item = new Repository<MedidaMetrica>().GetAll().Find(x => x.Name == row.En);
                lista.Add(new CellarCore
                {
                    IDProducto=Convert.ToInt32(row.IdProducto),
                    IDFactura=IdFactura,
                    PorMayor=row.Cantidad,
                    PrPorMayor=row.PrecioPorMayor,
                    IdPorMayorMedida=item.IdMedidaMetrica,
                    Medida=item.Name,
                    Sate=true
                });
            }
            #endregion
            //aniadimos los hijos
            foreach (var row in hResp)
            {
                var item = new Repository<MedidaMetrica>().GetAll().Find(x => x.Name == row.En);
                var aux = lista.Find(x => x.IDProducto == row.IdProducto);
                aux.PorMenor = row.Cantidad;
                aux.PrPorMenor = row.PrecioPorMayor;
                aux.IdPorMenorMedida = item.IdMedidaMetrica;
            }

            //proceso de grabado
            using (var item = new Repository<Cellar>())
             {
                foreach (var aux in lista)
                {
                    var exi = item.Find(x => x.IDFactura == aux.IDFactura && x.IDProducto == aux.IDProducto);
                    
                    if (exi == null)
                    {
                        var resp = item.GetAll().Count;
                        resp++;
                        if (item.Create(new Cellar
                        {
                            IdCellar = resp,
                            IDProducto = aux.IDProducto,
                            IDFactura = aux.IDFactura,
                            Sate = true,
                            PorMayor = aux.PorMayor,
                            PorMenor = aux.PorMenor,
                            PrPorMayor = aux.PrPorMayor,
                            PrPorMenor = aux.PrPorMenor,
                            IdPorMayorMedida = aux.IdPorMayorMedida,
                            IdPorMenorMedida = aux.IdPorMenorMedida,
                            PVentaMayor = aux.PVentaMayor,
                            PVentaMenor = aux.PVentaMenor
                        }) == null)
                        {
                            Error = item.Error;
                            Resul = false;
                            break;
                        }
                    }
                    else
                    {
                        Sate = true;
                        //exi.PrPorMayor = aux.PrPorMayor;
                        //exi.PrPorMenor = aux.PrPorMenor;
                        exi.PVentaMayor = aux.PrPorMayor;
                        exi.PVentaMenor = aux.PrPorMenor;
                        if (!item.Update(exi))
                        {
                            Error = item.Error;
                            Resul = false;
                            break;
                        }
                    }
                    
                }
            }

            return Resul;
        }
    }
}
