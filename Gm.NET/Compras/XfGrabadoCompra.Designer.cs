namespace Gm.NET
{
    partial class XfGrabadoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfGrabadoCompra));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.purchasesAbvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParaBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtBodega = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colAhorra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesAbvanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.purchasesAbvanceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtBodega});
            this.gridControl1.Size = new System.Drawing.Size(802, 321);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // purchasesAbvanceBindingSource
            // 
            this.purchasesAbvanceBindingSource.DataSource = typeof(Gm.Core.PurchasesAbvance);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDProducto,
            this.colNombre,
            this.colCantidad,
            this.colAhorra,
            this.colParaBodega});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIDProducto
            // 
            this.colIDProducto.FieldName = "IDProducto";
            this.colIDProducto.MinWidth = 25;
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.Width = 94;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "DESCRIPCION";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 517;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "PARA ALMACER";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Width = 123;
            // 
            // colParaBodega
            // 
            this.colParaBodega.Caption = "PARA BODEGA";
            this.colParaBodega.ColumnEdit = this.txtBodega;
            this.colParaBodega.FieldName = "ParaBodega";
            this.colParaBodega.MinWidth = 25;
            this.colParaBodega.Name = "colParaBodega";
            this.colParaBodega.Visible = true;
            this.colParaBodega.VisibleIndex = 2;
            this.colParaBodega.Width = 134;
            // 
            // txtBodega
            // 
            this.txtBodega.AutoHeight = false;
            this.txtBodega.Name = "txtBodega";
            // 
            // colAhorra
            // 
            this.colAhorra.Caption = "PARA ALMACEN";
            this.colAhorra.FieldName = "Ahorra";
            this.colAhorra.MinWidth = 25;
            this.colAhorra.Name = "colAhorra";
            this.colAhorra.OptionsColumn.AllowEdit = false;
            this.colAhorra.Visible = true;
            this.colAhorra.VisibleIndex = 1;
            this.colAhorra.Width = 131;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.Location = new System.Drawing.Point(287, 345);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 49);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(400, 345);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 49);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // XfGrabadoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 408);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfGrabadoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar";
            this.Load += new System.EventHandler(this.XfGrabadoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasesAbvanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBodega)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.BindingSource purchasesAbvanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colParaBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colAhorra;
    }
}