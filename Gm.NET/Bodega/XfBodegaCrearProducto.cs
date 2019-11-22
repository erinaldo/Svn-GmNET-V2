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
using DevExpress.XtraGrid;
using Gm.Core;
using Gm.Data;
using System.IO;

namespace Gm.NET
{
    public partial class XfBodegaCrearProducto : DevExpress.XtraEditors.XtraForm
    {
        public Producto nuevo;
        public delegate void Enviar(GridControl t, int i);
        public event Enviar unEvento;

        public GridControl dt;
        ProductoBLL aux;

        private static XfBodegaCrearProducto formulario = null;
        public static XfBodegaCrearProducto Instance()
        {
            if (((formulario == null) || (formulario.IsDisposed == true)))
                formulario = new XfBodegaCrearProducto();
            formulario.BringToFront();
            return formulario;
        }

        public XfBodegaCrearProducto()
        {
            InitializeComponent();
        }
        private void Inicializar()
        {
            txtCodigo.EditValue = null;
            chEstado.EditValue = true;
            
            txtDescripcion.EditValue = null;
            txtCosto.EditValue = null;
            
            txtPrecioVenta.EditValue = null;
            cbxIva.SelectedIndex = 0;
            pEFoto.Image = null;
            txtInventarioInicial.EditValue = null;


            var resp = new Repository<Producto>().GetAll();
            if (resp == null)
                txtCodigo.EditValue = 1;
            else
                txtCodigo.EditValue = resp.Count + 1;

        }

        private void XfBodegaCrearProducto_Load(object sender, EventArgs e)
        {
         
            dt = new GridControl();
            aux = new ProductoBLL();

            var resp = new Repository<Producto>().GetAll();
            if (resp == null)
                txtCodigo.EditValue = 1;
            else
                txtCodigo.EditValue = resp.Count + 1;
        }

        private void btnGuardaryNuevo_Click(object sender, EventArgs e)
        {
            Guardar();
            Inicializar();
        }
        private void Guardar()
        {
            try
            {
                var prod = new Repository<Producto>();
                var tmp = prod.GetAll();
                int rowMax = 0;
                if (tmp == null)
                    rowMax = 0;
                else
                    rowMax = tmp.Count;

                rowMax++;

                Producto producto = new Producto();
                producto.IDProducto = rowMax;
                producto.Nombre = txtDescripcion.Text;



                producto.Iva = (cbxIva.EditValue.Equals("No")) ? false : true;
                producto.Equivalencia1 = 1;
                producto.Estado = "A";
                producto.FechaSistema = DateTime.Now;

                //producto.
                producto.CodRapido = null;
                producto.IDMedidaMetrica = 1;
                producto.IDGrupo = 1;
                producto.IDMarca = 1;
                producto.IDUbicacion = 2;

                //codicion 1
                producto.Equivalencia2 = 0;
                producto.StateMedida2 = false;

                //condicion 2
                producto.Equivalencia3 = 0;
                producto.StateMedida3 = false;

                producto.ExistenciaMinima = 0;
                producto.ExistenciaActual = string.IsNullOrEmpty(txtInventarioInicial.Text) ? 0 : Convert.ToInt32(txtInventarioInicial.Text);

                producto.Notificar = false;
                //producto.FechaExpiracion = dtFechaExpiracion.DateTime;
                //producto.MostraNotificar = chMostrarNotificacion.Checked;


                //if (string.IsNullOrEmpty(txtInventarioInicial.Text))
                //{
                //    producto.ExistenciaActual = Convert.ToInt16(txtExistenciaActual.Text);
                //}
                //else
                //{
                //    var a1 = (string.IsNullOrEmpty(txtExistenciaActual.Text)) ? 0 : Convert.ToInt32(txtExistenciaActual.Text);
                //    var b1 = Convert.ToInt32(txtInventarioInicial.Text);

                //    producto.ExistenciaActual = a1 + b1;
                //}

                producto.PVenta1 = string.IsNullOrEmpty(txtPrecioVenta.Text) ? 0 : Convert.ToDecimal(txtPrecioVenta.Text);
                producto.PVenta2 = 0;
                producto.PVenta3 = 0;

                producto.PCAnterior = 0;


                if (pEFoto.Image != null)
                    producto.FotoProducto = Convertir_Imagen_Bytes(pEFoto.Image);

                if (prod.Create(producto) == null)
                    XtraMessageBox.Show(prod.Error);
                else
                {
                    var kard = new Repository<Kardex>();
                    if (!string.IsNullOrEmpty(txtInventarioInicial.Text))
                    {
                        var tmp1 = kard.GetAll();
                        int con1 = 0;
                        if (tmp1 == null)
                            con1 = 1;
                        else
                            con1 = tmp1.Count + 1;
                        kard.Create(new Kardex
                        {
                            IDKardex = con1,
                            IDProducto = producto.IDProducto,
                            ProductoEntra = Convert.ToInt16(txtInventarioInicial.Text),
                            ProductoEntraPrecio = string.IsNullOrEmpty(txtCosto.Text) ? 0 : Convert.ToDecimal(txtCosto.Text),
                            ProductoSale = 0,
                            ProductoSalePrecio = 0,
                            IVA = (producto.Iva != null) ? Convert.ToInt16(General.Iva) : 0,
                            IDFactura = "I" + con1,
                            Estado = "A",
                            Fecha = DateTime.Now,
                            FechaSistema = DateTime.Now,
                            Equivalencia = Convert.ToInt16(txtInventarioInicial.Text),
                            IdMedidaMetrica = producto.IDMedidaMetrica,
                            Referencia = 0,
                            IDUbicacion = producto.IDUbicacion,
                            Siclo = "R"
                        });
                    }
                    var resp = aux.Lista;
                    dt.DataSource = resp.Where(x=>x.IDUbicacion==2).ToList();
                    this.unEvento(dt, resp.Count - 1);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        public static byte[] Convertir_Imagen_Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            xtraOpenFileDialog1.InitialDirectory = "c:\\";
            xtraOpenFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            xtraOpenFileDialog1.FilterIndex = 2;
            xtraOpenFileDialog1.RestoreDirectory = true;

            if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pEFoto.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        {
            pEFoto.Image = null;
        }
    }
}