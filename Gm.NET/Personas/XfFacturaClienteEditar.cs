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
using Gm.Entities;
using Gm.Data;

namespace Gm.NET.Formularios.Ventas
{
    public partial class XfFacturaClienteEditar : DevExpress.XtraEditors.XtraForm
    {
        public Cliente cliente_;
        public XfFacturaClienteEditar()
        {
            InitializeComponent();
        }

        private void xfFacturaClienteEditar_Load(object sender, EventArgs e)
        {
            txtID.EditValue = cliente_.IDCliente;
            txtNombre.Text = cliente_.Nombre;
            txtCedula.Text = cliente_.Cedula;
            txtDireccion.Text = cliente_.Direccion;
            txtTelefono.Text = cliente_.Telefono;
            txtCorreo.Text = cliente_.Correo;
            toggleSwitch1.IsOn= (cliente_.Estado=="A") ? true : false;
            txtContacto.Text = cliente_.NombreContacto;
            txtTelefonoContacto.Text = cliente_.TelefonoContacto;
            txtDireccionContacto.Text = cliente_.DireccionContacto;
            txtCreditoMaximo.EditValue = cliente_.CreditoMaximo;
            txtObeservacion.Text = cliente_.Observaciones;
            rdPrecioVenta.SelectedIndex = Convert.ToInt16(cliente_.PrecioAplicado)-1;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtDireccion.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtNombre.Text.Trim()))
                {

                    using (var resp = new Repository<Cliente>())
                    {
                        var aux = resp.Find(x => x.IDCliente == cliente_.IDCliente);
                        aux.Nombre = txtNombre.Text;
                        aux.Cedula = txtCedula.Text;
                        aux.Direccion = txtDireccion.Text;
                        aux.Telefono = txtTelefono.Text;

                        aux.Correo = txtCorreo.Text;
                        aux.Estado = (toggleSwitch1.IsOn) ? "A" : "E";
                        aux.NombreContacto = txtContacto.Text;
                        aux.TelefonoContacto = txtTelefonoContacto.Text;
                        aux.DireccionContacto = txtDireccionContacto.Text;
                        aux.CreditoMaximo = (string.IsNullOrEmpty(txtCreditoMaximo.Text))?0:Convert.ToDecimal(txtCreditoMaximo.Text);
                        aux.Observaciones = txtObeservacion.Text;
                        aux.PrecioAplicado = Convert.ToInt16(rdPrecioVenta.EditValue);

                        if (resp.Update(aux))
                        {
                            cliente_ = aux;
                            Close();
                        }
                        else
                            throw new Exception(resp.Error);
                    }
                }
                else
                    throw new Exception("Favor revise hay campos sin completar");
            }
            catch(Exception ex)
            {
                this.Hide();
                XtraMessageBox.Show(ex.Message);
                this.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}