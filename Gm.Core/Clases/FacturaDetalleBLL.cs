using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Entities;

namespace Gm.Core
{
    public class FacturaDetalleBLL
    {
        public string CodBarra
        {
            get;
            set;
        }
        public Producto producto
        {
            get;
            set;
        }
        public decimal? Costo
        {
            get;
            set;
        }
        public int? Unidades
        {
            get;
            set;
        }
        public decimal? SubTotal
        {
            get;
            set;
        }
        public int? IdKardex
        {
            get;
            set;
        }
        public FacturaDetalleBLL()
        {
            producto = new Producto();
        }
    }
}
