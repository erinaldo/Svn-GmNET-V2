using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gm.Core;

namespace Gm.NET.Formularios.Consultas_Reportes
{
    public partial class XUCVentasCompras : DevExpress.XtraEditors.XtraUserControl
    {
        MovimientoKardexBLL metodo;
        public XUCVentasCompras()
        {
            InitializeComponent();
            labelControl14.Text = this.Text;
        }

        private void XUCVentasCompras_Load(object sender, EventArgs e)
        {
            using (FrmCargaComponentes frm = new FrmCargaComponentes(Mostrar))
            {
                frm.ShowDialog(this);
            }
        }
        private void Mostrar()
        {
            metodo = new MovimientoKardexBLL();
            pivotGridControl1.DataSource = metodo.Cargar();
            chartControl1.DataSource = pivotGridControl1.DataSource;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
    }
}
