namespace MMercadoAPU
{
    partial class XtraFormPrincipal
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
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton3 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton4 = new DevExpress.XtraBars.Navigation.NavButton();
            this.navButton5 = new DevExpress.XtraBars.Navigation.NavButton();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.xuUsuariosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.xuUsuariosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tileContainer1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.xuGruposDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.xuGruposTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.xuModulosDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.xuModulosTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.xuTerminalDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.xuTerminalTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalTile)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.navButton3);
            this.tileNavPane1.Buttons.Add(this.navButton4);
            this.tileNavPane1.Buttons.Add(this.navButton5);
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPane1.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(746, 40);
            this.tileNavPane1.TabIndex = 2;
            this.tileNavPane1.Text = "tileNavPane1";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Guajan.com";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // navButton3
            // 
            this.navButton3.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton3.Caption = "Acerca de";
            this.navButton3.Name = "navButton3";
            // 
            // navButton4
            // 
            this.navButton4.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton4.Caption = "Login";
            this.navButton4.Name = "navButton4";
            // 
            // navButton5
            // 
            this.navButton5.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navButton5.Caption = "Salir";
            this.navButton5.Name = "navButton5";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.xuUsuariosDocument,
            this.xuGruposDocument,
            this.xuModulosDocument,
            this.xuTerminalDocument});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.xuUsuariosTile,
            this.xuGruposTile,
            this.xuModulosTile,
            this.xuTerminalTile});
            // 
            // xuUsuariosDocument
            // 
            this.xuUsuariosDocument.Caption = "xuUsuarios";
            this.xuUsuariosDocument.ControlName = "xuUsuarios";
            this.xuUsuariosDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuUsuarios";
            // 
            // xuUsuariosTile
            // 
            this.xuUsuariosTile.Document = this.xuUsuariosDocument;
            this.xuUsuariosTile.Name = "xuUsuariosTile";
            // 
            // tileContainer1
            // 
            this.tileContainer1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.xuUsuariosTile,
            this.xuGruposTile,
            this.xuModulosTile,
            this.xuTerminalTile});
            this.tileContainer1.Name = "tileContainer1";
            // 
            // xuGruposDocument
            // 
            this.xuGruposDocument.Caption = "xuGrupos";
            this.xuGruposDocument.ControlName = "xuGrupos";
            this.xuGruposDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuGrupos";
            // 
            // xuGruposTile
            // 
            this.xuGruposTile.Document = this.xuGruposDocument;
            this.tileContainer1.SetID(this.xuGruposTile, 1);
            this.xuGruposTile.Name = "xuGruposTile";
            // 
            // xuModulosDocument
            // 
            this.xuModulosDocument.Caption = "xuModulos";
            this.xuModulosDocument.ControlName = "xuModulos";
            this.xuModulosDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuModulos";
            // 
            // xuModulosTile
            // 
            this.xuModulosTile.Document = this.xuModulosDocument;
            this.tileContainer1.SetID(this.xuModulosTile, 2);
            this.xuModulosTile.Name = "xuModulosTile";
            // 
            // xuTerminalDocument
            // 
            this.xuTerminalDocument.Caption = "xuTerminal";
            this.xuTerminalDocument.ControlName = "xuTerminal";
            this.xuTerminalDocument.ControlTypeName = "MMercadoAPU.Herramientas.xuTerminal";
            // 
            // xuTerminalTile
            // 
            this.xuTerminalTile.Document = this.xuTerminalDocument;
            this.tileContainer1.SetID(this.xuTerminalTile, 3);
            this.xuTerminalTile.Name = "xuTerminalTile";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // XtraFormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 443);
            this.Controls.Add(this.tileNavPane1);
            this.Name = "XtraFormPrincipal";
            this.Text = "XtraFormPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuUsuariosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuGruposTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuModulosTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xuTerminalTile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.NavButton navButton3;
        private DevExpress.XtraBars.Navigation.NavButton navButton4;
        private DevExpress.XtraBars.Navigation.NavButton navButton5;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuUsuariosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuUsuariosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuGruposTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuGruposDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuModulosTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuModulosDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile xuTerminalTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document xuTerminalDocument;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}