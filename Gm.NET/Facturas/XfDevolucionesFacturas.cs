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
    public partial class XfDevolucionesFacturas : DevExpress.XtraEditors.XtraForm
    {
        readonly Repository<FacturaDetalle> repositoryFacDetalle;
        List<FacturaDetalle> _facturaDetalles;
        public XfDevolucionesFacturas()
        {
            InitializeComponent();
            repositoryFacDetalle = new Repository<FacturaDetalle>();
        }

        private void XfDevolucionesFacturas_Load(object sender, EventArgs e)
        {
            gridControl1.Dock = DockStyle.Fill;
            chartControl1.Dock = DockStyle.Fill;
            chartControl1.Visible = false;
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            calendarControlDesde.EditValue = date;
            Cargar();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int? filas = repositoryFacDetalle.Count(x => x.Movimiento == "D" && x.Siclo=="V" && x.Estado==true);
            _facturaDetalles = new List<FacturaDetalle>();

            foreach (var row in repositoryFacDetalle.Search(x => x.Movimiento == "D" && x.Siclo=="V" && x.Estado==true))
            {
                row.FechaSistema = Convert.ToDateTime(row.FechaSistema.Value.ToShortDateString());

                //var desde = DateTime.Compare(calendarControlDesde.DateTime, row.FechaSistema.Value);
                //var hasta = DateTime.Compare(calendarControlHasta.DateTime, row.FechaSistema.Value);
                var desde = calendarControlDesde.DateTime.Ticks;
                var hasta = calendarControlHasta.DateTime.Ticks;
                var ahora = row.FechaSistema.Value.Ticks;

                if (desde <= ahora && hasta  >= ahora)
                    _facturaDetalles.Add(row);
            }
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gridControl1.DataSource = _facturaDetalles;
            chartControl1.DataSource = _facturaDetalles;
        }
        public void Cargar()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnGrilla_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = true;
            chartControl1.Visible = false;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            gridControl1.Visible = false;
            chartControl1.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}