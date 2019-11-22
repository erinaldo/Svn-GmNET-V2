using System;
using System.Collections.Generic;
using System.Linq;

using Gm.Data;
using Gm.Entities;
using Gm.Core.Generales;

namespace Gm.Core
{
    public class UsuarioBLL
    {
        
        public string Error;
        public UsuarioBLL() {
        }
        
        //cargamos todos los usuarios
        public List<Usuarios> MyUsers {
            get
            {
                return new Repository<Usuarios>().GetAll();
            }
        }

        public object ObtenerPropiedades { get; private set; }

        public List<Acceso> Cargar(int IDUsuario)
        {
            List<Acceso> Result = null;
            using (var resp = new Repository<Acceso>())
            {
                var lista = resp.Search(a => a.IDUsuario == IDUsuario);
                if (lista != null)
                {
                    Result = (from a in lista 
                             select new Acceso
                             {
                                 IDUsuario=a.IDUsuario,
                                 IDModulo=a.IDModulo,
                                 Estado=a.Estado,
                                 //Modulos=new Repository<Modulos>().Find(x=>x.IDModulo==a.IDModulo)
                             }).ToList();
                }
                else
                {
                    //Result = new List<Acceso>();
                    Result = (from a in new Repository<Modulos>().GetAll()
                     select new Acceso
                     {
                         IDUsuario = IDUsuario,
                         IDModulo = a.IDModulo,
                         Estado = false,
                         //Modulos = a
                     }).ToList();
                }
            }
            return Result;
        }
        public bool Grabar(Usuarios item)
        {
            bool Result = true;
            using (var resp = new Repository<Usuarios>())
            {
                var row = resp.GetAll().Count;
                row++;
                item.IDUsuario = row;

                if (resp.Create(item) == null)
                {
                    Result = false;
                    Error = resp.Error;
                }
            }
            return Result;
        }
        public bool Update(Usuarios item)
        {
            bool Result = true;
            using (var resp = new Repository<Usuarios>())
            {
                var aux = resp.Find(x=>x.IDUsuario==item.IDUsuario);
                aux.Nombre = item.Nombre;
                aux.Estado = item.Estado;
                aux.Cedula = item.Cedula;
                aux.Login = item.Login;
                aux.Pasword = item.Pasword;
                if (!resp.Update(aux))
                {
                    Result = false;
                    Error = resp.Error;
                }
            }
                return Result;
        }
        public void Actualizar(int IDUsuario, List<Acceso> lista)
        {
            foreach(Acceso item in lista)
            {
                using (var resp=new Repository<Acceso>())
                {
                    Acceso tbl = resp.Find(o => o.IDUsuario == IDUsuario && o.IDModulo == item.IDModulo);
                    if (tbl != null)
                    {
                        tbl.Estado = item.Estado;
                        resp.Update();
                    }
                }
            }
        }
        public bool Actualizar(Acceso item)
        {
            bool Resul = true;
            using (var resp = new Repository<Acceso>())
            {

                Acceso tbl = resp.Find(o => o.IDUsuario == item.IDUsuario && o.IDModulo == item.IDModulo);

                if (tbl == null)
                    resp.Create(item);
                else
                {
                    tbl.Estado = item.Estado;
                    if (!resp.Update(tbl))
                    {
                        Error = resp.Error;
                        Resul = false;
                    }
                }
            }
            return Resul;
        }
        public bool Login(string login, string pasword)
        {
            bool Result = true;
            using (var resp = new Repository<Usuarios>())
            {
                Usuarios tbl = resp.Find(o => o.Login == login && o.Pasword == pasword);
                if (tbl != null)
                {
                    General.Nombre = tbl.Nombre;
                    General.Login = tbl.Login;
                    General.IdUsuario =Convert.ToInt64(tbl.IDUsuario);

                    //string mac = new ObtenerPropiedades().myMac;

                    //Terminal tmp = new Repository<Terminal>().Find(a => a.Mac == mac);
                    //if (tmp == null)
                    //{
                    //    Error = "No esta registrado";
                    //    Result= false;
                    //}
                    //else
                    //{
                    //    GeneralBLL.terminal = string.Format("{0:000}", tmp.IDTerminal);
                    //    GeneralBLL.oficina = tmp.Oficina;
                    //}
                }
                else
                {
                    Error = (string.IsNullOrEmpty(resp.Error))?"Usuario no registrado":resp.Error;
                    Result = false;
                }    
            }
            return Result; 
        }
        public bool Delete(Usuarios item)
        {
            bool Result = true;
            using (var resp = new Repository<Usuarios>())
            {
                Usuarios tbl = resp.Find(a => a.IDUsuario == item.IDUsuario);
                tbl.Estado = false;
                if (!resp.Update())
                {
                    Result = false;
                    Error = resp.Error;
                }
            }
            return Result;
        }
        //private string miMac()
        //{
        //    NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
        //    String sMacAddress = string.Empty;
        //    foreach (NetworkInterface adapter in nics)
        //    {
        //        if (sMacAddress == String.Empty)
        //        {
        //            IPInterfaceProperties properties = adapter.GetIPProperties();
        //            sMacAddress = adapter.GetPhysicalAddress().ToString();
        //        }
        //    }
        //    return sMacAddress;
        //}
    }
}
