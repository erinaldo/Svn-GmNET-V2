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
    public partial class XfDevolucionCambio : DevExpress.XtraEditors.XtraForm
    {
        readonly Repository<Factura> repositoryFac;
        readonly Repository<FacturaDetalle> repositoryFacDet;
        readonly Repository<Kardex> repositoryKar;
        readonly Repository<Producto> repositoryPro;

        List<FacturaDetalle> _detalle;
        List<Producto> _producto;
        List<BillCore> _venta;
        public XfDevolucionCambio()
        {
            InitializeComponent();
            repositoryFac = new Repository<Factura>();
            repositoryFacDet = new Repository<FacturaDetalle>();
            repositoryKar = new Repository<Kardex>();
            repositoryPro = new Repository<Producto>();
        }

        private void XfDevolucionCambio_Load(object sender, EventArgs e)
        {
            _venta = new List<BillCore>();
            Control.CheckForIllegalCrossThreadCalls = false;
            word_Data.RunWorkerAsync();
        }
        private void txtNumeroFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtNumeroFactura.Text))
            {
                var fac = repositoryFac.Find(x => x.Numero == txtNumeroFactura.Text);
                _detalle = repositoryFacDet.Search(x => x.IDFactura == fac.IDFactura);

                gCDevolucion.DataSource = _detalle;

                if (fac.Siclo == "D")
                    btnAplicar.Enabled = false;
                else
                    btnAplicar.Enabled = true;
                //progressBarControl1.Properties.Maximum = _detalle.Count;
                //progressBarControl1.EditValue = 1;
            }
        }

        private void word_Data_DoWork(object sender, DoWorkEventArgs e)
        {
            _producto = new List<Producto>();
            foreach (var aux in repositoryPro.Search(x => x.Estado == "A"))
                _producto.Add(aux);
        }

        private void word_Data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            gCProducto.DataSource = _producto.OrderBy(x=>x.Nombre);
        }

        private void gVProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                RowAdd();
        }
        private void RowAdd()
        {
            var resp = gVProducto.GetRow(gVProducto.FocusedRowHandle) as Producto;
            if (_venta.Count == 0)
            {
                _venta.Add(new BillCore
                {
                    IdProducto = resp.IDProducto,
                    Unidades= 1,
                    Detalle = resp.Nombre,
                    Medida = resp.MedidaMetrica,
                    Marca_= resp.Marca,
                    Precio= Convert.ToSingle(resp.PVenta1),
                    IvaAplica = resp.Iva
                });
            }
            else
            {
                var aux = _venta.Find(x=>x.IdProducto==resp.IDProducto);
                if (aux != null)
                    aux.Unidades = aux.Unidades + 1;
                else
                {
                    _venta.Add(new BillCore
                    {
                        IdProducto = resp.IDProducto,
                        Unidades = 1,
                        Detalle = resp.Nombre,
                        Medida = resp.MedidaMetrica,
                        Marca_ = resp.Marca,
                        Precio = Convert.ToSingle(resp.PVenta1),
                        IvaAplica = resp.Iva
                    });
                }
            }

            gCCambio.DataSource = null;
            gCCambio.DataSource = _venta;

        }

        private void gVProducto_DoubleClick(object sender, EventArgs e)
        {
            RowAdd();
        }

        private void btnQuitarFila_Click(object sender, EventArgs e)
        {
            _venta.RemoveAt(gVCambio.FocusedRowHandle);
            gCCambio.DataSource = null;
            gCCambio.DataSource = _venta;
            Caulcular();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _venta = new List<BillCore>();
            gCCambio.DataSource = null;
            gCCambio.DataSource = _venta;
            Caulcular();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gVCambio_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            Caulcular();
        }

        private void txtDevolver_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void Caulcular()
        {
            var devo = _detalle.Sum(x => x.Costo * x.Unidades);
            var cam = _venta.Sum(x => x.Total);
            var resp = devo - Convert.ToDecimal(cam);
            if (resp > 0)
            {
                txtDevolver.EditValue = resp;
                txtCobrar.EditValue = 0;
            }
            if (resp < 0)
            {
                txtDevolver.EditValue = 0;
                txtCobrar.EditValue = resp * -1;
            }
            if (resp == 0)
            {
                txtDevolver.EditValue = 0;
                txtCobrar.EditValue = 0;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            #region Devolucion de factura
            foreach (var a in _detalle)
            {
                var deta = repositoryFacDet.Find(x => x.IDFactura == a.IDFactura && x.IDProducto == a.IDProducto);
                deta.Siclo = "D";
                deta.Estado = false;
                repositoryFacDet.Update(deta);

                string IDF = "V" + a.IDFactura;
                var kar = repositoryKar.Search(x => x.IDFactura == IDF && x.IDProducto == a.IDProducto);
                foreach (var i in kar)
                {
                    i.Siclo = "D";
                    i.Estado = "E";
                    repositoryKar.Update(i);
                }

                var sec = repositoryKar.Count();
                var referencia = kar.First().Referencia;
                var pCom = repositoryKar.Find(x => x.IDProducto == a.IDProducto && x.IDKardex == referencia);


                repositoryKar.Create(new Kardex
                {
                    IDKardex = sec + 1,
                    IDProducto = a.IDProducto,
                    ProductoEntra = a.Unidades,
                    ProductoEntraPrecio = pCom.ProductoEntraPrecio,
                    ProductoSale = 0,
                    ProductoSalePrecio = 0,
                    IDFactura = string.Format("D{0}", sec + 1),
                    IVA = a.Iva,
                    Fecha = DateTime.Now,
                    FechaSistema = DateTime.Now,
                    Estado = "A",
                    Equivalencia = a.Unidades,
                    Siclo = "R",
                    IdMedidaMetrica = a.IdMedidaMetrica,
                    FacturaDevolucion = a.IDFactura

                });

                var pro = repositoryPro.Find(x => x.IDProducto == a.IDProducto);
                pro.ExistenciaActual = pro.ExistenciaActual + a.Unidades;
                repositoryPro.Update(pro);

                //progressBarControl1.EditValue = Convert.ToInt16(progressBarControl1.EditValue) + 1;
            }

            var fac = repositoryFac.Find(x => x.Numero == txtNumeroFactura.Text);
            fac.Siclo = "C";
            //fac.Estado = "E";

            repositoryFac.Update(fac);
            #endregion

            #region Anexado en detalle factura
            BillCore metodo = new BillCore();
            metodo.Devolucion(_venta, _detalle.First().IDFactura);
            //metodo.Save
            #endregion
        }
    }
}