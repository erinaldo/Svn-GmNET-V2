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

namespace Gm.NET
{
    public partial class XfBodegaMovimiento : DevExpress.XtraEditors.XtraForm
    {
        public XfBodegaMovimiento()
        {
            InitializeComponent();
        }

        private void XfBodegaMovimiento_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        public void Actualizar()
        {
            var resp = new Repository<Traslados>().GetAll().OrderByDescending(x=>x.IDTraslado).Take(200);
            gridControl1.DataSource = resp;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Actualizar();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}