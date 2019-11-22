namespace Gm.NET
{
    partial class XfProductBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfProductBodega));
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPVenta3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecio1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.txtPrecio2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gVProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaUltimaCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedidaMetrica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chEnviar = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gCProductos = new DevExpress.XtraGrid.GridControl();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStateMedida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trasladosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasladosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colNombre
            // 
            this.colNombre.Caption = "DESCRIPCION";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 563;
            // 
            // colPVenta1
            // 
            this.colPVenta1.Caption = "PRECIO VENTA 1";
            this.colPVenta1.DisplayFormat.FormatString = "C";
            this.colPVenta1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPVenta1.FieldName = "PVenta1";
            this.colPVenta1.MinWidth = 25;
            this.colPVenta1.Name = "colPVenta1";
            this.colPVenta1.OptionsColumn.AllowEdit = false;
            this.colPVenta1.Width = 126;
            // 
            // colPVenta2
            // 
            this.colPVenta2.Caption = "PRECIO VENTA 2";
            this.colPVenta2.DisplayFormat.FormatString = "C";
            this.colPVenta2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPVenta2.FieldName = "PVenta2";
            this.colPVenta2.MinWidth = 25;
            this.colPVenta2.Name = "colPVenta2";
            this.colPVenta2.OptionsColumn.AllowEdit = false;
            this.colPVenta2.Width = 126;
            // 
            // colPVenta3
            // 
            this.colPVenta3.Caption = "PRECIO VENTA 3";
            this.colPVenta3.DisplayFormat.FormatString = "C";
            this.colPVenta3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPVenta3.FieldName = "PVenta3";
            this.colPVenta3.MinWidth = 25;
            this.colPVenta3.Name = "colPVenta3";
            this.colPVenta3.OptionsColumn.AllowEdit = false;
            this.colPVenta3.Width = 129;
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.AutoHeight = false;
            this.txtPrecio1.Name = "txtPrecio1";
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.AutoHeight = false;
            this.txtPrecio2.Name = "txtPrecio2";
            // 
            // gVProductos
            // 
            this.gVProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.colNombre,
            this.colPVenta1,
            this.colPVenta2,
            this.colPVenta3,
            this.colEnBodega,
            this.colFechaUltimaCompra,
            this.colGrupo,
            this.colMarca,
            this.colMedidaMetrica,
            this.colIva});
            this.gVProductos.GridControl = this.gCProductos;
            this.gVProductos.Name = "gVProductos";
            this.gVProductos.OptionsBehavior.AutoExpandAllGroups = true;
            this.gVProductos.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text;
            this.gVProductos.OptionsFind.AlwaysVisible = true;
            this.gVProductos.OptionsView.ColumnAutoWidth = false;
            this.gVProductos.OptionsView.ShowAutoFilterRow = true;
            this.gVProductos.OptionsView.ShowGroupPanel = false;
            this.gVProductos.ViewCaption = "PRODUCTOS";
            this.gVProductos.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gVProductos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gVProductos_MouseUp_1);
            // 
            // colIDProducto
            // 
            this.colIDProducto.Caption = "CODIGO";
            this.colIDProducto.DisplayFormat.FormatString = "COD{0}";
            this.colIDProducto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIDProducto.MinWidth = 25;
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.OptionsColumn.AllowEdit = false;
            this.colIDProducto.Visible = true;
            this.colIDProducto.VisibleIndex = 0;
            this.colIDProducto.Width = 94;
            // 
            // colEnBodega
            // 
            this.colEnBodega.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colEnBodega.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colEnBodega.AppearanceCell.Options.UseFont = true;
            this.colEnBodega.AppearanceCell.Options.UseForeColor = true;
            this.colEnBodega.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colEnBodega.AppearanceHeader.Options.UseForeColor = true;
            this.colEnBodega.Caption = "EXISTENCIA";
            this.colEnBodega.FieldName = "EnBodega";
            this.colEnBodega.MinWidth = 25;
            this.colEnBodega.Name = "colEnBodega";
            this.colEnBodega.OptionsColumn.AllowEdit = false;
            this.colEnBodega.Visible = true;
            this.colEnBodega.VisibleIndex = 5;
            this.colEnBodega.Width = 94;
            // 
            // colFechaUltimaCompra
            // 
            this.colFechaUltimaCompra.Caption = "ULTIMA COMPRA";
            this.colFechaUltimaCompra.FieldName = "FechaUltimaCompra";
            this.colFechaUltimaCompra.MinWidth = 25;
            this.colFechaUltimaCompra.Name = "colFechaUltimaCompra";
            this.colFechaUltimaCompra.OptionsColumn.AllowEdit = false;
            this.colFechaUltimaCompra.Visible = true;
            this.colFechaUltimaCompra.VisibleIndex = 6;
            this.colFechaUltimaCompra.Width = 119;
            // 
            // colGrupo
            // 
            this.colGrupo.Caption = "CATEGORIA";
            this.colGrupo.FieldName = "Grupo.Nombre";
            this.colGrupo.MinWidth = 25;
            this.colGrupo.Name = "colGrupo";
            this.colGrupo.OptionsColumn.AllowEdit = false;
            this.colGrupo.Visible = true;
            this.colGrupo.VisibleIndex = 1;
            this.colGrupo.Width = 107;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "MARCA";
            this.colMarca.FieldName = "Marca.NombreMarca";
            this.colMarca.MinWidth = 25;
            this.colMarca.Name = "colMarca";
            this.colMarca.OptionsColumn.AllowEdit = false;
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 3;
            this.colMarca.Width = 128;
            // 
            // colMedidaMetrica
            // 
            this.colMedidaMetrica.Caption = "MEDIDA";
            this.colMedidaMetrica.FieldName = "MedidaMetrica.Name";
            this.colMedidaMetrica.MinWidth = 25;
            this.colMedidaMetrica.Name = "colMedidaMetrica";
            this.colMedidaMetrica.OptionsColumn.AllowEdit = false;
            this.colMedidaMetrica.Visible = true;
            this.colMedidaMetrica.VisibleIndex = 4;
            this.colMedidaMetrica.Width = 94;
            // 
            // colIva
            // 
            this.colIva.Caption = "TRASLADAR";
            this.colIva.ColumnEdit = this.chEnviar;
            this.colIva.FieldName = "Iva";
            this.colIva.MinWidth = 25;
            this.colIva.Name = "colIva";
            this.colIva.Width = 94;
            // 
            // chEnviar
            // 
            this.chEnviar.AutoHeight = false;
            this.chEnviar.Name = "chEnviar";
            this.chEnviar.CheckedChanged += new System.EventHandler(this.chEnviar_CheckedChanged);
            // 
            // gCProductos
            // 
            this.gCProductos.DataSource = this.productoBindingSource;
            this.gCProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCProductos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCProductos.Location = new System.Drawing.Point(0, 0);
            this.gCProductos.MainView = this.gVProductos;
            this.gCProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCProductos.Name = "gCProductos";
            this.gCProductos.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPrecio1,
            this.txtPrecio2,
            this.chEnviar});
            this.gCProductos.Size = new System.Drawing.Size(1251, 625);
            this.gCProductos.TabIndex = 4;
            this.gCProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVProductos});
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Gm.Entities.Producto);
            // 
            // colStateMedida2
            // 
            this.colStateMedida2.Caption = "ACTIVADO 2";
            this.colStateMedida2.FieldName = "StateMedida2";
            this.colStateMedida2.MinWidth = 25;
            this.colStateMedida2.Name = "colStateMedida2";
            this.colStateMedida2.OptionsColumn.AllowEdit = false;
            this.colStateMedida2.Visible = true;
            this.colStateMedida2.VisibleIndex = 10;
            this.colStateMedida2.Width = 76;
            // 
            // trasladosBindingSource
            // 
            this.trasladosBindingSource.DataSource = typeof(Gm.Entities.Traslados);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Traslado a Almacen";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1251, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 625);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1251, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1251, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 625);
            // 
            // XfProductBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 625);
            this.Controls.Add(this.gCProductos);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XfProductBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos en Bodega";
            this.Load += new System.EventHandler(this.XtraFormProductoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasladosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gCProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gVProductos;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecio1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecio2;
        private DevExpress.XtraGrid.Columns.GridColumn colStateMedida2;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPVenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colPVenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colPVenta3;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaUltimaCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colMedidaMetrica;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colEnBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chEnviar;
        private System.Windows.Forms.BindingSource trasladosBindingSource;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}