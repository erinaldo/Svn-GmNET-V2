using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class PurchaseSubirTodos : PurchaseSubir
    {
        public DateTime? Fecha
        {
            get;
            set;
        }
        public string Factura
        {
            get;
            set;
        }
    }
}
