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

namespace Gm.NET
{
    public partial class xfMessageThankYou : DevExpress.XtraEditors.XtraForm
    {
        public Point posicion;
        public Point size;
        public string texto;
        public int imagen;
        public xfMessageThankYou()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            this.texto = General.MyVersion;
        }

        private void xfMessageThankYou_Load(object sender, EventArgs e)
        {
            
            //this.Location = posicion;
            //this.Size = new Size(size);
            //lbTexto.Text = texto;
            //btnSalir.ImageOptions.Image = imageCollection1.Images[imagen];
            reubicarbtns();
        }
        private void reubicarbtns()
        {
            //int mitad = this.Width/2;
            //btnSalir.Location = new Point(mitad + 1,btnSalir.Location.Y);
            //btnOk.Location = new Point(mitad-1-btnOk.Location.X, btnOk.Location.Y);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}