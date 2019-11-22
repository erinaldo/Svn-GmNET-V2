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
using Gm.NET.Formularios.Ventas;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;

namespace Gm.NET.Formularios
{
    public partial class XfClientesListado : DevExpress.XtraEditors.XtraForm
    {
        private List<Cliente> clientes;
        public XfClientesListado()
        {
            InitializeComponent();
        }

        private void xfClientesListado_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }
        public void CargaClientes()
        {
            clientes = new Repository<Cliente>().Search(x => x.Tipo == "C" && x.IDCliente>1 && x.Estado!="I");
            gridControl1.DataSource = clientes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargaClientes();
        }
        public void Crear()
        {
            XfFacturaClienteCrear mvc = new XfFacturaClienteCrear();
            mvc.ShowDialog();
        }
        public void Editar()
        {
            var cliente = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (cliente != null)
            {
                XfFacturaClienteEditar mvc = new XfFacturaClienteEditar { cliente_ = cliente };
                if (mvc.ShowDialog() == DialogResult.OK)
                    CargaClientes();
            }
        }
        public void Eliminar()
        {
            var cliente = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (cliente != null)
            {
                var resp = new Repository<Cliente>();
                var aux = resp.Find(x => x.IDCliente == cliente.IDCliente);

                if (XtraMessageBox.Show("Esta por elimimiar el Cliente\ndesea continuar","Alerta",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    aux.Estado = "I";
                    resp.Update(aux);
                    CargaClientes();
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;
            if (keyData == Keys.F5)
            {
                CargaClientes();
            }
            
           

            return Result;

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (resp != null)
            {
                barButtonItem1.Caption = string.Format("COD{0}", resp.IDCliente);
                barButtonItem2.Caption = string.Format("CLI: {0}", resp.Nombre);
                barButtonItem3.Caption = string.Format("NR: {0}", clientes.Count);
            }
            
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Estado"]);
                if (category == "E")
                {
                    e.Appearance.BackColor = Color.Salmon;
                    e.Appearance.BackColor2 = Color.SeaShell;
                    //e.HighPriority = true;
                }
            }
        }
        public void Imprimir()
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gridControl1;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }
        public void Cerrar()
        {
            Close();
        }
    }
}