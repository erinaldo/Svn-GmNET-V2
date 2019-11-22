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
    public partial class XuMedidas : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        public event Enviar unEvento;

        public static XuMedidas xu = new XuMedidas();

        private MedidaMetricaCore method;
        public XuMedidas()
        {
            InitializeComponent();
        }
        void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
        }
        void function()
        {
            method = new MedidaMetricaCore();
            gridControl1.DataSource = method.Lista;
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
            MedidaMetrica row = gridView1.GetRow(gridView1.FocusedRowHandle) as MedidaMetrica;
            txtID.EditValue = row.IdMedidaMetrica;
            txtNombre.EditValue = row.Name;
            chEstado.EditValue = row.State;
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MedidaMetrica row = gridView1.GetRow(gridView1.FocusedRowHandle) as MedidaMetrica;
            row.State = false;
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
                if (method.Save(new MedidaMetrica
                {
                    Name = txtNombre.Text.ToUpper(),
                    State = true
                }))
                {
                    //XtraMessageBox.Show("Engraving done successfully", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    function();
                }
                else
                    XtraMessageBox.Show(method.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (method.Update(new MedidaMetrica
                {
                    IdMedidaMetrica = Convert.ToInt64(txtID.EditValue),
                    Name = txtNombre.Text,
                    State = chEstado.Checked
                }))
                {
                    //XtraMessageBox.Show("Updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
