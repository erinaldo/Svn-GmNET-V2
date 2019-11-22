using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class VistaVentaBLL
    {
        
        public List<InventarioBLL> Inventario
        {
            get;
            private set;
        }
        public List<Sp_Existencia_Result> Existencia
        {
            get;
            private set;
        }
        

        public void RespVenta(DateTime fecha)
        {
            //var resp = new Repository<VistaVenta>();
            //DateTime aux = Convert.ToDateTime(fecha.ToString("dd-MM-yyyy"));
            //venta = resp.Search(x => x.Fecha == aux);
        }

        public void RespExistencia()
        {
            Existencia = new Repository<Sp_Existencia_Result>().SQLQuery("EXEC Sp_Existencia");
        }

        //cargar inventario
        public void RespInventario()
        {
            Inventario = new List<InventarioBLL>();
            RespExistencia();

            Inventario = (from row in Existencia
                          select new InventarioBLL
                          {
                              ID = Convert.ToInt32(row.IDProducto),
                              Name = row.Nombre,
                              EnExistencia = Convert.ToInt32(row.Existencia)
                          }).ToList();
        }

        public DataTable tabla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Nombre");

            DataRow row = dt.NewRow();
            
            row["ID"] = 0;
            row["Nombre"] = "Todos";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["ID"] = 1;
            row["Nombre"] = "En existenia";
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["ID"] = 2;
            row["Nombre"] = "En cerro";
            dt.Rows.Add(row);

            return dt;
        }


        
    }
}
