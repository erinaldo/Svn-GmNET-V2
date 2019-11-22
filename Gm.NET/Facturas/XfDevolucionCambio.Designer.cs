namespace Gm.NET
{
    partial class XfDevolucionCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfDevolucionCambio));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gCDevolucion = new DevExpress.XtraGrid.GridControl();
            this.gVDevolucion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFacturaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMedidaMetrica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNumeroFactura = new DevExpress.XtraEditors.TextEdit();
            this.gCProducto = new DevExpress.XtraGrid.GridControl();
            this.gVProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.gCCambio = new DevExpress.XtraGrid.GridControl();
            this.gVCambio = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaAplica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca_ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.word_Data = new System.ComponentModel.BackgroundWorker();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel3 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuitarFila = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            this.txtDevolver = new DevExpress.XtraEditors.TextEdit();
            this.txtCobrar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.colPVenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gCDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCCambio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCambio)).BeginInit();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.sidePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevolver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCobrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Numero Factura:";
            // 
            // gCDevolucion
            // 
            this.gCDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCDevolucion.Location = new System.Drawing.Point(8, 65);
            this.gCDevolucion.MainView = this.gVDevolucion;
            this.gCDevolucion.Name = "gCDevolucion";
            this.gCDevolucion.Size = new System.Drawing.Size(444, 408);
            this.gCDevolucion.TabIndex = 4;
            this.gCDevolucion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVDevolucion});
            // 
            // gVDevolucion
            // 
            this.gVDevolucion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDFacturaDetalle,
            this.colIDProducto,
            this.colCosto,
            this.colUnidades,
            this.colIDFactura,
            this.colIdMedidaMetrica,
            this.colFactura,
            this.colProducto,
            this.gridColumn1});
            this.gVDevolucion.GridControl = this.gCDevolucion;
            this.gVDevolucion.Name = "gVDevolucion";
            this.gVDevolucion.OptionsBehavior.Editable = false;
            this.gVDevolucion.OptionsView.ShowFooter = true;
            this.gVDevolucion.OptionsView.ShowGroupPanel = false;
            // 
            // colIDFacturaDetalle
            // 
            this.colIDFacturaDetalle.FieldName = "IDFacturaDetalle";
            this.colIDFacturaDetalle.MinWidth = 25;
            this.colIDFacturaDetalle.Name = "colIDFacturaDetalle";
            this.colIDFacturaDetalle.Width = 94;
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.MinWidth = 25;
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.Width = 94;
            // 
            // colCosto
            // 
            this.colCosto.Caption = "P.V.P";
            this.colCosto.DisplayFormat.FormatString = "C";
            this.colCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCosto.FieldName = "Costo";
            this.colCosto.MinWidth = 25;
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 2;
            this.colCosto.Width = 79;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "Cantidad";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 0;
            this.colUnidades.Width = 78;
            // 
            // colIDFactura
            // 
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Width = 94;
            // 
            // colIdMedidaMetrica
            // 
            this.colIdMedidaMetrica.FieldName = "IdMedidaMetrica";
            this.colIdMedidaMetrica.MinWidth = 25;
            this.colIdMedidaMetrica.Name = "colIdMedidaMetrica";
            this.colIdMedidaMetrica.Width = 94;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.MinWidth = 25;
            this.colFactura.Name = "colFactura";
            this.colFactura.Width = 94;
            // 
            // colProducto
            // 
            this.colProducto.Caption = "Descripcion";
            this.colProducto.FieldName = "Producto.Nombre";
            this.colProducto.MinWidth = 25;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 272;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ToTal";
            this.gridColumn1.DisplayFormat.FormatString = "C";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "{0:0.##}")});
            this.gridColumn1.UnboundExpression = "[Unidades] * [Costo]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 93;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(112, 26);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Properties.Appearance.Options.UseTextOptions = true;
            this.txtNumeroFactura.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtNumeroFactura.Properties.MaxLength = 20;
            this.txtNumeroFactura.Size = new System.Drawing.Size(340, 22);
            this.txtNumeroFactura.TabIndex = 3;
            this.txtNumeroFactura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumeroFactura_KeyDown);
            // 
            // gCProducto
            // 
            this.gCProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCProducto.Location = new System.Drawing.Point(10, 8);
            this.gCProducto.MainView = this.gVProducto;
            this.gCProducto.Name = "gCProducto";
            this.gCProducto.Size = new System.Drawing.Size(518, 526);
            this.gCProducto.TabIndex = 7;
            this.gCProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVProducto});
            // 
            // gVProducto
            // 
            this.gVProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colNombre,
            this.colMarca,
            this.colExistenciaActual,
            this.colPVenta1});
            this.gVProducto.GridControl = this.gCProducto;
            this.gVProducto.Name = "gVProducto";
            this.gVProducto.OptionsBehavior.Editable = false;
            this.gVProducto.OptionsFind.AlwaysVisible = true;
            this.gVProducto.OptionsView.ShowGroupPanel = false;
            this.gVProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gVProducto_KeyDown);
            this.gVProducto.DoubleClick += new System.EventHandler(this.gVProducto_DoubleClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IDProducto";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "Descripcion";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 242;
            // 
            // colMarca
            // 
            this.colMarca.Caption = "Marca";
            this.colMarca.FieldName = "Marca.NombreMarca";
            this.colMarca.MinWidth = 25;
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 2;
            this.colMarca.Width = 100;
            // 
            // colExistenciaActual
            // 
            this.colExistenciaActual.Caption = "Existencia";
            this.colExistenciaActual.FieldName = "ExistenciaActual";
            this.colExistenciaActual.MinWidth = 25;
            this.colExistenciaActual.Name = "colExistenciaActual";
            this.colExistenciaActual.Visible = true;
            this.colExistenciaActual.VisibleIndex = 0;
            this.colExistenciaActual.Width = 73;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.gCDevolucion);
            this.panelControl1.Controls.Add(this.txtNumeroFactura);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(467, 542);
            this.panelControl1.TabIndex = 12;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.btnLimpiar);
            this.sidePanel1.Controls.Add(this.btnQuitarFila);
            this.sidePanel1.Controls.Add(this.labelControl3);
            this.sidePanel1.Controls.Add(this.gCCambio);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(467, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(407, 542);
            this.sidePanel1.TabIndex = 13;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // gCCambio
            // 
            this.gCCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCCambio.Location = new System.Drawing.Point(2, 65);
            this.gCCambio.MainView = this.gVCambio;
            this.gCCambio.Name = "gCCambio";
            this.gCCambio.Size = new System.Drawing.Size(401, 408);
            this.gCCambio.TabIndex = 6;
            this.gCCambio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVCambio});
            // 
            // gVCambio
            // 
            this.gVCambio.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.colIdProducto1,
            this.colCodBarras,
            this.colDetalle,
            this.colPrecio,
            this.gridColumn4,
            this.colIva,
            this.colIvaAplica,
            this.colSubTotal,
            this.colTotal,
            this.colMedida,
            this.colMarca_});
            this.gVCambio.GridControl = this.gCCambio;
            this.gVCambio.Name = "gVCambio";
            this.gVCambio.OptionsView.ShowFooter = true;
            this.gVCambio.OptionsView.ShowGroupPanel = false;
            this.gVCambio.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gVCambio_CellValueChanged);
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IDFactura";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Width = 94;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.MinWidth = 25;
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Width = 94;
            // 
            // colCodBarras
            // 
            this.colCodBarras.FieldName = "CodBarras";
            this.colCodBarras.MinWidth = 25;
            this.colCodBarras.Name = "colCodBarras";
            this.colCodBarras.Width = 94;
            // 
            // colDetalle
            // 
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.MinWidth = 25;
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.OptionsColumn.AllowEdit = false;
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 1;
            this.colDetalle.Width = 183;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "P.V.P";
            this.colPrecio.DisplayFormat.FormatString = "C";
            this.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 25;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 4;
            this.colPrecio.Width = 38;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cantidad";
            this.gridColumn4.FieldName = "Unidades";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 54;
            // 
            // colIva
            // 
            this.colIva.FieldName = "Iva";
            this.colIva.MinWidth = 25;
            this.colIva.Name = "colIva";
            this.colIva.OptionsColumn.ReadOnly = true;
            this.colIva.Width = 94;
            // 
            // colIvaAplica
            // 
            this.colIvaAplica.FieldName = "IvaAplica";
            this.colIvaAplica.MinWidth = 25;
            this.colIvaAplica.Name = "colIvaAplica";
            this.colIvaAplica.Width = 94;
            // 
            // colSubTotal
            // 
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.MinWidth = 25;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.OptionsColumn.ReadOnly = true;
            this.colSubTotal.Width = 94;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "C";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:0.##}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 46;
            // 
            // colMedida
            // 
            this.colMedida.Caption = "Medida";
            this.colMedida.FieldName = "Medida.Name";
            this.colMedida.MinWidth = 25;
            this.colMedida.Name = "colMedida";
            this.colMedida.OptionsColumn.AllowEdit = false;
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 3;
            this.colMedida.Width = 38;
            // 
            // colMarca_
            // 
            this.colMarca_.Caption = "Marca";
            this.colMarca_.FieldName = "Marca_.NombreMarca";
            this.colMarca_.MinWidth = 25;
            this.colMarca_.Name = "colMarca_";
            this.colMarca_.OptionsColumn.AllowEdit = false;
            this.colMarca_.Visible = true;
            this.colMarca_.VisibleIndex = 2;
            this.colMarca_.Width = 41;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Location = new System.Drawing.Point(1171, 17);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 29);
            this.btnAplicar.TabIndex = 14;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(1271, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // word_Data
            // 
            this.word_Data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.word_Data_DoWork);
            this.word_Data.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.word_Data_RunWorkerCompleted);
            // 
            // sidePanel2
            // 
            this.sidePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel2.Controls.Add(this.sidePanel1);
            this.sidePanel2.Controls.Add(this.panelControl3);
            this.sidePanel2.Controls.Add(this.panelControl1);
            this.sidePanel2.Controls.Add(this.sidePanel3);
            this.sidePanel2.Location = new System.Drawing.Point(12, 16);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1408, 605);
            this.sidePanel2.TabIndex = 16;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.gCProducto);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(874, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(534, 542);
            this.panelControl3.TabIndex = 17;
            // 
            // sidePanel3
            // 
            this.sidePanel3.Controls.Add(this.labelControl6);
            this.sidePanel3.Controls.Add(this.labelControl5);
            this.sidePanel3.Controls.Add(this.txtCobrar);
            this.sidePanel3.Controls.Add(this.txtDevolver);
            this.sidePanel3.Controls.Add(this.btnSalir);
            this.sidePanel3.Controls.Add(this.btnAplicar);
            this.sidePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel3.Location = new System.Drawing.Point(0, 542);
            this.sidePanel3.Name = "sidePanel3";
            this.sidePanel3.Size = new System.Drawing.Size(1408, 63);
            this.sidePanel3.TabIndex = 0;
            this.sidePanel3.Text = "sidePanel3";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(9, 499);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 21);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "DEVOLUCION";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 499);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(71, 21);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "CAMBIO";
            // 
            // btnQuitarFila
            // 
            this.btnQuitarFila.Location = new System.Drawing.Point(18, 22);
            this.btnQuitarFila.Name = "btnQuitarFila";
            this.btnQuitarFila.Size = new System.Drawing.Size(94, 29);
            this.btnQuitarFila.TabIndex = 17;
            this.btnQuitarFila.Text = "Quitar Fila";
            this.btnQuitarFila.Click += new System.EventHandler(this.btnQuitarFila_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(118, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 29);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDevolver
            // 
            this.txtDevolver.EditValue = "0";
            this.txtDevolver.Location = new System.Drawing.Point(485, 7);
            this.txtDevolver.Name = "txtDevolver";
            this.txtDevolver.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDevolver.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDevolver.Properties.DisplayFormat.FormatString = "C";
            this.txtDevolver.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtDevolver.Properties.Mask.EditMask = "c";
            this.txtDevolver.Size = new System.Drawing.Size(125, 22);
            this.txtDevolver.TabIndex = 20;
            this.txtDevolver.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevolver_KeyPress);
            // 
            // txtCobrar
            // 
            this.txtCobrar.EditValue = "0";
            this.txtCobrar.Location = new System.Drawing.Point(485, 34);
            this.txtCobrar.Name = "txtCobrar";
            this.txtCobrar.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCobrar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCobrar.Properties.DisplayFormat.FormatString = "C";
            this.txtCobrar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.txtCobrar.Properties.Mask.EditMask = "c";
            this.txtCobrar.Size = new System.Drawing.Size(125, 22);
            this.txtCobrar.TabIndex = 21;
            this.txtCobrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevolver_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(404, 10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 16);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "DEVOLVER:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(414, 37);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 16);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "COBRAR:";
            // 
            // colPVenta1
            // 
            this.colPVenta1.Caption = "PVenta1";
            this.colPVenta1.DisplayFormat.FormatString = "C";
            this.colPVenta1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPVenta1.FieldName = "PVenta1";
            this.colPVenta1.MinWidth = 25;
            this.colPVenta1.Name = "colPVenta1";
            this.colPVenta1.Visible = true;
            this.colPVenta1.VisibleIndex = 3;
            this.colPVenta1.Width = 83;
            // 
            // XfDevolucionCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 640);
            this.Controls.Add(this.sidePanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfDevolucionCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion Cambio";
            this.Load += new System.EventHandler(this.XfDevolucionCambio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCCambio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCambio)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.sidePanel3.ResumeLayout(false);
            this.sidePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDevolver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCobrar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gCDevolucion;
        private DevExpress.XtraGrid.Views.Grid.GridView gVDevolucion;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFacturaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedidaMetrica;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtNumeroFactura;
        private DevExpress.XtraGrid.GridControl gCProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gVProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaActual;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraGrid.GridControl gCCambio;
        private DevExpress.XtraGrid.Views.Grid.GridView gVCambio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaAplica;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca_;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.ComponentModel.BackgroundWorker word_Data;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
        private DevExpress.XtraEditors.SimpleButton btnQuitarFila;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtCobrar;
        private DevExpress.XtraEditors.TextEdit txtDevolver;
        private DevExpress.XtraGrid.Columns.GridColumn colPVenta1;
    }
}