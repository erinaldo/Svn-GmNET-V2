namespace Gm.NET.Formularios
{
    partial class xfPurchaseSubir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfPurchaseSubir));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchaseSubirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioReal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioPorMayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPrecioVenta = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnConfirmar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSubirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.purchaseSubirBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtPrecioVenta});
            this.gridControl1.Size = new System.Drawing.Size(916, 475);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchaseSubirBindingSource
            // 
            this.purchaseSubirBindingSource.DataSource = typeof(Gm.Core.PurchaseSubir);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colName,
            this.colCantidad,
            this.colPrecioReal,
            this.colEn,
            this.colPrecioPorMayor});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "DETALLE";
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
            this.colName.VisibleIndex = 1;
            this.colName.Width = 487;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "CANTIDAD";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 0;
            this.colCantidad.Width = 99;
            // 
            // colPrecioReal
            // 
            this.colPrecioReal.Caption = "PRECIO REAL";
            this.colPrecioReal.FieldName = "PrecioReal";
            this.colPrecioReal.MinWidth = 25;
            this.colPrecioReal.Name = "colPrecioReal";
            this.colPrecioReal.OptionsColumn.AllowEdit = false;
            this.colPrecioReal.Visible = true;
            this.colPrecioReal.VisibleIndex = 2;
            this.colPrecioReal.Width = 104;
            // 
            // colEn
            // 
            this.colEn.Caption = "MEDIDA EN";
            this.colEn.FieldName = "En";
            this.colEn.MinWidth = 25;
            this.colEn.Name = "colEn";
            this.colEn.OptionsColumn.AllowEdit = false;
            this.colEn.Visible = true;
            this.colEn.VisibleIndex = 3;
            this.colEn.Width = 94;
            // 
            // colPrecioPorMayor
            // 
            this.colPrecioPorMayor.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.colPrecioPorMayor.AppearanceHeader.Options.UseBackColor = true;
            this.colPrecioPorMayor.Caption = "PRECIO VENTA";
            this.colPrecioPorMayor.ColumnEdit = this.txtPrecioVenta;
            this.colPrecioPorMayor.FieldName = "PrecioPorMayor";
            this.colPrecioPorMayor.MinWidth = 25;
            this.colPrecioPorMayor.Name = "colPrecioPorMayor";
            this.colPrecioPorMayor.Visible = true;
            this.colPrecioPorMayor.VisibleIndex = 4;
            this.colPrecioPorMayor.Width = 109;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.AutoHeight = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(730, 505);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(94, 29);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(834, 504);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // xfPurchaseSubir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(940, 554);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfPurchaseSubir";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Subir";
            this.Load += new System.EventHandler(this.xfPurchaseSubir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseSubirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnConfirmar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource purchaseSubirBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioReal;
        private DevExpress.XtraGrid.Columns.GridColumn colEn;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioPorMayor;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtPrecioVenta;
    }
}