using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using Gm.Entities;
using Gm.Core;
using Gm.Data;
using System.Linq;
using DevExpress.Utils;
using System.Drawing;
using System.IO;

namespace Gm.NET.Formularios
{
    public partial class XfProductNew : DevExpress.XtraEditors.XtraForm
    {
        public Producto nuevo;
        public delegate void Enviar(GridControl t, int i);
        public event Enviar unEvento;

        public GridControl dt;
        ProductoBLL aux;


        private static XfProductNew formulario = null;
        public static XfProductNew Instance()
        {
            if (((formulario == null) || (formulario.IsDisposed == true)))
                formulario = new XfProductNew();
            formulario.BringToFront();
            return formulario;
        }

        public XfProductNew()
        {
            InitializeComponent();
            
        }

        private void Inicializar()
        {
            txtCodigo.EditValue = string.Empty;
            chEstado.EditValue = true;
            txtExistenciaActual.EditValue = string.Empty;
            txtDescripcion.EditValue = string.Empty;
            txtCosto.EditValue = string.Empty;
            txtPrecioReal.EditValue = null;
            txtPrecioVenta.EditValue = null;
            cbxIva.SelectedIndex = 0;
            txtExistenciaMinima.EditValue = string.Empty;
            txtUtilidad.EditValue = string.Empty;
            txtCodigoRapido.EditValue = string.Empty;
            lookUnidadMedida.EditValue = null;
            txtCodigoBarra.EditValue = string.Empty;
            lookCategoria.EditValue = null;
            txtExistencia2.EditValue = string.Empty;
            lookMarca.EditValue = null;
            pEFoto.Image = null;
            chNotificar.EditValue = false;
            dtFechaExpiracion.EditValue = string.Empty;
            chMostrarNotificacion.EditValue = false;
            txtPrecio2.EditValue = null;
            txtPrecio3.EditValue = null;
            //txtApartir2.EditValue = string.Empty;
            //txtApartir3.EditValue = string.Empty;
            //chHabilitar2.EditValue = false;
            //chHabilitar3.EditValue = false;
            txtInventarioInicial.EditValue = string.Empty;

            var resp = new Repository<Producto>().GetAll();
            if (resp == null)
                txtCodigo.EditValue = 1;
            else
                txtCodigo.EditValue = resp.Count + 1;

            
        }
        private void xfProduct_Load(object sender, EventArgs e)
        {
            #region combox
            ProductoBLL metodo = new ProductoBLL();
            var Categoria_ = (from a in new Repository<Grupo>().GetAll()
                             select new { a.IDGrupo, a.Nombre}).ToList();

            lookCategoria.Properties.DataSource = Categoria_;
            lookCategoria.Properties.DisplayMember = "Nombre";
            lookCategoria.Properties.ValueMember = "IDGrupo";
            lookCategoria.Properties.PopulateColumns();
            lookCategoria.Properties.Columns[0].Visible = false;


            var Medida_ = (from a in new Repository<MedidaMetrica>().GetAll()
                             select new { a.IdMedidaMetrica, a.Name }).ToList();

            lookUnidadMedida.Properties.DataSource = Medida_;
            lookUnidadMedida.Properties.DisplayMember = "Name";
            lookUnidadMedida.Properties.ValueMember = "IdMedidaMetrica";
            lookUnidadMedida.Properties.PopulateColumns();
            lookUnidadMedida.Properties.Columns[0].Visible = false;

            var Marca_ = (from a in new Repository<Marca>().GetAll()
                          select new { a.IDMarca, a.NombreMarca }).ToList();

            lookMarca.Properties.DataSource = Marca_;
            lookMarca.Properties.DisplayMember = "NombreMarca";
            lookMarca.Properties.ValueMember = "IDMarca";
            lookMarca.Properties.PopulateColumns();
            lookMarca.Properties.Columns[0].Visible = false;


            //var Ubicacion_ = (from a in new Repository<Ubicacion>().GetAll()
            //                  select new { a.IDUbicacion, a.Nombre }).ToList();

            //lookEUbicacion.Properties.DataSource = Ubicacion_;
            //lookEUbicacion.Properties.DisplayMember = "Nombre";
            //lookEUbicacion.Properties.ValueMember = "IDUbicacion";
            //lookEUbicacion.Properties.PopulateColumns();
            //lookEUbicacion.Properties.Columns[0].Visible = false;

            #endregion

            //txtPrecio2.Enabled = chHabilitar2.Checked;
            //txtPrecio3.Enabled = chHabilitar2.Checked;
            //txtApartir2.Enabled = chHabilitar3.Checked;
            //txtApartir3.Enabled = chHabilitar3.Checked;
            dtFechaExpiracion.Enabled = chNotificar.Checked;

            dt = new GridControl();
            aux = new ProductoBLL();

            var resp = new Repository<Producto>().Count();
            if (resp == 0)
                txtCodigo.EditValue = 1;
            else
                txtCodigo.EditValue = resp + 1;
        }
        
