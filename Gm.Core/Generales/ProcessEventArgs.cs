using System;

namespace Gm.Core.Generales
{
    public class ProcessEventArgs:EventArgs
    {
        public int numeroActual { get; }
        public int numeroTotal { get; }
        public ProcessEventArgs(int numeroActual, int numeroTotal)
        {
            this.numeroActual = numeroActual;
            this.numeroTotal = numeroTotal;
        }
    }
}
