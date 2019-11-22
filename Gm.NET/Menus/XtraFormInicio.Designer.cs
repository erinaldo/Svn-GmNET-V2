namespace MMercadoAPU
{
    partial class XtraFormInicio
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
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.windowsUIView2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.xuUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tile2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainer2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.xuGruposDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tile3 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.xuModulosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tile4 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.xuTerminalDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.tile5 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile5)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView2;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView2});
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
            // windowsUIView2
            // 
            this.windowsUIView2.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer2});
            this.windowsUIView2.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.xuUsuariosDocument,
            this.xuGruposDocument,
            this.xuModulosDocument,
            this.xuTerminalDocument});
            this.windowsUIView2.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tile2,
            this.tile3,
            this.tile4,
            this.tile5});
            // 
            // xuUsuariosDocument
            // 
            this.xuUsuariosDocument.Caption = "xuUsuarios";
            this.xuUsuariosDocument.ControlName = "xuUsuarios";
            this.xuUsuariosDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuUsuarios";
            // 
            // tile2
            // 
            this.tile2.Document = this.xuUsuariosDocument;
            this.tile2.Name = "tile2";
            this.tile2.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // tileContainer2
            // 
            this.tileContainer2.Caption = "Menu";
            this.tileContainer2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.tile2,
            this.tile3,
            this.tile4,
            this.tile5});
            this.tileContainer2.Name = "tileContainer2";
            this.tileContainer2.Properties.ShowText = DevExpress.Utils.DefaultBoolean.False;
            // 
            // xuGruposDocument
            // 
            this.xuGruposDocument.Caption = "xuGrupos";
            this.xuGruposDocument.ControlName = "xuGrupos";
            this.xuGruposDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuGrupos";
            // 
            // tile3
            // 
            this.tile3.Document = this.xuGruposDocument;
            this.tileContainer2.SetID(this.tile3, 1);
            this.tile3.Name = "tile3";
            this.tile3.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // xuModulosDocument
            // 
            this.xuModulosDocument.Caption = "xuModulos";
            this.xuModulosDocument.ControlName = "xuModulos";
            this.xuModulosDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuModulos";
            // 
            // tile4
            // 
            this.tile4.Document = this.xuModulosDocument;
            this.tileContainer2.SetID(this.tile4, 2);
            this.tile4.Name = "tile4";
            this.tile4.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // xuTerminalDocument
            // 
            this.xuTerminalDocument.Caption = "xuTerminal";
            this.xuTerminalDocument.ControlName = "xuTerminal";
            this.xuTerminalDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuTerminal";
            // 
            // tile5
            // 
            this.tile5.Document = this.xuTerminalDocument;
            this.tileContainer2.SetID(this.tile5, 3);
            this.tile5.Name = "tile5";
            this.tile5.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            // 
            // XtraFormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 426);
            this.Name = "XtraFormInicio";
            this.Text = "XtraFormInicio";
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuUsuariosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuGruposTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuGruposDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuModulosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuModulosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuTerminalTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuTerminalDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile3;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile4;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile5;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}