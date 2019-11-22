using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class MedidaMetricaCore: MedidaMetrica
    {
        public List<MedidaMetrica> Lista { get { return setLista; } }
        private List<MedidaMetrica> setLista;
        public string Error;
        public MedidaMetricaCore() {
            setLista = new Repository<MedidaMetrica>().GetAll();
        }
        public bool Save(MedidaMetrica item)
        {
            bool resul = true;
            using (var resp= new Repository<MedidaMetrica>())
            {
                var row = resp.GetAll().Count;
                row++;
                item.IdMedidaMetrica = row;
                if (resp.Create(item) == null)
                {
                    resul = false;
                    Error = resp.Error;
                }
            }
            return resul;
        }
        public bool Update(MedidaMetrica item)
        {
            bool Result = true;
            using (var resp= new Repository<MedidaMetrica>())
            {
                if (!resp.Update(item))
                {
                    Result = false;
                    Error = resp.Error;
                }
            }
                return Result;
        }
    }
}
