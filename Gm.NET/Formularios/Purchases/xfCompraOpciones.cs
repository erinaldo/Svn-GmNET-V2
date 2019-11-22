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

namespace Gm.NET.Formularios.Sales
{
    public partial class XfCompraOpciones : DevExpress.XtraEditors.XtraForm
    {
        public int Opcion;
        public XfCompraOpciones()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Opcion = Convert.ToInt16(radioGroup1.EditValue);
        }
    }
}