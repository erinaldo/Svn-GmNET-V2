namespace Gm.NET
{
    partial class XfPermisosyUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfPermisosyUsuarios));
            this.gridCUsuarios = new DevExpress.XtraGrid.GridControl();
            this.gridVUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.pCAriba = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEstado1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.miAccesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.btnAplicar = new DevExpress.XtraEditors.SimpleButton();
            this.pCAbajo = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.chEstado = new DevExpress.XtraEditors.CheckEdit();
            this.txtPasword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pCBotones = new DevExpress.XtraEditors.PanelControl();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.btnActivarTodo = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridCUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCAriba)).BeginInit();
            this.pCAriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miAccesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCAbajo)).BeginInit();
            this.pCAbajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBotones)).BeginInit();
            this.pCBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCUsuarios
            // 
            this.gridCUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCUsuarios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCUsuarios.Location = new System.Drawing.Point(0, 0);
            this.gridCUsuarios.MainView = this.gridVUsuarios;
            this.gridCUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridCUsuarios.Name = "gridCUsuarios";
            this.gridCUsuarios.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridCUsuarios.Size = new System.Drawing.Size(761, 325);
            this.gridCUsuarios.TabIndex = 7;
            this.gridCUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridVUsuarios});
            // 
            // gridVUsuarios
            // 
            this.gridVUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDUsuario,
            this.colNombre,
            this.colCedula,
            this.colLogin,
            this.colPasword,
            this.colEstado,
            this.colAcceso});
            this.gridVUsuarios.GridControl = this.gridCUsuarios;
            this.gridVUsuarios.Name = "gridVUsuarios";
            this.gridVUsuarios.OptionsBehavior.Editable = false;
            this.gridVUsuarios.OptionsView.ShowAutoFilterRow = true;
            this.gridVUsuarios.OptionsView.ShowGroupPanel = false;
            this.gridVUsuarios.ViewCaption = "USUARIOS";
            this.gridVUsuarios.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridVUsuarios_RowCellClick);
            this.gridVUsuarios.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridVUsuarios_FocusedRowChanged);
            // 
            // colIDUsuario
            // 
            this.colIDUsuario.FieldName = "IDUsuario";
            this.colIDUsuario.Name = "colIDUsuario";
            this.colIDUsuario.Width = 74;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 166;
            // 
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 1;
            this.colCedula.Width = 88;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 2;
            this.colLogin.Width = 109;
            // 
            // colPasword
            // 
            this.colPasword.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPasword.FieldName = "Pasword";
            this.colPasword.Name = "colPasword";
            this.colPasword.Visible = true;
            this.colPasword.VisibleIndex = 3;
            this.colPasword.Width = 107;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.PasswordChar = '.';
            this.repositoryItemTextEdit1.UseSystemPasswordChar = true;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 49;
            // 
            // colAcceso
            // 
            this.colAcceso.FieldName = "Acceso";
            this.colAcceso.Name = "colAcceso";
            this.colAcceso.Width = 81;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(121, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pCAriba
            // 
            this.pCAriba.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCAriba.Controls.Add(this.gridCUsuarios);
            this.pCAriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCAriba.Location = new System.Drawing.Point(0, 0);
            this.pCAriba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCAriba.Name = "pCAriba";
            this.pCAriba.Size = new System.Drawing.Size(761, 325);
            this.pCAriba.TabIndex = 11;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 325);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(761, 15);
            this.splitterControl1.TabIndex = 10;
            this.splitterControl1.TabStop = false;
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataSource = typeof(Gm.Entities.Modulos);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.btnActivarTodo);
            this.sidePanel1.Controls.Add(this.treeList1);
            this.sidePanel1.Controls.Add(this.textEdit1);
            this.sidePanel1.Controls.Add(this.btnAplicar);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(761, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(417, 340);
            this.sidePanel1.TabIndex = 12;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // treeList1
            // 
            this.treeList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescripcion,
            this.colEstado1});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.miAccesoBindingSource;
            this.treeList1.Location = new System.Drawing.Point(13, 81);
            this.treeList1.Name = "treeList1";
            this.treeList1.ParentFieldName = "IDParent";
            this.treeList1.Size = new System.Drawing.Size(388, 251);
            this.treeList1.TabIndex = 10;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 289;
            // 
            // colEstado1
            // 
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.Visible = true;
            this.colEstado1.VisibleIndex = 1;
            this.colEstado1.Width = 76;
            // 
            // miAccesoBindingSource
            // 
            this.miAccesoBindingSource.DataSource = typeof(Gm.Core.MiAcceso);
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(15, 9);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(386, 28);
            this.textEdit1.TabIndex = 9;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(125, 44);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(135, 30);
            this.btnAplicar.TabIndex = 8;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // pCAbajo
            // 
            this.pCAbajo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCAbajo.Controls.Add(this.xtraTabControl1);
            this.pCAbajo.Controls.Add(this.pCBotones);
            this.pCAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCAbajo.Location = new System.Drawing.Point(0, 340);
            this.pCAbajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCAbajo.Name = "pCAbajo";
            this.pCAbajo.Size = new System.Drawing.Size(1178, 282);
            this.pCAbajo.TabIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1178, 234);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.chEstado);
            this.xtraTabPage1.Controls.Add(this.txtPasword);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.txtLogin);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.txtCedula);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.txtNombre);
            this.xtraTabPage1.Controls.Add(this.txtID);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1176, 204);
            this.xtraTabPage1.Text = "Usuario";
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(84, 94);
            this.chEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chEstado.Name = "chEstado";
            this.chEstado.Properties.Caption = "Estado";
            this.chEstado.Size = new System.Drawing.Size(90, 20);
            this.chEstado.TabIndex = 10;
            // 
            // txtPasword
            // 
            this.txtPasword.Location = new System.Drawing.Point(572, 62);
            this.txtPasword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasword.Name = "txtPasword";
            this.txtPasword.Properties.MaxLength = 10;
            this.txtPasword.Properties.PasswordChar = '.';
            this.txtPasword.Properties.UseSystemPasswordChar = true;
            this.txtPasword.Size = new System.Drawing.Size(211, 22);
            this.txtPasword.TabIndex = 9;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(512, 65);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Pasword:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(572, 30);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Properties.MaxLength = 10;
            this.txtLogin.Size = new System.Drawing.Size(211, 22);
            this.txtLogin.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(512, 33);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 16);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Login:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(84, 62);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Properties.MaxLength = 13;
            this.txtCedula.Size = new System.Drawing.Size(166, 22);
            this.txtCedula.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 16);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Cedula:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(159, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Properties.MaxLength = 50;
            this.txtNombre.Size = new System.Drawing.Size(299, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 30);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Properties.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(68, 22);
            this.txtID.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 33);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Nombre:";
            // 
            // pCBotones
            // 
            this.pCBotones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCBotones.Controls.Add(this.btnCancelar);
            this.pCBotones.Controls.Add(this.btnGrabar);
            this.pCBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCBotones.Location = new System.Drawing.Point(0, 234);
            this.pCBotones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCBotones.Name = "pCBotones";
            this.pCBotones.Size = new System.Drawing.Size(1178, 48);
            this.pCBotones.TabIndex = 0;
            // 
            // btnGrabar
            // 
            this.btnGrabar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGrabar.ImageOptions.Image")));
            this.btnGrabar.Location = new System.Drawing.Point(17, 10);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(97, 30);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // dockManager1
            // 
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
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"});
            // 
            // btnActivarTodo
            // 
            this.btnActivarTodo.Location = new System.Drawing.Point(266, 44);
            this.btnActivarTodo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActivarTodo.Name = "btnActivarTodo";
            this.btnActivarTodo.Size = new System.Drawing.Size(135, 30);
            this.btnActivarTodo.TabIndex = 11;
            this.btnActivarTodo.Text = "Activar Todo";
            this.btnActivarTodo.Click += new System.EventHandler(this.btnActivarTodo_Click);
            // 
            // XfPermisosyUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 622);
            this.Controls.Add(this.pCAriba);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.pCAbajo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XfPermisosyUsuarios";
            this.Text = "Permisos & Usuarios";
            this.Load += new System.EventHandler(this.XfPermisosyUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCAriba)).EndInit();
            this.pCAriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miAccesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCAbajo)).EndInit();
            this.pCAbajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBotones)).EndInit();
            this.pCBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridCUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridVUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colIDUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colPasword;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceso;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.PanelControl pCAriba;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEstado1;
        private System.Windows.Forms.BindingSource miAccesoBindingSource;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton btnAplicar;
        private DevExpress.XtraEditors.PanelControl pCAbajo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.CheckEdit chEstado;
        private DevExpress.XtraEditors.TextEdit txtPasword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pCBotones;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.SimpleButton btnActivarTodo;
    }
}