using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class TerminalBLL
    {
        public string error;
        private List<Terminal> mostrar;
        public List<Terminal> Mostar { get => mostrar = new Repository<Terminal>().Search(x=>x.Estado=="A"); }
        public TerminalBLL()
        {
            mostrar = new List<Terminal>();
            
        }
        public bool Save(Terminal arg)
        {
            bool Result = true;
            using (var resp=new Repository<Terminal>())
            {
                //var aux = resp.Find(x => x.IDTerminal == arg.IDTerminal);
                var row = resp.GetAll().Count;
                row++;
                arg.IDTerminal = row;
                if (resp.Create(arg) == null)
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
        public bool Delete(Terminal arg)
        {
            bool Result = true;
            using (var resp = new Repository<Terminal>())
            {
                var aux = resp.Find(x=>x.IDTerminal==arg.IDTerminal);

                if (!resp.Delete(aux))
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
        public bool Update(Terminal arg)
        {
            bool Result = true;
            using (var resp = new Repository<Terminal>())
            {
                var aux = resp.Find(x => x.Mac == arg.Mac);
                if (aux != null)
                {
                    //aux.Mac = arg.Mac;
                    aux.Maquina = arg.Maquina;
                    aux.Oficina = arg.Oficina;
                    aux.Estado = arg.Estado;
                    aux.IDTerminal = arg.IDTerminal;
                    if (!resp.Update(aux))
                    {
                        Result = false;
                        error = resp.Error;
                    }
                }
            }
            return Result;
        }
    }
}
