namespace Gm.NET.Formularios.Consultas_Reportes
{
    partial class XUCCuantitativo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XUCCuantitativo));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldFecha1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProducto = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProductoSale1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.sidePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.pivotGridControl1);
            this.sidePanel1.Controls.Add(this.sidePanel2);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1116, 719);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldFecha1,
            this.fieldProducto,
            this.fieldProductoSale1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 43);
            this.pivotGridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.LegacyOptimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(1116, 676);
            this.pivotGridControl1.TabIndex = 23;
            // 
            // fieldFecha1
            // 
            this.fieldFecha1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFecha1.AreaIndex = 0;
            this.fieldFecha1.CellFormat.FormatString = "MM/dd/yy";
            this.fieldFecha1.FieldName = "Fecha";
            this.fieldFecha1.Name = "fieldFecha1";
            this.fieldFecha1.ValueFormat.FormatString = "dd-MM-yyyy";
            this.fieldFecha1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldProducto
            // 
            this.fieldProducto.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProducto.AreaIndex = 0;
            this.fieldProducto.FieldName = "Producto";
            this.fieldProducto.Name = "fieldProducto";
            this.fieldProducto.Width = 422;
            // 
            // fieldProductoSale1
            // 
            this.fieldProductoSale1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldProductoSale1.AreaIndex = 0;
            this.fieldProductoSale1.FieldName = "ProductoSale";
            this.fieldProductoSale1.Name = "fieldProductoSale1";
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.labelControl14);
            this.sidePanel2.Controls.Add(this.btnActualizar);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sidePanel2.Location = new System.Drawing.Point(0, 0);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(1116, 43);
            this.sidePanel2.TabIndex = 22;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(11, 0);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(353, 40);
            this.labelControl14.TabIndex = 85;
            this.labelControl14.Text = "Movimiento Producto";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(1007, 5);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // XUCCuantitativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sidePanel1);
            this.Name = "XUCCuantitativo";
            this.Size = new System.Drawing.Size(1116, 719);
            this.Load += new System.EventHandler(this.XUCCuantitativo_Load);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.sidePanel2.ResumeLayout(false);
            this.sidePanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFecha1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProducto;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProductoSale1;
    }
}
