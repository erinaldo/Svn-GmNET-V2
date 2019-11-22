namespace Gm.NET
{
    partial class xfMessageThankYou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xfMessageThankYou));
            this.lbTexto = new DevExpress.XtraEditors.LabelControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTexto
            // 
            this.lbTexto.Appearance.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTexto.Appearance.Options.UseFont = true;
            this.lbTexto.Appearance.Options.UseTextOptions = true;
            this.lbTexto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbTexto.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbTexto.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbTexto.Location = new System.Drawing.Point(91, 150);
            this.lbTexto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(742, 278);
            this.lbTexto.TabIndex = 0;
            this.lbTexto.Text = "Gracias por su\r\nCompra";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOk.Location = new System.Drawing.Point(365, 31);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(168, 63);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Continuar";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("buy_32x32.png", "devav/actions/buy_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/buy_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "buy_32x32.png");
            this.imageCollection1.InsertGalleryImage("sales_32x32.png", "devav/view/sales_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/view/sales_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "sales_32x32.png");
            // 
            // sidePanel1
            // 
            this.sidePanel1.Appearance.BackColor = System.Drawing.Color.White;
            this.sidePanel1.Appearance.Options.UseBackColor = true;
            this.sidePanel1.Controls.Add(this.btnOk);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sidePanel1.Location = new System.Drawing.Point(0, 493);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(927, 127);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // xfMessageThankYou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 620);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.lbTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "xfMessageThankYou";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.xfMessageThankYou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTexto;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
    }
}