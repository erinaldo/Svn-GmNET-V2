using Gm.Data;
using Gm.Entities;

namespace Gm.Core.Generales
{
    public class Reiniciar
    {
        public Reiniciar()
        {
            new Repository<Sp_Existencia_Result>().SQLQuery<Sp_Existencia_Result>("EXEC Sp_ReinicioTablas");
        }
    }
}
