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

using Gm.Core;
using Gm.Entities;
using Gm.Core.Generales;
using Gm.Data;

namespace Gm.NET.Herramientas
{
    public partial class XuUsuarios : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        public event Enviar unEvento;

        public static XuUsuarios xu = new XuUsuarios();

        Usuarios item;
        List<MiAcceso> miAccesos;

        public XuUsuarios()
        {
            InitializeComponent();
        }

        void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
            gridVUsuarios.Focus();
        }
        
        void function()
        {
            var resp = new UsuarioBLL();
            gridCUsuarios.DataSource = resp.MyUsers;

            Cancel();
        }
        
        private void xuUsuarios_Load(object sender, EventArgs e)
        {
            function();
            btnNuevo.Enabled = ClaseAcceso.UsuariosNuevo_;
            btnEditar.Enabled = ClaseAcceso.UsuariosEditar_;
            btnEliminar.Enabled = ClaseAcceso.UsuariosEliminar_;
            btnAplicar.Enabled = ClaseAcceso.UsuariosNuevo_;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            item = null;
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;

            txtLogin.Enabled = true;
            txtID.EditValue = null;
            txtNombre.EditValue = null;
            txtCedula.EditValue = null;
            txtLogin.EditValue = null;
            txtPasword.EditValue = null;
            //xtraTabControl1.TabPages[1].Select();
            txtID.EditValue = null;
            //btnAcceso.Enabled = false;
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;

            item = gridVUsuarios.GetRow(gridVUsuarios.FocusedRowHandle) as Usuarios;

            txtID.EditValue = item.IDUsuario;
            txtNombre.EditValue = item.Nombre;
            txtCedula.EditValue = item.Cedula;
            txtLogin.EditValue = item.Login;
            txtPasword.EditValue = item.Pasword;
            chEstado.EditValue = item.Estado;
            //btnAcceso.Enabled = true;
            txtNombre.Focus();

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCedula.Text) ||
                string.IsNullOrEmpty(txtLogin.Text) || string.IsNullOrEmpty(txtPasword.Text))
                XtraMessageBox.Show(Mensajes.CamposVacios);

            else
            {
                var metodo = new UsuarioBLL();
                bool Resul = true;

                if (item == null)
                {
                    var tmp = new Repository<Usuarios>().GetAll().Count;

                    if(!metodo.Grabar(new Usuarios {
                        IDUsuario= tmp+1,
                        Nombre = txtNombre.Text,
                        Cedula = txtCedula.Text,
                        Estado = chEstado.Checked,
                        Login = txtLogin.Text,
                        Pasword = txtPasword.Text
                    }))
                    {
                        Resul = false;
                        XtraMessageBox.Show(metodo.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    item.Nombre = txtNombre.Text;
                    item.Cedula = txtCedula.Text;
                    item.Estado = chEstado.Checked;
                    item.Login = txtLogin.Text;
                    item.Pasword = txtPasword.Text;
                    if (!metodo.Update(item))
                    {
                        Resul = false;
                        XtraMessageBox.Show(metodo.Error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (Resul)
                {
                    function();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuarios resp = gridVUsuarios.GetRow(gridVUsuarios.FocusedRowHandle) as Usuarios;
            var metodo = new UsuarioBLL();

            if (metodo.Delete(resp))
                function();
            else
                XtraMessageBox.Show(metodo.Error);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            function();
        }

        private void gridVUsuarios_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Cancel();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.unEvento();
        }

        private void gridVUsuarios_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var resp = gridVUsuarios.GetRow(gridVUsuarios.FocusedRowHandle) as Usuarios;

            var permisos = new Repository<Acceso>();
            var modulos = new Repository<Modulos>().GetAll();
            //Quitamos todos lo activos

            foreach(var row in modulos)
                row.Estado = false;

            //Actualizamos las propiedades
            foreach (var a in modulos)
            {
                long IDM = a.IDModulo;
                long IDU = resp.IDUsuario;

                var aux = permisos.Find(x => x.IDModulo == IDM && x.IDUsuario == IDU);
                if(aux!=null)
                    a.Estado = aux.Estado;
            }

            miAccesos = new List<MiAcceso>();
            foreach (var a in modulos)
            {
                miAccesos.Add(new MiAcceso
                {
                    ID = Convert.ToInt32(a.IDModulo),
                    IDParent = Convert.ToInt32(a.Comando),
                    Descripcion = a.Nombre,
                    Estado = Convert.ToBoolean(a.Estado)
                });
            }


            //treeList1.DataSource = miAccesos.OrderBy(x=>x.Descripcion).ToList();
            treeList1.DataSource = miAccesos;
            textEdit1.EditValue = resp.Nombre;

            
        }

        private void BtnAplicar_Click(object sender, EventArgs e)
        {
            var usuario = gridVUsuarios.GetRow(gridVUsuarios.FocusedRowHandle) as Usuarios;

            try
            {
                using (var resp = new Repository<Acceso>())
                {
                    long IDU = usuario.IDUsuario;
                    //borramos para crear nuevamente
                    foreach (var a in resp.GetAll())
                    {
                        var tmp = resp.Find(x => x.IDUsuario == IDU);
                        resp.Delete(tmp);
                    }
                    //Creamos en caso de que sea nuevo
                    var noExiste = resp.Find(x => x.IDUsuario == IDU);
                    if (noExiste==null)
                    {
                        resp.AddRange((from a in miAccesos
                                       select new Acceso
                                       {
                                           IDUsuario = IDU,
                                           IDModulo = a.ID,
                                           Estado = a.Estado
                                       }).ToList());


                        if (!resp.Save())
                            throw new Exception(resp.Error);
                    }
                    //Empezamos a modificar
                    //else
                    //{
                    //    var cadena="";
                    //    foreach(var row in miAccesos)
                    //    {
                    //        var tmp = resp.Find(x => x.IDModulo == row.ID && x.IDUsuario == IDU);
                    //        if (tmp != null)
                    //        {
                    //            tmp.Estado = row.Estado;
                    //            if (!resp.Update(tmp))
                    //                throw new Exception(resp.Error);
                    //        }
                    //        else
                    //            cadena = cadena + "Error -> "+row.Descripcion+" \n";
                    //    }
                    //    if (!string.IsNullOrEmpty(cadena))
                    //        throw new Exception(cadena);
                    //}

                }
                //this.Hide();
                XtraMessageBox.Show("Guardado Correcto", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
