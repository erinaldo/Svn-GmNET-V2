using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class FacturaImpresion
    {
        public long IDFactura { get; set; }
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; }

        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public int Iva { get; set; }
        public float Total {
            get
            {
                var resul = Cantidad * Precio;
                return resul;
            }
        }
        public float IvaCalculado
        {
            get
            {
                var resul = 0f;
                if (Iva != 0)
                {
                    float cantidad = Convert.ToSingle(Cantidad);

                    resul = (Precio * cantidad)*(General.Iva/100);
                }
                return resul;
            }
        }
        public float Monto { get; set; }
        public string Siclo { get; set; }
        public string SicloDetalle {
            get {
                string detalle = string.Empty;
                if (Siclo == "D")
                    detalle = "Devolucion";
                if (Siclo == "C")
                    detalle = "Devuelto y Cambiado";
                return detalle;
            }
        }
    }
}
