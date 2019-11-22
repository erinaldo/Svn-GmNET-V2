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
    public partial class XfCompraEditar : DevExpress.XtraEditors.XtraForm
    {
        public long? IdFactura;
        private Repository<Factura> repositoryFactura;
        public XfCompraEditar()
        {
            InitializeComponent();
        }

        private void XfCompraEditar_Load(object sender, EventArgs e)
        {
            repositoryFactura = new Repository<Factura>();
            var resp = repositoryFactura.Find(x=>x.IDFactura==IdFactura);

            var controlCabecera = new XUCCompraCabecera();
            controlCabecera.factura = resp;
            controlCabecera.Editar = true;
            xtraUserControl1.Controls.Add(controlCabecera);
            controlCabecera.Dock = DockStyle.Fill;

            var controlDetalle = new XUCCompraDetalle();
            controlDetalle.factura = resp;
            
            xtraUserControl2.Controls.Add(controlDetalle);
            controlDetalle.Dock = DockStyle.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}