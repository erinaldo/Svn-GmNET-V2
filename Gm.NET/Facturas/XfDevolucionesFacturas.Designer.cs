namespace Gm.NET
{
    partial class XfDevolucionesFacturas
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfDevolucionesFacturas));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFacturaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnDevolucion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.fieldFechaSistema1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldEnDevolucion1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductoNombre = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.calendarControlDesde = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.calendarControlHasta = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrilla = new DevExpress.XtraEditors.SimpleButton();
            this.btnChart = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControlDesde.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControlHasta.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.facturaDetalleBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 93);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(708, 510);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // facturaDetalleBindingSource
            // 
            this.facturaDetalleBindingSource.DataSource = typeof(Gm.Entities.FacturaDetalle);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDFacturaDetalle,
            this.colCosto,
            this.colUnidades,
            this.colEnDevolucion,
            this.colProducto,
            this.colFechaSistema,
            this.colTotal,
            this.colIDFactura});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", this.colTotal, "(Total: SUM={0:0.##})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colIDFacturaDetalle
            // 
            this.colIDFacturaDetalle.FieldName = "IDFacturaDetalle";
            this.colIDFacturaDetalle.MinWidth = 25;
            this.colIDFacturaDetalle.Name = "colIDFacturaDetalle";
            this.colIDFacturaDetalle.Width = 94;
            // 
            // colCosto
            // 
            this.colCosto.FieldName = "Costo";
            this.colCosto.MinWidth = 25;
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 4;
            this.colCosto.Width = 92;
            // 
            // colUnidades
            // 
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Width = 94;
            // 
            // colEnDevolucion
            // 
            this.colEnDevolucion.Caption = "Devuelto";
            this.colEnDevolucion.FieldName = "EnDevolucion";
            this.colEnDevolucion.MinWidth = 25;
            this.colEnDevolucion.Name = "colEnDevolucion";
            this.colEnDevolucion.Visible = true;
            this.colEnDevolucion.VisibleIndex = 3;
            this.colEnDevolucion.Width = 72;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto.Nombre";
            this.colProducto.MinWidth = 25;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 2;
            this.colProducto.Width = 363;
            // 
            // colFechaSistema
            // 
            this.colFechaSistema.Caption = "Fecha";
            this.colFechaSistema.FieldName = "FechaSistema";
            this.colFechaSistema.MinWidth = 25;
            this.colFechaSistema.Name = "colFechaSistema";
            this.colFechaSistema.Visible = true;
            this.colFechaSistema.VisibleIndex = 0;
            this.colFechaSistema.Width = 111;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // chartControl1
            // 
            this.chartControl1.DataSource = this.facturaDetalleBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(86, 151);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "Producto.Nombre";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "FechaSistema";
            this.chartControl1.SeriesTemplate.SeriesDataMember = "Producto.Nombre";
            this.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Unidades";
            this.chartControl1.Size = new System.Drawing.Size(751, 471);
            this.chartControl1.TabIndex = 1;
            // 
            // fieldFechaSistema1
            // 
            this.fieldFechaSistema1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldFechaSistema1.AreaIndex = 0;
            this.fieldFechaSistema1.Caption = "Fecha Sistema";
            this.fieldFechaSistema1.FieldName = "FechaSistema";
            this.fieldFechaSistema1.Name = "fieldFechaSistema1";
            this.fieldFechaSistema1.Width = 150;
            // 
            // fieldEnDevolucion1
            // 
            this.fieldEnDevolucion1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldEnDevolucion1.AreaIndex = 0;
            this.fieldEnDevolucion1.Caption = "En Devolucion";
            this.fieldEnDevolucion1.FieldName = "EnDevolucion";
            this.fieldEnDevolucion1.Name = "fieldEnDevolucion1";
            this.fieldEnDevolucion1.Width = 136;
            // 
            // fieldProductoNombre
            // 
            this.fieldProductoNombre.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductoNombre.AreaIndex = 1;
            this.fieldProductoNombre.Caption = "Producto";
            this.fieldProductoNombre.FieldName = "Producto.Nombre";
            this.fieldProductoNombre.Name = "fieldProductoNombre";
            this.fieldProductoNombre.Width = 350;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:0.##}")});
            this.colTotal.UnboundExpression = "[Costo] * [Unidades]";
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 94;
            // 
            // colIDFactura
            // 
            this.colIDFactura.Caption = "Factura";
            this.colIDFactura.FieldName = "Factura.Numero";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Visible = true;
            this.colIDFactura.VisibleIndex = 1;
            this.colIDFactura.Width = 94;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(380, 650);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.calendarControlHasta);
            this.xtraTabPage1.Controls.Add(this.calendarControlDesde);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(378, 620);
            this.xtraTabPage1.Text = "Parametros";
            // 
            // calendarControlDesde
            // 
            this.calendarControlDesde.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControlDesde.Location = new System.Drawing.Point(15, 32);
            this.calendarControlDesde.Name = "calendarControlDesde";
            this.calendarControlDesde.Size = new System.Drawing.Size(340, 270);
            this.calendarControlDesde.TabIndex = 0;
            // 
            // calendarControlHasta
            // 
            this.calendarControlHasta.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControlHasta.Location = new System.Drawing.Point(15, 330);
            this.calendarControlHasta.Name = "calendarControlHasta";
            this.calendarControlHasta.Size = new System.Drawing.Size(340, 270);
            this.calendarControlHasta.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(951, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(393, 650);
            this.panelControl1.TabIndex = 4;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Location = new System.Drawing.Point(1114, 16);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 29);
            this.btnAplicar.TabIndex = 0;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(1214, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGrilla
            // 
            this.btnGrilla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnGrilla.Location = new System.Drawing.Point(14, 10);
            this.btnGrilla.Name = "btnGrilla";
            this.btnGrilla.Size = new System.Drawing.Size(94, 29);
            this.btnGrilla.TabIndex = 0;
            this.btnGrilla.Text = "Cuantitativo";
            this.btnGrilla.Click += new System.EventHandler(this.btnGrilla_Click);
            // 
            // btnChart
            // 
            this.btnChart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnChart.Location = new System.Drawing.Point(116, 10);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(94, 29);
            this.btnChart.TabIndex = 1;
            this.btnChart.Text = "Grafico";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.btnAplicar);
            this.panelControl2.Controls.Add(this.btnSalir);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 699);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1344, 57);
            this.panelControl2.TabIndex = 6;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.btnGrilla);
            this.panelControl3.Controls.Add(this.btnChart);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1344, 49);
            this.panelControl3.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Desde";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 306);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Hasta";
            // 
            // XfDevolucionesFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 756);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfDevolucionesFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones Facturas";
            this.Load += new System.EventHandler(this.XfDevolucionesFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControlDesde.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControlHasta.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource facturaDetalleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFacturaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colEnDevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSistema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFechaSistema1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldEnDevolucion1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductoNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControlHasta;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControlDesde;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChart;
        private DevExpress.XtraEditors.SimpleButton btnGrilla;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}