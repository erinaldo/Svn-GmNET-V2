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
using Gm.Core;
using Gm.Entities;
using DevExpress.XtraGrid;
using Gm.NET.Formularios;
using Gm.Data;

namespace Gm.NET
{
    public partial class XfFacturaProductoAyuda : DevExpress.XtraEditors.XtraForm
    {

        public readonly List<Producto> listaResul;
        private readonly Repository<Producto> repository;
        private readonly ProductoBuscado metodo;

        public ProductoBuscado seleccion;
        public bool bOk = false;

        public int RowTotal;

        #region delegados
        public delegate void Enviar(List<Producto> arg);
        public event Enviar DatosProducto;
        public static XfFacturaProductoAyuda formulario = new XfFacturaProductoAyuda();
        #endregion

        public static XfFacturaProductoAyuda Instance()
        {
            if (((formulario == null) || (formulario.IsDisposed == true)))
                formulario = new XfFacturaProductoAyuda();
            formulario.BringToFront();
            return formulario;
        }

        public XfFacturaProductoAyuda()
        {
            InitializeComponent();
            metodo = new ProductoBuscado();
            listaResul = new List<Producto>();
            repository = new Repository<Producto>();
        }

        private void XtraFormAyuda_Load(object sender, EventArgs e)
        {
            //Obtengo los productos con existencia
            var resp = metodo.ProductosList();

            List<long> keys = new List<long>();
            foreach (var a in resp)
                keys.Add(Convert.ToInt64(a.IDProducto));

            //Agregamos datos que no hay en existencia
            var lista = (from a in repository.GetAll()
                      where keys.Contains(a.IDProducto) == false
                      select new ProductoBuscado {
                          IDProducto=a.IDProducto,
                          Descripcion= a.Nombre,
                          PV1 = a.PVenta1,
                          Existencia =0,
                          medida = a.MedidaMetrica,
                          marca = a.Marca
                      }).ToList();



            resp.AddRange(lista);

            gridControl1.DataSource = resp.OrderBy(x=>x.Descripcion);
            RowTotal = resp.Count;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            bool Result = false;

            listaResul.Clear();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var resp = gridView1.GetRow(i) as ProductoBuscado;
                listaResul.Add(repository.Find(x => x.IDProducto == resp.IDProducto));
            }

            this.DatosProducto(listaResul);

            if (keyData == Keys.Enter || keyData == Keys.Escape)
            {
                Result = true;
                Close();
            }
                

            return Result;

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            seleccion = gridView1.GetRow(gridView1.FocusedRowHandle) as ProductoBuscado;
            bOk = true;
            Close();
        }
    }
}