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
using DevExpress.XtraGrid;
using Gm.Core;
using DevExpress.XtraGrid.Views.Grid;
using Gm.Data;

namespace Gm.NET.Formularios
{
    public partial class XfProductEditQuick : DevExpress.XtraEditors.XtraForm
    {
        Repository<Producto> tmp;
        public Producto nuevo;
        public delegate void Enviar(GridControl t, int i);
        public event Enviar unEvento;

        public int row;
        public GridControl dt;
        
        //ProductoBLL aux;

        public static XfProductEditQuick formulario = null;
        public static XfProductEditQuick Instance()
        {
            if (((formulario == null) || (formulario.IsDisposed == true)))
                formulario = new XfProductEditQuick();
            formulario.BringToFront();
            return formulario;
        }

        public XfProductEditQuick()
        {
            InitializeComponent();
        }

        private void xfProductoEditRapida_Load(object sender, EventArgs e)
        {
            var grid = new GridView();
            try
            {
                grid = (GridView)dt.ViewCollection[0];
                lbContador.Text = string.Format("{0}/{1}", grid.RowCount, row + 1);

                tmp = new Repository<Producto>();
                Producto p = grid.GetRow(row) as Producto;

                nuevo = tmp.Find(x => x.IDProducto == p.IDProducto);

                if (nuevo != null)
                {
                    txtNombre.EditValue = nuevo.Nombre;
                    txtPrecioCompraReal.EditValue = nuevo.PCAnterior;
                    txtPrecio1.EditValue = nuevo.PVenta1;

                    txtPrecio2.EditValue = nuevo.PVenta2;
                    //txtCodicion2.EditValue = nuevo.Equivalencia2;

                    //txtPrecio2.Enabled = (nuevo.StateMedida2 != null) ? (bool)nuevo.StateMedida2 : false;
                    //txtCodicion2.Enabled = (nuevo.StateMedida2 != null) ? (bool)nuevo.StateMedida2 : false;


                    txtPrecio3.EditValue = nuevo.PVenta3;
                    txtPrecio4.EditValue = nuevo.PVenta4;
                    //txtCondicion3.EditValue = nuevo.Equivalencia3;
                    //txtPrecio3.Enabled = (nuevo.StateMedida3 != null) ? (bool)nuevo.StateMedida3 : false;
                    //txtCondicion3.Enabled = (nuevo.StateMedida3 != null) ? (bool)nuevo.StateMedida3 : false;



                    //aux = new ProductoBLL();
                }
            }
            catch (Exception) { }
            
            
        }

