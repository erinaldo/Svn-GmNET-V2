using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    [Serializable]
    public class BillData
    {
        public long? IDFactura
        {
            get;
            set;
        }
        public long IdProducto
        {
            get;
            set;
        }
        public string CodBarras
        {
            get;
            set;
        }
        public string Detalle
        {
            get;
            set;
        }
        public float? Precio
        {
            get;
            set;
        }
        public int? Unidades
        {
            get;
            set;
        }
        public float? Iva
        {
            get;
            set;
        }
        public bool? IvaAplica
        {
            get;
            set;
        }
        public float? SubTotal
        {
            get;
            set;
        }

        public float? Total
        {
            get;
            set;
        }
        public long? IdMedida
        {
            get;set;
        }
        public long? IdMarca
        {
            get;set;
        }
    }
}
