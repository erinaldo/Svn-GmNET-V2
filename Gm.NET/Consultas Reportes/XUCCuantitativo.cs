using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gm.Core;
using Gm.Data;
using DevExpress.Spreadsheet.Charts;
using Gm.Entities;
using DevExpress.Utils.Drawing.Helpers;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    
    public partial class XUCCuantitativo : DevExpress.XtraEditors.XtraUserControl
    {
        private KardexBLL metodo;
        
        public XUCCuantitativo()
        {
            InitializeComponent();
            //labelControl14.Text = this.Text;
        }

        private void XUCCuantitativo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            Dictionary<string, Series> seriesList = new Dictionary<string, Series>();
            try
            {
                metodo = new KardexBLL();
                var de = new Repository<Sp_ProcedureKardex_Result>();
                var aux = de.SQLQuery("EXEC Sp_ProcedureKardex");
                List<VistaKardex> vista = (from a in aux
                                           select new VistaKardex
                                           {
                                               IDKardex = Convert.ToInt32(a.IDKardex),
                                               IDProducto = a.IDProducto,
                                               Producto = a.Producto,
                                               ProductoEntra = a.ProductoEntra,
                                               ProductoEntraPrecio = a.ProductoEntraPrecio,
                                               ProductoSale = a.ProductoSale,
                                               ProductoSalePrecio = a.ProductoSalePrecio,
                                               IVA = a.IVA,
                                               Fecha = a.Fecha,
                                               Estado = a.Estado,
                                               Medida = a.Medida
                                           }).ToList();

                pivotGridControl1.DataSource = vista;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            
            //https://www.youtube.com/watch?v=f3w4RAyBbhg
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
