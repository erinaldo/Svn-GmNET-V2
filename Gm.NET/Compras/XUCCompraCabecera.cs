using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Gm.Entities;
using Gm.Data;
using Gm.NET.Formularios;
using Gm.Core;

namespace Gm.NET
{
    public partial class XUCCompraCabecera : DevExpress.XtraEditors.XtraUserControl
    {

        public Factura factura;
        private Repository<Cliente> repositoryCliente;
        private Repository<Factura> repositoryFactura;
        

        private Cliente cliente;
        public bool Editar;
        public XUCCompraCabecera()
        {
            InitializeComponent();
        }

        private void XUCCompraCabecera_Load(object sender, EventArgs e)
        {
            Cragar();
        }
        private void Cragar()
        {
            repositoryCliente = new Repository<Cliente>();
            repositoryFactura = new Repository<Factura>();

            txtFactura.EditValue = factura.Numero;
            dtFecha.EditValue = factura.Fecha;
            txtFlete.EditValue = factura.Flete;
            cliente = factura.Cliente;
            txtProveedor.EditValue = cliente.Nombre;

            btnProveedor.Enabled = Editar?false:true;
            btnGrabar.Enabled = Editar?false:true;
            txtFactura.ReadOnly = Editar;
            dtFecha.ReadOnly = Editar;
            txtFlete.ReadOnly = Editar;
        }
        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Editar = false;
            txtFactura.ReadOnly = Editar;
            dtFecha.ReadOnly = Editar;
            txtFlete.ReadOnly = Editar;
            btnProveedor.Enabled = Editar ? false : true;
            btnGrabar.Enabled = Editar ? false : true;
        }

        private void btnProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Editar == false)
            {
                XfCompraProveedorBuscar buscaProveedor = new XfCompraProveedorBuscar();
                buscaProveedor.ShowDialog();
                if (buscaProveedor.cliente != null)
                    cliente = buscaProveedor.cliente;
            }
        }

        private void btnGrabar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (Editar == false)
                {
                    var resp = repositoryFactura.Find(x => x.IDFactura == factura.IDFactura);
                    resp.Fecha = dtFecha.DateTime;
                    resp.Flete = Convert.ToDecimal(txtFlete.Text);
                    resp.IDCliente = cliente.IDCliente;

                    if (!repositoryFactura.Update(resp))
                        throw new Exception(repositoryFactura.Error);

                    Editar = true;
                    btnProveedor.Enabled = Editar ? false : true;
                    btnGrabar.Enabled = Editar ? false : true;
                    txtFactura.ReadOnly = Editar;
                    dtFecha.ReadOnly = Editar;
                    txtFlete.ReadOnly = Editar;

                    //Realizamos la distribucion de Flete al producto comprado
                    new DistribucionFlete().Distribuir(resp);

                    XtraMessageBox.Show("Actualizado correcto");
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }
    }
}
