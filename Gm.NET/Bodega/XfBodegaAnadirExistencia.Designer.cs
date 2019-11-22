namespace Gm.NET
{
    partial class XfBodegaAnadirExistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfBodegaAnadirExistencia));
            this.txtExistenciaNueva = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardaryNuevo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaNueva.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExistenciaNueva
            // 
            this.txtExistenciaNueva.Location = new System.Drawing.Point(141, 95);
            this.txtExistenciaNueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExistenciaNueva.Name = "txtExistenciaNueva";
            this.txtExistenciaNueva.Properties.Mask.EditMask = "d";
            this.txtExistenciaNueva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtExistenciaNueva.Properties.MaxLength = 6;
            this.txtExistenciaNueva.Size = new System.Drawing.Size(188, 22);
            this.txtExistenciaNueva.TabIndex = 1;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(69, 71);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(129, 16);
            this.labelControl10.TabIndex = 34;
            this.labelControl10.Text = "AGREGAR EXISTENCIA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(335, 142);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 30);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardaryNuevo
            // 
            this.btnGuardaryNuevo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardaryNuevo.Location = new System.Drawing.Point(206, 142);
            this.btnGuardaryNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardaryNuevo.Name = "btnGuardaryNuevo";
            this.btnGuardaryNuevo.Size = new System.Drawing.Size(123, 30);
            this.btnGuardaryNuevo.TabIndex = 2;
            this.btnGuardaryNuevo.Text = "Guardar";
            this.btnGuardaryNuevo.Click += new System.EventHandler(this.btnGuardaryNuevo_Click);
            // 
            // XfBodegaAnadirExistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 194);
            this.ControlBox = false;
            this.Controls.Add(this.txtExistenciaNueva);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardaryNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfBodegaAnadirExistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anadir Existencia";
            this.Load += new System.EventHandler(this.XfBodegaAnadirExistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExistenciaNueva.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtExistenciaNueva;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnGuardaryNuevo;
    }
}