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
using Gm.NET.Formularios;

namespace Gm.NET
{
    //https://www.iconfinder.com/icons/619539/cancel_close_delete_dismiss_exit_recycle_remove_icon#size=128
    public partial class XtraFormMain : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMain()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tileItemVenta_ItemClick(object sender, TileItemEventArgs e)
        {
                       
            this.Hide();
            //XtraFormVenta formulario = new XtraFormVenta();
            xfBill formulario = new xfBill();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();

        }

        private void tileItemCompras_ItemClick(object sender, TileItemEventArgs e)
        {
            //this.Hide();
            //xfPurchases formulario = new xfPurchases();
            //formulario.Activate();
            //formulario.ShowDialog();
            //this.Show();
        }

        private void tileItemProductos_ItemClick(object sender, TileItemEventArgs e)
        {
            //this.tileControlContenedor.Hide();
            this.Hide();
            xfProductAdmin formulario = new xfProductAdmin();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }

        private void tileItemKardex_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            XtraFormKardex formulario = new XtraFormKardex();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }

        private void tileItemAforo_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            XtraFormAforo formulario = new XtraFormAforo();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }

        private void tileItemProveedor_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            xfProviderAdmin formulario = new xfProviderAdmin();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }

        private void tileItemFacturas_ItemClick(object sender, TileItemEventArgs e)
        {
            //this.Hide();
            ////xfFacturas formulario = new xfFacturas();
            //formulario.Activate();
            //formulario.ShowDialog();
            //this.Show();
        }

        private void tileItemCategoria_ItemClick(object sender, TileItemEventArgs e)
        {
            //this.Hide();
            //XtraFormGrupo formulario = new XtraFormGrupo();
            //formulario.Activate();
            //formulario.ShowDialog();
            //this.Show();
        }

        private void tileItemReportes_ItemClick(object sender, TileItemEventArgs e)
        {
            XtraFormR a = new XtraFormR();
            a.ShowDialog();
            if (a.opcion != 0)
            {
                this.Hide();
                switch (a.opcion)
                {
                    case 2:
                        //xfComprasVSVentas formulario = new xfComprasVSVentas();
                        //formulario.Activate();
                        //formulario.ShowDialog();
                        break;
                    case 1:
                        //XtraFormVistaVenta formulario1 = new XtraFormVistaVenta();
                        //formulario1.Activate();
                        //formulario1.ShowDialog();
                        break;
                    case 3:
                        //XtraFormMovimientoProduto formulario2 = new XtraFormMovimientoProduto();
                        //formulario2.Activate();
                        //formulario2.ShowDialog();
                        //break;
                    case 4:
                        xfInventarioAdmin formulario3 = new xfInventarioAdmin();
                        formulario3.Activate();
                        formulario3.ShowDialog();
                        break;
                }
                this.Show();
            }
        }

        private void tileItemModulos_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            xfConfiguracion formulario = new xfConfiguracion();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }

        private void tileItemUsuario_ItemClick(object sender, TileItemEventArgs e)
        {
            this.Hide();
            xfClientAdmin formulario = new xfClientAdmin();
            formulario.Activate();
            formulario.ShowDialog();
            this.Show();
        }
    }
}