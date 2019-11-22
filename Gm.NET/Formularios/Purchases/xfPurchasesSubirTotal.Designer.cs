namespace Gm.NET
{
    partial class xfPurchasesSubirTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfPurchasesSubirTotal));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseSubirTodosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioPorMayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecioVenta = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNivel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSubirTodosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.purchaseSubirTodosBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPrecioVenta});
            this.gridControl1.Size = new System.Drawing.Size(1033, 557);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // purchaseSubirTodosBindingSource
            // 
            this.purchaseSubirTodosBindingSource.DataSource = typeof(Gm.Core.PurchaseSubirTodos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFecha,
            this.colFactura,
            this.colIdProducto,
            this.colName,
            this.colCantidad,
            this.colPrecioReal,
            this.colEn,
            this.colPrecioPorMayor,
            this.colNivel});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "FACTURAS";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 128;
            // 
            // colFactura
            // 
            this.colFactura.Caption = "FACTURA";
            this.colFactura.FieldName = "Factura";
            this.colFactura.MinWidth = 25;
            this.colFactura.Name = "colFactura";
            this.colFactura.OptionsColumn.AllowEdit = false;
            this.colFactura.Visible = true;
            this.colFactura.VisibleIndex = 1;
            this.colFactura.Width = 115;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 94;
            // 
            // colName
            // 
            this.colName.Caption = "DETALLE";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 433;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 94;
            // 
            // colPrecioReal
            // 
            this.colPrecioReal.Caption = "PRECIO REAL";
            this.colPrecioReal.FieldName = "PrecioReal";
            this.colPrecioReal.MinWidth = 25;
            this.colPrecioReal.Name = "colPrecioReal";
            this.colPrecioReal.OptionsColumn.AllowEdit = false;
            this.colPrecioReal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrecioReal", "T={0:0.##}")});
            this.colPrecioReal.Visible = true;
            this.colPrecioReal.VisibleIndex = 4;
            this.colPrecioReal.Width = 123;
            // 
            // colEn
            // 
            this.colEn.Caption = "EN";
            this.colEn.FieldName = "En";
            this.colEn.MinWidth = 25;
            this.colEn.Name = "colEn";
            this.colEn.OptionsColumn.AllowEdit = false;
            this.colEn.Visible = true;
            this.colEn.VisibleIndex = 3;
            this.colEn.Width = 97;
            // 
            // colPrecioPorMayor
            // 
            this.colPrecioPorMayor.Caption = "PRECIO VENTA";
            this.colPrecioPorMayor.ColumnEdit = this.txtPrecioVenta;
            this.colPrecioPorMayor.FieldName = "PrecioPorMayor";
            this.colPrecioPorMayor.MinWidth = 25;
            this.colPrecioPorMayor.Name = "colPrecioPorMayor";
            this.colPrecioPorMayor.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colPrecioPorMayor.Visible = true;
            this.colPrecioPorMayor.VisibleIndex = 5;
            this.colPrecioPorMayor.Width = 123;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AutoHeight = false;
            this.txtPrecioVenta.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            // 
            // colNivel
            // 
            this.colNivel.FieldName = "Nivel";
            this.colNivel.MinWidth = 25;
            this.colNivel.Name = "colNivel";
            this.colNivel.Width = 94;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.ImageOptions.Image")));
            this.btnConfirmar.Location = new System.Drawing.Point(851, 589);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(951, 589);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // xfPurchasesSubirTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 630);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfPurchasesSubirTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchases Subir Todos";
            this.Load += new System.EventHandler(this.xfPurchasesSubirTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSubirTodosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource purchaseSubirTodosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioReal;
        private DevExpress.XtraGrid.Columns.GridColumn colEn;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioPorMayor;
        private DevExpress.XtraGrid.Columns.GridColumn colNivel;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecioVenta;
    }
}