        private void btnGuardaryNuevo_Click(object sender, EventArgs e)
        {
            Guardar();
            Inicializar();
        }

        private void chHabilitar2_CheckedChanged(object sender, EventArgs e)
        {
            //txtPrecio2.Enabled = chHabilitar2.Checked;
            //txtApartir2.Enabled = chHabilitar2.Checked;

        }

        private void chHabilitar3_CheckedChanged(object sender, EventArgs e)
        {
            //txtPrecio3.Enabled = chHabilitar3.Checked;
            //txtApartir3.Enabled = chHabilitar3.Checked;
        }

        private void chNotificar_CheckedChanged(object sender, EventArgs e)
        {
            dtFechaExpiracion.Enabled = chNotificar.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void btnGuardaySalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                    throw new Exception("Ingrese la descripcion del producto, para poder continuar");

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
                producto.CodRapido = txtCodigoRapido.Text;
                producto.IDMedidaMetrica = (lookUnidadMedida.EditValue == null) ? 1 : Convert.ToInt32(lookUnidadMedida.EditValue);
                producto.IDGrupo = (lookCategoria.EditValue == null) ? 1 : Convert.ToInt32(lookCategoria.EditValue);
                producto.IDMarca = (lookMarca.EditValue == null) ? 1 : Convert.ToInt32(lookMarca.EditValue);
                //producto.IDUbicacion = (lookEUbicacion.EditValue == null) ? 1 : Convert.ToInt32(lookEUbicacion.EditValue);

                //codicion 1
                //producto.Equivalencia2 = string.IsNullOrEmpty(txtApartir2.Text) ? 0 : Convert.ToInt16(txtApartir2.Text);
                //producto.StateMedida2 = chHabilitar2.Checked;
                
                //condicion 2
                //producto.Equivalencia3 = string.IsNullOrEmpty(txtApartir3.Text) ? 0 : Convert.ToInt16(txtApartir3.Text);
                //producto.StateMedida3 = chHabilitar3.Checked;

                producto.ExistenciaMinima = string.IsNullOrEmpty(txtExistenciaMinima.Text) ? 0 : Convert.ToInt32(txtExistenciaMinima.Text);
                producto.ExistenciaActual = string.IsNullOrEmpty(txtInventarioInicial.Text) ? 0 : Convert.ToInt32(txtInventarioInicial.Text);

                producto.Notificar = chNotificar.Checked;
                producto.FechaExpiracion = dtFechaExpiracion.DateTime;
                producto.MostraNotificar = chMostrarNotificacion.Checked;


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
                producto.PVenta2 = string.IsNullOrEmpty(txtPrecio2.Text) ? 0 : Convert.ToDecimal(txtPrecio2.Text);
                producto.PVenta3 = string.IsNullOrEmpty(txtPrecio3.Text) ? 0 : Convert.ToDecimal(txtPrecio3.Text);
                producto.PVenta4 = string.IsNullOrEmpty(txtPrecio4.Text) ? 0 : Convert.ToDecimal(txtPrecio4.Text);

                producto.PCAnterior = string.IsNullOrEmpty(txtPrecioReal.Text) ? 0 : Convert.ToDecimal(txtPrecioReal.Text);


                if (pEFoto.Image != null)
                    producto.FotoProducto = TratadoImagen.Convertir_Imagen_Bytes(pEFoto.Image);

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
                            ProductoEntraPrecio = string.IsNullOrEmpty(txtPrecioReal.Text)?0:Convert.ToDecimal(txtPrecioReal.Text),
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
                    dt.DataSource = resp;
                    this.unEvento(dt, resp.Count - 1);
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
        }

