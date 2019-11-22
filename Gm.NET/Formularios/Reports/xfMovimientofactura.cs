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

namespace Gm.NET.Formularios
{
    public partial class xfMovimientofactura : DevExpress.XtraEditors.XtraForm
    {
        public xfMovimientofactura()
        {
            InitializeComponent();
            labelControl14.Text = this.Text;
        }

        void function()
        {
            var resp = new Repository<Sp_MovimientoFactura_Result>();
            var aux = resp.SQLQuery("EXEC Sp_MovimientoFactura");
            gridControl1.DataSource = aux;
        }
        private void xfMovimientofactura_Load(object sender, EventArgs e)
        {
            function();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void xfMovimientofactura_SizeChanged(object sender, EventArgs e)
        {
            sidePanel1.Location = CenterForm.Function(this.Width, sidePanel1.Width);
        }
    }
}