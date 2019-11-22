using System;
using Gm.Core;
using Gm.Core.Generales;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors;
using Gm.NET.Formularios;
using System.IO;
using DevExpress.Skins;
using Gm.NET.Formularios.Accesos;
using Gm.Data;
using Gm.Entities;
using Gm.NET.ClasesVarias;
using System.Linq;

namespace Gm.NET
{
    public partial class XtraFormLogin : DevExpress.XtraEditors.XtraForm
    {
        #region variables
        public bool btOk = false;
        bool Result = false;
        bool Conexion = false;
        UsuarioBLL metodo;
        private int intento = 0;
        const int maximo = 3;
        #endregion

        public XtraFormLogin()
        {
            InitializeComponent();
        }

        void Mostrar()
        {
            this.Text = General.MyVersion;

            Result = metodo.Login(txtUsuario.Text, txtPassword.Text);
            if (!Result)
            {
                XtraMessageBox.Show("Comuniquese con el proveedor del software...\n equipo "+ metodo.Error,"Alerta");
                intento++;
            }
        }

        void Verificar()
        {
            using (var resp = new Repository<Terminal>())
            {
                //var p = new ObtenerPropiedades();
                var p = new LecturaArchivo();


                //var aux = resp.Find(x => x.Mac.Equals(p.GetAccess));
                var aux = (from row in resp.GetAll()
                           where row.IDTerminal == Convert.ToInt16(p.GetTerminal)
                           select row).First();


                if (aux != null)
                {
                    General.Oficina = aux.Oficina;
                    General.Terminal = aux.IDTerminal.ToString();
                    //General.FotoEmpres = aux.
                    Conexion = false;
                }
                else
                    Conexion = true;
                //Conexion = true;
            }
        }

        void Cargar()
        {
            //carga inicial
            using (xfCargaBasica frm = new xfCargaBasica(Verificar))
            {
                frm.ShowDialog(this);
            }

            if (Conexion)
            {
                this.Hide();
                xfCambiarConexion m = new xfCambiarConexion();
                m.ShowDialog();
            }
        }

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
            metodo = new UsuarioBLL();
            this.Text = General.MyVersion;

            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(new LecturaArchivo().GetSkin);
            labelControl3.Text = string.Format("Intento {0} de 3", intento);
            var resp = new ParametrosBLL();
            General.Iva = resp.myIva;
            General.FotoEmpres = resp.myFoto;
            do
            {
                Cargar();

            } while (Conexion == true);
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            using (xfCargaBasica frm = new xfCargaBasica(Mostrar))
            {
                frm.ShowDialog(this);
            }
            if (Result)
            {
                this.Hide();
                RibbonFormMenu principa = new RibbonFormMenu();
                principa.Show();
            }
            else if (!Result)
            {
                if (intento == maximo)
                {
                    this.Hide();
                    XtraMessageBox.Show("Numero de intentos exedidos se cierra la aplicación\npor seguridad...",
                        "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                txtUsuario.EditValue = string.Empty;
                txtPassword.EditValue = string.Empty;
                txtUsuario.Focus();
                labelControl3.Text = string.Format("Intento {0} de 3", intento);
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void txtUsuario_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                txtUsuario.Focus();
                txtUsuario.SelectAll();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnOk.Focus();
            }        
        }
    }
}