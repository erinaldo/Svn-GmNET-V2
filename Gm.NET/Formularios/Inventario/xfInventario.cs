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
using Gm.Data;
using Gm.Core;
using Gm.Entities;

namespace Gm.NET.Formularios.Inventario
{

    public partial class xfInventario : DevExpress.XtraEditors.XtraForm
    {
        public xfInventario()
        {
            InitializeComponent();
        }
        void Function()
        {
            
            var resp = new InventarioTotalCore();
            gCInventario.DataSource = resp.Lista().OrderBy(x => x.Name);
            //treeList1.DataSource = temp.OrderBy(x => x.Name);
        }
        private void xfInventario_Load(object sender, EventArgs e)
        {
            Function();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Function();
        }

        private void xfInventario_SizeChanged(object sender, EventArgs e)
        {
            pCCentral.Location = CenterForm.Function(this.Width, pCCentral.Width);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            const int WM_KEYDOWN = 0x100;
            const int WM_SYSKEYDOWN = 0x104;

            if ((msg.Msg == WM_KEYDOWN) || (msg.Msg == WM_SYSKEYDOWN))
            {
                switch (keyData)
                {
                    case Keys.F5:
                        btnActualizar.Focus();
                        break;
                    case Keys.Escape:
                        btnSalir.Focus();
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}