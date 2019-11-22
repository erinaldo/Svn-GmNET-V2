namespace Gm.NET
{
    partial class XfAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfAuditoria));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKardex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoEntraPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSalePrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEquivalencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiclo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResiduo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlete = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kardexBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1450, 540);
            this.gridControl1.TabIndex = 0;
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
            this.colIDProducto,
            this.colProductoEntra,
            this.colProductoEntraPrecio,
            this.colProductoSale,
            this.colProductoSalePrecio,
            this.colIDFactura,
            this.colFecha,
            this.colFechaSistema,
            this.colEquivalencia,
            this.colReferencia,
            this.colSiclo,
            this.colResiduo,
            this.colMovimiento,
            this.colPrecioReal,
            this.colFlete});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Equivalencia", this.colEquivalencia, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductoEntra", this.colProductoEntra, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductoSale", this.colProductoSale, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDProducto, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIDKardex
            // 
            this.colIDKardex.Caption = "ID";
            this.colIDKardex.FieldName = "IDKardex";
            this.colIDKardex.MinWidth = 25;
            this.colIDKardex.Name = "colIDKardex";
            this.colIDKardex.Visible = true;
            this.colIDKardex.VisibleIndex = 0;
            this.colIDKardex.Width = 70;
            // 
            // colIDProducto
            // 
            this.colIDProducto.Caption = "DESCRIPCION";
            this.colIDProducto.FieldName = "Producto.Nombre";
            this.colIDProducto.MinWidth = 25;
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.Visible = true;
            this.colIDProducto.VisibleIndex = 1;
            this.colIDProducto.Width = 94;
            // 
            // colProductoEntra
            // 
            this.colProductoEntra.Caption = "ENTRA";
            this.colProductoEntra.FieldName = "ProductoEntra";
            this.colProductoEntra.MinWidth = 25;
            this.colProductoEntra.Name = "colProductoEntra";
            this.colProductoEntra.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductoEntra", "SUM={0:0.##}")});
            this.colProductoEntra.Visible = true;
            this.colProductoEntra.VisibleIndex = 1;
            this.colProductoEntra.Width = 96;
            // 
            // colProductoEntraPrecio
            // 
            this.colProductoEntraPrecio.Caption = "PRECIO COMPRA";
            this.colProductoEntraPrecio.FieldName = "ProductoEntraPrecio";
            this.colProductoEntraPrecio.MinWidth = 25;
            this.colProductoEntraPrecio.Name = "colProductoEntraPrecio";
            this.colProductoEntraPrecio.Visible = true;
            this.colProductoEntraPrecio.VisibleIndex = 7;
            this.colProductoEntraPrecio.Width = 135;
            // 
            // colProductoSale
            // 
            this.colProductoSale.Caption = "SALE";
            this.colProductoSale.FieldName = "ProductoSale";
            this.colProductoSale.MinWidth = 25;
            this.colProductoSale.Name = "colProductoSale";
            this.colProductoSale.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductoSale", "SUM={0:0.##}")});
            this.colProductoSale.Visible = true;
            this.colProductoSale.VisibleIndex = 2;
            this.colProductoSale.Width = 80;
            // 
            // colProductoSalePrecio
            // 
            this.colProductoSalePrecio.Caption = "PRECIO SALE";
            this.colProductoSalePrecio.FieldName = "ProductoSalePrecio";
            this.colProductoSalePrecio.MinWidth = 25;
            this.colProductoSalePrecio.Name = "colProductoSalePrecio";
            this.colProductoSalePrecio.Visible = true;
            this.colProductoSalePrecio.VisibleIndex = 8;
            this.colProductoSalePrecio.Width = 116;
            // 
            // colIDFactura
            // 
            this.colIDFactura.Caption = "COD. FACTURA";
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Visible = true;
            this.colIDFactura.VisibleIndex = 3;
            this.colIDFactura.Width = 116;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 9;
            this.colFecha.Width = 116;
            // 
            // colFechaSistema
            // 
            this.colFechaSistema.Caption = "FECHA SISTEMA";
            this.colFechaSistema.DisplayFormat.FormatString = "d";
            this.colFechaSistema.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colFechaSistema.FieldName = "FechaSistema";
            this.colFechaSistema.MinWidth = 25;
            this.colFechaSistema.Name = "colFechaSistema";
            this.colFechaSistema.Visible = true;
            this.colFechaSistema.VisibleIndex = 10;
            this.colFechaSistema.Width = 116;
            // 
            // colEquivalencia
            // 
            this.colEquivalencia.Caption = "EQUIVALENCIA";
            this.colEquivalencia.FieldName = "Equivalencia";
            this.colEquivalencia.MinWidth = 25;
            this.colEquivalencia.Name = "colEquivalencia";
            this.colEquivalencia.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Equivalencia", "SUM={0:0.##}")});
            this.colEquivalencia.Visible = true;
            this.colEquivalencia.VisibleIndex = 4;
            this.colEquivalencia.Width = 116;
            // 
            // colReferencia
            // 
            this.colReferencia.Caption = "REFERENCIA";
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.MinWidth = 25;
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 5;
            this.colReferencia.Width = 102;
            // 
            // colSiclo
            // 
            this.colSiclo.Caption = "SICLO";
            this.colSiclo.FieldName = "Siclo";
            this.colSiclo.MinWidth = 25;
            this.colSiclo.Name = "colSiclo";
            this.colSiclo.Visible = true;
            this.colSiclo.VisibleIndex = 11;
            this.colSiclo.Width = 71;
            // 
            // colResiduo
            // 
            this.colResiduo.Caption = "RESIDUO";
            this.colResiduo.FieldName = "Residuo";
            this.colResiduo.MinWidth = 25;
            this.colResiduo.Name = "colResiduo";
            this.colResiduo.Visible = true;
            this.colResiduo.VisibleIndex = 6;
            this.colResiduo.Width = 125;
            // 
            // colMovimiento
            // 
            this.colMovimiento.Caption = "MOVIMIENTO";
            this.colMovimiento.FieldName = "Movimiento";
            this.colMovimiento.MinWidth = 25;
            this.colMovimiento.Name = "colMovimiento";
            this.colMovimiento.Visible = true;
            this.colMovimiento.VisibleIndex = 12;
            this.colMovimiento.Width = 168;
            // 
            // colPrecioReal
            // 
            this.colPrecioReal.Caption = "PRECIO REAL";
            this.colPrecioReal.FieldName = "PrecioReal";
            this.colPrecioReal.MinWidth = 25;
            this.colPrecioReal.Name = "colPrecioReal";
            this.colPrecioReal.Width = 96;
            // 
            // colFlete
            // 
            this.colFlete.Caption = "FLETE";
            this.colFlete.FieldName = "Flete";
            this.colFlete.MinWidth = 25;
            this.colFlete.Name = "colFlete";
            this.colFlete.Visible = true;
            this.colFlete.VisibleIndex = 13;
            this.colFlete.Width = 94;
            // 
            // XfAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 540);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfAuditoria";
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.XfAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource kardexBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKardex;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntraPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSale;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSalePrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSistema;
        private DevExpress.XtraGrid.Columns.GridColumn colEquivalencia;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colSiclo;
        private DevExpress.XtraGrid.Columns.GridColumn colResiduo;
        private DevExpress.XtraGrid.Columns.GridColumn colMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioReal;
        private DevExpress.XtraGrid.Columns.GridColumn colFlete;
    }
}