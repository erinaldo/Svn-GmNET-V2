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
using Gm.Entities;
using DevExpress.XtraGrid;
using Gm.NET.Formularios;
using Gm.Data;

namespace Gm.NET
{
    public partial class XfCompraProductoAyuda : DevExpress.XtraEditors.XtraForm
    {

        //public AyudaCore item;
        private readonly ProductoBuscado metodo;
        public Producto ProductoSeleccion;

        #region delegados
        public delegate void Enviar(AyudaCore arg);
        public event Enviar DatosProducto;
        public static XfCompraProductoAyuda formulario = new XfCompraProductoAyuda();
        #endregion
        public static XfCompraProductoAyuda Instance()
        {
            if (((formulario == null) || (formulario.IsDisposed == true)))
                formulario = new XfCompraProductoAyuda();
            formulario.BringToFront();
            return formulario;
        }

        public XfCompraProductoAyuda()
        {
            InitializeComponent();
            metodo = new ProductoBuscado();
        }

        private void XtraFormAyuda_Load(object sender, EventArgs e)
        {

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

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (!txtFiltro.Text.Trim().Equals(""))
            {
                var aux = (from a in new Repository<Producto>().GetAll()
                           where a.Nombre.Contains(txtFiltro.Text)
                           select a).ToList();

                var resp = (from a in aux
                            select new Producto
                            {
                                IDProducto = a.IDProducto,
                                Nombre = a.Nombre,
                                Marca = a.Marca,
                                MedidaMetrica = a.MedidaMetrica,
                                Iva=a.Iva
                            }).ToList();

                gridControl1.DataSource = resp;

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

        private void Seleccionar()
        {
            //var resp = (ProductoBuscado)gridView1.GetRow(gridView1.FocusedRowHandle);

            //var p = new Repository<Producto>().Find(x => x.IDProducto==resp.IDProducto);
            var p = (Producto)gridView1.GetRow(gridView1.FocusedRowHandle);
            ProductoSeleccion = p;
            if (this.DatosProducto != null)
            {
                this.DatosProducto(new AyudaCore
                {
                    IDProducto = p.IDProducto,
                    CodBarra = p.CodBarra,
                    Nombre = p.Nombre,
                    PVenta1 = p.PVenta1,
                    PVenta2 = p.PVenta2,
                    MedidaMetrica = p.MedidaMetrica,
                    Marca = p.Marca,
                    //NameMedida1 = p.NameMedida1,
                    Iva = p.Iva,
                    //Opcion1 = true

                });
            }
            

            txtFiltro.SelectAll();
            txtFiltro.Focus();
            Close();
        }
    }
}