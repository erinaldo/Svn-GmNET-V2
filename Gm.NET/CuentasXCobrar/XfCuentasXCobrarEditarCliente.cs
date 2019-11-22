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
using Gm.Core;
using DevExpress.XtraGrid;
using Gm.NET.Formularios;
//using Gm.NET.Formularios.VentaCompra;
using Gm.Data;

namespace Gm.NET
{
    public partial class XfCuentasXCobrarEditarCliente : DevExpress.XtraEditors.XtraForm
    {
        public long? cliente_;
        public long? factura_;
        Repository<Cliente> repositoryCliente;
        public XfCuentasXCobrarEditarCliente()
        {
            InitializeComponent();
        }

        void Mostrar()
        {
            repositoryCliente = new Repository<Cliente>();
            gridControl1.DataSource = repositoryCliente.Search(x=>x.IDCliente>1);
        }

        private void XtraFormCliente_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xfClientAdmin_SizeChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            var factura = new Repository<Factura>();
            var fac = factura.Find(x=>x.IDFactura==factura_);
            if (resp.IDCliente != cliente_)
            {
                fac.IDCliente = resp.IDCliente;
                if (factura.Update(fac))
                    Close();
                else
                    XtraMessageBox.Show(factura.Error);
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (resp!=null && e.KeyCode == Keys.Enter)
            {
                txtCliente.EditValue = resp.Nombre;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (resp != null )
            {
                txtCliente.EditValue = resp.Nombre;
            }
        }
    }
}