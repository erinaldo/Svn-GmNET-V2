using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gm.Core
{
    public class ProveedorProducto
    {
        [Display(Name = "CODIGO")]
        public long Codigo { get; set; }
        [Display(Name = "DESCRIPCION")]
        public string Nombre { get; set; }
        [Display(Name = "MARCA")]
        public string Marca { get; set; }
    }
}
