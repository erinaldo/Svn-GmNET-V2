namespace Gm.NET
{
    partial class XfBodegaCrearProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfBodegaCrearProducto));
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPrecioVenta = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtInventarioInicial = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnImportarFoto = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuitarFoto = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.pEFoto = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cbxIva = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.chEstado = new DevExpress.XtraEditors.CheckEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardaryNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventarioInicial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(852, 357);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 30);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(22, 12);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(964, 319);
            this.xtraTabControl1.TabIndex = 28;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtPrecioVenta);
            this.xtraTabPage1.Controls.Add(this.labelControl21);
            this.xtraTabPage1.Controls.Add(this.labelControl18);
            this.xtraTabPage1.Controls.Add(this.txtInventarioInicial);
            this.xtraTabPage1.Controls.Add(this.panelControl1);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.cbxIva);
            this.xtraTabPage1.Controls.Add(this.labelControl10);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.txtCosto);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.chEstado);
            this.xtraTabPage1.Controls.Add(this.txtCodigo);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtDescripcion);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(962, 289);
            this.xtraTabPage1.Text = "PRODUCTO";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(350, 180);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Properties.Mask.EditMask = "f";
            this.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecioVenta.Properties.MaxLength = 6;
            this.txtPrecioVenta.Size = new System.Drawing.Size(149, 22);
            this.txtPrecioVenta.TabIndex = 4;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(289, 20);
            this.labelControl21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(48, 16);
            this.labelControl21.TabIndex = 45;
            this.labelControl21.Text = "ESTADO";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(40, 220);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(118, 16);
            this.labelControl18.TabIndex = 39;
            this.labelControl18.Text = "INVENTARIO INICIAL";
            // 
            // txtInventarioInicial
            // 
            this.txtInventarioInicial.EditValue = "";
            this.txtInventarioInicial.Enabled = false;
            this.txtInventarioInicial.Location = new System.Drawing.Point(40, 244);
            this.txtInventarioInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInventarioInicial.Name = "txtInventarioInicial";
            this.txtInventarioInicial.Properties.Mask.EditMask = "f0";
            this.txtInventarioInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtInventarioInicial.Size = new System.Drawing.Size(149, 22);
            this.txtInventarioInicial.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnImportarFoto);
            this.panelControl1.Controls.Add(this.btnQuitarFoto);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.pEFoto);
            this.panelControl1.Location = new System.Drawing.Point(679, 20);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(248, 232);
            this.panelControl1.TabIndex = 35;
            // 
            // btnImportarFoto
            // 
            this.btnImportarFoto.Location = new System.Drawing.Point(128, 186);
            this.btnImportarFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportarFoto.Name = "btnImportarFoto";
            this.btnImportarFoto.Size = new System.Drawing.Size(81, 30);
            this.btnImportarFoto.TabIndex = 2;
            this.btnImportarFoto.Text = "Importar";
            this.btnImportarFoto.Click += new System.EventHandler(this.btnImportarFoto_Click);
            // 
            // btnQuitarFoto
            // 
            this.btnQuitarFoto.Location = new System.Drawing.Point(41, 186);
            this.btnQuitarFoto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuitarFoto.Name = "btnQuitarFoto";
            this.btnQuitarFoto.Size = new System.Drawing.Size(81, 30);
            this.btnQuitarFoto.TabIndex = 1;
            this.btnQuitarFoto.Text = "Borrar";
            this.btnQuitarFoto.Click += new System.EventHandler(this.btnQuitarFoto_Click);
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(112, 9);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(33, 16);
            this.labelControl16.TabIndex = 36;
            this.labelControl16.Text = "FOTO";
            // 
            // pEFoto
            // 
            this.pEFoto.Location = new System.Drawing.Point(44, 32);
            this.pEFoto.Name = "pEFoto";
            this.pEFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pEFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pEFoto.Size = new System.Drawing.Size(165, 136);
            this.pEFoto.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(505, 157);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(73, 16);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "APLICAR IVA";
            // 
            // cbxIva
            // 
            this.cbxIva.EditValue = "No";
            this.cbxIva.Location = new System.Drawing.Point(505, 180);
            this.cbxIva.Name = "cbxIva";
            this.cbxIva.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxIva.Properties.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbxIva.Size = new System.Drawing.Size(125, 22);
            this.cbxIva.TabIndex = 5;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(350, 156);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(105, 16);
            this.labelControl10.TabIndex = 27;
            this.labelControl10.Text = "PRECIO DE VENTA";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(40, 156);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 16);
            this.labelControl8.TabIndex = 23;
            this.labelControl8.Text = "MANO DE OBRA";
            // 
            // txtCosto
            // 
            this.txtCosto.EditValue = "";
            this.txtCosto.Location = new System.Drawing.Point(40, 180);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.Mask.EditMask = "f0";
            this.txtCosto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCosto.Size = new System.Drawing.Size(149, 22);
            this.txtCosto.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(40, 104);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(79, 16);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "DESCRIPCION";
            // 
            // chEstado
            // 
            this.chEstado.EditValue = true;
            this.chEstado.Location = new System.Drawing.Point(289, 51);
            this.chEstado.Name = "chEstado";
            this.chEstado.Properties.Caption = "HABILITADO";
            this.chEstado.Size = new System.Drawing.Size(94, 20);
            this.chEstado.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(40, 50);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCodigo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCodigo.Size = new System.Drawing.Size(243, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(40, 26);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(134, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "CODIGO DE PRODUCTO";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(40, 128);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Size = new System.Drawing.Size(611, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // btnGuardaryNuevo
            // 
            this.btnGuardaryNuevo.Location = new System.Drawing.Point(723, 357);
            this.btnGuardaryNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardaryNuevo.Name = "btnGuardaryNuevo";
            this.btnGuardaryNuevo.Size = new System.Drawing.Size(123, 30);
            this.btnGuardaryNuevo.TabIndex = 0;
            this.btnGuardaryNuevo.Text = "Guardar y Nuevo";
            this.btnGuardaryNuevo.Click += new System.EventHandler(this.btnGuardaryNuevo_Click);
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // XfBodegaCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnGuardaryNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfBodegaCrearProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Producto";
            this.Load += new System.EventHandler(this.XfBodegaCrearProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInventarioInicial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.TextEdit txtPrecioVenta;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit txtInventarioInicial;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnImportarFoto;
        private DevExpress.XtraEditors.SimpleButton btnQuitarFoto;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.PictureEdit pEFoto;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit cbxIva;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chEstado;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnGuardaryNuevo;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
    }
}