using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class ProductoBLL
    {
        
        public string TextoError;
        public ProductoBLL()
        {
            //Llenar();
        }
        
        public List<Producto> Lista { get => new Repository<Producto>().GetAll(); }

        public bool Save(Producto item)
        {
            bool resul = true;
            using (var resp = new Repository<Producto>())
            {
                var row = resp.GetAll().Count;
                row++;

                item.IDProducto = row;
                item.FechaSistema = DateTime.Now;
                item.Estado = "A";

                if (resp.Create(item) == null)
                {
                    resul = false;
                    TextoError = resp.Error;
                }
            }
            return resul;
        }
        public bool Update(Producto item)
        {
            bool Result = true;
            using (var resp = new Repository<Producto>())
            {
                Producto tbl = resp.Find(a => a.IDProducto == item.IDProducto);
                
                tbl.IDProducto = item.IDProducto;
                tbl.CodBarra = item.CodBarra;
                tbl.Nombre = item.Nombre;
                tbl.Iva = item.Iva;
                //tbl.PVenta1 = item.PVenta1;
                //tbl.PVenta2 = item.PVenta2;
                tbl.IDGrupo = item.IDGrupo;
                tbl.Estado = item.Estado;
                tbl.Equivalencia1 = item.Equivalencia1;
                tbl.Equivalencia2 = item.Equivalencia2;
                //tbl.IDMedida1 = item.IDMedida1;
                //tbl.IDMedida2 = item.IDMedida2;
                //tbl.StateMedida1 = item.StateMedida1;
                //tbl.StateMedida2 = item.StateMedida2;
                //tbl.NameMedida1 = item.NameMedida1;
                //tbl.NameMedida2 = item.NameMedida2;
                
                if (!resp.Update(tbl))
                {
                    Result = false;
                    TextoError = resp.Error;
                }
            }
            return Result;
        }
        public bool Delete(int IDProducto)
        {
            return true;
        }
        

    }
}
