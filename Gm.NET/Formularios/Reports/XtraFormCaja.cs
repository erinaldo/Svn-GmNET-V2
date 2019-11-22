using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Gm.Core;
using Gm.Entities;
using Gm.Data;

namespace Gm.NET
{
    public partial class XtraFormCaja : DevExpress.XtraEditors.XtraForm
    {
        
        public XtraFormCaja()
        {
            InitializeComponent();
        }

        private void XtraFormCaja_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Now;
        }
        private void Mostrar()
        {
            var fac = new Repository<Factura>().Search(a => a.Tipo == "V" && a.Estado == "A");

            var re = (from a in fac
                      where a.Fecha.Value.ToString("MM/dd/yyy") == dateEdit1.DateTime.ToString("MM/dd/yyy")
                      select a).ToList();
                

            List < CajaBLL > datos = new List<CajaBLL>();
            var detalle = new Repository<FacturaDetalle>();

            foreach(var aux in re)
            {
                var r = detalle.Search(x => x.IDFactura == aux.IDFactura);
                datos.Add(new CajaBLL {
                    terminal=aux.IDTerminal.ToString(),
                    IdFactura = Convert.ToInt32(aux.IDFactura),
                    venta = Convert.ToDecimal(r.Sum(x=>x.Costo*x.Unidades))
                });
            }

            List<CajaBLL> result = datos.GroupBy(l => l.terminal).Select(cl => new CajaBLL
            {
                terminal = cl.First().terminal,
                IdFactura = cl.First().IdFactura,
                venta = cl.Sum(c => c.venta)
            }).ToList();


            DataTable dt = new DataTable();
            dt.Columns.Add("terminal");
            dt.Columns.Add("monto");

            foreach (CajaBLL a in result)
            {
                DataRow row = dt.NewRow();
                row["terminal"] = string.Format("{0:000}",Convert.ToInt32(a.terminal));
                row["monto"] = a.venta;
                dt.Rows.Add(row);
            }

            gridControl1.DataSource = dt;
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}