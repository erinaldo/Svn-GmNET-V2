using System;
using System.Collections.Generic;
using System.Linq;

using Gm.Entities;
using Gm.Data;


namespace Gm.Core
{
    public class AforoAdministracionBLL
    {
        private List<AforoBLL> datos;
        public AforoAdministracionBLL()
        {
            Llenar();
        }

        public List<AforoBLL> Datos { get => datos; set => datos = value; }

        private void Llenar()
        {
            var resp = new VistaVentaBLL();
            //Datos = (from a in resp.Existencia
            //                       select new AforoBLL
            //                       {
            //                           IDProducto=Convert.ToInt32(a.IDProducto),
            //                           Nombre=a.Nombre,
            //                           Existencia=a.Existencia,
            //                           ExistenciaFisica=0
            //                       }
            //                       ).ToList();
        }
        public void Modificar(AforoBLL dato, int valor)
        {
            //AforoBLL item = datos.FirstOrDefault(a => a.IDProducto == dato.IDProducto);
            //item.ExistenciaFisica += valor;
            //item.Diferencia = (Int32)item.Existencia - (Int32)item.ExistenciaFisica;
        }
        public AforoBLL Dato(string codigo)
        {
            var resp = new Repository<Producto>();
            Producto item = resp.Find(a => a.CodBarra == codigo);
            //AforoBLL dato;
            if (item != null)
            {
                //dato = new AforoBLL() { IDProducto = item.IDProducto, Nombre = item.Nombre };
            }
            //else
            //    dato = null;
            return null;
        }
    }
}
