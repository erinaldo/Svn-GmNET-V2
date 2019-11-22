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
    public partial class XfInicio : DevExpress.XtraEditors.XtraForm
    {
        public XfInicio()
        {
            InitializeComponent();
        }

        private void XfInicio_SizeChanged(object sender, EventArgs e)
        {
            int x = (sidePanel1.Height - pictureEdit1.Height )/ 2;
            int y = (sidePanel1.Width- pictureEdit1.Width) / 2;

            pictureEdit1.Location = new Point(y, x);
            pictureEdit1.Image = General.FotoEmpres;
        }
    }
}