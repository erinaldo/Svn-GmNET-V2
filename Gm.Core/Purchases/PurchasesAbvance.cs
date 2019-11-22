namespace Gm.Core
{
    using System;
    public class PurchasesAbvance
    {
        public long IDProducto
        {
            get;
            set;
        }
        public string CodBarras
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
        public bool Iva
        {
            get;
            set;
        }
        public float? PrecioUnitario
        {
            get;
            set;
        }
        public float? PrecioTotal {
            get
            {
                var resp = PrecioUnitario * Cantidad;
                if (Iva)
                    CalculoIva = resp * (General.Iva / 100);
                else
                    CalculoIva = 0;

                //if (Flete > 0)
                //{
                //    resp = Precio * Cantidad + (Flete / Cantidad);
                //}

                return resp;
            }
        }
        public float Flete { get; set; }
        public float? PrecioCompraUnitario
        {
            get
            {
                //return (Flete/Cantidad);
                return (Flete + PrecioTotal) / Cantidad;
            }
        }
        public float? PrecioCompraFinal
        {
            get
            {
                //return (Flete/Cantidad);
                return PrecioCompraUnitario * Cantidad;
            }
        }
        public float? CalculoIva
        {
            get;
            private set;
        }


        public bool Estado { get; set; }
        public int ParaBodega { get; set; }

        /// <summary>
        /// Cantidad sobrante despues de lo que se envia a bodega
        /// </summary>
        public int Ahorra
        {
            get
            {
                if ((Cantidad - ParaBodega) < 0)
                    ParaBodega = 0;
                return Cantidad - ParaBodega;
            }
        }
    }
}
