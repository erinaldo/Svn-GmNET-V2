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
using Gm.Entities;
using Gm.Data;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    public partial class XUCGrafico : DevExpress.XtraEditors.XtraUserControl
    {
        private KardexBLL metodo;
        public XUCGrafico()
        {
            InitializeComponent();
            labelControl14.Text = this.Text;
        }
        private void Mostrar()
        {
            //Dictionary<string, Series> seriesList = new Dictionary<string, Series>();
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

                chartControl1.DataSource = vista;
                //https://www.youtube.com/watch?v=f3w4RAyBbhg
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }
        private void XUCGrafico_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
