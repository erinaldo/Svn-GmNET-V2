namespace Gm.NET
{
    partial class XUCCompraDetalle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XUCCompraDetalle));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnGrabar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditar = new DevExpress.XtraBars.BarButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgregar = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAgregarProducto = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchasesAbvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalculoIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFlete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecio = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesAbvanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnGrabar,
            this.btnEditar,
            this.btnEliminar,
            this.btnAgregar,
            this.btnAgregarProducto});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGrabar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAgregar)});
            this.bar1.Text = "Tools";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Caption = "Grabar Detalle";
            this.btnGrabar.Id = 0;
            this.btnGrabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.Image")));
            this.btnGrabar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.LargeImage")));
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrabar_ItemClick);
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.Id = 1;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.LargeImage")));
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar Fila";
            this.btnEliminar.Id = 2;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Caption = "Agregar Producto";
            this.btnAgregar.Id = 3;
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.LargeImage")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgregar_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(879, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 469);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(879, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(879, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Caption = "Buscar producto";
            this.btnAgregarProducto.Id = 4;
            this.btnAgregarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.ImageOptions.Image")));
            this.btnAgregarProducto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.ImageOptions.LargeImage")));
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchasesAbvanceBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPrecio});
            this.gridControl1.Size = new System.Drawing.Size(879, 432);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.colNombre,
            this.colCantidad,
            this.colMedida,
            this.colPrecioUnitario,
            this.colIva,
            this.colPrecioTotal,
            this.colCalculoIva,
            this.colIdMedida,
            this.colMarca,
            this.colCodBarras,
            this.colFlete});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.MinWidth = 25;
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.OptionsColumn.AllowEdit = false;
            this.colIDProducto.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 277;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 0;
            this.colCantidad.Width = 73;
            // 
            // colMedida
            // 
            this.colMedida.FieldName = "Medida";
            this.colMedida.MinWidth = 25;
            this.colMedida.Name = "colMedida";
            this.colMedida.OptionsColumn.AllowEdit = false;
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 2;
            this.colMedida.Width = 81;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.ColumnEdit = this.txtPrecio;
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.MinWidth = 25;
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.OptionsColumn.AllowEdit = false;
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 4;
            this.colPrecioUnitario.Width = 101;
            // 
            // colIva
            // 
            this.colIva.FieldName = "Iva";
            this.colIva.MinWidth = 25;
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.AllowEdit = false;
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 7;
            this.colIva.Width = 51;
            // 
            // colPrecioTotal
            // 
            this.colPrecioTotal.Caption = "Precio Total";
            this.colPrecioTotal.FieldName = "PrecioTotal";
            this.colPrecioTotal.MinWidth = 25;
            this.colPrecioTotal.Name = "colPrecioTotal";
            this.colPrecioTotal.OptionsColumn.AllowEdit = false;
            this.colPrecioTotal.OptionsColumn.ReadOnly = true;
            this.colPrecioTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "T={0:0.##}")});
            this.colPrecioTotal.Visible = true;
            this.colPrecioTotal.VisibleIndex = 6;
            this.colPrecioTotal.Width = 106;
            // 
            // colCalculoIva
            // 
            this.colCalculoIva.FieldName = "CalculoIva";
            this.colCalculoIva.MinWidth = 25;
            this.colCalculoIva.Name = "colCalculoIva";
            this.colCalculoIva.OptionsColumn.AllowEdit = false;
            this.colCalculoIva.OptionsColumn.ReadOnly = true;
            this.colCalculoIva.Width = 94;
            // 
            // colIdMedida
            // 
            this.colIdMedida.FieldName = "IdMedida";
            this.colIdMedida.MinWidth = 25;
            this.colIdMedida.Name = "colIdMedida";
            this.colIdMedida.Width = 94;
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.MinWidth = 25;
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            this.colMarca.Width = 88;
            // 
            // colCodBarras
            // 
            this.colCodBarras.FieldName = "CodBarras";
            this.colCodBarras.MinWidth = 25;
            this.colCodBarras.Name = "colCodBarras";
            this.colCodBarras.Width = 94;
            // 
            // colFlete
            // 
            this.colFlete.Caption = "Flete";
            this.colFlete.FieldName = "Flete";
            this.colFlete.MinWidth = 25;
            this.colFlete.Name = "colFlete";
            this.colFlete.OptionsColumn.AllowEdit = false;
            this.colFlete.Visible = true;
            this.colFlete.VisibleIndex = 5;
            this.colFlete.Width = 82;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoHeight = false;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // XUCCompraDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XUCCompraDetalle";
            this.Size = new System.Drawing.Size(879, 469);
            this.Load += new System.EventHandler(this.XUCCompraDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesAbvanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnGrabar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnEliminar;
        private DevExpress.XtraBars.BarButtonItem btnAgregar;
        private DevExpress.XtraBars.BarButtonItem btnAgregarProducto;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource purchasesAbvanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCalculoIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colFlete;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecio;
    }
}
