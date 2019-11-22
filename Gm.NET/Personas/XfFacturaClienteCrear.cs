

namespace Gm.NET.Formularios
{
    using System;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;

    using Gm.Data;
    using Gm.Entities;

    public partial class XfFacturaClienteCrear : DevExpress.XtraEditors.XtraForm
    {
        public XfFacturaClienteCrear()
        {
            InitializeComponent();
        }

        private void xfFacturaClienteCrear_Load(object sender, EventArgs e)
        {
            var resp = new Repository<Cliente>().GetAll().Count;
            txtID.EditValue = resp+1;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                using (var resp = new Repository<Cliente>())
                {
                    if (resp.Create(new Cliente
                    {
                        IDCliente = resp.Count() + 1,
                        Nombre = txtNombre.Text,
                        Cedula = txtCedula.Text,
                        Direccion = txtDireccion.Text,
                        Telefono = txtTelefono.Text,
                        Correo = txtCorreo.Text,
                        Estado = (toggleSwitch1.IsOn) ? "A" : "E",
                        NombreContacto = txtContacto.Text,
                        TelefonoContacto = txtTelefonoContacto.Text,
                        DireccionContacto = txtDireccionContacto.Text,
                        CreditoMaximo = (string.IsNullOrEmpty(txtCreditoMaximo.Text)) ? 0 : Convert.ToDecimal(txtCreditoMaximo.Text),
                        Observaciones = txtObeservacion.Text,
                        PrecioAplicado = rdPrecioVenta.SelectedIndex,
                        Tipo = "C"
                    }) == null)
                    {
                        this.Hide();
                        XtraMessageBox.Show(resp.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Visible = true;
                    }
                    else
                    {
                        this.Hide();
                        XtraMessageBox.Show("Guardado Corecto", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}