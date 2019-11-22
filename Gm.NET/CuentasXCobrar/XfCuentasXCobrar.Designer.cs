namespace Gm.NET.Formularios
{
    partial class XfCuentasXCobrar
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfCuentasXCobrar));
            this.colSaldoActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gCCuentasCobrar = new DevExpress.XtraGrid.GridControl();
            this.creditoBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gVCuentasCobrar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaVence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.btnEditarAbono = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarAbono = new DevExpress.XtraEditors.SimpleButton();
            this.gCCuentasCobrarHistorial = new DevExpress.XtraGrid.GridControl();
            this.gVCuentasCobrarHistorial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.gCDetalle = new DevExpress.XtraGrid.GridControl();
            this.gVDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFacturaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraSaveFileDialog1 = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gCCuentasCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditoBLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCuentasCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCCuentasCobrarHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCuentasCobrarHistorial)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // colSaldoActual
            // 
            this.colSaldoActual.Caption = "SALDO ACTUAL";
            this.colSaldoActual.DisplayFormat.FormatString = "c";
            this.colSaldoActual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSaldoActual.FieldName = "SaldoActual";
            this.colSaldoActual.Name = "colSaldoActual";
            this.colSaldoActual.OptionsColumn.AllowEdit = false;
            this.colSaldoActual.Visible = true;
            this.colSaldoActual.VisibleIndex = 6;
            this.colSaldoActual.Width = 114;
            // 
            // colSaldo
            // 
            this.colSaldo.Caption = "SALDO INICIAL";
            this.colSaldo.DisplayFormat.FormatString = "c";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.OptionsColumn.ReadOnly = true;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 5;
            this.colSaldo.Width = 104;
            // 
            // gCCuentasCobrar
            // 
            this.gCCuentasCobrar.DataSource = this.creditoBLLBindingSource;
            this.gCCuentasCobrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCCuentasCobrar.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCCuentasCobrar.Location = new System.Drawing.Point(0, 0);
            this.gCCuentasCobrar.MainView = this.gVCuentasCobrar;
            this.gCCuentasCobrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCCuentasCobrar.Name = "gCCuentasCobrar";
            this.gCCuentasCobrar.Size = new System.Drawing.Size(885, 644);
            this.gCCuentasCobrar.TabIndex = 1;
            this.gCCuentasCobrar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVCuentasCobrar});
            // 
            // creditoBLLBindingSource
            // 
            this.creditoBLLBindingSource.DataSource = typeof(Gm.Core.CreditoBLL);
            // 
            // gVCuentasCobrar
            // 
            this.gVCuentasCobrar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colIDCredito,
            this.colIDUsuario,
            this.colIDFactura,
            this.colNumFactura,
            this.colEstado,
            this.colNombre,
            this.colCedula,
            this.colFechaVence,
            this.colTelefono,
            this.colSaldo,
            this.colAbona,
            this.colSaldoActual,
            this.colState,
            this.colFecha});
            gridFormatRule1.Column = this.colSaldoActual;
            gridFormatRule1.ColumnApplyTo = this.colSaldoActual;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleExpression1.Expression = "[State] = True";
            formatConditionRuleExpression1.PredefinedName = "Green Bold Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Column = this.colSaldo;
            gridFormatRule2.ColumnApplyTo = this.colSaldo;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleExpression2.Expression = "[State] = True";
            formatConditionRuleExpression2.PredefinedName = "Red Bold Text";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gVCuentasCobrar.FormatRules.Add(gridFormatRule1);
            this.gVCuentasCobrar.FormatRules.Add(gridFormatRule2);
            this.gVCuentasCobrar.GridControl = this.gCCuentasCobrar;
            this.gVCuentasCobrar.Name = "gVCuentasCobrar";
            this.gVCuentasCobrar.OptionsView.ShowAutoFilterRow = true;
            this.gVCuentasCobrar.OptionsView.ShowViewCaption = true;
            this.gVCuentasCobrar.ViewCaption = "CUENTAS POR COBRAR";
            this.gVCuentasCobrar.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gVCuentasCobrar_RowStyle);
            this.gVCuentasCobrar.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIdCliente
            // 
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            // 
            // colIDCredito
            // 
            this.colIDCredito.FieldName = "IDCredito";
            this.colIDCredito.Name = "colIDCredito";
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.FieldName = "IDUsuario";
            this.colIDUsuario.Name = "colIDUsuario";
            // 
            // colIDFactura
            // 
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.Name = "colIDFactura";
            // 
            // colNumFactura
            // 
            this.colNumFactura.Caption = "FACTURA";
            this.colNumFactura.FieldName = "NumFactura";
            this.colNumFactura.Name = "colNumFactura";
            this.colNumFactura.OptionsColumn.AllowEdit = false;
            this.colNumFactura.Visible = true;
            this.colNumFactura.VisibleIndex = 0;
            this.colNumFactura.Width = 107;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "CLIENTE";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 397;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "CEDULA";
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.OptionsColumn.AllowEdit = false;
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 2;
            this.colCedula.Width = 137;
            // 
            // colFechaVence
            // 
            this.colFechaVence.Caption = "VENCE";
            this.colFechaVence.FieldName = "FechaVence";
            this.colFechaVence.MinWidth = 25;
            this.colFechaVence.Name = "colFechaVence";
            this.colFechaVence.Visible = true;
            this.colFechaVence.VisibleIndex = 9;
            this.colFechaVence.Width = 94;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "TELEFONO";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.OptionsColumn.AllowEdit = false;
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 3;
            this.colTelefono.Width = 98;
            // 
            // colAbona
            // 
            this.colAbona.Caption = "ABONO";
            this.colAbona.DisplayFormat.FormatString = "c";
            this.colAbona.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAbona.FieldName = "Abona";
            this.colAbona.Name = "colAbona";
            this.colAbona.OptionsColumn.AllowEdit = false;
            this.colAbona.Visible = true;
            this.colAbona.VisibleIndex = 4;
            this.colAbona.Width = 83;
            // 
            // colState
            // 
            this.colState.Caption = "ESTADO";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.OptionsColumn.AllowEdit = false;
            this.colState.Visible = true;
            this.colState.VisibleIndex = 7;
            this.colState.Width = 77;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 8;
            this.colFecha.Width = 156;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("972ef58f-5330-48a1-af77-b056d4a6646a");
            this.dockPanel1.Location = new System.Drawing.Point(1389, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(318, 200);
            this.dockPanel1.SavedSizeFactor = 0D;
            this.dockPanel1.Size = new System.Drawing.Size(318, 644);
            this.dockPanel1.Text = "Lista de Pagos";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.btnEditarAbono);
            this.dockPanel1_Container.Controls.Add(this.btnEliminarAbono);
            this.dockPanel1_Container.Controls.Add(this.gCCuentasCobrarHistorial);
            this.dockPanel1_Container.Location = new System.Drawing.Point(7, 45);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(306, 594);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // btnEditarAbono
            // 
            this.btnEditarAbono.Location = new System.Drawing.Point(103, 8);
            this.btnEditarAbono.Name = "btnEditarAbono";
            this.btnEditarAbono.Size = new System.Drawing.Size(94, 29);
            this.btnEditarAbono.TabIndex = 5;
            this.btnEditarAbono.Text = "Editar Abono";
            this.btnEditarAbono.Click += new System.EventHandler(this.btnEditarAbono_Click);
            // 
            // btnEliminarAbono
            // 
            this.btnEliminarAbono.Location = new System.Drawing.Point(3, 8);
            this.btnEliminarAbono.Name = "btnEliminarAbono";
            this.btnEliminarAbono.Size = new System.Drawing.Size(94, 29);
            this.btnEliminarAbono.TabIndex = 4;
            this.btnEliminarAbono.Text = "Eliminar Abono";
            this.btnEliminarAbono.Click += new System.EventHandler(this.btnEliminarAbono_Click);
            // 
            // gCCuentasCobrarHistorial
            // 
            this.gCCuentasCobrarHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCCuentasCobrarHistorial.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCCuentasCobrarHistorial.Location = new System.Drawing.Point(3, 43);
            this.gCCuentasCobrarHistorial.MainView = this.gVCuentasCobrarHistorial;
            this.gCCuentasCobrarHistorial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCCuentasCobrarHistorial.Name = "gCCuentasCobrarHistorial";
            this.gCCuentasCobrarHistorial.Size = new System.Drawing.Size(300, 543);
            this.gCCuentasCobrarHistorial.TabIndex = 3;
            this.gCCuentasCobrarHistorial.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVCuentasCobrarHistorial});
            // 
            // gVCuentasCobrarHistorial
            // 
            this.gVCuentasCobrarHistorial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colIDFactura1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.colFactura1,
            this.colUsuarios});
            this.gVCuentasCobrarHistorial.GridControl = this.gCCuentasCobrarHistorial;
            this.gVCuentasCobrarHistorial.Name = "gVCuentasCobrarHistorial";
            this.gVCuentasCobrarHistorial.OptionsView.ShowFooter = true;
            this.gVCuentasCobrarHistorial.OptionsView.ShowGroupPanel = false;
            this.gVCuentasCobrarHistorial.ViewCaption = "HISTORIAL ABONOS";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IDCredito";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colIDFactura1
            // 
            this.colIDFactura1.FieldName = "IDFactura";
            this.colIDFactura1.Name = "colIDFactura1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IDUsuario";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "FECHA";
            this.gridColumn3.FieldName = "Fecha";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 130;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ABONA";
            this.gridColumn4.DisplayFormat.FormatString = "c";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn4.FieldName = "Abona";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abona", "{0:#.##}")});
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 74;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "State";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // colFactura1
            // 
            this.colFactura1.FieldName = "Factura";
            this.colFactura1.Name = "colFactura1";
            // 
            // colUsuarios
            // 
            this.colUsuarios.FieldName = "Usuarios";
            this.colUsuarios.Name = "colUsuarios";
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel2.ID = new System.Guid("0838d2e2-4dc0-48e7-ad58-4daf7238b43b");
            this.dockPanel2.Location = new System.Drawing.Point(885, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(504, 200);
            this.dockPanel2.SavedSizeFactor = 0D;
            this.dockPanel2.Size = new System.Drawing.Size(504, 644);
            this.dockPanel2.Text = "Detalle";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.gCDetalle);
            this.dockPanel2_Container.Location = new System.Drawing.Point(7, 45);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(492, 594);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // gCDetalle
            // 
            this.gCDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gCDetalle.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCDetalle.Location = new System.Drawing.Point(7, 0);
            this.gCDetalle.MainView = this.gVDetalle;
            this.gCDetalle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCDetalle.Name = "gCDetalle";
            this.gCDetalle.Size = new System.Drawing.Size(480, 586);
            this.gCDetalle.TabIndex = 4;
            this.gCDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVDetalle});
            // 
            // gVDetalle
            // 
            this.gVDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDFacturaDetalle,
            this.colIDProducto,
            this.gridColumn6,
            this.colFactura,
            this.colProducto,
            this.colCosto,
            this.colUnidades,
            this.colFechaSistema,
            this.gridColumn7});
            this.gVDetalle.GridControl = this.gCDetalle;
            this.gVDetalle.Name = "gVDetalle";
            this.gVDetalle.OptionsView.ShowFooter = true;
            this.gVDetalle.OptionsView.ShowGroupPanel = false;
            this.gVDetalle.ViewCaption = "VENTA DETALLE";
            // 
            // colIDFacturaDetalle
            // 
            this.colIDFacturaDetalle.FieldName = "IDFacturaDetalle";
            this.colIDFacturaDetalle.Name = "colIDFacturaDetalle";
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IDFactura";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            // 
            // colProducto
            // 
            this.colProducto.Caption = "DETALLE";
            this.colProducto.FieldName = "Producto.Nombre";
            this.colProducto.Name = "colProducto";
            this.colProducto.OptionsColumn.AllowEdit = false;
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 0;
            this.colProducto.Width = 211;
            // 
            // colCosto
            // 
            this.colCosto.Caption = "COSTO";
            this.colCosto.DisplayFormat.FormatString = "c";
            this.colCosto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.OptionsColumn.AllowEdit = false;
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 1;
            this.colCosto.Width = 77;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "CANTIDAD";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsColumn.AllowEdit = false;
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 2;
            this.colUnidades.Width = 78;
            // 
            // colFechaSistema
            // 
            this.colFechaSistema.FieldName = "FechaSistema";
            this.colFechaSistema.Name = "colFechaSistema";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SUB.TOTAL";
            this.gridColumn7.DisplayFormat.FormatString = "c";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn7.FieldName = "gridColumn1";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "{0:#.##}")});
            this.gridColumn7.UnboundExpression = "[Unidades] * [Costo]";
            this.gridColumn7.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 91;
            // 
            // xtraSaveFileDialog1
            // 
            this.xtraSaveFileDialog1.FileName = "Documento";
            // 
            // XfCuentasXCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 644);
            this.Controls.Add(this.gCCuentasCobrar);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XfCuentasXCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.xfAbonoAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCCuentasCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditoBLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCuentasCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCCuentasCobrarHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVCuentasCobrarHistorial)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gCCuentasCobrar;
        private DevExpress.XtraGrid.Views.Grid.GridView gVCuentasCobrar;
        private System.Windows.Forms.BindingSource creditoBLLBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colNumFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colAbona;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoActual;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl gCCuentasCobrarHistorial;
        private DevExpress.XtraGrid.Views.Grid.GridView gVCuentasCobrarHistorial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarios;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraGrid.GridControl gCDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gVDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFacturaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSistema;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.SimpleButton btnEditarAbono;
        private DevExpress.XtraEditors.SimpleButton btnEliminarAbono;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaVence;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog1;
    }
}