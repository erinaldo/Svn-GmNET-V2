namespace Gm.NET
{
    partial class XtProductoInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtProductoInventario));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKardex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoEntraPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSalePrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiclo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Archivo";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Editar";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Imprimir";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Actualizar";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Salir";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1421, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 609);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1421, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 580);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1421, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 580);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kardexBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1421, 580);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kardexBindingSource
            // 
            this.kardexBindingSource.DataSource = typeof(Gm.Entities.Kardex);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKardex,
            this.colProductoEntra,
            this.colProductoEntraPrecio,
            this.colProductoSale,
            this.colProductoSalePrecio,
            this.colIDFactura,
            this.colFecha,
            this.colPrecioReal,
            this.colProducto,
            this.colMovimiento,
            this.colSiclo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colIDKardex
            // 
            this.colIDKardex.DisplayFormat.FormatString = "COD{0}";
            this.colIDKardex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIDKardex.FieldName = "IDKardex";
            this.colIDKardex.MinWidth = 25;
            this.colIDKardex.Name = "colIDKardex";
            this.colIDKardex.Width = 80;
            // 
            // colProductoEntra
            // 
            this.colProductoEntra.Caption = "CANTIDAD";
            this.colProductoEntra.FieldName = "ProductoEntra";
            this.colProductoEntra.MinWidth = 25;
            this.colProductoEntra.Name = "colProductoEntra";
            this.colProductoEntra.Visible = true;
            this.colProductoEntra.VisibleIndex = 2;
            this.colProductoEntra.Width = 169;
            // 
            // colProductoEntraPrecio
            // 
            this.colProductoEntraPrecio.Caption = "PRECIO COMPRA";
            this.colProductoEntraPrecio.DisplayFormat.FormatString = "c";
            this.colProductoEntraPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colProductoEntraPrecio.FieldName = "ProductoEntraPrecio";
            this.colProductoEntraPrecio.MinWidth = 25;
            this.colProductoEntraPrecio.Name = "colProductoEntraPrecio";
            this.colProductoEntraPrecio.Visible = true;
            this.colProductoEntraPrecio.VisibleIndex = 3;
            this.colProductoEntraPrecio.Width = 169;
            // 
            // colProductoSale
            // 
            this.colProductoSale.FieldName = "ProductoSale";
            this.colProductoSale.MinWidth = 25;
            this.colProductoSale.Name = "colProductoSale";
            this.colProductoSale.Width = 151;
            // 
            // colProductoSalePrecio
            // 
            this.colProductoSalePrecio.FieldName = "ProductoSalePrecio";
            this.colProductoSalePrecio.MinWidth = 25;
            this.colProductoSalePrecio.Name = "colProductoSalePrecio";
            this.colProductoSalePrecio.Width = 151;
            // 
            // colIDFactura
            // 
            this.colIDFactura.Caption = "CODIGO";
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Visible = true;
            this.colIDFactura.VisibleIndex = 0;
            this.colIDFactura.Width = 95;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA DE INGRESO";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 4;
            this.colFecha.Width = 181;
            // 
            // colPrecioReal
            // 
            this.colPrecioReal.FieldName = "PrecioReal";
            this.colPrecioReal.MinWidth = 25;
            this.colPrecioReal.Name = "colPrecioReal";
            this.colPrecioReal.Width = 198;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "DESCRIPCION";
            this.colProducto.FieldName = "Producto.Nombre";
            this.colProducto.MinWidth = 25;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 506;
            // 
            // colMovimiento
            // 
            this.colMovimiento.FieldName = "Movimiento";
            this.colMovimiento.MinWidth = 25;
            this.colMovimiento.Name = "colMovimiento";
            this.colMovimiento.Width = 94;
            // 
            // colSiclo
            // 
            this.colSiclo.Caption = "SICLO";
            this.colSiclo.FieldName = "Siclo";
            this.colSiclo.MinWidth = 25;
            this.colSiclo.Name = "colSiclo";
            this.colSiclo.Visible = true;
            this.colSiclo.VisibleIndex = 5;
            this.colSiclo.Width = 94;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Eliminar";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // XtProductoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 633);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtProductoInventario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario Inicial";
            this.Load += new System.EventHandler(this.XtraFormProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kardexBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKardex;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntraPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSale;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSalePrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioReal;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colSiclo;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}