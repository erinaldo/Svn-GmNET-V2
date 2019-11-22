namespace Gm.NET.Formularios.Inventario
{
    partial class xfInventario
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
            DevExpress.XtraEditors.FormatConditionRuleDataBar formatConditionRuleDataBar1 = new DevExpress.XtraEditors.FormatConditionRuleDataBar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfInventario));
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gCInventario = new DevExpress.XtraGrid.GridControl();
            this.inventarioTotalCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gVInventario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pCCentral = new DevExpress.XtraEditors.PanelControl();
            this.pCMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gCInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioTotalCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCCentral)).BeginInit();
            this.pCCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCMenu)).BeginInit();
            this.pCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "CANTIDAD";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.MinWidth = 25;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.OptionsColumn.AllowEdit = false;
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 403;
            // 
            // gCInventario
            // 
            this.gCInventario.DataSource = this.inventarioTotalCoreBindingSource;
            this.gCInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCInventario.Location = new System.Drawing.Point(0, 50);
            this.gCInventario.MainView = this.gVInventario;
            this.gCInventario.Name = "gCInventario";
            this.gCInventario.Size = new System.Drawing.Size(1001, 437);
            this.gCInventario.TabIndex = 0;
            this.gCInventario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gVInventario});
            // 
            // inventarioTotalCoreBindingSource
            // 
            this.inventarioTotalCoreBindingSource.DataSource = typeof(Gm.Core.InventarioTotalCore);
            // 
            // gVInventario
            // 
            this.gVInventario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colName,
            this.colCantidad,
            this.colEn});
            gridFormatRule1.Column = this.colCantidad;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleDataBar1.PredefinedName = "Blue Gradient";
            gridFormatRule1.Rule = formatConditionRuleDataBar1;
            this.gVInventario.FormatRules.Add(gridFormatRule1);
            this.gVInventario.GridControl = this.gCInventario;
            this.gVInventario.Name = "gVInventario";
            this.gVInventario.OptionsView.ShowGroupPanel = false;
            this.gVInventario.OptionsView.ShowViewCaption = true;
            this.gVInventario.ViewCaption = "PRODUCTOS";
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.MinWidth = 25;
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.OptionsEditForm.ColumnSpan = 2;
            this.colIdProducto.OptionsEditForm.RowSpan = 2;
            this.colIdProducto.OptionsEditForm.UseEditorColRowSpan = false;
            this.colIdProducto.Width = 83;
            // 
            // colName
            // 
            this.colName.Caption = "DETALLE";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsEditForm.ColumnSpan = 2;
            this.colName.OptionsEditForm.RowSpan = 2;
            this.colName.OptionsEditForm.StartNewRow = true;
            this.colName.OptionsEditForm.UseEditorColRowSpan = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 415;
            // 
            // colEn
            // 
            this.colEn.Caption = "EN";
            this.colEn.FieldName = "En";
            this.colEn.MinWidth = 25;
            this.colEn.Name = "colEn";
            this.colEn.OptionsColumn.AllowEdit = false;
            this.colEn.Visible = true;
            this.colEn.VisibleIndex = 2;
            this.colEn.Width = 89;
            // 
            // pCCentral
            // 
            this.pCCentral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pCCentral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCCentral.Controls.Add(this.gCInventario);
            this.pCCentral.Controls.Add(this.pCMenu);
            this.pCCentral.Location = new System.Drawing.Point(12, 12);
            this.pCCentral.Name = "pCCentral";
            this.pCCentral.Size = new System.Drawing.Size(1001, 487);
            this.pCCentral.TabIndex = 1;
            // 
            // pCMenu
            // 
            this.pCMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCMenu.Controls.Add(this.btnSalir);
            this.pCMenu.Controls.Add(this.btnActualizar);
            this.pCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCMenu.Location = new System.Drawing.Point(0, 0);
            this.pCMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCMenu.Name = "pCMenu";
            this.pCMenu.Size = new System.Drawing.Size(1001, 50);
            this.pCMenu.TabIndex = 34;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(897, 10);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(794, 10);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // xfInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 511);
            this.Controls.Add(this.pCCentral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "xfInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.xfInventario_Load);
            this.SizeChanged += new System.EventHandler(this.xfInventario_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gCInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioTotalCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCCentral)).EndInit();
            this.pCCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCMenu)).EndInit();
            this.pCMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gCInventario;
        private DevExpress.XtraGrid.Views.Grid.GridView gVInventario;
        private System.Windows.Forms.BindingSource inventarioTotalCoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEn;
        private DevExpress.XtraEditors.PanelControl pCCentral;
        private DevExpress.XtraEditors.PanelControl pCMenu;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
    }
}