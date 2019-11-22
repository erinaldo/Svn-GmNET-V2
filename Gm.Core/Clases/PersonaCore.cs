using System;
using System.Collections.Generic;
using System.Linq;

using Gm.Data;
using Gm.Entities;
using Gm.Core.Generales;

namespace Gm.Core
{
    public class PersonaCore
    {

        public delegate void OnMessageEvent(object sender, MesageEventArg e);
        public event OnMessageEvent MessaheEvent;
        public string error;

        protected virtual void OnMessage(MesageEventArg e)
        {
            if (MessaheEvent != null)
                MessaheEvent(this, e);
        }
        public PersonaCore() { }
        public List<Cliente> GetCliente()
        {
            
            var resp = new Repository<Cliente>().GetAll();
          
            return resp;
        }

        public Cliente Buscar(string DNI)
        {
            var resp = new Repository<Cliente>();
            if (resp.Error != null)
                OnMessage(new MesageEventArg(resp.Error, "Buscar"));
            return resp.Find(a => a.Cedula == DNI);
        }

        public Cliente Grabar(Cliente info )
        {
            if (info.IDCliente == 0)
            {
                var resp = new Repository<Cliente>();
                info.Estado = "A";
                info.FechaSistema = DateTime.Now;
                return resp.Create(info);
            }
            return info;
        }

        public bool Save(Cliente reg)
        {
            bool Result = true;
            using (var resp= new Repository<Cliente>())
            {
                if (resp.Create(reg) == null)
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }

        public bool Update(Cliente reg)
        {
            bool Result = true;
            using (var resp = new Repository<Cliente>())
            {
                var aux = resp.Find(x=>x.IDCliente==reg.IDCliente);
                aux.Nombre = reg.Nombre;
                aux.Cedula = reg.Cedula;
                aux.Direccion = reg.Direccion;
                aux.Telefono = reg.Telefono;
                aux.Correo = reg.Correo;

                if (!resp.Update(aux))
                {
                    Result = false;
                    error = resp.Error;
                }
            }
            return Result;
        }
    }
}
