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
using Gm.Entities;
using Gm.Data;

namespace Gm.NET
{
    public partial class XfFacturaDevolucion : DevExpress.XtraEditors.XtraForm
    {
        public Factura _factura;
        public XfFacturaDevolucion()
        {
            InitializeComponent();
        }

        private void XfFacturaDevolucion_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("FACTURA ->{0}",_factura.Numero);
            var resp = new Repository<FacturaDetalle>().Search(x => x.IDFactura == _factura.IDFactura && x.Movimiento == "D");
            gridControl1.DataSource = resp;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}