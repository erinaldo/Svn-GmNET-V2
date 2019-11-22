using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class EnFactura : Factura
    {
        public string Siclo
        {
            get;
            set;
        }
        public double Monto
        {
            get;
            set;
        }
        public DateTime FechaFin
        {
            get;
            set;
        }
    }
}
