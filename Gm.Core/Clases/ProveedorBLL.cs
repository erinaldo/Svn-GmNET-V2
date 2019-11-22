using System.Data;
using System.Collections.Generic;
using System.Linq;
using System;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class ProveedorBLL
    {
        private List<Cliente> datos;
        public string error;
        public ProveedorBLL()
        {
            Mostrar();
        }

        public List<Cliente> Datos { get => datos; set => datos = value; }
        

        private void Mostrar()
        {
            var prove = (from pro in new Repository<Proveedor>().GetAll()
                         select pro.IDCliente
                        ).Distinct().ToList();

            var resp = (from pro in new Repository<Cliente>().GetAll()
                        where prove.Contains(pro.IDCliente)
                        where pro.Estado!="E"
                        select pro
                      ).ToList();

            datos = resp;
        }
        public List<Cliente> GetList(long IDProducto)
        {
            var pro = (from res in new Repository<Proveedor>().Search(a => a.IDProducto == IDProducto)
                       select res).ToList();

            List<Cliente> resp=new List<Cliente>();

            foreach (Proveedor res in pro.ToList())
            {
                resp = (from a in new Repository<Cliente>().Search(a => a.IDCliente == res.IDCliente)
                        select a).ToList();
            }
            
            return resp;
        }

        public bool Delete(Int32 IDCliente)
        {
            using (var resp= new Repository<Cliente>())
            {
                try
                {
                    Cliente tbl = resp.Find(a => a.IDCliente == IDCliente);
                    if (tbl == null)
                        throw new Exception(resp.Error);

                    tbl.Estado = "E";

                    if (!resp.Update(tbl))
                        throw new Exception(resp.Error);
                    return true;
                }
                catch(Exception ex)
                {
                    error = ex.Message;
                }
            }
            return false;
        }
      
        public bool Save(Cliente item)
        {
            bool Result = true;

            using (var resp = new Repository<Cliente>())
            {
                if (resp.Create(item)==null)
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
        public bool Update(Cliente item)
        {
            bool Result = true;

            using (var resp = new Repository<Cliente>())
            {
                var re = resp.Find(x=>x.IDCliente==item.IDCliente);
                re.Nombre = item.Nombre;
                re.Direccion = item.Direccion;
                re.Correo = item.Correo;
                re.Cedula = item.Cedula;
                re.Telefono = item.Telefono;
                if (!resp.Update(re))
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
    }
}
