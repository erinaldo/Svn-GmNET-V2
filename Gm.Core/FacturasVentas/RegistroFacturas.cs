using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class RegistroFacturas
    {
        public long? IdFactura { get; set; }
        public string Numero { get; set; }
        public decimal? Costo { get; set; }
        public string Cliente { get; set; }
    }
}
