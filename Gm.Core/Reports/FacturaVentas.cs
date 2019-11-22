using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class FacturaVentas
    {
        public long IDFactura
        {
            get;
            set;
        }
        public string Numero
        {
            get;
            set;
        }
        public Nullable<long> IDCliente
        {
            get;
            set;
        }
        public Nullable<System.DateTime> Fecha
        {
            get;
            set;
        }

    }
}
