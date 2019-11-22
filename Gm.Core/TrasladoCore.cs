using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class TrasladoCore
    {
        public long IDFactura { get; set; }
        public string NumeroFactura { get; set; }
        public long IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int EnBodega { get; set; }
        public int Queda {
            get
            {
                var resp = Cantidad - Sale;
                if (resp < 0)
                    Sale = 0;
                return Cantidad - Sale;
            }
        }
        public int Sale { get; set; }
    }
}
