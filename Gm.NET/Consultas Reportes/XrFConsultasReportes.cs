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
using DevExpress.Spreadsheet.Charts;

namespace Gm.NET.Formularios
{
    public partial class XrFConsultasReportes : DevExpress.XtraEditors.XtraForm
    {

        DateTime fechaVentasRealizadas;
        MovimientoKardexBLL comprasvsVentas;
        KardexBLL movimientoProducto;
        KardexBLL estadisticaProducto;
        public XrFConsultasReportes()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Obtiene las ventas realizadas para sacar la invercion realizada
        /// </summary>
        public void VentaRealizada()
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
            gridView1.ViewCaption = string.Format("MOVIENTOS DE ({0})", fechaVentasRealizadas.ToShortDateString());

            var fecha = Convert.ToDateTime(fechaVentasRealizadas.ToShortDateString()).Ticks;

            var _ventasRealizadas = new Repository<Kardex>().Search(x => x.Equivalencia < 0 && x.Estado == "A").
                Where(x => x.Fecha.Value.ToShortDateString() == fechaVentasRealizadas.ToShortDateString()).ToList();

            List<VistaVentaCore> ventas = new List<VistaVentaCore>();

            if (_ventasRealizadas != null)
            {
                foreach (var fila in _ventasRealizadas)
                {

                    var temp = (from item in new Repository<Kardex>().GetAll()
                                where item.IDKardex == fila.Referencia && item.IDProducto == fila.IDProducto
                                select item
                                ).First();

                    if (temp != null)
                        fila.ProductoEntraPrecio = temp.ProductoEntraPrecio;
                }

                ventas = (from item in _ventasRealizadas
                          select new VistaVentaCore
                          {
                              IDProducto = item.IDProducto,
                              Nombre = item.Producto.Nombre,
                              Cantidad = item.ProductoSale,
                              PVenta = item.ProductoSalePrecio,
                              PCompra = item.ProductoEntraPrecio,
                              Fecha = item.Fecha,
                              Venta = item.ProductoSale * item.ProductoSalePrecio,
                              Inversion = item.ProductoEntraPrecio * item.ProductoSale,
                              Ganancia = (item.ProductoSalePrecio - item.ProductoEntraPrecio) * item.ProductoSale
                          }).ToList();
            }

            var aux = ventas.
                GroupBy(x => x.IDProducto).
                Select(cl => new VistaVentaCore
                {
                    Nombre = cl.First().Nombre,
                    Cantidad = cl.Sum(c => c.Cantidad),
                    Venta = cl.Sum(c => c.Venta),
                    Inversion = cl.Sum(c => c.Inversion),
                    Ganancia = cl.Sum(c => c.Ganancia),
                    Fecha = cl.First().Fecha
                }).ToList();

            lcTotalVenta.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Venta));
            lcTotalGanancia.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Ganancia));
            lcInversionRealizada.Text = string.Format("{0:0.000}", ventas.Sum(x => x.Inversion));

            gridControl1.DataSource = aux;
        }
        public void ComprasvsVentas()
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
            comprasvsVentas = new MovimientoKardexBLL();
            pivotGridControl1.DataSource = comprasvsVentas.Cargar();
            chartControl1.DataSource = pivotGridControl1.DataSource;
        }
        public void MovimientoProducto()
        {
            try
            {
                xtraTabControl1.SelectedTabPageIndex = 2;
                movimientoProducto = new KardexBLL();
                var repositoryProcedure = new Repository<Sp_ProcedureKardex_Result>();
                var lista = repositoryProcedure.SQLQuery("EXEC Sp_ProcedureKardex");

                List<VistaKardex> vista = (from item in lista
                                           where item.Estado!="E"
                                           select new VistaKardex
                                           {
                                               IDKardex = Convert.ToInt32(item.IDKardex),
                                               IDProducto = item.IDProducto,
                                               Producto = item.Producto,
                                               ProductoEntra = item.ProductoEntra,
                                               ProductoEntraPrecio = item.ProductoEntraPrecio,
                                               ProductoSale = item.ProductoSale,
                                               ProductoSalePrecio = item.ProductoSalePrecio,
                                               IVA = item.IVA,
                                               Fecha = item.Fecha,
                                               Estado = item.Estado,
                                               Medida = item.Medida
                                           }).ToList();

                chartControl2.DataSource = vista;
                //https://www.youtube.com/watch?v=f3w4RAyBbhg
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        public void EstadisticaProducto()
        {
            Dictionary<string, Series> seriesList = new Dictionary<string, Series>();
            try
            {
                xtraTabControl1.SelectedTabPageIndex = 3;
                estadisticaProducto = new KardexBLL();
                var repositoryProcedure = new Repository<Sp_ProcedureKardex_Result>();

                var lista = repositoryProcedure.SQLQuery("EXEC Sp_ProcedureKardex");

                List<VistaKardex> vista = (from item in lista
                                           where item.Estado!="E"
                                           select new VistaKardex
                                           {
                                               IDKardex = Convert.ToInt32(item.IDKardex),
                                               IDProducto = item.IDProducto,
                                               Producto = item.Producto,
                                               ProductoEntra = item.ProductoEntra,
                                               ProductoEntraPrecio = item.ProductoEntraPrecio,
                                               ProductoSale = item.ProductoSale,
                                               ProductoSalePrecio = item.ProductoSalePrecio,
                                               IVA = item.IVA,
                                               Fecha = item.Fecha,
                                               Estado = item.Estado,
                                               Medida = item.Medida
                                           }).ToList();

                pivotGridControl2.DataSource = vista;

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }


            //https://www.youtube.com/watch?v=f3w4RAyBbhg
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            using (Formularios.XfFecha form = new Formularios.XfFecha { fecha = this.fechaVentasRealizadas })
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    fechaVentasRealizadas = form.fecha;
                    VentaRealizada();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            VentaRealizada();
        }

        private void XrFConsultasReportes_Load(object sender, EventArgs e)
        {
            fechaVentasRealizadas = DateTime.Now;
            VentaRealizada();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MovimientoProducto();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            //var a = xtraTabControl1.SelectedTabPageIndex;
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 0:
                    VentaRealizada();
                    break;
                case 1:
                    ComprasvsVentas();
                    break;
                case 2:
                    MovimientoProducto();
                    break;
                case 3:
                    EstadisticaProducto();
                    break;
            }
        }
        public void Cerrar()
        {
            Close();
        }
    }
}