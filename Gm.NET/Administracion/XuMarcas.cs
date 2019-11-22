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

using Gm.Data;
using Gm.Entities;
using Gm.Core;

namespace Gm.NET.Herramientas
{
    public partial class XuMarcas : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        public event Enviar unEvento;

        public static XuMarcas xu = new XuMarcas();

        private Repository<Marca> method;
        public XuMarcas()
        {
            InitializeComponent();
        }
        void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
            btnNuevo.Enabled = ClaseAcceso.MedidasNuevo_;
            btnEditar.Enabled = ClaseAcceso.MedidasEditar_;
            btnEliminar.Enabled = ClaseAcceso.MedidasEliminar_;
        }
        void function()
        {
            method = new Repository<Marca>();
            gridControl1.DataSource = method.GetAll();
            Cancel();
            
        }
        private void xuMedidas_Load(object sender, EventArgs e)
        {
            function();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            splitterControl1.Visible = true;
            pCAbajo.Visible = true;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
            chEstado.EditValue = null;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetRow(gridView1.FocusedRowHandle) as Marca;
            txtID.EditValue = row.IDMarca;
            txtNombre.EditValue = row.NombreMarca;
            chEstado.EditValue = row.Estado;
            //pCAbajo.Visible = true;
            splitterControl1.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var row = gridView1.GetRow(gridView1.FocusedRowHandle) as Marca;
            row.Estado = false;
            if (method.Update(row))
            {
                XtraMessageBox.Show("Engraving done successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                function();
            }
            else
                XtraMessageBox.Show(method.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                if (method.Create(new Marca
                {
                    IDMarca = method.GetAll().Count+1,
                    NombreMarca = txtNombre.Text.ToUpper(),
                    Estado = true
                })!=null)
                {
                    function();
                }
                else
                    XtraMessageBox.Show(method.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (method.Update(new Marca
                {
                    IDMarca = Convert.ToInt64(txtID.EditValue),
                    NombreMarca = txtNombre.Text,
                    Estado = chEstado.Checked
                }))
                {
                    function();
                }
                else
                    XtraMessageBox.Show(method.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
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
