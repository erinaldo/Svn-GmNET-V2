namespace Gm.NET.Formularios
{
    partial class xfAbonoHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfAbonoHistorial));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.facturaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFacturaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.creditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCredito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuarios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.facturaDetalleBindingSource;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(14, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(576, 421);
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
            this.colIDProducto,
            this.colIDFactura,
            this.colFactura,
            this.colProducto,
            this.colCosto,
            this.colUnidades,
            this.colFechaSistema,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "VENTA DETALLE";
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
            // colIDFactura
            // 
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.Name = "colIDFactura";
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
            this.colProducto.Width = 174;
            // 
            // colCosto
            // 
            this.colCosto.Caption = "COSTO";
            this.colCosto.FieldName = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.OptionsColumn.AllowEdit = false;
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 1;
            this.colCosto.Width = 52;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "CANTIDAD";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.OptionsColumn.AllowEdit = false;
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 2;
            this.colUnidades.Width = 46;
            // 
            // colFechaSistema
            // 
            this.colFechaSistema.FieldName = "FechaSistema";
            this.colFechaSistema.Name = "colFechaSistema";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "SUB.TOTAL";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "gridColumn1", "{0:#.##}")});
            this.gridColumn1.UnboundExpression = "[Unidades] * [Costo]";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 63;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.creditoBindingSource;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Location = new System.Drawing.Point(596, 30);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(251, 421);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // creditoBindingSource
            // 
            this.creditoBindingSource.DataSource = typeof(Gm.Entities.Credito);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCredito,
            this.colIDFactura1,
            this.colIDUsuario,
            this.colFecha,
            this.colAbona,
            this.colState,
            this.colFactura1,
            this.colUsuarios});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.ShowViewCaption = true;
            this.gridView2.ViewCaption = "HISTORIAL ABONOS";
            // 
            // colIDCredito
            // 
            this.colIDCredito.FieldName = "IDCredito";
            this.colIDCredito.Name = "colIDCredito";
            // 
            // colIDFactura1
            // 
            this.colIDFactura1.FieldName = "IDFactura";
            this.colIDFactura1.Name = "colIDFactura1";
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.FieldName = "IDUsuario";
            this.colIDUsuario.Name = "colIDUsuario";
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.OptionsColumn.AllowEdit = false;
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 0;
            this.colFecha.Width = 130;
            // 
            // colAbona
            // 
            this.colAbona.Caption = "ABONA";
            this.colAbona.FieldName = "Abona";
            this.colAbona.Name = "colAbona";
            this.colAbona.OptionsColumn.AllowEdit = false;
            this.colAbona.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Abona", "{0:#.##}")});
            this.colAbona.Visible = true;
            this.colAbona.VisibleIndex = 1;
            this.colAbona.Width = 74;
            // 
            // colState
            // 
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
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
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(750, 461);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // xfAbonoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xfAbonoHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.xfAbonoHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource facturaDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFacturaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaSistema;
        private System.Windows.Forms.BindingSource creditoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCredito;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colAbona;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}