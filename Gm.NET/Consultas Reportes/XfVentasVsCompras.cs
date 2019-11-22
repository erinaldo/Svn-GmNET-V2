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
using Gm.NET.Formularios;
using DevExpress.XtraPrinting;

namespace Gm.NET
{
    public partial class XfVentasVsCompras : DevExpress.XtraEditors.XtraForm
    {
        MovimientoKardexBLL metodo;
        public XfVentasVsCompras()
        {
            InitializeComponent();
        }

        private void XfVentasVsCompras_Load(object sender, EventArgs e)
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mostrar();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = chartControl1;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
    }
}