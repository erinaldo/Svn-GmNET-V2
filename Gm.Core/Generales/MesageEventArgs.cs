using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core.Generales
{
    public class MesageEventArg : EventArgs
    {
        public string Texto { get; }
        public string Titulo { get; }
        public MesageEventArg(string Texto, string Titulo)
        {
            this.Texto = Texto;
            this.Titulo = Titulo;
        }
    }
}
