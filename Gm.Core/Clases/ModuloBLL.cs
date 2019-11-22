using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class ModuloBLL
    {
        private List<Modulos> mostar;
        public string Error;
        public ModuloBLL() { }

        public List<Modulos> Mostar { get => mostar=new Repository<Modulos>().GetAll(); }
        public bool Grabar(Modulos item)
        {
            using (var resp = new Repository<Modulos>())
            {
                try
                {
                    Modulos tbl = resp.Find(a => a.IDModulo == item.IDModulo);
                    if (tbl == null)
                        tbl = resp.Create(item);
                    else
                    {
                        tbl.IDModulo = item.IDModulo;
                        tbl.Nombre = item.Nombre;
                        tbl.Imagen = item.Imagen;
                        tbl.IsMDI = item.IsMDI;
                        tbl.Estado = item.Estado;
                        tbl.Color = item.Color;
                        resp.Update();
                    }
                    return true;
                }
                catch(Exception)
                {
                    Error = resp.Error;
                }
                return false;
            }
        }

    }
}
