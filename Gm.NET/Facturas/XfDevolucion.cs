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
using Gm.Entities;
using Gm.Core;

namespace Gm.NET
{
    public partial class XfDevolucion : DevExpress.XtraEditors.XtraForm
    {
        public Factura _factura;
        readonly Repository<Factura> repositoryFac;
        readonly Repository<FacturaDetalle> repositoryFacDet;
        readonly Repository<Kardex> repositoryKar;
        readonly Repository<Producto> repositoryPro;
        readonly Repository<Devolucion> repositoryDev;

        List<DevolucionCore> _detalle;
        public XfDevolucion()
        {
            InitializeComponent();
            repositoryFac = new Repository<Factura>();
            repositoryFacDet = new Repository<FacturaDetalle>();
            repositoryKar = new Repository<Kardex>();
            repositoryPro = new Repository<Producto>();
            repositoryDev = new Repository<Devolucion>();
        }
        private void XfDevolucion_Load(object sender, EventArgs e)
        {
            NumeroTextEdit.EditValue = _factura.Numero;
            ClienteTextEdit.EditValue = _factura.Cliente.Nombre;
            CedulatextEdit.EditValue = _factura.Cliente.Cedula;
            FechaDateEdit.EditValue = _factura.Fecha;

            if (!string.IsNullOrEmpty(NumeroTextEdit.Text))
            {
                _detalle = new List<DevolucionCore>();
                var fac = repositoryFac.Find(x => x.Numero == NumeroTextEdit.Text);
                _detalle = (from a in repositoryFacDet.Search(x => x.IDFactura == fac.IDFactura)
                            select new DevolucionCore
                            {
                                IDFacturaDetalle = a.IDFacturaDetalle,
                                IDFactura = a.IDFactura,
                                IDProducto = a.IDProducto,
                                Costo = a.Costo,
                                Producto = a.Producto,
                                Unidades = a.Unidades,
                                MedidaMetrica = a.MedidaMetrica,
                                IdMedidaMetrica = a.IdMedidaMetrica,
                                IDKardex = a.IDKardex,
                                Iva = a.Iva,

                            }).ToList();
                gridControl1.DataSource = _detalle;
                progressBarControl1.Properties.Maximum = _detalle.Count;
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int contador = 0;
            foreach (var fila in _detalle)
            {
                if (fila.Sale > 0 )
                {
                    DevolucionProducto._Devolucion(fila);
                    contador++;
                }
                progressBarControl1.EditValue = Convert.ToInt16(progressBarControl1.EditValue) + 1;
            }

            bool Resul = false;
            foreach(var fila in _detalle)
            {
                if (fila.Queda > 0)
                    Resul = true;
            }

            var fac = repositoryFac.Find(x => x.Numero == NumeroTextEdit.Text);
            if(_detalle.Count>contador)
                fac.Siclo = "D";
            if(Resul)
                fac.Estado = "E";

            repositoryFac.Update(fac);

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            btnAplicar.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit check = (CheckEdit)sender;
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle)as FacturaDetalle;
            resp.Estado = check.Checked;
        }

        private void NumeroTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}