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
using DevExpress.XtraGrid.Views.Grid;
using Gm.Core;
using DevExpress.XtraPrinting;

namespace Gm.NET.Formularios
{
    public partial class XfProveedorListado : DevExpress.XtraEditors.XtraForm
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Proveedor> proveedors;
        public XfProveedorListado()
        {
            InitializeComponent();
        }

        private void xfClientesListado_Load(object sender, EventArgs e)
        {
            CargaClientes();
        }
        public void CargaClientes()
        {
            clientes = new Repository<Cliente>().Search(x=>x.Tipo=="P");
            productos = new Repository<Producto>().Search(x=>x.Estado!="E");
            proveedors = new Repository<Proveedor>().GetAll();
            gridControl1.DataSource = clientes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
        public void Crear()
        {
            XfComprasProveedor mvc = new XfComprasProveedor();
            mvc.ShowDialog();
        }
        public void Editar()
        {
            var cliente = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;

            XfComprasProveedorEditar mvc = new XfComprasProveedorEditar { cliente_ = cliente };
            if (mvc.ShowDialog() == DialogResult.OK)
                CargaClientes();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            var aux = new Repository<Proveedor>().Search(x=>x.IDCliente==resp.IDCliente);
            try
            {
                var pro = new List<Producto>();
                var con = new Repository<Producto>();
                foreach(var a in aux)
                    pro.Add(con.Find(x => x.IDProducto == a.IDProducto));

                //gridControl2.DataSource = pro;
            }
            catch (Exception) { }
        }
        public void Eliminar()
        {
            var cliente = gridView1.GetRow(gridView1.FocusedRowHandle) as Cliente;
            if (cliente != null)
            {
                var resp = new Repository<Cliente>();
                var aux = resp.Find(x => x.IDCliente == cliente.IDCliente);

                if (XtraMessageBox.Show("Esta por elimimiar el Proveedor\ndesea continuar", "Alerta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    aux.Estado = "E";
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

        private void gridView1_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            GridView view = sender as GridView;
            var pro = view.GetRow(e.RowHandle) as Cliente;
            if (pro != null)
            {
                List<long> product = (from a in proveedors
                                     where a.IDCliente == pro.IDCliente
                                     select a.IDProducto).ToList();
                var resp = (from a in productos
                            where product.Contains(a.IDProducto)
                            select a).ToList();


                if (resp != null)
                    e.IsEmpty = false;
                else
                    e.IsEmpty = true;
            }
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = sender as GridView;
            var pro = view.GetRow(e.RowHandle) as Cliente;
            if (pro != null)
            {
                List<long> product = (from a in proveedors
                                      where a.IDCliente == pro.IDCliente
                                      select a.IDProducto).ToList();
                var resp = (from a in productos
                            where product.Contains(a.IDProducto)
                            select a).ToList();

                List<ProveedorProducto> lista = new List<ProveedorProducto>();
                foreach (var a in resp)
                {
                    lista.Add(
                        new ProveedorProducto
                        {
                            Codigo = a.IDProducto,
                            Nombre = a.Nombre,
                            Marca = (a.Marca != null) ? a.Marca.NombreMarca : "NINGUNO"
                        }
                        );
                }
                

                e.ChildList = lista;
            }
        }

        private void gridView1_MasterRowGetRelationCount(object sender, MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }

        private void gridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        public void Imprimir()
        {


            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gridControl1;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();

            //GridControl grid = new GridControl();
            //GridView view = new GridView(gridControl1);
            //gridControl1.MainView = view;
            //gridControl1.DataSource = gridControl1.DataSource;
            //gridControl1.BindingContext = new System.Windows.Forms.BindingContext();
            //gridControl1.ForceInitialize();
            //gridControl1.MainView.ShowPrintPreview();
        }
        public void Cerrar()
        {
            Close();
        }
    }
}