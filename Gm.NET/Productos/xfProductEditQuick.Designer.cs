namespace Gm.NET.Formularios
{
    partial class XfProductEditQuick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfProductEditQuick));
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioCompraReal = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio1 = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio2 = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecio3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lbContador = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrecio4 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompraReal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.EditValue = "";
            this.txtNombre.Location = new System.Drawing.Point(17, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 50;
            this.txtNombre.Size = new System.Drawing.Size(611, 28);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // txtPrecioCompraReal
            // 
            this.txtPrecioCompraReal.EditValue = "";
            this.txtPrecioCompraReal.Enabled = false;
            this.txtPrecioCompraReal.Location = new System.Drawing.Point(634, 50);
            this.txtPrecioCompraReal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecioCompraReal.Name = "txtPrecioCompraReal";
            this.txtPrecioCompraReal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompraReal.Properties.Appearance.Options.UseFont = true;
            this.txtPrecioCompraReal.Properties.MaxLength = 50;
            this.txtPrecioCompraReal.Size = new System.Drawing.Size(134, 28);
            this.txtPrecioCompraReal.TabIndex = 1;
            this.txtPrecioCompraReal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(774, 50);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio1.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio1.Properties.Mask.EditMask = "n2";
            this.txtPrecio1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio1.Properties.MaxLength = 6;
            this.txtPrecio1.Size = new System.Drawing.Size(117, 28);
            this.txtPrecio1.TabIndex = 2;
            this.txtPrecio1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(897, 50);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio2.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio2.Properties.Mask.EditMask = "f";
            this.txtPrecio2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio2.Properties.MaxLength = 6;
            this.txtPrecio2.Size = new System.Drawing.Size(117, 28);
            this.txtPrecio2.TabIndex = 3;
            this.txtPrecio2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // txtPrecio3
            // 
            this.txtPrecio3.Location = new System.Drawing.Point(1020, 50);
            this.txtPrecio3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio3.Name = "txtPrecio3";
            this.txtPrecio3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio3.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio3.Properties.Mask.EditMask = "f";
            this.txtPrecio3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio3.Properties.MaxLength = 6;
            this.txtPrecio3.Size = new System.Drawing.Size(117, 28);
            this.txtPrecio3.TabIndex = 4;
            this.txtPrecio3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 27);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "DESCRIPCION";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(1020, 26);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "PRECIO VENTA 3";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(634, 26);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(130, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "PRECIO COMPRA REAL";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(774, 26);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "PRECIO VENTA 1";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(897, 26);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(97, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "PRECIO VENTA 2";
            // 
            // lbContador
            // 
            this.lbContador.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContador.Appearance.Options.UseFont = true;
            this.lbContador.Location = new System.Drawing.Point(17, 84);
            this.lbContador.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbContador.Name = "lbContador";
            this.lbContador.Size = new System.Drawing.Size(76, 21);
            this.lbContador.TabIndex = 10;
            this.lbContador.Text = "000/000";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(1143, 26);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(115, 16);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "(PRECIO VENTA 4)";
            // 
            // txtPrecio4
            // 
            this.txtPrecio4.Location = new System.Drawing.Point(1143, 50);
            this.txtPrecio4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio4.Name = "txtPrecio4";
            this.txtPrecio4.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio4.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio4.Properties.Mask.EditMask = "f";
            this.txtPrecio4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPrecio4.Properties.MaxLength = 6;
            this.txtPrecio4.Size = new System.Drawing.Size(117, 28);
            this.txtPrecio4.TabIndex = 5;
            this.txtPrecio4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EndEdit_TextEdit);
            // 
            // XfProductEditQuick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 128);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtPrecio4);
            this.Controls.Add(this.lbContador);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtPrecio3);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.txtPrecioCompraReal);
            this.Controls.Add(this.txtNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XfProductEditQuick";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion Rapida";
            this.Load += new System.EventHandler(this.xfProductoEditRapida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompraReal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtPrecioCompraReal;
        private DevExpress.XtraEditors.TextEdit txtPrecio1;
        private DevExpress.XtraEditors.TextEdit txtPrecio2;
        private DevExpress.XtraEditors.TextEdit txtPrecio3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl lbContador;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtPrecio4;
    }
}