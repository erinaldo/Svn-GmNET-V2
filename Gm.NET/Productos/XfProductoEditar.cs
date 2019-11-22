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
using System.IO;

namespace Gm.NET.Formularios
{ 
    public partial class XfProductoEditar : DevExpress.XtraEditors.XtraForm
    {
        public Producto producto_;
        public XfProductoEditar()
        {
            InitializeComponent();
        }

        private void xfProductoEditar_Load(object sender, EventArgs e)
        {
            #region combox
            ProductoBLL metodo = new ProductoBLL();
            var Categoria_ = (from a in new Repository<Grupo>().GetAll()
                              select new { a.IDGrupo, a.Nombre }).ToList();

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

            Carga();
        }
        private void Carga()
        {
            txtCodigo.EditValue = producto_.IDProducto;
            chEstado.Checked = producto_.Estado == "A" ? true : false;
            txtExistencia1.EditValue = producto_.ExistenciaActual;
            txtDescripcion.EditValue = producto_.Nombre;
            txtCosto.EditValue = string.Empty;
            txtPrecioReal.EditValue = producto_.PCAnterior;
            txtPrecioVenta.EditValue = producto_.PVenta1;
            cbxIva.SelectedIndex = Convert.ToBoolean(producto_.Iva) ? 1 : 0;
            txtExistenciaMinima.EditValue = producto_.ExistenciaMinima;
            txtUtilidad.EditValue = string.Empty;
            txtCodigoRapido.EditValue = producto_.CodRapido;
            lookUnidadMedida.EditValue = producto_.IDMedidaMetrica;
            txtCodigoBarra.EditValue = producto_.CodBarra;
            lookCategoria.EditValue = producto_.IDGrupo;
            txtExistenciaActual.EditValue = producto_.ExistenciaActual;
            lookMarca.EditValue = producto_.IDMarca;
            //lookEUbicacion.EditValue = producto_.IDUbicacion;
            pEFoto.EditValue = string.Empty;
            chNotificar.Checked = false;
            dtFechaExpiracion.EditValue = string.Empty;
            chMostrarNotificacion.EditValue = false;

            //chHabilitar2.Checked = Convert.ToBoolean(producto_.StateMedida2);
            txtPrecio2.EditValue = producto_.PVenta2;
            //txtApartir2.EditValue = producto_.Equivalencia2;
            //txtPrecio2.Enabled = txtApartir2.Enabled = chHabilitar2.Checked;

            //chHabilitar3.Checked = Convert.ToBoolean(producto_.StateMedida3);
            txtPrecio3.EditValue = producto_.PVenta3;
            txtPrecio4.EditValue = producto_.PVenta4;
            //txtApartir3.EditValue = producto_.Equivalencia3;
            //txtPrecio3.Enabled = txtApartir3.Enabled = chHabilitar3.Checked;

            chNotificar.Checked = Convert.ToBoolean(producto_.Notificar);
            dtFechaExpiracion.EditValue = producto_.FechaExpiracion;
            dtFechaExpiracion.Enabled = chNotificar.Checked;
            chMostrarNotificacion.Checked = Convert.ToBoolean(producto_.MostraNotificar);
            if (producto_.FotoProducto!=null && producto_.FotoProducto.Length > 0)
                pEFoto.Image = TratadoImagen.Convertir_Bytes_Imagen(producto_.FotoProducto);

            //buscamos todos los proveedores de ese producto
            
            try
            {
                var pro = new Repository<Proveedor>().Search(x => x.IDProducto == producto_.IDProducto);
                var prove = new List<Cliente>();
                var repoPro = new Repository<Cliente>();

                foreach(var row in pro)
                {
                    var aux = repoPro.Find(x=>x.IDCliente==row.IDCliente);
                    prove.Add(aux);
                }
                gridControl1.DataSource = prove;
            }
            catch (Exception) { }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Close();
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
        private void Guardar()
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text) && string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
                    throw new Exception("Ingrese el detalle del producto para continuar");

                var prod = new Repository<Producto>();
                
                Producto producto = prod.Find(x => x.IDProducto == producto_.IDProducto);

                producto.FechaSistema = DateTime.Now;
                producto.Estado = (chEstado.CheckState == CheckState.Checked) ? "A" : "E";

                producto.NombreAnterior = producto.Nombre;
                producto.Nombre = txtDescripcion.Text;
                producto.EdNombre = true;

                producto.PVAnterior1 = producto.PVenta1;
                producto.PVenta1 = string.IsNullOrEmpty(txtPrecioVenta.Text) ? 0 : Convert.ToDecimal(txtPrecioVenta.Text);
                producto.Iva = (cbxIva.EditValue.Equals("No")) ? false : true;
                producto.Equivalencia1 = 1;
                producto.EdPVenta1 = true;

