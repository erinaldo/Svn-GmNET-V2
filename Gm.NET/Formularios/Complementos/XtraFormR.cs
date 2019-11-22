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
    public partial class XtraFormR : DevExpress.XtraEditors.XtraForm
    {
        public int opcion = 0;
        public XtraFormR()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            opcion = Convert.ToInt16(radioGroup1.EditValue);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}