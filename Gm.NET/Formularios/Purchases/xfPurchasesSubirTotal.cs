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

namespace Gm.NET
{
    public partial class xfPurchasesSubirTotal : DevExpress.XtraEditors.XtraForm
    {
        public List<EnRegistro> lista;
        public xfPurchasesSubirTotal()
        {
            InitializeComponent();
        }

        private void xfPurchasesSubirTotal_Load(object sender, EventArgs e)
        {
            List<PurchaseSubirTodos> resp = (from a in lista
                                             select new PurchaseSubirTodos
                                             {
                                                 IdProducto = a.IDProduct,
                                                 Name = a.Name,
                                                 Cantidad = a.Cantidad,
                                                 PrecioReal = a.PrecioReal,
                                                 En = a.Medida,
                                                 //PrecioPorMayor = l,
                                                 Fecha = a.Fecha,
                                                 Factura=a.Numfactura
                                             }).ToList();
            gridControl1.DataSource = resp;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}