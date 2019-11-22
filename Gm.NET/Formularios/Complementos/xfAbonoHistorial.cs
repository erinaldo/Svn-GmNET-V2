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

using Gm.Data;
using Gm.Entities;

namespace Gm.NET.Formularios
{
    public partial class xfAbonoHistorial : DevExpress.XtraEditors.XtraForm
    {
        public long IdFactura;
        public string numFactura;
        public xfAbonoHistorial()
        {
            InitializeComponent();
        }

        private void xfAbonoHistorial_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("HISTORIAL -> Factura {0}",numFactura);

            var detalle = new Repository<FacturaDetalle>().Search(x=>x.IDFactura==IdFactura);
            gridControl1.DataSource = detalle;
            var credito = new Repository<Credito>().Search(x=>x.IDFactura==IdFactura);
            gridControl2.DataSource = credito;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}