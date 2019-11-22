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
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;

namespace Gm.NET
{
    public partial class XfConfiguracion : DevExpress.XtraEditors.XtraForm
    {
        //XtraUserControl control;
        public XfConfiguracion()
        {
            InitializeComponent();
        }

        private void xfConfiguracion_Load(object sender, EventArgs e)
        {
            
            
        }
        public void Usuarios()
        {
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    var aux = new Herramientas.XuUsuarios();
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }
            
        }
        public void Marcas()
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    var aux = new Herramientas.XuMarcas();
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }

        }
        public void Medidas()
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    var aux = new Herramientas.XuMedidas();
            //    XtraUserControl control;
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }

        }
        public void Grupos()
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    XtraUserControl control;
            //    var aux = new Herramientas.XuGrupos();
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }

        }
        public void Terminales()
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    var aux = new Herramientas.XuTerminal();
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }

        }
        public void Modulos()
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            //try
            //{
            //    xtraUserControl1.Controls.Clear();
            //    var aux = new Herramientas.XuModulos();
            //    control = aux;
            //    xtraUserControl1.Controls.Add(control);
            //    control.Dock = DockStyle.Fill;
            //}
            //catch (Exception) { }

        }
        
        public void Salir()
        {
            Close();
        }

        private void xfConfiguracion_SizeChanged(object sender, EventArgs e)
        {
            //pCContenedor.Location = CenterForm.Function(this.Width, pCContenedor.Width);
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            
        }
    }
}