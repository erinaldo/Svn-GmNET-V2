namespace Gm.NET.Herramientas
{
    partial class XfParametrizacionFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfParametrizacionFactura));
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSecuencial = new DevExpress.XtraEditors.TextEdit();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNuevoIva = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNuevoSecuencial = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnImportar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorrar = new DevExpress.XtraEditors.SimpleButton();
            this.pEFoto = new DevExpress.XtraEditors.PictureEdit();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoSecuencial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pEFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(469, 360);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 30);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(366, 360);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(97, 30);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Aplicar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(35, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(181, 16);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "SECUENCIAL FACTURA ACTUAL";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(35, 154);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(161, 16);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "PROCENTAJE I.V.A. ACTUAL";
            // 
            // txtSecuencial
            // 
            this.txtSecuencial.Enabled = false;
            this.txtSecuencial.Location = new System.Drawing.Point(35, 76);
            this.txtSecuencial.Name = "txtSecuencial";
            this.txtSecuencial.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencial.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtSecuencial.Properties.Appearance.Options.UseFont = true;
            this.txtSecuencial.Properties.Appearance.Options.UseForeColor = true;
            this.txtSecuencial.Properties.Mask.EditMask = "f0";
            this.txtSecuencial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSecuencial.Properties.MaxLength = 5;
            this.txtSecuencial.Size = new System.Drawing.Size(181, 22);
            this.txtSecuencial.TabIndex = 11;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(35, 176);
            this.txtIva.Name = "txtIva";
            this.txtIva.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtIva.Properties.Appearance.Options.UseFont = true;
            this.txtIva.Properties.Appearance.Options.UseForeColor = true;
            this.txtIva.Properties.Mask.EditMask = "d";
            this.txtIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIva.Properties.MaxLength = 2;
            this.txtIva.Size = new System.Drawing.Size(181, 22);
            this.txtIva.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtNuevoIva);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtNuevoSecuencial);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtIva);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtSecuencial);
            this.groupControl1.Location = new System.Drawing.Point(39, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 303);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Parametros";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(175, 16);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "NUEVO SECUENCIAL FACTURA";
            // 
            // txtNuevoIva
            // 
            this.txtNuevoIva.Location = new System.Drawing.Point(35, 226);
            this.txtNuevoIva.Name = "txtNuevoIva";
            this.txtNuevoIva.Properties.Mask.EditMask = "d";
            this.txtNuevoIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNuevoIva.Properties.MaxLength = 2;
            this.txtNuevoIva.Size = new System.Drawing.Size(181, 22);
            this.txtNuevoIva.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(35, 204);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(155, 16);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "NUEVO PROCENTAJE I.V.A.";
            // 
            // txtNuevoSecuencial
            // 
            this.txtNuevoSecuencial.Location = new System.Drawing.Point(35, 126);
            this.txtNuevoSecuencial.Name = "txtNuevoSecuencial";
            this.txtNuevoSecuencial.Properties.Mask.EditMask = "f0";
            this.txtNuevoSecuencial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNuevoSecuencial.Properties.MaxLength = 5;
            this.txtNuevoSecuencial.Size = new System.Drawing.Size(181, 22);
            this.txtNuevoSecuencial.TabIndex = 15;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnImportar);
            this.groupControl2.Controls.Add(this.btnBorrar);
            this.groupControl2.Controls.Add(this.pEFoto);
            this.groupControl2.Location = new System.Drawing.Point(311, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(255, 303);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Foto";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(147, 245);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(94, 29);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Importar";
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(15, 245);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 29);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // pEFoto
            // 
            this.pEFoto.Location = new System.Drawing.Point(15, 29);
            this.pEFoto.Name = "pEFoto";
            this.pEFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pEFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pEFoto.Size = new System.Drawing.Size(226, 200);
            this.pEFoto.TabIndex = 0;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataSource = typeof(Gm.Entities.Modulos);
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(39, 321);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(527, 22);
            this.progressBarControl1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // XfParametrizacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 403);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGrabar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfParametrizacionFactura";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametrizacion Inicial";
            this.Load += new System.EventHandler(this.xfAccesoUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSecuencial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNuevoSecuencial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pEFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSecuencial;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtNuevoIva;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNuevoSecuencial;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnImportar;
        private DevExpress.XtraEditors.SimpleButton btnBorrar;
        private DevExpress.XtraEditors.PictureEdit pEFoto;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}