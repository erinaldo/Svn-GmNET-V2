using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    [Serializable]
    public class RespaldoCompra
    {
        public long IdCliente { get; set; }
        public List<PurchasesData> Detalle { get; set; }
    }
}
