using System;
using System.Collections.Generic;
using System.Linq;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class KardexBLL
    {
        private List<VistaKardex> datos;
        public KardexBLL()
        {
            datos = new List<VistaKardex>();
            Mostrar();
        }
        private void Mostrar()
        {
            var resp = new Repository<VistaKardex>();
            datos = resp.Search(a=>a.Estado!="C").ToList();
        }
        public List<VistaKardex> Datos {
            get => datos ;
            set => datos = value;
        }
        public string Find()
        {
            var resp = new Repository<Kardex>();
            string item = resp.Search(a => a.IDFactura.Contains("V")).Max(a=>a.IDFactura);
            item = (item == null) ? "V1" : item;
            int numero = Convert.ToInt32(item.Substring(1, item.Length-1));
            
            return string.Format("010-001-{0:000000000}", numero);
        }
        public List<Factura> EnRecepcion()
        {
            var resp = new Repository<Kardex>().Search(x => x.Siclo == "R");

            var lista = (from a in resp
                                  select a.IDFactura).ToList();

            var facturas = new List<Factura>();

            foreach (string row in lista.Distinct())
            {
                var fac = new Repository<Factura>().Find(x => "C" + x.IDFactura == row);
                if(fac!=null)
                    facturas.Add(fac);
                
            }
            return facturas;
        }
        public List<EnFactura> enFacturas
        {
            get
            {
                
                var resp = new Repository<Kardex>().Search(x => x.Siclo == "R" || x.Siclo == "I" || x.Siclo=="E");
                var lista = (from a in resp select new { a.IDFactura, a.Siclo, a.Movimiento } ).ToList();

                var facturas = new List<EnFactura>();

                foreach(var row in lista.Distinct())
                {
                    var fac = new Repository<Factura>().Find(x => "C"+x.IDFactura == row.IDFactura);
                    
                    if (fac != null)
                        facturas.Add(
                            new EnFactura
                            {
                                IDFactura = fac.IDFactura,
                                Numero = fac.Numero,
                                IDCliente = fac.IDCliente,
                                Fecha = fac.Fecha,
                                Estado = fac.Estado,
                                FechaSistema = fac.FechaSistema,
                                IDTerminal = fac.IDTerminal,
                                Flete = fac.Flete,
                                Observacion = fac.Observacion,
                                //Cellar = fac.Cellar,
                                Cliente = fac.Cliente,
                                //Credito = fac.Credito,
                                FacturaDetalle = fac.FacturaDetalle,
                                Siclo = row.Movimiento,
                                Monto = Convert.ToDouble(fac.FacturaDetalle.Sum(x=>x.Costo*x.Unidades))
                            }
                            );
                }

                return facturas;
            }
        }
    }
}
