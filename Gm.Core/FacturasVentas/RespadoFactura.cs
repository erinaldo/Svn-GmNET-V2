using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    [Serializable]
    public class RespadoFactura
    {
        public long IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public List<BillData> Detalle { get; set; }
    }
}
