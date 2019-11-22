namespace Gm.NET
{
    partial class XfProductoTrasladoBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfProductoTrasladoBodega));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.trasladoCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasladoCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.trasladoCoreBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(632, 524);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // trasladoCoreBindingSource
            // 
            this.trasladoCoreBindingSource.DataSource = typeof(Gm.Core.TrasladoCore);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDFactura,
            this.colNumeroFactura,
            this.colIdProducto,
            this.colNombre,
            this.colCantidad,
            this.colEnBodega,
            this.colQueda,
            this.colSale});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIDFactura
            // 
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Width = 94;
            // 
            // colNumeroFactura
            // 
            this.colNumeroFactura.FieldName = "NumeroFactura";
            this.colNumeroFactura.MinWidth = 25;
            this.colNumeroFactura.Name = "colNumeroFactura";
            this.colNumeroFactura.OptionsColumn.AllowEdit = false;
            this.colNumeroFactura.Visible = true;
            this.colNumeroFactura.VisibleIndex = 0;
            this.colNumeroFactura.Width = 121;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Width = 387;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 62;
            // 
            // colEnBodega
            // 
            this.colEnBodega.FieldName = "EnBodega";
            this.colEnBodega.MinWidth = 25;
            this.colEnBodega.Name = "colEnBodega";
            this.colEnBodega.Width = 62;
            // 
            // colQueda
            // 
            this.colQueda.Caption = "En Almacen";
            this.colQueda.FieldName = "Queda";
            this.colQueda.MinWidth = 25;
            this.colQueda.Name = "colQueda";
            this.colQueda.OptionsColumn.AllowEdit = false;
            this.colQueda.OptionsColumn.ReadOnly = true;
            this.colQueda.Visible = true;
            this.colQueda.VisibleIndex = 1;
            this.colQueda.Width = 62;
            // 
            // colSale
            // 
            this.colSale.Caption = "Traslado a Bodega";
            this.colSale.FieldName = "Sale";
            this.colSale.MinWidth = 25;
            this.colSale.Name = "colSale";
            this.colSale.Visible = true;
            this.colSale.VisibleIndex = 2;
            this.colSale.Width = 68;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 542);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(632, 22);
            this.progressBarControl1.TabIndex = 1;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(450, 570);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 29);
            this.btnAplicar.TabIndex = 2;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(550, 570);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // XfProductoTrasladoBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 622);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfProductoTrasladoBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Traslado a Bodega";
            this.Load += new System.EventHandler(this.XfTrasladoProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trasladoCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource trasladoCoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEnBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colQueda;
        private DevExpress.XtraGrid.Columns.GridColumn colSale;
    }
}