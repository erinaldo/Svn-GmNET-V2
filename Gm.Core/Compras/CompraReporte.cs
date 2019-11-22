using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class CompraReporte
    {
       public long Idfactura { get; set; }
        public string Numero { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaFin { get; set; }
        public decimal? Monto { get; set; }
        public decimal? Flete { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public decimal? FleteAplicado { get; set; }
        public string Detalle { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public int? Iva { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Inversion { get; set; }
        public decimal? PrecioReal { get; set; }
    }
}
