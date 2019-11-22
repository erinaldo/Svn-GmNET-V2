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
using Gm.Core;
using Gm.Entities;

namespace Gm.NET.Herramientas
{
    public partial class XuTerminal : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        public event Enviar unEvento;

        public static XuTerminal xu = new XuTerminal();

        Terminal item;
        public XuTerminal()
        {
            InitializeComponent();
        }

        private void xuTerminal_Load(object sender, EventArgs e)
        {
            Mostrar();
            btnNuevo.Enabled = ClaseAcceso.ComputadorasNuevo_;
            btnEditar.Enabled = ClaseAcceso.ComputadorasEditar_;
            btnEliminar.Enabled = ClaseAcceso.ComputadorasEliminar_;
        }
        private void Mostrar()
        {
            var resp = new TerminalBLL();
            gridControl1.DataSource = resp.Mostar;
            Cancel();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            item = null;

            pCAbajo.Visible = true;
            splitterControl1.Visible = true;
            txtTerminal.EditValue = null;
            txtMac.EditValue = null;
            txtMaquina.EditValue = null;
            txtOficina.EditValue = null;
            chEstado.EditValue = null;
           
        }
        void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
            gridView1.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;

            item = gridView1.GetRow(gridView1.FocusedRowHandle) as Terminal;

            txtTerminal.EditValue = item.IDTerminal;
            txtMac.EditValue = item.Mac;
            txtMaquina.EditValue = item.Maquina;
            txtOficina.EditValue = item.Oficina;
            chEstado.Checked = (item.Estado == "A") ? true : false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMac.Text) || string.IsNullOrEmpty(txtMaquina.Text))
            {
                XtraMessageBox.Show("Hay campos vacios");
            }
            else
            {
                var metodo = new TerminalBLL();
                bool Resul = true;
                if (item == null)
                {
                    if (!metodo.Save(new Terminal
                    {
                        Mac = txtMac.Text,
                        Maquina = txtMaquina.Text,
                        Oficina = string.IsNullOrEmpty(txtOficina.Text) ? "XXXX" : txtOficina.Text,
                        Estado = chEstado.Checked ? "A" : "E"
                    }))
                        Resul = false;
                }
                else
                {
                    item.Mac = txtMac.Text;
                    item.Maquina = txtMaquina.Text;
                    item.Oficina = string.IsNullOrEmpty(txtOficina.Text) ? "XXXX" : txtOficina.Text;
                    item.Estado = chEstado.Checked ? "A" : "E";
                    if (!metodo.Update(item))
                        Resul = false;
                }

                if (!Resul)
                    XtraMessageBox.Show(metodo.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    Mostrar();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            item = gridView1.GetRow(gridView1.FocusedRowHandle) as Terminal;
            var resp = new TerminalBLL();
            if (resp.Delete(item))
            {
                XtraMessageBox.Show("Engraving done successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrar();
            }
            else
                XtraMessageBox.Show(resp.error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
