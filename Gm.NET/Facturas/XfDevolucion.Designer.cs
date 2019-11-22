namespace Gm.NET
{
    partial class XfDevolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfDevolucion));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.devolucionCoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDFacturaDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnidades = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMedidaMetrica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCosto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chEstado = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CedulatextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NumeroTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FechaDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ClienteTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForNumero = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFecha = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCliente = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionCoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CedulatextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.devolucionCoreBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 118);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chEstado});
            this.gridControl1.Size = new System.Drawing.Size(909, 425);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // devolucionCoreBindingSource
            // 
            this.devolucionCoreBindingSource.DataSource = typeof(Gm.Core.DevolucionCore);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDFacturaDetalle,
            this.colIDFactura,
            this.colUnidades,
            this.colQueda,
            this.colProducto,
            this.colProducto1,
            this.colMedidaMetrica,
            this.colIva,
            this.colCosto,
            this.colSale,
            this.colTotal,
            this.colTotal2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIDFacturaDetalle
            // 
            this.colIDFacturaDetalle.FieldName = "IDFacturaDetalle";
            this.colIDFacturaDetalle.MinWidth = 25;
            this.colIDFacturaDetalle.Name = "colIDFacturaDetalle";
            this.colIDFacturaDetalle.Width = 94;
            // 
            // colIDFactura
            // 
            this.colIDFactura.FieldName = "IDFactura";
            this.colIDFactura.MinWidth = 25;
            this.colIDFactura.Name = "colIDFactura";
            this.colIDFactura.Width = 94;
            // 
            // colUnidades
            // 
            this.colUnidades.FieldName = "Unidades";
            this.colUnidades.MinWidth = 25;
            this.colUnidades.Name = "colUnidades";
            this.colUnidades.Width = 74;
            // 
            // colQueda
            // 
            this.colQueda.Caption = "Cantidad";
            this.colQueda.FieldName = "Queda";
            this.colQueda.MinWidth = 25;
            this.colQueda.Name = "colQueda";
            this.colQueda.OptionsColumn.ReadOnly = true;
            this.colQueda.Visible = true;
            this.colQueda.VisibleIndex = 0;
            this.colQueda.Width = 59;
            // 
            // colProducto
            // 
            this.colProducto.FieldName = "Producto.Nombre";
            this.colProducto.MinWidth = 25;
            this.colProducto.Name = "colProducto";
            this.colProducto.Visible = true;
            this.colProducto.VisibleIndex = 1;
            this.colProducto.Width = 290;
            // 
            // colProducto1
            // 
            this.colProducto1.Caption = "Marca";
            this.colProducto1.FieldName = "Producto.Marca.NombreMarca";
            this.colProducto1.MinWidth = 25;
            this.colProducto1.Name = "colProducto1";
            this.colProducto1.Visible = true;
            this.colProducto1.VisibleIndex = 2;
            this.colProducto1.Width = 84;
            // 
            // colMedidaMetrica
            // 
            this.colMedidaMetrica.Caption = "Medida";
            this.colMedidaMetrica.FieldName = "MedidaMetrica.Name";
            this.colMedidaMetrica.MinWidth = 25;
            this.colMedidaMetrica.Name = "colMedidaMetrica";
            this.colMedidaMetrica.Visible = true;
            this.colMedidaMetrica.VisibleIndex = 3;
            // 
            // colIva
            // 
            this.colIva.FieldName = "Iva";
            this.colIva.MinWidth = 25;
            this.colIva.Name = "colIva";
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 4;
            this.colIva.Width = 42;
            // 
            // colCosto
            // 
            this.colCosto.Caption = "P.V.P";
            this.colCosto.FieldName = "Costo";
            this.colCosto.MinWidth = 25;
            this.colCosto.Name = "colCosto";
            this.colCosto.Visible = true;
            this.colCosto.VisibleIndex = 5;
            this.colCosto.Width = 65;
            // 
            // colSale
            // 
            this.colSale.Caption = "Devuelve";
            this.colSale.FieldName = "Sale";
            this.colSale.MinWidth = 25;
            this.colSale.Name = "colSale";
            this.colSale.Visible = true;
            this.colSale.VisibleIndex = 7;
            this.colSale.Width = 92;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "T={0:0.##}")});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            this.colTotal.Width = 88;
            // 
            // colTotal2
            // 
            this.colTotal2.Caption = "Tota Devuelto";
            this.colTotal2.FieldName = "Total2";
            this.colTotal2.MinWidth = 25;
            this.colTotal2.Name = "colTotal2";
            this.colTotal2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total2", "T={0:0.##}")});
            this.colTotal2.Visible = true;
            this.colTotal2.VisibleIndex = 8;
            this.colTotal2.Width = 104;
            // 
            // chEstado
            // 
            this.chEstado.AutoHeight = false;
            this.chEstado.Name = "chEstado";
            this.chEstado.CheckedChanged += new System.EventHandler(this.chEstado_CheckedChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(709, 595);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(94, 29);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(809, 595);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 549);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.ShowTitle = true;
            this.progressBarControl1.Size = new System.Drawing.Size(909, 22);
            this.progressBarControl1.TabIndex = 5;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CedulatextEdit);
            this.dataLayoutControl1.Controls.Add(this.NumeroTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FechaDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ClienteTextEdit);
            this.dataLayoutControl1.DataSource = this.facturaBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(936, 112);
            this.dataLayoutControl1.TabIndex = 6;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // CedulatextEdit
            // 
            this.CedulatextEdit.Location = new System.Drawing.Point(486, 64);
            this.CedulatextEdit.Name = "CedulatextEdit";
            this.CedulatextEdit.Size = new System.Drawing.Size(438, 22);
            this.CedulatextEdit.StyleController = this.dataLayoutControl1;
            this.CedulatextEdit.TabIndex = 7;
            this.CedulatextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTextEdit_KeyPress);
            // 
            // NumeroTextEdit
            // 
            this.NumeroTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturaBindingSource, "Numero", true));
            this.NumeroTextEdit.Location = new System.Drawing.Point(107, 12);
            this.NumeroTextEdit.Name = "NumeroTextEdit";
            this.NumeroTextEdit.Size = new System.Drawing.Size(817, 22);
            this.NumeroTextEdit.StyleController = this.dataLayoutControl1;
            this.NumeroTextEdit.TabIndex = 4;
            this.NumeroTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTextEdit_KeyPress);
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Gm.Entities.Factura);
            // 
            // FechaDateEdit
            // 
            this.FechaDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturaBindingSource, "Fecha", true));
            this.FechaDateEdit.EditValue = null;
            this.FechaDateEdit.Enabled = false;
            this.FechaDateEdit.Location = new System.Drawing.Point(107, 38);
            this.FechaDateEdit.Name = "FechaDateEdit";
            this.FechaDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.FechaDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.FechaDateEdit.Size = new System.Drawing.Size(817, 22);
            this.FechaDateEdit.StyleController = this.dataLayoutControl1;
            this.FechaDateEdit.TabIndex = 5;
            // 
            // ClienteTextEdit
            // 
            this.ClienteTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.facturaBindingSource, "Cliente", true));
            this.ClienteTextEdit.Location = new System.Drawing.Point(107, 64);
            this.ClienteTextEdit.Name = "ClienteTextEdit";
            this.ClienteTextEdit.Size = new System.Drawing.Size(375, 22);
            this.ClienteTextEdit.StyleController = this.dataLayoutControl1;
            this.ClienteTextEdit.TabIndex = 6;
            this.ClienteTextEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroTextEdit_KeyPress);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(936, 112);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForNumero,
            this.ItemForFecha,
            this.ItemForCliente,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(916, 92);
            // 
            // ItemForNumero
            // 
            this.ItemForNumero.Control = this.NumeroTextEdit;
            this.ItemForNumero.Location = new System.Drawing.Point(0, 0);
            this.ItemForNumero.Name = "ItemForNumero";
            this.ItemForNumero.Size = new System.Drawing.Size(916, 26);
            this.ItemForNumero.Text = "Numero Factura";
            this.ItemForNumero.TextSize = new System.Drawing.Size(92, 16);
            // 
            // ItemForFecha
            // 
            this.ItemForFecha.Control = this.FechaDateEdit;
            this.ItemForFecha.Location = new System.Drawing.Point(0, 26);
            this.ItemForFecha.Name = "ItemForFecha";
            this.ItemForFecha.Size = new System.Drawing.Size(916, 26);
            this.ItemForFecha.Text = "Fecha";
            this.ItemForFecha.TextSize = new System.Drawing.Size(92, 16);
            // 
            // ItemForCliente
            // 
            this.ItemForCliente.Control = this.ClienteTextEdit;
            this.ItemForCliente.Location = new System.Drawing.Point(0, 52);
            this.ItemForCliente.Name = "ItemForCliente";
            this.ItemForCliente.Size = new System.Drawing.Size(474, 40);
            this.ItemForCliente.Text = "Cliente";
            this.ItemForCliente.TextSize = new System.Drawing.Size(92, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.CedulatextEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(474, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(442, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // XfDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 641);
            this.ControlBox = false;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfDevolucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.XfDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devolucionCoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CedulatextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FechaDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chEstado;
        private System.Windows.Forms.BindingSource devolucionCoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFacturaDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colIDFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidades;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colMedidaMetrica;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colCosto;
        private DevExpress.XtraGrid.Columns.GridColumn colSale;
        private DevExpress.XtraGrid.Columns.GridColumn colQueda;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit NumeroTextEdit;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DevExpress.XtraEditors.DateEdit FechaDateEdit;
        private DevExpress.XtraEditors.TextEdit ClienteTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNumero;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFecha;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCliente;
        private DevExpress.XtraEditors.TextEdit CedulatextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}