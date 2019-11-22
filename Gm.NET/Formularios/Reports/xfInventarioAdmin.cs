using System;
using System.Windows.Forms;
using Gm.Core;
using System.Linq;
using DevExpress.XtraEditors;
using Gm.NET.Formularios;
using Gm.Entities;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;

namespace Gm.NET
{
    public partial class xfInventarioAdmin : DevExpress.XtraEditors.XtraForm
    {
        VistaVentaBLL metodo;
        public xfInventarioAdmin()
        {
            InitializeComponent();
        }

        private void XtraFormVistaExistencia_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
   
        private void Mostrar()
        {
            metodo = new VistaVentaBLL();
            gridControl2.DataSource = metodo.Existencia;
            lookUpEdit1.Properties.DataSource = metodo.tabla();

            lookUpEdit1.Properties .DisplayMember = "Nombre";
            lookUpEdit1.Properties.ValueMember = "ID";
        }


        private void btnVer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Sp_Existencia_Result resp = gridView2.GetRow(gridView2.FocusedRowHandle) as Sp_Existencia_Result;

            using (xfInventarioProvider mvc =new xfInventarioProvider { IdProduct= Convert.ToInt64(resp.IDProducto)})
            {
                mvc.ShowDialog();
            };
        }

        private void gridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //GridView View = sender as GridView;
            //if (e.RowHandle >= 0)
            //{
            //    int existencia = (int)View.GetRowCellValue(e.RowHandle, View.Columns["Existencia"]);
            //    if (existencia == 0)
            //    {
            //        e.Appearance.BackColor = Color.Red;
            //        e.Appearance.BackColor2 = Color.SeaShell;
            //    }
            //    else if (existencia<5)
            //    {
            //        e.Appearance.BackColor = Color.Yellow;
            //        e.Appearance.BackColor2 = Color.YellowGreen;
            //    }
            //    e.HighPriority = true;
            //}
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit aux = (LookUpEdit)sender;
            switch (Convert.ToInt32(aux.EditValue))
            {
                case 0:
                    gridView2.ViewCaption = "Todos";
                    gridControl2.DataSource = metodo.Existencia;
                    break;
                case 1:
                    gridView2.ViewCaption = "En existencia";
                    var resp = (from a in metodo.Existencia
                                where a.Existencia > 0
                                select a);

                    gridControl2.DataSource = resp.ToList();
                    break;
                case 2:
                    gridView2.ViewCaption = "En cero";
                    var resp1 = (from a in metodo.Existencia
                                 where a.Existencia == 0
                                 select a);

                    gridControl2.DataSource = resp1.ToList();
                    break;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}