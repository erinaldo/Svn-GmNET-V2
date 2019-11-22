using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class CreditoBLL : Credito
    {

        #region Variables
        public long IdCliente
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public string Cedula
        {
            get;
            set;
        }
        public string Telefono
        {
            get;
            set;
        }
        public decimal? Saldo
        {
            get;
            set;
        }
        public decimal? SaldoActual
        {
            get;
            set;
        }
        public string NumFactura
        {
            get;
            set;
        }
        public string Error
        {
            get;
            set;
        }
        #endregion

        #region Metodos
        public bool Save(Credito arg)
        {
            bool Resul = true;
            using (var resp = new Repository<Credito>())
            {
                if (resp.Create(arg) == null)
                {
                    Resul = true;
                    Error = resp.Error;
                }
            }
            return Resul;
        }

        public List<CreditoBLL> CuentasXCobrar()
        {
            try
            {
                List<CreditoBLL> resp = new List<CreditoBLL>();
                var creditos = new Repository<Credito>().GetAll().Where(x => x.Estado.Equals("A") || x.Estado == "T").GroupBy(x => x.IDFactura).ToList();

                for (int i = 0; i < creditos.Count; i++)
                {
                    long Id = Convert.ToInt64(creditos[i].Key);

                    var cabecera = new Repository<Factura>().Find(x => x.IDFactura == Id);
                    var detalle = new Repository<FacturaDetalle>().Search(x => x.IDFactura == Id);
                    var estado = new Repository<Credito>().Find(x => x.IDFactura == Id);


                    this.Abona = creditos[i].Sum(x => x.Abona);
                    this.Saldo = detalle.Sum(x => x.Unidades * x.Costo);

                    resp.Add(new CreditoBLL
                    {
                        IDFactura = Id,
                        IdCliente = Convert.ToInt64(cabecera.IDCliente),
                        Nombre = cabecera.Cliente.Nombre,
                        Cedula = cabecera.Cliente.Cedula,
                        NumFactura = cabecera.Numero,
                        Telefono = cabecera.Cliente.Telefono,
                        Fecha = Convert.ToDateTime(cabecera.Fecha),
                        Saldo = this.Saldo,
                        Abona = this.Abona,
                        SaldoActual = this.Saldo - this.Abona,
                        State = Convert.ToBoolean(estado.State),
                        Estado = estado.Estado,
                        FechaVence = estado.FechaVence
                    });
                }
                return resp.OrderByDescending(x => x.Fecha).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool Update(decimal Saldo, long IdFactura)
        {
            bool Result = true;
            using (var resp = new Repository<Credito>())
            {
                var aux = resp.Search(x => x.IDFactura == IdFactura);
                
                if (Saldo == aux.Sum(x => x.Abona))
                {
                    foreach (Credito item in aux)
                    {
                        item.State = false;
                        item.Estado = "T";
                        if(!resp.Update(item))
                        {
                            Result = false;
                            Error = resp.Error;
                        }
                    }
                }
            }
            return Result;
        }
        #endregion
    }
}
