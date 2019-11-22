namespace Gm.NET
{
    partial class XfConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfConfiguracion));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xuTerminal1 = new Gm.NET.Herramientas.XuTerminal();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.xuGrupos1 = new Gm.NET.Herramientas.XuGrupos();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xuMedidas1 = new Gm.NET.Herramientas.XuMedidas();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xuMarcas1 = new Gm.NET.Herramientas.XuMarcas();
            this.xuModulos1 = new Gm.NET.Herramientas.XuModulos();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1275, 651);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.xuModulos1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1245, 649);
            this.xtraTabPage1.Text = "MODULOS";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.xuTerminal1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1245, 649);
            this.xtraTabPage2.Text = "TERMINALES";
            // 
            // xuTerminal1
            // 
            this.xuTerminal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuTerminal1.Location = new System.Drawing.Point(0, 0);
            this.xuTerminal1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xuTerminal1.Name = "xuTerminal1";
            this.xuTerminal1.Size = new System.Drawing.Size(1245, 649);
            this.xuTerminal1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.xuGrupos1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1245, 649);
            this.xtraTabPage3.Text = "CATEGORIAS";
            // 
            // xuGrupos1
            // 
            this.xuGrupos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuGrupos1.Location = new System.Drawing.Point(0, 0);
            this.xuGrupos1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xuGrupos1.Name = "xuGrupos1";
            this.xuGrupos1.Size = new System.Drawing.Size(1245, 649);
            this.xuGrupos1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.xuMedidas1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(1245, 649);
            this.xtraTabPage4.Text = "UNIDADES DE MEDIDA";
            // 
            // xuMedidas1
            // 
            this.xuMedidas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuMedidas1.Location = new System.Drawing.Point(0, 0);
            this.xuMedidas1.Name = "xuMedidas1";
            this.xuMedidas1.Size = new System.Drawing.Size(1245, 649);
            this.xuMedidas1.TabIndex = 0;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.xuMarcas1);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(1245, 649);
            this.xtraTabPage5.Text = "MARCAS";
            // 
            // xuMarcas1
            // 
            this.xuMarcas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuMarcas1.Location = new System.Drawing.Point(0, 0);
            this.xuMarcas1.Name = "xuMarcas1";
            this.xuMarcas1.Size = new System.Drawing.Size(1245, 649);
            this.xuMarcas1.TabIndex = 0;
            // 
            // xuTerminal2
            // 
            this.xuModulos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuModulos1.Location = new System.Drawing.Point(0, 0);
            this.xuModulos1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xuModulos1.Name = "xuModulos1";
            this.xuModulos1.Size = new System.Drawing.Size(1245, 649);
            this.xuModulos1.TabIndex = 0;
            // 
            // XfConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 651);
            this.Controls.Add(this.xtraTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XfConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.xfConfiguracion_Load);
            this.SizeChanged += new System.EventHandler(this.xfConfiguracion_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private Herramientas.XuTerminal xuTerminal1;
        private Herramientas.XuGrupos xuGrupos1;
        private Herramientas.XuMedidas xuMedidas1;
        private Herramientas.XuMarcas xuMarcas1;
        //private Herramientas.XuTerminal xuTerminal2;

        private Herramientas.XuModulos xuModulos1;
        //private Herramientas.XuTerminal xuTerminal1;
        //private Herramientas.XuMedidas xuMedidas1;
        //private Herramientas.XuMarcas xuMarcas1;
    }
}