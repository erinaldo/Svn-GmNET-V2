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

namespace Gm.NET.Formularios
{
    public partial class XfProductoActivaColumnas : DevExpress.XtraEditors.XtraForm
    {
        public Dictionary<string,bool> col_;

        public XfProductoActivaColumnas()
        {
            InitializeComponent();
        }

        

        private void xfProductoActivaColumnas_Load(object sender, EventArgs e)
        {
            try
            {
                chCodigoBarras.CheckState = (col_["CCodBarra"]) ? CheckState.Checked : CheckState.Unchecked;
                chIva.CheckState = col_["CIvaA"] ? CheckState.Checked : CheckState.Unchecked;
                chPV2.CheckState = col_["CPv2A"] ? CheckState.Checked : CheckState.Unchecked;
                chPV3.CheckState = col_["CPv3A"] ? CheckState.Checked : CheckState.Unchecked;
                chEquivalencia1.CheckState = col_["CEqui1A"] ? CheckState.Checked : CheckState.Unchecked;
                chEquivalencia2.CheckState = col_["CEqui2A"] ? CheckState.Checked : CheckState.Unchecked;
                chEquivalencia3.CheckState = col_["CEqui3A"] ? CheckState.Checked : CheckState.Unchecked;
                chUltimaCompraFecha.CheckState = col_["CUltimaCompraA"] ? CheckState.Checked : CheckState.Unchecked;
                chUltimaVentaFecha.CheckState = col_["CUltimaVentaA"] ? CheckState.Checked : CheckState.Unchecked;
                chPVA1.CheckState = col_["CPrecioAnteriorVenta1"] ? CheckState.Checked : CheckState.Unchecked;
                chPVA2.CheckState = col_["CPrecioAnteriorVenta2"] ? CheckState.Checked : CheckState.Unchecked;
                chPVA3.CheckState = col_["CPrecioAnteriorVenta3"] ? CheckState.Checked : CheckState.Unchecked;
                chDescripcionAnterior.CheckState = col_["CNombreAnterior"] ? CheckState.Checked : CheckState.Unchecked;
                chCodigoRapido.CheckState = col_["CCodigoRapido"] ? CheckState.Checked : CheckState.Unchecked;
                chExistenciaMinima.CheckState = col_["CExistenciaMinima"] ? CheckState.Checked : CheckState.Unchecked;
                chMarca.CheckState = col_["CMarca"] ? CheckState.Checked : CheckState.Unchecked;
                chCategoria.CheckState = col_["CCategoria"] ? CheckState.Checked : CheckState.Unchecked;
                chEstado.CheckState = col_["CEstado"] ? CheckState.Checked : CheckState.Unchecked;
                chExistenciaActual.CheckState = col_["CExistenciaActual"] ? CheckState.Checked : CheckState.Unchecked;
                chFoto.CheckState = col_["CFotoProducto"] ? CheckState.Checked : CheckState.Unchecked;
                chPrecioCompraAnterior.CheckState = col_["CPCAnterior"] ? CheckState.Checked : CheckState.Unchecked;
            }
            catch { }
            

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {

            col_ = new Dictionary<string, bool>();

            col_.Add("CCodBarra", chCodigoBarras.Checked);
            col_.Add("CIvaA", chIva.Checked);
            col_.Add("CPv2A", chPV2.Checked);
            col_.Add("CPv3A", chPV3.Checked);
            col_.Add("CEqui1A", chEquivalencia1.Checked);
            col_.Add("CEqui2A", chEquivalencia2.Checked);
            col_.Add("CEqui3A", chEquivalencia3.Checked);
            col_.Add("CUltimaVentaA", chUltimaVentaFecha.Checked);
            col_.Add("CUltimaCompraA", chUltimaCompraFecha.Checked);
            col_.Add("CPrecioAnteriorVenta1", chPVA1.Checked);
            col_.Add("CPrecioAnteriorVenta2", chPVA2.Checked); 
            col_.Add("CPrecioAnteriorVenta3", chPVA3.Checked);
            col_.Add("CNombreAnterior", chDescripcionAnterior.Checked);
            col_.Add("CCodigoRapido", chCodigoRapido.Checked);
            col_.Add("CExistenciaMinima", chExistenciaMinima.Checked);
            col_.Add("CMarca", chMarca.Checked);
            col_.Add("CCategoria", chCategoria.Checked);
            col_.Add("CEstado", chEstado.Checked);
            col_.Add("CExistenciaActual", chExistenciaActual.Checked);
            col_.Add("CFotoProducto", chFoto.Checked);
            col_.Add("CPCAnterior", chPrecioCompraAnterior.Checked);



            var aux = new Repository<Usuarios>();
            var resp = aux.Find(x=>x.IDUsuario == General.IdUsuario);
            resp.CCodBarra = col_["CCodBarra"];
            resp.CIvaA = col_["CIvaA"];
            resp.CPv2A = col_["CPv2A"];
            resp.CPv3A = col_["CPv3A"];
            resp.CEqui1A = col_["CEqui1A"];
            resp.CEqui2A = col_["CEqui2A"];
            resp.CEqui3A = col_["CEqui3A"];
            resp.CUltimaVentaA = col_["CUltimaVentaA"];
            resp.CUltimaCompraA = col_["CUltimaCompraA"];
            resp.CPrecioAnteriorVenta1 = col_["CPrecioAnteriorVenta1"];
            resp.CPrecioAnteriorVenta2 = col_["CPrecioAnteriorVenta2"];
            resp.CPrecioAnteriorVenta3 = col_["CPrecioAnteriorVenta3"];
            resp.CNombreAnterior = col_["CNombreAnterior"];
            resp.CCodigoRapido = col_["CCodigoRapido"];
            resp.CExistenciaMinima = col_["CExistenciaMinima"];
            resp.CMarca = col_["CMarca"];
            resp.CCategoria = col_["CCategoria"];
            resp.CEstado = col_["CEstado"];
            resp.CExistenciaActual = col_["CExistenciaActual"];
            resp.CFotoProducto = col_["CFotoProducto"];
            resp.CPCAnterior = col_["CPCAnterior"];

            aux.Update(resp);
            Close();
        }
    }
}