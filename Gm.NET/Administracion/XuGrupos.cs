using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Gm.Entities;
using Gm.Core;
using Gm.Core.Generales;
using Gm.Data;

namespace Gm.NET.Herramientas
{
    public partial class XuGrupos : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        public event Enviar unEvento;

        public static XuGrupos xu = new XuGrupos();

        Grupo item;
        public XuGrupos()
        {
            InitializeComponent();
        }
        void function()
        {
            var resp = new Repository<Grupo>();
            gridControl1.DataSource = resp.GetAll();
            splitterControl1.Visible = false;
            pCAbajo.Visible = false;

            btnNuevo.Enabled = ClaseAcceso.CategoriaNuevo_;
            btnEditar.Enabled = ClaseAcceso.CategoriaEditar_;
            btnEliminar.Enabled = ClaseAcceso.CategoriaEliminar_;
        }
        

        private void xuGrupos_Load(object sender, EventArgs e)
        {
            function();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            item = null;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
            chEstado.EditValue = null;
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;

            item = gridView1.GetRow(gridView1.FocusedRowHandle) as Grupo;
            txtID.EditValue = item.IDGrupo;
            txtNombre.EditValue = item.Nombre;
            chEstado.EditValue = (item.Estado=="A") ? true : false;

            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                XtraMessageBox.Show(Mensajes.CamposVacios, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);            

            var metodo = new GrupoBLL();
            var Result = true;

            if (item == null)
            {
             if(!metodo.Grabar(
                 new Grupo
                 {
                     Nombre=txtNombre.Text,
                     Estado= (chEstado.Checked) ? "A" : "E",
                 }
                 ))
                    Result = false;
            }
            else
            {
                item.Nombre = txtNombre.Text;
                item.Estado = (chEstado.Checked) ? "A" : "E";

                if (!metodo.Update(item))
                    Result = false;
            }

            if (!Result)
                XtraMessageBox.Show(metodo.error, "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                function();
        }

        void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
            gridView1.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Grupo item = gridView1.GetRow(gridView1.FocusedRowHandle) as Grupo;
            var resp = new GrupoBLL();

            if (resp.Delete(item))
            {
                XtraMessageBox.Show("Engraving done successfully","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                function();
            }
            else
            {
                XtraMessageBox.Show(resp.error,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Cancel();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.unEvento();
        }
    }

}