        private void btnMedida_Click(object sender, EventArgs e)
        {
            XfProductoMedida mvc = new XfProductoMedida();
            if (mvc.ShowDialog() == DialogResult.OK)
            {
                var Medida_ = (from a in new Repository<MedidaMetrica>().GetAll()
                               select new { a.IdMedidaMetrica, a.Name }).ToList();

                lookUnidadMedida.Properties.DataSource = Medida_;
                lookUnidadMedida.Properties.DisplayMember = "Name";
                lookUnidadMedida.Properties.ValueMember = "IdMedidaMetrica";
                lookUnidadMedida.Properties.PopulateColumns();
                lookUnidadMedida.Properties.Columns[0].Visible = false;
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            XfProductoCategoria mvc = new XfProductoCategoria();
            if (mvc.ShowDialog() == DialogResult.OK)
            {
                var Categoria_ = (from a in new Repository<Grupo>().GetAll()
                                  select new { a.IDGrupo, a.Nombre }).ToList();

                lookCategoria.Properties.DataSource = Categoria_;
                lookCategoria.Properties.DisplayMember = "Nombre";
                lookCategoria.Properties.ValueMember = "IDGrupo";
                lookCategoria.Properties.PopulateColumns();
                lookCategoria.Properties.Columns[0].Visible = false;
            }
        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            XfProductoMarca mvc = new XfProductoMarca();
            if (mvc.ShowDialog() == DialogResult.OK)
            {
                var Marca_ = (from a in new Repository<Marca>().GetAll()
                              select new { a.IDMarca, a.NombreMarca }).ToList();

                lookMarca.Properties.DataSource = Marca_;
                lookMarca.Properties.DisplayMember = "NombreMarca";
                lookMarca.Properties.ValueMember = "IDMarca";
                lookMarca.Properties.PopulateColumns();
                lookMarca.Properties.Columns[0].Visible = false;
            }
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
        //public static byte[] Convertir_Imagen_Bytes(Image img)
        //{
        //    string sTemp = Path.GetTempFileName();
        //    FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        //    img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
        //    fs.Position = 0;

        //    int imgLength = Convert.ToInt32(fs.Length);
        //    byte[] bytes = new byte[imgLength];
        //    fs.Read(bytes, 0, imgLength);
        //    fs.Close();
        //    return bytes;
        //}

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //XfProductoUbicacion mvc = new XfProductoUbicacion();
            //if (mvc.ShowDialog() == DialogResult.OK)
            //{
            //    var Ubicacion_ = (from a in new Repository<Ubicacion>().GetAll()
            //                   select new { a.IDUbicacion, a.Nombre }).ToList();

            //    lookEUbicacion.Properties.DataSource = Ubicacion_;
            //    lookEUbicacion.Properties.DisplayMember = "Nombre";
            //    lookEUbicacion.Properties.ValueMember = "IDUbicacion";
            //    lookEUbicacion.Properties.PopulateColumns();
            //    lookEUbicacion.Properties.Columns[0].Visible = false;
            //}
        }
    }
}