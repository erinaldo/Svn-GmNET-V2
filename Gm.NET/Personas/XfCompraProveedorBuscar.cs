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
using Gm.Entities;
using Gm.Data;
using Gm.Core;

namespace Gm.NET.Formularios
{
    public partial class XfCompraProveedorBuscar : DevExpress.XtraEditors.XtraForm
    {
        public delegate void Enviar(Cliente arg);
        public event Enviar DatosCliente;
        public static XfCompraProveedorBuscar formulario = new XfCompraProveedorBuscar();
        private List<Cliente> Lista;
        public Cliente cliente;
        public XfCompraProveedorBuscar()
        {
            InitializeComponent();
        }

        private void xfFacturaCliente_Load(object sender, EventArgs e)
        {
            Lista = new Repository<Cliente>().Search(x=>x.Tipo=="P" && x.Estado=="A");
            gridControl1.DataSource = Lista;
        }

        private void txtFiltro_EditValueChanged(object sender, EventArgs e)
        {
            if (!txtFiltro.Text.Trim().Equals(""))
            {
                gridControl1.DataSource = (from a in Lista
                                           where a.Nombre.Contains(txtFiltro.Text)
                                           select a).ToList();

            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    gridControl1.Focus();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Seleccionar();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
        private void Seleccionar()
        {
            var item = (Cliente)gridView1.GetRow(gridView1.FocusedRowHandle);
            this.DatosCliente(item);
            cliente = item;
            Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}