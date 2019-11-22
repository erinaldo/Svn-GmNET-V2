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

namespace MMercadoAPU
{
    public partial class XtraFormInicio : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormInicio()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView1.QueryControl += windowsUIView1_QueryControl;
            // Handling the QueryControl event that will populate all automatically generated Documents
            //this.widgetView1.QueryControl += widgetView1_QueryControl;
            // Handling the QueryControl event that will populate all automatically generated Documents
            //this.tabbedView1.QueryControl += tabbedView1_QueryControl;
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.windowsUIView2.QueryControl += windowsUIView2_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == xuUsuariosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuUsuarios();
            if (e.Document == xuGruposDocument)
                e.Control = new MMercadoAPU.Herramientas.xuGrupos();
            if (e.Document == xuModulosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuModulos();
            if (e.Document == xuTerminalDocument)
                e.Control = new MMercadoAPU.Herramientas.xuTerminal();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        // Assigning a required content for each auto generated Document
        void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == xuUsuariosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuUsuarios();
            if (e.Document == xuGruposDocument)
                e.Control = new MMercadoAPU.Herramientas.xuGrupos();
            if (e.Document == xuModulosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuModulos();
            if (e.Document == xuTerminalDocument)
                e.Control = new MMercadoAPU.Herramientas.xuTerminal();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == xuUsuariosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuUsuarios();
            if (e.Document == xuGruposDocument)
                e.Control = new MMercadoAPU.Herramientas.xuGrupos();
            if (e.Document == xuModulosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuModulos();
            if (e.Document == xuTerminalDocument)
                e.Control = new MMercadoAPU.Herramientas.xuTerminal();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        // Assigning a required content for each auto generated Document
        void windowsUIView2_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == xuUsuariosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuUsuarios();
            if (e.Document == xuGruposDocument)
                e.Control = new MMercadoAPU.Herramientas.xuGrupos();
            if (e.Document == xuModulosDocument)
                e.Control = new MMercadoAPU.Herramientas.xuModulos();
            if (e.Document == xuTerminalDocument)
                e.Control = new MMercadoAPU.Herramientas.xuTerminal();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }
    }
}