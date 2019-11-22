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

namespace Gm.NET.Formularios.Ventas
{
    public partial class XfFacturaReservacioBuscar : DevExpress.XtraEditors.XtraForm
    {
        public List<BillCore> detalle;
        public long IdReservacion = 0;
        public bool Ok = false;
        public Cliente cliente;
        public XfFacturaReservacioBuscar()
        {
            InitializeComponent();
        }

        private void xfFacturaReservacioBuscar_Load(object sender, EventArgs e)
        {
            var resp = new Repository<Reservacion>();
            var lista = (from row in resp.GetAll()
                         where row.Estado=="A"
                         select new
                         {
                             row.IDCliente,
                             row.IDReservacion,
                             //row.Fecha,
                             row.Comentario,
                             row.Estado
                         }).Distinct().ToList();

            List<ReservacionCore> reservaciones = new List<ReservacionCore>();
            foreach (var row in lista)
            {
                var cli = new Repository<Cliente>().Find(x => x.IDCliente == row.IDCliente);
                var p = new Repository<Reservacion>().Find(x => x.IDReservacion == row.IDReservacion);
                reservaciones.Add(new ReservacionCore
                {
                    IDReservacion = row.IDReservacion,
                    cliente = new Repository<Cliente>().Find(x=>x.IDCliente==row.IDCliente),
                    Fecha=p.Fecha,
                    Comentario=row.Comentario,
                    Estado=row.Estado
                });
            }

            gridControl1.DataSource = reservaciones;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var resp = gridView1.GetRow(gridView1.FocusedRowHandle) as ReservacionCore;
            long codigo = Convert.ToInt64(resp.IDReservacion);
            var aux = new Repository<Reservacion>().Search(x => x.IDReservacion==codigo);
            detalle = new List<BillCore>();

            IdReservacion = resp.IDReservacion;
            cliente = resp.cliente;

            foreach (var row in aux)
            {
                long cod = Convert.ToInt64(row.IDMedida);
                var temp = new Repository<MedidaMetrica>().Find(x => x.IdMedidaMetrica == cod);
                detalle.Add(
                    new BillCore
                    {
                        IdProducto = row.IDProducto,
                        Unidades = row.Cantidad,
                        Detalle=new Repository<Producto>().Find(x=>x.IDProducto==row.IDProducto).Nombre,
                        Precio = Convert.ToSingle(row.Precio),
                        Medida = temp,
                        IvaAplica = row.AplicaIva
                    }
                    );
            }
            gridControl2.DataSource = detalle;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                Ok = true;
                Close();
            }    
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Ok = true;
            Close();
        }
    }
}