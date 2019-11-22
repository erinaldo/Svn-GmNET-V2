namespace Gm.NET.Formularios.Accesos
{
    partial class SplashScreenWelcome
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lbBienvenido = new DevExpress.XtraEditors.LabelControl();
            this.lbmensaje = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 279);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 24);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Loading";
            // 
            // lbBienvenido
            // 
            this.lbBienvenido.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenido.Appearance.Options.UseFont = true;
            this.lbBienvenido.Location = new System.Drawing.Point(46, 110);
            this.lbBienvenido.Margin = new System.Windows.Forms.Padding(4);
            this.lbBienvenido.Name = "lbBienvenido";
            this.lbBienvenido.Size = new System.Drawing.Size(206, 47);
            this.lbBienvenido.TabIndex = 8;
            this.lbBienvenido.Text = "Bienvenido";
            // 
            // lbmensaje
            // 
            this.lbmensaje.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmensaje.Appearance.Options.UseFont = true;
            this.lbmensaje.Appearance.Options.UseTextOptions = true;
            this.lbmensaje.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lbmensaje.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbmensaje.Location = new System.Drawing.Point(46, 180);
            this.lbmensaje.Margin = new System.Windows.Forms.Padding(4);
            this.lbmensaje.Name = "lbmensaje";
            this.lbmensaje.Size = new System.Drawing.Size(768, 68);
            this.lbmensaje.TabIndex = 9;
            this.lbmensaje.Text = "Roberto Rivelino Guaján Lema";
            // 
            // timer1
            // 
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SplashScreenWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 425);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lbBienvenido);
            this.Controls.Add(this.lbmensaje);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SplashScreenWelcome";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SplashScreenWelcome_FormClosing);
            this.Load += new System.EventHandler(this.SplashScreenWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbBienvenido;
        private DevExpress.XtraEditors.LabelControl lbmensaje;
        private System.Windows.Forms.Timer timer1;
    }
}
