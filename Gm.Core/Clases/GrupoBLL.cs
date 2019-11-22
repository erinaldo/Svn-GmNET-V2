using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class GrupoBLL
    {
        public List<Grupo> Mostrar
        {
            get {
                return new Repository<Grupo>().GetAll();
            }
        }
        public string error;
        public GrupoBLL() {         
        }

        public bool Grabar(Grupo item)
        {
            bool Resul = true;
            using (var resp = new Repository<Grupo>())
            {
                var row = resp.GetAll().Count;
                row++;
                item.IDGrupo = row;
                if (resp.Create(item) == null)
                {
                    Resul = false;
                    error = resp.Error;
                }
            }
            return Resul;
        }
        public bool Update(Grupo item)
        {
            bool Resul = true;
            using (var resp = new Repository<Grupo>())
            {
                var aux = resp.Find(x=>x.IDGrupo==item.IDGrupo);
                if (aux != null)
                {
                    aux.IDGrupo = item.IDGrupo;
                    aux.Nombre = item.Nombre;
                    aux.Estado = item.Estado;
                    if (!resp.Update(aux))
                    {
                        Resul = false;
                        error = resp.Error;
                    }
                }
            }
            return Resul;
        }
        public bool Delete(Grupo arg)
        {
            bool Result = true;
            using (var resp=new Repository<Grupo>())
            {
                var aux = resp.Find(x=>x.IDGrupo==arg.IDGrupo);
                if (!resp.Delete(aux))
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
    }
}
