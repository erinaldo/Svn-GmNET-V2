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
using Gm.Data;
using Gm.Entities;

namespace Gm.NET.Formularios
{
    public partial class xfVentaCliente : DevExpress.XtraEditors.XtraForm
    {
        public Cliente cliente;
        public string FacturaNumero;
        public DateTime fecha;

        public xfVentaCliente()
        {
            InitializeComponent();
        }
        private void xfVentaCliente_Load(object sender, EventArgs e)
        {
            var resp = new Repository<Parametros>().GetAll().First(x => x.Station==1);
            FacturaNumero = Convert.ToString(resp.NumFactura);
            txtFacturaNumero.EditValue = FacturaNumero;
            fecha = DateTime.Now;
            deFecha.EditValue = fecha;

            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            btnConfirmar.Enabled = false;
        }
        private void txtCedula_EditValueChanged(object sender, EventArgs e)
        {
            ValidarCedula();
        }
        void ValidarCedula()
        {
            if (!string.IsNullOrEmpty(txtCedula.Text) && txtCedula.Text.Length >= 10)
            {
                var resp = new Repository<Cliente>().Find(x => x.Cedula.Equals(txtCedula.Text));
                if (resp != null)
                {
                    cliente = resp;
                    txtNombre.EditValue = resp.Nombre;
                    txtDireccion.EditValue = resp.Direccion;
                    txtTelefono.EditValue = resp.Telefono;
                    txtFacturaNumero.Focus();
                }
                else
                {
                    txtNombre.Enabled = true;
                    txtDireccion.Enabled = true;
                    txtTelefono.Enabled = true;
                    txtNombre.Focus();
                }
                btnConfirmar.Enabled = true;
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtTelefono.Enabled = false;
            }
        }
        void Textos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var resp = sender as TextEdit;
                switch (resp.Name.ToString())
                {
                    case "txtNombre":
                        if (!string.IsNullOrEmpty(txtNombre.Text))
                            txtDireccion.Focus();
                        break;
                    case "txtDireccion":
                        if (!string.IsNullOrEmpty(txtDireccion.Text))
                            txtTelefono.Focus();
                        break;
                    case "txtTelefono":
                        if (!string.IsNullOrEmpty(txtTelefono.Text))
                            txtFacturaNumero.Focus();
                        break;
                }
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCedula.Text))
                dxErrorProvider1.SetError(txtCedula, "Error");
            else
                dxErrorProvider1.SetError(txtCedula, string.Empty);

            if (string.IsNullOrEmpty(txtNombre.Text))
                dxErrorProvider1.SetError(txtNombre, "Error");
            else
                dxErrorProvider1.SetError(txtNombre, string.Empty);

            if (string.IsNullOrEmpty(txtDireccion.Text))
                dxErrorProvider1.SetError(txtDireccion, "Error");
            else
                dxErrorProvider1.SetError(txtDireccion, string.Empty);

            if (string.IsNullOrEmpty(txtTelefono.Text))
                dxErrorProvider1.SetError(txtTelefono, "Error");
            else
                dxErrorProvider1.SetError(txtTelefono, string.Empty);

            if (string.IsNullOrEmpty(txtFacturaNumero.Text))
                dxErrorProvider1.SetError(txtFacturaNumero, "Error");
            else
                dxErrorProvider1.SetError(txtFacturaNumero, string.Empty);

            if (!dxErrorProvider1.HasErrors)
            {
                if (cliente == null)
                    cliente = new Cliente();

                cliente.Cedula = txtCedula.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTelefono.Text;

                FacturaNumero = txtFacturaNumero.Text;
                fecha = deFecha.DateTime;

                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}