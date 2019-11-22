using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core.Generales
{
    public class CalculoIva
    {
        public float? SubTotal { get; set; }
        public float? Iva { get; set; }
        public float? Total { get { return Total_; } }
        private float? Total_;
        public void Calacular(float? T0)
        {
            ParametrosBLL dll = new ParametrosBLL();
            Total_ = T0;
            decimal p = Convert.ToDecimal(dll.myIva) / 100;
            Iva = Convert.ToSingle(p + 1);
            Iva = T0 - (T0 / Iva);
            SubTotal = T0 - Iva;
        }

    }
}
