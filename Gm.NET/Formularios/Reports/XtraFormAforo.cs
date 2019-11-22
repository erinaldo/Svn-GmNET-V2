using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Implementation;
using DevExpress.XtraGrid.Views.Grid;
using Gm.Core;
using Gm.Data;
using Gm.Entities;

namespace Gm.NET
{
    public partial class XtraFormAforo : DevExpress.XtraEditors.XtraForm
    {
        AforoAdministracionBLL metodo;

        public XtraFormAforo()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            metodo = new AforoAdministracionBLL();
            gridControl1.DataSource = metodo.Datos;

        }
        private void XtraFormAforo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.EditValue = null;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
            txtUnidades.EditValue = null;
            txtCodigo.Focus();
        }

        private void txtUnidades_KeyDown(object sender, KeyEventArgs e)
        {
            //if(!txtUnidades.Text.Trim().Equals("") && e.KeyCode == Keys.Enter)
            //{
            //    metodo.Modificar(value, Convert.ToInt32(txtUnidades.Text));
            //    gridControl1.RefreshDataSource();
            //    btnLimpiar_Click(null, null);
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var aux = new Repository<Producto>().Find(x => x.CodBarra == txtCodigo.Text);
                for(int i=0; i < metodo.Datos.Count; i++)
                {
                    //if (metodo.Datos[i].IDProducto == aux.IDProducto)
                    //{
                    //    metodo.Datos[i].ExistenciaFisica++;
                    //    gridView1.FocusedRowHandle = i;
                    //    txtCodigo.EditValue = null;
                    //    gridControl1.RefreshDataSource();
                    //    break;
                    //}
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            using (var resp = new Repository<Kardex>())
            {
                foreach (var row in metodo.Datos)
                {
                    //Kardex nuevo=null;
                    //var pro = new Repository<Producto>().Find(x=>x.IDProducto==row.IDProducto);
                    ////si es positivo se graba una salida
                    //if (row.Diferencia > 0)
                    //{
                    //    nuevo = new Kardex
                    //    {
                    //        IDProducto=row.IDProducto,
                    //        ProductoEntra=0,
                    //        ProductoEntraPrecio=0,
                    //        ProductoSale=row.Diferencia,
                    //        ProductoSalePrecio=0,
                    //        IDFactura="0000",
                    //        IVA=0,
                    //        Fecha=DateTime.Now,
                    //        Estado="F",
                    //        //Equivalencia=pro.Equivalencia,
                    //        //Referencia=pro.Referencia
                    //    };
                    //}
                    ////si es negativo se graba una entrada
                    //else if (row.Diferencia < 0)
                    //{
                    //    nuevo = new Kardex
                    //    {
                    //        IDProducto = row.IDProducto,
                    //        ProductoEntra = row.Diferencia*-1,
                    //        ProductoEntraPrecio = 0,
                    //        ProductoSale = 0,
                    //        ProductoSalePrecio = 0,
                    //        IDFactura = "0000",
                    //        IVA = 0,
                    //        Fecha = DateTime.Now,
                    //        Estado = "F",
                    //        //Equivalencia = pro.Equivalencia,
                    //        //Referencia = pro.Referencia
                    //    };
                    //}
                    //if (nuevo != null)
                    //    if (resp.Create(nuevo) == null)
                    //    {
                    //        XtraMessageBox.Show(resp.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //        return;
                    //    }
                }
                XtraMessageBox.Show("Engraving done successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void DrawCellBorder(Graphics g, Brush borderBrush, Rectangle cellBounds, int borderThickness)
        {
            
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView currentView = sender as GridView;
            if (e.Column.FieldName == "Diferencia")
            {
                int resp = Int32.Parse(currentView.GetRowCellDisplayText(e.RowHandle, currentView.Columns["Diferencia"]));
                if(resp>0)
                    e.Appearance.ForeColor = Color.Red;
                else if(resp<0)
                    e.Appearance.ForeColor = Color.Green;
            }
        }
    }
}