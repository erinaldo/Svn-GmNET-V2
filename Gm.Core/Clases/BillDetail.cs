using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class BillDetail : FacturaDetalle
    {
        //public BillDetail()
        //{
        //    Producto = new Producto();
        //}
        public decimal? SubTotal
        {
            get
            {
                return Convert.ToDecimal(Unidades* Costo);
            }
        }
        
    }
}
