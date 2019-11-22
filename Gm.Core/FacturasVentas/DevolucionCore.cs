using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class DevolucionCore : FacturaDetalle
    {
        public float? IvaAplicado
        {
            get
            {
                float? resp = 0;
                if (Iva > 0)
                {
                    resp = Convert.ToSingle(Costo) / Iva;
                    resp = resp * Unidades;
                }
                return resp;
            }
        }
        public float? IvaAplicado2
        {
            get
            {
                float? resp = 0;
                if (Iva > 0)
                {
                    resp = Convert.ToSingle(Sale) / Iva;
                    resp = resp * Queda;
                }
                return resp;
            }
        }
        public int? Sale
        {
            get;
            set;
        }
        public int? Queda
        {
            get
            {
                var resp = Unidades - ((Sale==null)?0:Sale);
                if (resp < 0)
                    Sale = 0;
                return Unidades - ((Sale == null) ? 0 : Sale); 
            }
        }
        public float? Total
        {
            get
            {
                return Convert.ToSingle(Queda * Costo);
            }
        }
        public float? Total2
        {
            get
            {
                return Convert.ToSingle(Sale * Costo);
            }
        }
    }
}
