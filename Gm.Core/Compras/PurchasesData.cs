using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class PurchasesData
    {
        public long IDProducto
        {
            get;
            set;
        }
        public string Nombre
        {
            get;
            set;
        }
        public int Cantidad
        {
            get;
            set;
        }
        public string Medida
        {
            get;
            set;
        }
        public decimal Precio
        {
            get;
            set;
        }
        public bool Iva
        {
            get;
            set;
        }
        public decimal SubTotal
        {
            get;
            set;
        }

        public decimal CalculoIva
        {
            get;
            set;
        }
        public long IdMedida
        {
            get;
            set;
        }
        public string Marca
        {
            get;
            set;
        }
        public string CodBarras
        {
            get;
            set;
        }
        public float Flete { get; set; }
    }
}
