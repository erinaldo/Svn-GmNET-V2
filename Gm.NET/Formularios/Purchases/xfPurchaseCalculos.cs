namespace Gm.NET.Formularios
{
    using System;
    public partial class xfPurchaseCalculos : DevExpress.XtraEditors.XtraForm
    {
        public decimal conIva;
        public decimal sinIva;
        public decimal calculoIva;
        public decimal Total;
        public int cConIva;
        public int cSinIva;
        public xfPurchaseCalculos()
        {
            InitializeComponent();
        }
        private void xfPurchaseCalculos_Load(object sender, EventArgs e)
        {
            lb2.Text = string.Format("{0:0.000}", conIva);
            lb5.Text = string.Format("{0:0.000}", sinIva);
            lb3.Text = string.Format("{0:0.000}", calculoIva);
            lb7.Text = string.Format("{0:0.000}", Total);

            lb1.Text = string.Format("{0:0.000}", cConIva);
            lb4.Text = string.Format("{0:0.000}", cSinIva);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}