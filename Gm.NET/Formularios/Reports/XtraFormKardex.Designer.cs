namespace Gm.NET
{
    partial class XtraFormKardex
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression5 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormKardex));
            this.colProductoEntra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoEntraPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductoSalePrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gCKardex = new DevExpress.XtraGrid.GridControl();
            this.vistaKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gVKardex = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDKardex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.colSiclo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gCKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVKardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // colProductoEntra
            // 
            this.colProductoEntra.Caption = "ENTRA";
            this.colProductoEntra.FieldName = "ProductoEntra";
            this.colProductoEntra.Name = "colProductoEntra";
            this.colProductoEntra.Visible = true;
            this.colProductoEntra.VisibleIndex = 2;
            this.colProductoEntra.Width = 108;
            // 
            // colProductoEntraPrecio
            // 
            this.colProductoEntraPrecio.Caption = "PRECIO ENTRADA";
            this.colProductoEntraPrecio.DisplayFormat.FormatString = "c";
            this.colProductoEntraPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colProductoEntraPrecio.FieldName = "ProductoEntraPrecio";
            this.colProductoEntraPrecio.Name = "colProductoEntraPrecio";
            this.colProductoEntraPrecio.Visible = true;
            this.colProductoEntraPrecio.VisibleIndex = 3;
            this.colProductoEntraPrecio.Width = 128;
            // 
            // colProductoSale
            // 
            this.colProductoSale.Caption = "SALE";
            this.colProductoSale.FieldName = "ProductoSale";
            this.colProductoSale.Name = "colProductoSale";
            this.colProductoSale.Visible = true;
            this.colProductoSale.VisibleIndex = 4;
            this.colProductoSale.Width = 90;
            // 
            // colProductoSalePrecio
            // 
            this.colProductoSalePrecio.Caption = "PRECIO SALIDA";
            this.colProductoSalePrecio.DisplayFormat.FormatString = "c";
            this.colProductoSalePrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colProductoSalePrecio.FieldName = "ProductoSalePrecio";
            this.colProductoSalePrecio.Name = "colProductoSalePrecio";
            this.colProductoSalePrecio.Visible = true;
            this.colProductoSalePrecio.VisibleIndex = 5;
            this.colProductoSalePrecio.Width = 118;
            // 
            // colIVA
            // 
            this.colIVA.Caption = "IVA";
            this.colIVA.DisplayFormat.FormatString = "{0}%";
            this.colIVA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIVA.FieldName = "IVA";
            this.colIVA.Name = "colIVA";
            this.colIVA.Visible = true;
            this.colIVA.VisibleIndex = 7;
            this.colIVA.Width = 47;
            // 
            // gCKardex
            // 
            this.gCKardex.DataSource = this.vistaKardexBindingSource;
            this.gCKardex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCKardex.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCKardex.Location = new System.Drawing.Point(0, 31);
            this.gCKardex.MainView = this.gVKardex;
            this.gCKardex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gCKardex.Name = "gCKardex";
            this.gCKardex.Size = new System.Drawing.Size(1508, 620);
            this.gCKardex.TabIndex = 0;
            this.gCKardex.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVKardex});
            // 
            // vistaKardexBindingSource
            // 
            this.vistaKardexBindingSource.DataSource = typeof(Gm.Entities.VistaKardex);
            // 
            // gVKardex
            // 
            this.gVKardex.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVKardex.Appearance.FocusedRow.Options.UseFont = true;
            this.gVKardex.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVKardex.Appearance.GroupRow.Options.UseFont = true;
            this.gVKardex.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVKardex.Appearance.HeaderPanel.Options.UseFont = true;
            this.gVKardex.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gVKardex.Appearance.Row.Options.UseFont = true;
            this.gVKardex.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDKardex,
            this.colIDProducto,
            this.colProducto,
            this.colProductoEntra,
            this.colProductoEntraPrecio,
            this.colProductoSale,
            this.colProductoSalePrecio,
            this.colIVA,
            this.colFecha,
            this.colEstado,
            this.colMedida,
            this.colSiclo});
            gridFormatRule1.Name = "Entra";
            formatConditionRuleExpression1.Expression = "[ProductoEntra] <> 0";
            formatConditionRuleExpression1.PredefinedName = "Red Text";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            gridFormatRule2.Name = "PEntra";
            formatConditionRuleExpression2.Expression = "[ProductoEntraPrecio] <> 0";
            formatConditionRuleExpression2.PredefinedName = "Red Text";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            gridFormatRule3.Name = "Sale";
            formatConditionRuleExpression3.Expression = "[ProductoSale] <> 0";
            formatConditionRuleExpression3.PredefinedName = "Green Text";
            gridFormatRule3.Rule = formatConditionRuleExpression3;
            gridFormatRule4.Name = "PSale";
            formatConditionRuleExpression4.Expression = "[ProductoSalePrecio] <> 0";
            formatConditionRuleExpression4.PredefinedName = "Green Text";
            gridFormatRule4.Rule = formatConditionRuleExpression4;
            gridFormatRule5.Name = "Iva";
            formatConditionRuleExpression5.Expression = "[IVA] == 0";
            formatConditionRuleExpression5.PredefinedName = "Red Fill";
            gridFormatRule5.Rule = formatConditionRuleExpression5;
            this.gVKardex.FormatRules.Add(gridFormatRule1);
            this.gVKardex.FormatRules.Add(gridFormatRule2);
            this.gVKardex.FormatRules.Add(gridFormatRule3);
            this.gVKardex.FormatRules.Add(gridFormatRule4);
            this.gVKardex.FormatRules.Add(gridFormatRule5);
            this.gVKardex.GridControl = this.gCKardex;
            this.gVKardex.Name = "gVKardex";
            this.gVKardex.OptionsBehavior.Editable = false;
            this.gVKardex.OptionsView.ShowAutoFilterRow = true;
            this.gVKardex.ViewCaption = "KARDEX";
            this.gVKardex.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gVKardex_RowStyle);
            // 
            // colIDKardex
            // 
            this.colIDKardex.Caption = "REGISTRO";
            this.colIDKardex.DisplayFormat.FormatString = "COD{0}";
            this.colIDKardex.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIDKardex.FieldName = "IDKardex";
            this.colIDKardex.Name = "colIDKardex";
            this.colIDKardex.Visible = true;
            this.colIDKardex.VisibleIndex = 0;
            this.colIDKardex.Width = 79;
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.Name = "colIDProducto";
            // 
            // colProducto
            // 
            this.colProducto.Caption = "DETALLE";
            this.colProducto.FieldName = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 565;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.DisplayFormat.FormatString = "dddd, dd MMMM yyyy";
            this.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 8;
            this.colFecha.Width = 102;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "ESTADO";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            this.colEstado.Width = 81;
            // 
            // colMedida
            // 
            this.colMedida.Caption = "MEDIDA";
            this.colMedida.FieldName = "Medida";
            this.colMedida.MinWidth = 25;
            this.colMedida.Name = "colMedida";
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 6;
            this.colMedida.Width = 112;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barSubItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Actualizar";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Imprimir";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Exportar";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Salir";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1508, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 651);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1508, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 620);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1508, 31);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 620);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Herramientas";
            this.barSubItem2.Id = 3;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // colSiclo
            // 
            this.colSiclo.FieldName = "Siclo";
            this.colSiclo.MinWidth = 25;
            this.colSiclo.Name = "colSiclo";
            this.colSiclo.Width = 94;
            // 
            // XtraFormKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 651);
            this.Controls.Add(this.gCKardex);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraFormKardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria Inventario";
            this.Load += new System.EventHandler(this.XtraFormKardex_Load);
            this.SizeChanged += new System.EventHandler(this.XtraFormKardex_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gCKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVKardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCKardex;
        private DevExpress.XtraGrid.Views.Grid.GridView gVKardex;
        private System.Windows.Forms.BindingSource vistaKardexBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKardex;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntra;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoEntraPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSale;
        private DevExpress.XtraGrid.Columns.GridColumn colProductoSalePrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colSiclo;
    }
}