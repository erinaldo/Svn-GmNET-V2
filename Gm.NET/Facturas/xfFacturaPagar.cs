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
    public partial class XfFacturaPagar : DevExpress.XtraEditors.XtraForm
    {
        public decimal total;
        public decimal saldo;
        public decimal abonar;
        public XfFacturaPagar()
        {
            InitializeComponent();
        }

        private void xfFacturaPagar_Load(object sender, EventArgs e)
        {
            txtTotal.EditValue = total;
        }

        private void txtEfectivo_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEfectivo.Text))
            {
                var cambio= Convert.ToDecimal(txtEfectivo.EditValue) - total;
                if (cambio >= 0)
                    saldo = 0;
                if (cambio < 0)
                {
                    saldo = -1 * cambio;
                    cambio = 0;
                }
                
                txtCambio.EditValue = cambio;
                txtSaldo.EditValue = saldo;
                abonar = Convert.ToDecimal(txtEfectivo.Text);
            }
        }

        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
                btnCobrar.Focus();
            if (Keys.Escape == e.KeyCode)
            {
                Close();
            }       
        }
    }
}