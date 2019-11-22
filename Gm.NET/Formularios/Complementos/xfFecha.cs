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

namespace Gm.NET.Formularios
{
    public partial class XfFecha : DevExpress.XtraEditors.XtraForm
    {
        public DateTime fecha;
        public XfFecha()
        {
            InitializeComponent();
        }

        private void xfFecha_Load(object sender, EventArgs e)
        {
            deFecha.EditValue = fecha;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            fecha = deFecha.DateTime;
        }

        private void deFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAplicar.Focus();
        }
    }
}