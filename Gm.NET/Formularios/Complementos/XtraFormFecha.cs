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

namespace Gm.NET
{
    public partial class XtraFormFecha : DevExpress.XtraEditors.XtraForm
    {
        public DateTime desde;
        public DateTime hasta;
        //public bool bOk = false;
        public XtraFormFecha()
        {
            InitializeComponent();
        }

        private void XtraFormFactura_Load(object sender, EventArgs e)
        {
            deDesde.EditValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            deHasta.EditValue = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            desde = deDesde.DateTime;
            hasta = deHasta.DateTime;
            
            //bOk = true;
            Close();
        }
    }
}