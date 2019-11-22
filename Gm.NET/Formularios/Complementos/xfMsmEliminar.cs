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
    public partial class xfMsmEliminar : DevExpress.XtraEditors.XtraForm
    {
        public string Observacion;
        public xfMsmEliminar()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtObservaciones.Text))
            {
                Observacion = txtObservaciones.Text;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}