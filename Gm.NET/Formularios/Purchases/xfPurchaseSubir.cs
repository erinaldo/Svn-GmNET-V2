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
using Gm.Core;
using Gm.Data;
using Gm.Entities;

namespace Gm.NET.Formularios
{


    public partial class xfPurchaseSubir : XtraForm
    {
        
        #region variables
        public List<EnRegistro> detalle;
        public List<PurchaseSubir> datos;
        private List<PurchaseSubir> lista;
        public long IdFactura;
        #endregion

        void function()
        {
            datos = new List<PurchaseSubir>();
            lista = new PurchaseSubir().Lista(detalle);
            gridControl1.DataSource = lista;
        }

        public xfPurchaseSubir()
        {
            InitializeComponent();
        }

        private void xfPurchaseSubir_Load(object sender, EventArgs e)
        {
            function();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            CellarCore temp = new CellarCore();

            if(lista.Exists(x=>x.PrecioPorMayor == null || x.PrecioPorMayor == 0))
                XtraMessageBox.Show("Hay valores sin asignar favor revise");
            else
            {
                if (temp.Subir(lista, IdFactura))
                {
                    XtraMessageBox.Show("Done");
                    Close();
                }
                else
                    XtraMessageBox.Show(temp.Error);
            }

        }
    }
}