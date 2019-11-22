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
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace Gm.NET
{
    public partial class XtraFormMenu : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMenu()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

           
            //if (e.Document == xtraFormCompraDocument)
            //    e.Control = new MMercadoAPU.xfCompras();
            if (e.Document == xtraFormProductoDocument)
                e.Control = new Gm.NET.xfProductAdmin();
            //if (e.Document == xtraFormGrupoDocument)
                //e.Control = new MMercadoAPU.xuGrupos();
            //if (e.Document == xtraFormVentaDocument)
            //    e.Control = new MMercadoAPU.XtraFormVenta();
            if (e.Document == xtraFormAforoDocument)
                e.Control = new Gm.NET.XtraFormAforo();
            if (e.Document == xtraFormProveedorDocument)
                e.Control = new Gm.NET.xfProviderAdmin();
            if (e.Document == xtraFormKardexDocument)
                e.Control = new Gm.NET.XtraFormKardex();
            //if (e.Document == xtraFormFacturaAdminDocument)
            //    e.Control = new Gm.NET.xfFacturas();
            //if (e.Document == xtraFormVistaVentaDocument)
            //    e.Control = new Gm.NET.XtraFormVistaVenta();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
        public FlyoutAction createCloseAction(Flyout flyout)
        {
            FlyoutAction closeaction = new FlyoutAction();
            closeaction.Description = "Cerrar esta aplicacion ?";
            closeaction.Commands.Add(FlyoutCommand.Yes);
            closeaction.Commands.Add(FlyoutCommand.No);
            return closeaction;
        }

        private void XtraFormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FlyoutCloseAction.Action = createCloseAction(FlyoutCloseAction);
            if (windowsUIView1.ShowFlyoutDialog(FlyoutCloseAction) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
                return;
        }
    }
}