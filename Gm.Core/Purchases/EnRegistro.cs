using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class EnRegistro
    {
        public EnFactura enFactura
        {
            get;
            set;
        }
        public long? IDProduct
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
        public decimal? PrecioUnitario
        {
            get;
            set;
        }
        public decimal? SubTotal {
            get
            {
                return Cantidad * PrecioUnitario;
            }
        }
        public decimal? Invercion
        {
            get;
            private set;
        }
        public decimal? PrecioReal
        {
            get
            {
                return PrecioUnitario + (Flete / Cantidad);
                //return Convert.ToDecimal(string.Format("{0:0.0000}",Invercion / Cantidad));
            }
        }
        public float? PrecioVenta { get; set; }
        public decimal? Flete
        {
            get;
            private set;
        }
        public int? Iva
        {
            get;
            private set;
        }
        public int? IdKardex { get; set; }
        public string Medida
        {
            get;
            private set;
        }
        public DateTime? Fecha { get; set; }
        public string Numfactura { get; set; }
        public long? IDFactura { get; set; }
        public EnRegistro()
        {
            this.enFactura = new EnFactura();
        }

        public void Canculos(decimal? miFlete, decimal compraTotal)
        {
            decimal? x;
            if (miFlete != null)
                x = miFlete + compraTotal;
            else
                x = compraTotal;


            decimal? x1 = (100 * SubTotal) / x;

            if (miFlete != null)
            {
                Flete = Convert.ToDecimal(string.Format("{0:0.0000}", (miFlete * x1) / 100));
                Invercion = Convert.ToDecimal(string.Format("{0:0.0000}", (SubTotal + Flete)));
            }
            else
            {
                Invercion = Convert.ToDecimal(string.Format("{0:0.0000}", (SubTotal)));
            }
        }
        public void ObtenerIva(long? IdKardex, long? IdProducto, long? IdFactura)
        {
            var resp = new Repository<Kardex>().Find(x => x.IDKardex == IdKardex);
            Iva = resp.IVA;
            var medi = new Repository<MedidaMetrica>().Find(x => x.IdMedidaMetrica == resp.IdMedidaMetrica);
            Medida = medi.Name;
        }
        
    }
}
