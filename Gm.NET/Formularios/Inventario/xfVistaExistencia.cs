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


namespace Gm.NET.Formularios.Inventario
{
    using Gm.Core;
    using Gm.Data;
    using Gm.Entities;

    public partial class XfVistaExistencia : DevExpress.XtraEditors.XtraForm
    {
        public XfVistaExistencia()
        {
            InitializeComponent();
            labelControl14.Text = this.Text;
        }
        void function()
        {
            ProductoAdmin inventario = new ProductoAdmin();

            //gridControl1.DataSource = inventario.GetInventario().OrderBy(x=>x.Nombre).ToList();
        }

        private void xfVistaExistencia_Load(object sender, EventArgs e)
        {
            function();
        }

        private void xfVistaExistencia_SizeChanged(object sender, EventArgs e)
        {
            sidePanel1.Location = CenterForm.Function(this.Width, sidePanel1.Width );
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void btnProveedor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as VistaExistenciaCore;
            using (XfInventarioProvider mvc= new XfInventarioProvider { IdProduct = resp.IDProducto })
            {
                mvc.ShowDialog();
            }
        }
    }
}