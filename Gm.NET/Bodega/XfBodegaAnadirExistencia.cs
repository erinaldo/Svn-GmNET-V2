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
using Gm.Data;
using Gm.Core;

namespace Gm.NET
{
    public partial class XfBodegaAnadirExistencia : DevExpress.XtraEditors.XtraForm
    {
        public Producto producto_;
        public XfBodegaAnadirExistencia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void XfBodegaAnadirExistencia_Load(object sender, EventArgs e)
        {
            this.Text = producto_.Nombre;
        }

        private void btnGuardaryNuevo_Click(object sender, EventArgs e)
        {
            var resp = new Repository<Producto>();
            var karBode = new Repository<KardexBodega>();

            if (!string.IsNullOrEmpty(txtExistenciaNueva.Text))
            {
                var pro = resp.Find(x => x.IDProducto == producto_.IDProducto);
                var con = karBode.GetAll().Count;
                if (con == 0)
                    con = 1;
                else
                    con = con + 1;

                if (karBode.Create(new KardexBodega
                {
                    IDKardexBodega = con,
                    IDProducto = producto_.IDProducto,
                    Cantidad = Convert.ToInt16(txtExistenciaNueva.Text),
                    Precio = 0,
                    FechaSystema = DateTime.Now,
                    Entra = Convert.ToInt16(txtExistenciaNueva.Text),
                    Sale = 0,
                    Movimiento = "B",
                    IDUsuario = General.IdUsuario
                }) == null)
                    XtraMessageBox.Show(karBode.Error);
                else
                    Close();
            }
        }

        private void txtExistenciaActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}