using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public class ReservacionCore : Reservacion
    {
        public Producto producto
        {
            get;
            set;
        }
        public Cliente cliente
        {
            get;
            set;
        }
        public ReservacionCore()
        {
            producto = new Producto();
            cliente = new Cliente();
        }
    }
}
