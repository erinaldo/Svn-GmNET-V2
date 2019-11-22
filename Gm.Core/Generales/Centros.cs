using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core.Generales
{
    public class Centros
    {
        public Centros()
        {
          
        }
        public int Centrado(int Padre, int hijo)
        {
            int resp = Padre - hijo;
            return resp / 2; 
        }
    }
}
