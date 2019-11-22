namespace Gm.NET.Formularios
{
    partial class XfClientesListado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfClientesListado));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccionContacto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreditoMaximo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservaciones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioAplicado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clienteBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1384, 531);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Gm.Entities.Cliente);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCliente,
            this.colNombre,
            this.colCedula,
            this.colDireccion,
            this.colTelefono,
            this.colCorreo,
            this.colEstado,
            this.colNombreContacto,
            this.colTelefonoContacto,
            this.colDireccionContacto,
            this.colCreditoMaximo,
            this.colObservaciones,
            this.colPrecioAplicado,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.ViewCaption = "Clientes";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colIDCliente
            // 
            this.colIDCliente.Caption = "CODIGO";
            this.colIDCliente.DisplayFormat.FormatString = "COD{0}";
            this.colIDCliente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colIDCliente.FieldName = "IDCliente";
            this.colIDCliente.MinWidth = 25;
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.Visible = true;
            this.colIDCliente.VisibleIndex = 0;
            this.colIDCliente.Width = 63;
            // 
            // colNombre
            // 
            this.colNombre.Caption = "CLIENTE";
            this.colNombre.FieldName = "Nombre";
            this.colNombre.MinWidth = 25;
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 107;
            // 
            // colCedula
            // 
            this.colCedula.Caption = "CEDULA";
            this.colCedula.FieldName = "Cedula";
            this.colCedula.MinWidth = 25;
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 2;
            this.colCedula.Width = 107;
            // 
            // colDireccion
            // 
            this.colDireccion.Caption = "DIRECCION";
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.MinWidth = 25;
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 3;
            this.colDireccion.Width = 107;
            // 
            // colTelefono
            // 
            this.colTelefono.Caption = "TELEFONO";
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.MinWidth = 25;
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 4;
            this.colTelefono.Width = 107;
            // 
            // colCorreo
            // 
            this.colCorreo.Caption = "CORREO";
            this.colCorreo.FieldName = "Correo";
            this.colCorreo.MinWidth = 25;
            this.colCorreo.Name = "colCorreo";
            this.colCorreo.Visible = true;
            this.colCorreo.VisibleIndex = 5;
            this.colCorreo.Width = 107;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "ESTADO";
            this.colEstado.FieldName = "Estado";
            this.colEstado.MinWidth = 25;
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 12;
            this.colEstado.Width = 124;
            // 
            // colNombreContacto
            // 
            this.colNombreContacto.Caption = "NOMBRE CONTACTO";
            this.colNombreContacto.FieldName = "NombreContacto";
            this.colNombreContacto.MinWidth = 25;
            this.colNombreContacto.Name = "colNombreContacto";
            this.colNombreContacto.Visible = true;
            this.colNombreContacto.VisibleIndex = 6;
            this.colNombreContacto.Width = 107;
            // 
            // colTelefonoContacto
            // 
            this.colTelefonoContacto.Caption = "CONTACTO TELEFONO";
            this.colTelefonoContacto.FieldName = "TelefonoContacto";
            this.colTelefonoContacto.MinWidth = 25;
            this.colTelefonoContacto.Name = "colTelefonoContacto";
            this.colTelefonoContacto.Visible = true;
            this.colTelefonoContacto.VisibleIndex = 7;
            this.colTelefonoContacto.Width = 107;
            // 
            // colDireccionContacto
            // 
            this.colDireccionContacto.Caption = "CONTACTO DIRECCION";
            this.colDireccionContacto.FieldName = "DireccionContacto";
            this.colDireccionContacto.MinWidth = 25;
            this.colDireccionContacto.Name = "colDireccionContacto";
            this.colDireccionContacto.Visible = true;
            this.colDireccionContacto.VisibleIndex = 8;
            this.colDireccionContacto.Width = 107;
            // 
            // colCreditoMaximo
            // 
            this.colCreditoMaximo.Caption = "CREDITO MAXIMO";
            this.colCreditoMaximo.DisplayFormat.FormatString = "C";
            this.colCreditoMaximo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCreditoMaximo.FieldName = "CreditoMaximo";
            this.colCreditoMaximo.MinWidth = 25;
            this.colCreditoMaximo.Name = "colCreditoMaximo";
            this.colCreditoMaximo.Visible = true;
            this.colCreditoMaximo.VisibleIndex = 9;
            this.colCreditoMaximo.Width = 107;
            // 
            // colObservaciones
            // 
            this.colObservaciones.Caption = "OBSERVACIONES";
            this.colObservaciones.FieldName = "Observaciones";
            this.colObservaciones.MinWidth = 25;
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.Visible = true;
            this.colObservaciones.VisibleIndex = 10;
            this.colObservaciones.Width = 107;
            // 
            // colPrecioAplicado
            // 
            this.colPrecioAplicado.Caption = "PRECIO APLICADO";
            this.colPrecioAplicado.FieldName = "PrecioAplicado";
            this.colPrecioAplicado.MinWidth = 25;
            this.colPrecioAplicado.Name = "colPrecioAplicado";
            this.colPrecioAplicado.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PRECIO APLICADO";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundExpression = "Concat(\'PRECIO DE VENTA\', [PrecioAplicado])";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            this.gridColumn1.Width = 107;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "N:0";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "COD.";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "CLIENTE";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 33);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 531);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 531);
            // 
            // XfClientesListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 564);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfClientesListado";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.xfClientesListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colCorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccionContacto;
        private DevExpress.XtraGrid.Columns.GridColumn colCreditoMaximo;
        private DevExpress.XtraGrid.Columns.GridColumn colObservaciones;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioAplicado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}