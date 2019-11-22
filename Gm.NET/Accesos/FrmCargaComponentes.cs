using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gm.Core;

namespace Gm.NET.Formularios
{
    public partial class FrmCargaComponentes : DevExpress.XtraEditors.XtraForm
    {
        public Action Worker { get; set; }
        public FrmCargaComponentes(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;
            Carga();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        void Carga()
        {
            label2.Text = General.MyVersion;
            if (General.NomSkin == null)
            {
                string ruta = "them.txt";
                StreamReader lector = new StreamReader(ruta);
                General.NomSkin = lector.ReadLine();
                lector.Close();
            }
            
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(General.NomSkin);
        }
    }
}
