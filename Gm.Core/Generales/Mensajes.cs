using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core.Generales
{
    public static class Mensajes
    {
        public static string Grabado = string.Format("Grabado correcto {0}\n Gracias por su visita..........", DateTime.Now);
        public static string Error = string.Format("Se provoco un error {0}\n comuniquese con sistemas...........\n",DateTime.Now);
        public static string InformativoFactura = string.Format("La Factura esta grabada o no tiene productos...........\n{0}",DateTime.Now);
        public static string NingunCambio = string.Format("Ningun cambio encontrado para actualizar...\nFecha{0}", DateTime.Now);
        public static string CamposVacios = string.Format("Campos vacios no son permitidos...\nFecha", DateTime.Now);
    }
}
