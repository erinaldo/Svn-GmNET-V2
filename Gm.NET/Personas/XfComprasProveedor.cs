using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using Gm.Core;
using Gm.Entities;
using Gm.Data;

namespace Gm.NET.Formularios
{
    public partial class XfComprasProveedor : DevExpress.XtraEditors.XtraForm
    {
        public Cliente cliente;
        private Repository<Cliente> repository;

        public XfComprasProveedor()
        {
            InitializeComponent();
        }

        private void xfClienteNew_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();

            repository = new Repository<Cliente>();
            var resp = repository.GetAll();
            int row = 0;
            if (resp == null)
                row = 1;
            else
                row = resp.Count + 1;

            txtID.EditValue = row;
            cliente.IDCliente = row;
            chEstado.CheckState = CheckState.Checked;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtCedula.Text))
            {
                cliente.Nombre = txtNombre.Text;
                cliente.Cedula = txtCedula.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;
                cliente.Correo = txtCorreo.Text;
                cliente.Estado = chEstado.Checked ? "A" : "E";
                cliente.Tipo = "P";

                if (repository.Create(cliente) == null)
                {
                    this.Hide();
                    XtraMessageBox.Show(repository.Error);
                    this.Visible = true;
                }
                else
                    Close();
            }
            else
                XtraMessageBox.Show("Existen campos vacios por favor, reviselos");

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}