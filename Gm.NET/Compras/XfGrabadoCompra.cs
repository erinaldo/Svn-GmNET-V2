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
    public partial class XfGrabadoCompra : DevExpress.XtraEditors.XtraForm
    {
        public List<PurchasesAbvance> detalle_;
        public XfGrabadoCompra()
        {
            InitializeComponent();
        }

        private void XfGrabadoCompra_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = detalle_;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //foreach(var row in detalle_)
            //{
            //    //row.Cantidad = row.Ahorra;
            //    //row.ParaBodega = row.ParaBodega;
            //}
                
        }
    }
}