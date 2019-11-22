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
using Gm.Entities;
using Gm.Core;
using Gm.Data;

namespace Gm.NET.Formularios
{
    public partial class xfAyudaCliente : DevExpress.XtraEditors.XtraForm
    {
        public Cliente item;
        private readonly List<Cliente> Lista;
        public xfAyudaCliente()
        {
            InitializeComponent();
            Lista= new Repository<Cliente>().GetAll();
        }

        private void txtFiltro_EditValueChanged(object sender, EventArgs e)
        {
            if (!txtFiltro.Text.Trim().Equals(""))
            {
                gridControl1.DataSource = (from a in Lista
                                           where a.Nombre.Contains(txtFiltro.Text)
                                           select a).ToList();

            }
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    gridControl1.Focus();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    item = (Cliente)gridView1.GetRow(gridView1.FocusedRowHandle);
                    Close();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            item = (Cliente)gridView1.GetRow(gridView1.FocusedRowHandle);
            Close();
        }
    }
}