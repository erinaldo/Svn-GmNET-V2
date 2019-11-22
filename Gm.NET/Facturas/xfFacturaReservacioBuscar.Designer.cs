namespace Gm.NET.Formularios.Ventas
{
    partial class XfFacturaReservacioBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfFacturaReservacioBuscar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.reservacionCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDReservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.billCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaAplica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.reservacionCoreBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(26, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(778, 218);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // reservacionCoreBindingSource
            // 
            this.reservacionCoreBindingSource.DataSource = typeof(Gm.Core.ReservacionCore);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcliente,
            this.colIDReservacion,
            this.colFecha,
            this.colEstado,
            this.colComentario});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "RESERVACIONES";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colcliente
            // 
            this.colcliente.Caption = "CLIENTE";
            this.colcliente.FieldName = "cliente.Nombre";
            this.colcliente.MinWidth = 25;
            this.colcliente.Name = "colcliente";
            this.colcliente.Visible = true;
            this.colcliente.VisibleIndex = 1;
            this.colcliente.Width = 239;
            // 
            // colIDReservacion
            // 
            this.colIDReservacion.Caption = "CODIGO";
            this.colIDReservacion.FieldName = "IDReservacion";
            this.colIDReservacion.MinWidth = 25;
            this.colIDReservacion.Name = "colIDReservacion";
            this.colIDReservacion.Visible = true;
            this.colIDReservacion.VisibleIndex = 0;
            this.colIDReservacion.Width = 104;
            // 
            // colFecha
            // 
            this.colFecha.Caption = "FECHA";
            this.colFecha.FieldName = "Fecha";
            this.colFecha.MinWidth = 25;
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            this.colFecha.Width = 106;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "ESTADO";
            this.colEstado.FieldName = "Estado";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            this.colEstado.Width = 108;
            // 
            // colComentario
            // 
            this.colComentario.Caption = "COMENTARIO";
            this.colComentario.FieldName = "Comentario";
            this.colComentario.MinWidth = 25;
            this.colComentario.Name = "colComentario";
            this.colComentario.Visible = true;
            this.colComentario.VisibleIndex = 2;
            this.colComentario.Width = 198;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.billCoreBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(26, 251);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(778, 328);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // billCoreBindingSource
            // 
            this.billCoreBindingSource.DataSource = typeof(Gm.Core.BillCore);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colDetalle,
            this.colPrecio,
            this.colUnidades,
            this.colIva,
            this.colIvaAplica,
            this.colSubTotal,
            this.colTotal,
            this.colMedida});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 94;
            // 
            // colDetalle
            // 
            this.colDetalle.Caption = "DETALLE";
            this.colDetalle.FieldName = "Detalle";
            this.colDetalle.MinWidth = 25;
            this.colDetalle.Name = "colDetalle";
            this.colDetalle.Visible = true;
            this.colDetalle.VisibleIndex = 1;
            this.colDetalle.Width = 342;
            // 
            // colPrecio
            // 
            this.colPrecio.Caption = "PRECIO";
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.MinWidth = 25;
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            this.colPrecio.Width = 79;
            // 
            // colUnidades
            // 
            this.colUnidades.Caption = "CANTIDAD";
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Visible = true;
            this.colUnidades.VisibleIndex = 0;
            this.colUnidades.Width = 87;
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
            this.colIvaAplica.Caption = "IVA";
            this.colIvaAplica.FieldName = "IvaAplica";
            this.colIvaAplica.MinWidth = 25;
            this.colIvaAplica.Name = "colIvaAplica";
            this.colIvaAplica.Visible = true;
            this.colIvaAplica.VisibleIndex = 4;
            this.colIvaAplica.Width = 59;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "SUB. TOTAL";
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.MinWidth = 25;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.OptionsColumn.ReadOnly = true;
            this.colSubTotal.Width = 100;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "TOTAL";
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.ReadOnly = true;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 88;
            // 
            // colMedida
            // 
            this.colMedida.Caption = "MEDIDA";
            this.colMedida.FieldName = "Medida.Name";
            this.colMedida.MinWidth = 25;
            this.colMedida.Name = "colMedida";
            this.colMedida.Visible = true;
            this.colMedida.VisibleIndex = 2;
            this.colMedida.Width = 94;
            // 
            // XfFacturaReservacioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 608);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XfFacturaReservacioBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservacion Buscar";
            this.Load += new System.EventHandler(this.xfFacturaReservacioBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource reservacionCoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIDReservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colComentario;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource billCoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaAplica;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colMedida;
    }
}