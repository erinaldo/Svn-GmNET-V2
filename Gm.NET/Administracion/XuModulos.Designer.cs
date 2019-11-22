namespace Gm.NET.Herramientas
{
    partial class XuModulos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XuModulos));
            this.pCMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnActualizar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chEstado = new DevExpress.XtraEditors.CheckEdit();
            this.txtHijo = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtRaiz = new DevExpress.XtraEditors.TextEdit();
            this.pCBotones = new DevExpress.XtraEditors.PanelControl();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGrabar = new DevExpress.XtraEditors.SimpleButton();
            this.pCAbajo = new DevExpress.XtraEditors.PanelControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pCArriba = new DevExpress.XtraEditors.PanelControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEstado1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.miAccesoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pCMenu)).BeginInit();
            this.pCMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHijo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaiz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBotones)).BeginInit();
            this.pCBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCAbajo)).BeginInit();
            this.pCAbajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCArriba)).BeginInit();
            this.pCArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miAccesoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pCMenu
            // 
            this.pCMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCMenu.Controls.Add(this.btnActualizar);
            this.pCMenu.Controls.Add(this.btnEliminar);
            this.pCMenu.Controls.Add(this.btnEditar);
            this.pCMenu.Controls.Add(this.btnNuevo);
            this.pCMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCMenu.Location = new System.Drawing.Point(0, 0);
            this.pCMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCMenu.Name = "pCMenu";
            this.pCMenu.Size = new System.Drawing.Size(982, 44);
            this.pCMenu.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.ImageOptions.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(328, 7);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 30);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(225, 8);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(122, 8);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 30);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(19, 8);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 30);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(982, 220);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.chEstado);
            this.xtraTabPage1.Controls.Add(this.txtHijo);
            this.xtraTabPage1.Controls.Add(this.txtNombre);
            this.xtraTabPage1.Controls.Add(this.txtRaiz);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(980, 190);
            this.xtraTabPage1.Text = "Modulo";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 90);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 16);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "MODULO:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(45, 58);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 16);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "HIJO:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(45, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 16);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "RAIZ:";
            // 
            // chEstado
            // 
            this.chEstado.Location = new System.Drawing.Point(126, 114);
            this.chEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chEstado.Name = "chEstado";
            this.chEstado.Properties.Caption = "Estado";
            this.chEstado.Size = new System.Drawing.Size(86, 20);
            this.chEstado.TabIndex = 3;
            // 
            // txtHijo
            // 
            this.txtHijo.Enabled = false;
            this.txtHijo.Location = new System.Drawing.Point(126, 55);
            this.txtHijo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHijo.Name = "txtHijo";
            this.txtHijo.Size = new System.Drawing.Size(69, 22);
            this.txtHijo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtRaiz
            // 
            this.txtRaiz.Enabled = false;
            this.txtRaiz.Location = new System.Drawing.Point(126, 25);
            this.txtRaiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(69, 22);
            this.txtRaiz.TabIndex = 0;
            // 
            // pCBotones
            // 
            this.pCBotones.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCBotones.Controls.Add(this.btnCancelar);
            this.pCBotones.Controls.Add(this.btnGrabar);
            this.pCBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCBotones.Location = new System.Drawing.Point(0, 220);
            this.pCBotones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCBotones.Name = "pCBotones";
            this.pCBotones.Size = new System.Drawing.Size(982, 48);
            this.pCBotones.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(120, 10);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // pCAbajo
            // 
            this.pCAbajo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCAbajo.Controls.Add(this.xtraTabControl1);
            this.pCAbajo.Controls.Add(this.pCBotones);
            this.pCAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCAbajo.Location = new System.Drawing.Point(0, 307);
            this.pCAbajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCAbajo.Name = "pCAbajo";
            this.pCAbajo.Size = new System.Drawing.Size(982, 268);
            this.pCAbajo.TabIndex = 7;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 292);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(982, 15);
            this.splitterControl1.TabIndex = 8;
            this.splitterControl1.TabStop = false;
            // 
            // pCArriba
            // 
            this.pCArriba.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pCArriba.Controls.Add(this.treeList1);
            this.pCArriba.Controls.Add(this.pCMenu);
            this.pCArriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCArriba.Location = new System.Drawing.Point(0, 0);
            this.pCArriba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pCArriba.Name = "pCArriba";
            this.pCArriba.Size = new System.Drawing.Size(982, 292);
            this.pCArriba.TabIndex = 9;
            // 
            // treeList1
            // 
            this.treeList1.Caption = "MODULOS";
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescripcion,
            this.colEstado1});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.miAccesoBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList1.Location = new System.Drawing.Point(0, 44);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowCaption = true;
            this.treeList1.ParentFieldName = "IDParent";
            this.treeList1.Size = new System.Drawing.Size(801, 248);
            this.treeList1.TabIndex = 6;
            this.treeList1.RowClick += new DevExpress.XtraTreeList.RowClickEventHandler(this.treeList1_RowClick);
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDescripcion.AppearanceCell.Options.UseFont = true;
            this.colDescripcion.Caption = "MODULOS";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 676;
            // 
            // colEstado1
            // 
            this.colEstado1.Caption = "ESTADO";
            this.colEstado1.FieldName = "Estado";
            this.colEstado1.Name = "colEstado1";
            this.colEstado1.Visible = true;
            this.colEstado1.VisibleIndex = 1;
            this.colEstado1.Width = 70;
            // 
            // miAccesoBindingSource
            // 
            this.miAccesoBindingSource.DataSource = typeof(Gm.Core.MiAcceso);
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataSource = typeof(Gm.Entities.Modulos);
            // 
            // XuModulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pCArriba);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.pCAbajo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XuModulos";
            this.Size = new System.Drawing.Size(982, 575);
            this.Load += new System.EventHandler(this.xuModulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCMenu)).EndInit();
            this.pCMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHijo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRaiz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBotones)).EndInit();
            this.pCBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCAbajo)).EndInit();
            this.pCAbajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pCArriba)).EndInit();
            this.pCArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miAccesoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pCMenu;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PanelControl pCBotones;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGrabar;
        private DevExpress.XtraEditors.CheckEdit chEstado;
        private DevExpress.XtraEditors.TextEdit txtHijo;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtRaiz;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl pCAbajo;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl pCArriba;
        private DevExpress.XtraEditors.SimpleButton btnActualizar;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEstado1;
        private System.Windows.Forms.BindingSource miAccesoBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
