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
using System.IO;

namespace Gm.NET.Formularios.Accesos
{
    public partial class xfCargaBasica : DevExpress.XtraEditors.XtraForm
    {
        private int con = 0;
        private const int max = 5;
        private char efecto = '.';
        private string etiqueta = "Procesing";
        public Action Worker { get; set; }
        public xfCargaBasica(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); timer1.Stop(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void xfCargaBasica_Load(object sender, EventArgs e)
        {
            label2.Text = General.MyVersion;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(new LecturaArchivo().GetSkin);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (con < max)
            {
                labelControl1.Text += efecto;
                con++;
            }
            else
            {
                labelControl1.Text = etiqueta;
                con = 0;
            }
        }
    }
}