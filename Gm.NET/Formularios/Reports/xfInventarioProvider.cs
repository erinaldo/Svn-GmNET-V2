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

namespace Gm.NET.Formularios
{
    public partial class XfInventarioProvider : DevExpress.XtraEditors.XtraForm
    {
        public long IdProduct;
        public XfInventarioProvider()
        {
            InitializeComponent();
        }

        private void xfProveedor_Load(object sender, EventArgs e)
        {
            ProveedorBLL method = new ProveedorBLL();
            gridControl1.DataSource = method.GetList(IdProduct);
        }
    }
}