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
    public partial class XfComprasProveedorEditar : DevExpress.XtraEditors.XtraForm
    {
        public Cliente cliente_;
        private Repository<Cliente> repository;

        public XfComprasProveedorEditar()
        {
            InitializeComponent();
        }

        private void xfClienteNew_Load(object sender, EventArgs e)
        {
            repository = new Repository<Cliente>();
            
            cliente_ = repository.Find(x => x.IDCliente == cliente_.IDCliente);

            txtID.EditValue = cliente_.IDCliente;
            txtNombre.Text = cliente_.Nombre;
            txtCedula.Text = cliente_.Cedula;
            txtDireccion.Text = cliente_.Direccion;
            txtTelefono.Text = cliente_.Telefono;
            txtCorreo.Text = cliente_.Correo;
            chEstado.Checked = cliente_.Estado == "A"? true : false;
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                cliente_.Nombre = txtNombre.Text;
                cliente_.Cedula = txtCedula.Text;
                cliente_.Direccion = txtDireccion.Text;
                cliente_.Telefono = txtTelefono.Text;
                cliente_.Correo = txtCorreo.Text;
                cliente_.Estado = chEstado.Checked ? "A" : "E";

                if (!repository.Update(cliente_))
                {
                    this.Hide();
                    XtraMessageBox.Show(repository.Error);
                    this.Visible = true;
                }
                else
                {
                    Close();
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}