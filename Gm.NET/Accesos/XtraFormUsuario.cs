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
using MMercadoBLL;
using MMercadoEntities;

namespace MMercadoAPU
{
    public partial class XtraFormUsuario : DevExpress.XtraEditors.XtraForm
    {
        UsuarioBLL metodo;
        List<Usuarios> datos;
        List<Acceso> accesos;
        public XtraFormUsuario()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            metodo = new UsuarioBLL();
            datos = metodo.Datos;

            gridControl1.DataSource = datos;
        }

        private void XtraFormUsuario_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int indice = e.FocusedRowHandle;
            
            txtID.EditValue = datos[indice].IDUsuario;
            txtNombre.EditValue = datos[indice].Nombre;
            txtCedula.EditValue = datos[indice].Cedula;
            txtLogin.EditValue = datos[indice].Login;
            txtPasword.EditValue = datos[indice].Pasword;
            chEstado.EditValue = datos[indice].Estado;

            metodo.Cargar(Convert.ToInt32(txtID.Text));
            accesos = metodo.Accesos;
            gridControl2.DataSource = accesos;

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Usuarios item = new Usuarios()
            {
                IDUsuario = (txtID.Text == "") ? 0 : Convert.ToInt32(txtID.Text),
                Nombre = txtNombre.Text,
                Cedula = txtCedula.Text,
                Estado = chEstado.Checked,
                Login = txtLogin.Text,
                Pasword = txtPasword.Text
            };
            metodo.Grabar(item);
            metodo.Cargar(Convert.ToInt32(txtID.Text));
            accesos = metodo.Accesos;
            gridControl2.DataSource = accesos;

            Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.EditValue = 0;
            txtNombre.EditValue = null;
            txtCedula.EditValue = null;
            txtLogin.EditValue = null;
            txtPasword.EditValue = null;
            chEstado.EditValue = null;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //XtraFormMain form = (XtraFormMain)this.MdiParent;
            //form.tileControlContenedor.Show();
            Close();
        }

        private void gridView2_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colEstado1")
            {
                Acceso a = accesos[e.RowHandle];
                a.Estado = Convert.ToBoolean(e.Value);
                metodo.Actualizar(a);
            }
        }
    }
}