        private void EndEdit_TextEdit(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                var resp = tmp.GetAll();
                dt.DataSource = resp;

                var grid = (GridView)dt.ViewCollection[0];

                row--;
                if (row < 0)
                    row = grid.RowCount-1;

                this.unEvento(dt, row);

                Producto p2 = grid.GetRow(row) as Producto;

                nuevo = tmp.Find(x => x.IDProducto == p2.IDProducto);
                //nuevo = grid.GetRow(row) as Producto;

                txtNombre.EditValue = nuevo.Nombre;
                txtPrecioCompraReal.EditValue = 0;
                txtPrecio1.EditValue = nuevo.PVenta1;
                txtPrecio2.EditValue = nuevo.PVenta2;
                txtPrecio3.EditValue = nuevo.PVenta3;
                txtPrecio4.EditValue = nuevo.PVenta4;
                //txtCodicion2.EditValue = nuevo.Equivalencia2;
                //txtCondicion3.EditValue = nuevo.Equivalencia3;
                txtPrecioCompraReal.EditValue = nuevo.PCAnterior;

                txtNombre.Focus();

                lbContador.Text = string.Format("{0}/{1}", grid.RowCount, row + 1);
            }
            if (e.KeyCode == Keys.Down)
            {
                var resp = tmp.GetAll();
                dt.DataSource = resp;

                var grid = (GridView)dt.ViewCollection[0];

                row++;
                if (row >= grid.RowCount)
                    row = 0;

                this.unEvento(dt, row);

                Producto p1 = grid.GetRow(row) as Producto;

                nuevo = tmp.Find(x => x.IDProducto == p1.IDProducto);
                //nuevo = grid.GetRow(row) as Producto;

                txtNombre.EditValue = nuevo.Nombre;
                txtPrecioCompraReal.EditValue = 0;
                txtPrecio1.EditValue = nuevo.PVenta1;
                txtPrecio2.EditValue = nuevo.PVenta2;
                txtPrecio3.EditValue = nuevo.PVenta3;
                txtPrecio4.EditValue = nuevo.PVenta4;
                //txtCodicion2.EditValue = nuevo.Equivalencia2;
                //txtCondicion3.EditValue = nuevo.Equivalencia3;
                txtPrecioCompraReal.EditValue = nuevo.PCAnterior;

                txtNombre.Focus();

                lbContador.Text = string.Format("{0}/{1}", grid.RowCount, row + 1);

            }
            if (e.KeyCode == Keys.Enter)
            {

                if (Validar())
                {
                    if (!tmp.Update(nuevo))
                    {
                        this.Hide();
                        XtraMessageBox.Show(tmp.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Visible = true;
                    }
                }

                var resp = tmp.GetAll();
                dt.DataSource = resp;

                var grid = (GridView)dt.ViewCollection[0];
                
                row++;
                if (row >= grid.RowCount)
                    row = 0;

                this.unEvento(dt, row);

                Producto p = grid.GetRow(row) as Producto;

                nuevo = tmp.Find(x => x.IDProducto == p.IDProducto);
                //nuevo = grid.GetRow(row) as Producto;

                txtNombre.EditValue = nuevo.Nombre;
                txtPrecioCompraReal.EditValue = 0;
                txtPrecio1.EditValue = nuevo.PVenta1;
                txtPrecio2.EditValue = nuevo.PVenta2;
                txtPrecio3.EditValue = nuevo.PVenta3;
                txtPrecio4.EditValue = nuevo.PVenta4;
                //txtCodicion2.EditValue = nuevo.Equivalencia2;
                //txtCondicion3.EditValue = nuevo.Equivalencia3;
                txtPrecioCompraReal.EditValue = nuevo.PCAnterior;

                txtNombre.Focus();

                lbContador.Text = string.Format("{0}/{1}", grid.RowCount, row+1);
                
            }
            else if(e.KeyCode==Keys.Escape)
            {
                Close();
            }
        }
        private bool Validar()
        {
            bool Result = false;

            try
            {    
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNombre.Text.Trim()) && txtNombre.Text != nuevo.Nombre)
                {
                    nuevo.NombreAnterior = nuevo.Nombre;
                    nuevo.Nombre = txtNombre.Text;
                    nuevo.EdNombre = true;
                    Result = true;
                }
                //if (!string.IsNullOrEmpty(txtPrecioCompraReal.Text) && txtPrecioCompraReal.Text != nuevo.p)
                //{
                //    nuevo.CodBarra = txtPrecioCompraReal.Text;
                //    Result = true;
                //}

                if (!string.IsNullOrEmpty(txtPrecio1.Text) && Convert.ToDecimal(txtPrecio1.Text) != nuevo.PVenta1)
                {
                    nuevo.PVAnterior1 = nuevo.PVenta1;
                    nuevo.PVenta1 = Convert.ToDecimal(txtPrecio1.Text);
                    nuevo.EdPVenta1 = true;
                    Result = true;
                }

                if (!string.IsNullOrEmpty(txtPrecio2.Text) && Convert.ToDecimal(txtPrecio2.Text) != nuevo.PVenta2)
                {
                    nuevo.PVAnterior2 = nuevo.PVenta2;
                    nuevo.PVenta2 = Convert.ToDecimal(txtPrecio2.Text);
                    nuevo.EdPVenta2 = true;
                    Result = true;
                }
                if (!string.IsNullOrEmpty(txtPrecio3.Text) && Convert.ToDecimal(txtPrecio3.Text) != nuevo.PVenta3)
                {
                    nuevo.PVAnterior3 = nuevo.PVenta3;
                    nuevo.PVenta3 = Convert.ToDecimal(txtPrecio3.Text);
                    nuevo.EdPVenta3 = true;
                    Result = true;
                }
                if (!string.IsNullOrEmpty(txtPrecio4.Text) && Convert.ToDecimal(txtPrecio4.Text) != nuevo.PVenta4)
                {
                    //nuevo.PVAnterior4 = nuevo.PVenta4;
                    nuevo.PVenta4 = Convert.ToDecimal(txtPrecio4.Text);
                    //nuevo.EdPVenta3 = true;
                    Result = true;
                }
                //if (!string.IsNullOrEmpty(txtCodicion2.Text) && Convert.ToInt32(txtCodicion2.Text) != nuevo.Equivalencia2)
                //{
                //    nuevo.Equivalencia2 = Convert.ToInt32(txtCodicion2.Text);
                //    Result = true;
                //}
                //if (!string.IsNullOrEmpty(txtCondicion3.Text) && Convert.ToInt32(txtCondicion3.Text) != nuevo.Equivalencia3)
                //{
                //    nuevo.Equivalencia3 = Convert.ToInt32(txtCondicion3.Text);
                //    Result = true;
                //}
            }
            catch (Exception) { }
            
            return Result;
        }
    }
}