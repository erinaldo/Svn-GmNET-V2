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
    public partial class XfAuditoria : DevExpress.XtraEditors.XtraForm
    {
        int row = 200;
        public XfAuditoria()
        {
            InitializeComponent();
        }
        public void Actualizar()
        {
            var resp = new Repository<Kardex>();
            gridControl1.DataSource = resp.GetAll().Take(row);
        }
        public void Filas()
        {

        }
        private void XfAuditoria_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        public void Cerrar()
        {
            Close();
        }
    }
}