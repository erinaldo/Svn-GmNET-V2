

namespace Gm.NET.Formularios
{
    using System;
    using Gm.Data;
    using Gm.Entities;
    using System.Windows.Forms;
    using DevExpress.XtraEditors;
    public partial class xfPurchaseDistribuidor : DevExpress.XtraEditors.XtraForm
    {
        public string FacturaNumero;
        public decimal flete;
        public DateTime fecha;
        public xfPurchaseDistribuidor()
        {
            InitializeComponent();
        }
        private void xfPurchaseDistribuidor_Load(object sender, EventArgs e)
        {
            
            btnConfirmar.Enabled = false;
        }
        
        void Textos(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var resp = sender as TextEdit;
                switch (resp.Name.ToString())
                {
                    case "txtFacturaNumero":
                        if (!string.IsNullOrEmpty(txtFacturaNumero.Text))
                        {
                            txtFlete.Focus();
                            btnConfirmar.Enabled = true;
                        }
                            
                        break;
                    case "txtFlete":
                        deFecha.EditValue = DateTime.Now;
                            deFecha.Focus();
                        break;
                    case "deFecha":
                        btnConfirmar.Focus();
                        break;
                }
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFacturaNumero.Text))
                dxErrorProvider1.SetError(txtFacturaNumero, "Error");
            else
                dxErrorProvider1.SetError(txtFacturaNumero, string.Empty);

            if (!dxErrorProvider1.HasErrors)
            {
                
                FacturaNumero = txtFacturaNumero.Text;
                txtFlete.Text = string.IsNullOrEmpty(txtFlete.Text) ? "0" : txtFlete.Text;

                flete = Convert.ToDecimal(txtFlete.Text);
                fecha = deFecha.DateTime;

                Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deFecha_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(deFecha.Text))
                btnConfirmar.Focus();
        }
    }
}