                producto.ExistenciaMinima = string.IsNullOrEmpty(txtExistenciaMinima.Text) ? 0 : Convert.ToInt32(txtExistenciaMinima.Text);



                producto.CodRapido = txtCodigoRapido.Text;
                //producto.
                producto.CodRapido = txtCodigoRapido.Text;
                producto.IDMedidaMetrica = (lookUnidadMedida.EditValue == null) ? 1 : Convert.ToInt32(lookUnidadMedida.EditValue);
                producto.CodBarra = txtCodigoBarra.Text;
                producto.IDGrupo = (lookCategoria.EditValue == null) ? 1 : Convert.ToInt32(lookCategoria.EditValue);

                if (string.IsNullOrEmpty(txtInventarioInicial.Text))
                {
                    producto.ExistenciaActual = Convert.ToInt16(txtExistenciaActual.Text);
                }
                else
                {
                    var a1 = (string.IsNullOrEmpty(txtExistenciaActual.Text)) ? 0 : Convert.ToInt32(txtExistenciaActual.Text);
                    var b1 = Convert.ToInt32(txtInventarioInicial.Text);

                    producto.ExistenciaActual = a1 + b1;
                }
                producto.PCAnterior = string.IsNullOrEmpty(txtPrecioReal.Text) ? 0 : Convert.ToDecimal(txtPrecioReal.Text);

                producto.IDMarca = (lookMarca.EditValue == null) ? 1 : Convert.ToInt32(lookMarca.EditValue);
                //producto.IDUbicacion = (lookEUbicacion.EditValue == null) ? 1 : Convert.ToInt32(lookEUbicacion.EditValue);


                //codicion 1
                producto.PVAnterior2 = producto.PVenta2;
                producto.PVenta2 = string.IsNullOrEmpty(txtPrecio2.Text) ? 0 : Convert.ToDecimal(txtPrecio2.Text);
                //producto.Equivalencia2 = string.IsNullOrEmpty(txtApartir2.Text) ? 0 : Convert.ToInt16(txtApartir2.Text);
                //producto.StateMedida2 = chHabilitar2.Checked;
                producto.EdPVenta2 = true;

                //condicion 2
                producto.PVAnterior3 = producto.PVenta3;
                producto.PVenta3 = string.IsNullOrEmpty(txtPrecio3.Text) ? 0 : Convert.ToDecimal(txtPrecio3.Text);
                //producto.Equivalencia3 = string.IsNullOrEmpty(txtApartir3.Text) ? 0 : Convert.ToInt16(txtApartir3.Text);
                //producto.StateMedida3 = chHabilitar3.Checked;
                producto.EdPVenta3 = true;

                producto.PVenta4 = string.IsNullOrEmpty(txtPrecio4.Text) ? 0 : Convert.ToDecimal(txtPrecio4.Text);


                producto.Notificar = chNotificar.Checked;
                producto.FechaExpiracion = dtFechaExpiracion.DateTime;
                producto.MostraNotificar = chMostrarNotificacion.Checked;

                if (!string.IsNullOrEmpty(pEFoto.EditValue.ToString()))
                    producto.FotoProducto = TratadoImagen.Convertir_Imagen_Bytes(pEFoto.Image);


                if (!prod.Update(producto))
                {

                    this.Hide();
                    XtraMessageBox.Show(prod.Error);
                    this.Visible = true;
                }
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
                            ProductoEntraPrecio = 0,
                            ProductoSale = 0,
                            ProductoSalePrecio = 0,
                            IVA = (producto.Iva != null) ? Convert.ToInt16(General.Iva) : 0,
                            IDFactura = "I" + con1,
                            Estado = "A",
                            Fecha = DateTime.Now,
                            FechaSistema = DateTime.Now,
                            Equivalencia = Convert.ToInt16(txtInventarioInicial.Text),
                            IdMedidaMetrica = producto.MedidaMetrica.IdMedidaMetrica,
                            IDUbicacion = producto.IDUbicacion,
                            Referencia = 0,
                            Siclo = "R"
                        });
                    }
                }
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
            
                
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
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
            try
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
            catch(Exception) { }
        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        {
            pEFoto.Image = null;
        }

        private void chEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            //XfProductoUbicacion mvc = new XfProductoUbicacion();
            //if (mvc.ShowDialog() == DialogResult.OK)
            //{
            //    var Ubicacion_ = (from a in new Repository<Ubicacion>().GetAll()
            //                      select new { a.IDUbicacion, a.Nombre }).ToList();

            //    lookEUbicacion.Properties.DataSource = Ubicacion_;
            //    lookEUbicacion.Properties.DisplayMember = "Nombre";
            //    lookEUbicacion.Properties.ValueMember = "IDUbicacion";
            //    lookEUbicacion.Properties.PopulateColumns();
            //    lookEUbicacion.Properties.Columns[0].Visible = false;
            //}
        }
    }
}