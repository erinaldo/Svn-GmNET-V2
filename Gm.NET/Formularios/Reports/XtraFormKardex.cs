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
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid;

namespace Gm.NET
{
    public partial class XtraFormKardex : DevExpress.XtraEditors.XtraForm
    {
        KardexBLL metodo;
        public XtraFormKardex()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            metodo = new KardexBLL();
            gCKardex.DataSource = metodo.Datos.OrderByDescending(a=>a.IDKardex).Take(200);
            
        }
        private void XtraFormKardex_Load(object sender, EventArgs e)
        {
            Mostrar();
        }     

        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    const int WM_KEYDOWN = 0x100;
        //    const int WM_SYSKEYDOWN = 0x104;

        //    if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
        //    {
        //        switch (keyData)
        //        {
        //            case Keys.F5:
        //                Mostrar();
        //                break;
        //            case Keys.Escape:
        //                Close();
        //                break;
        //        }
        //    }
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            //var resp1 = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["ProductoEntra"]);
            //var resp2 = gridView1.GetRowCellValue(e.RowHandle, gridView1.Columns["ProductoSale"]);

            //if (resp1!=null && Convert.ToInt32(resp1) > 0)
            //{
            //    e.Appearance.ForeColor = Color.Red;
            //}
            //else if(resp2 != null && Convert.ToInt32(resp2) > 0)
            //{
            //    e.Appearance.ForeColor = Color.Green;
            //}
            
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.Column.Name == "colProductoEntra" && Convert.ToInt32(e.CellValue) > 0)
            //{
            //    e.Appearance.ForeColor = Color.Red;
            //}
            //switch (e.Column.Name)
            //{
            //    case "colProductoEntra":
            //    case "colProductoEntraPrecio":
            //        if(Convert.ToDecimal(e.CellValue) > 0)
            //            e.Appearance.ForeColor = Color.Red;
            //        break;
            //    case "colProductoSale":
            //    case "colProductoSalePrecio":
            //        if (Convert.ToDecimal(e.CellValue) > 0)
            //            e.Appearance.ForeColor = Color.Green;
            //        break;
            //}
        }

        private void XtraFormKardex_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintableComponentLink componentLink = new PrintableComponentLink(new PrintingSystem());
            componentLink.Component = gCKardex;
            componentLink.CreateDocument();
            PrintTool pt = new PrintTool(componentLink.PrintingSystemBase);
            pt.ShowPreviewDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel document|*.xls";
            save.Title = "Save an Excel File";
            save.ShowDialog();
            if (save.FileName != "")
            {
                gCKardex.ExportToXls(save.FileName);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mostrar();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void gVKardex_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["Siclo"]);
                if (category == "A")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.BackColor2 = Color.White;
                    e.HighPriority = true;
                }
            }
        }
    }
}