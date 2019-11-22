using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class FacturaImpresionVenta
    {
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string NumeroFactura { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public string Detalle { get; set; }
        public float VUnitario { get; set; }
        public float VTotal { get; set; }
        public float SubTotal { get; set; }
        public float Iva { get; set; }
        public float Total { get; set; }
    }
}
