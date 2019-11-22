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
    public partial class XuModulos : DevExpress.XtraEditors.XtraUserControl
    {
        public delegate void Enviar();
        //public event Enviar unEvento;

        public static XuModulos xu = new XuModulos();

        ModuloBLL metodo;
        List<Modulos> datos;
        
        Modulos item;
        public XuModulos()
        {
            InitializeComponent();
        }
        private void Mostrar()
        {
            metodo = new ModuloBLL();
            datos = metodo.Mostar;
            var resp = (from a in datos
                        select new MiAcceso
                        {
                            ID = Convert.ToInt16(a.IDModulo),
                            IDParent = Convert.ToInt16(a.Comando),
                            Descripcion = a.Nombre,
                            Estado = Convert.ToBoolean(a.Estado)
                        }).ToList();

            //gridControl1.DataSource = datos;
            treeList1.DataSource = resp;
            
            Cancel();
            btnNuevo.Enabled = ClaseAcceso.ModulosNuevo_;
            btnEditar.Enabled = ClaseAcceso.ModulosEditar_;
            btnEliminar.Enabled = ClaseAcceso.ModulosEliminar_;
        }
        private void xuModulos_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var aux = new Repository<Modulos>();

            txtHijo.EditValue = aux.GetAll().Count + 1; ;
            txtRaiz.EditValue = null; 
            txtNombre.EditValue = null;
            chEstado.Checked = true;
            pCAbajo.Visible = true;
            splitterControl1.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            var item = treeList1.GetFocusedRow() as MiAcceso;

            txtRaiz.EditValue = item.IDParent;
            txtHijo.EditValue = item.ID;
            txtNombre.EditValue = item.Descripcion;
            chEstado.Checked = item.Estado;

            pCAbajo.Visible = true;
            splitterControl1.Visible = true;
            txtNombre.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtRaiz.Text) || String.IsNullOrEmpty(txtHijo.Text))
                    throw new Exception(Mensajes.CamposVacios);
                //if (item.Nombre == txtNombre.Text || item.Comando == txtComando.Text)
                //    throw new Exception(Mensajes.NingunCambio);

                item = new Modulos()
                {
                    IDModulo = (txtHijo.Text == "") ? 0 : Convert.ToInt32(txtHijo.Text),
                    Comando = txtRaiz.Text,
                    Nombre = txtNombre.Text,
                    Estado = chEstado.Checked,
                    
                };
                if (!metodo.Grabar(item))
                    throw new Exception(metodo.Error);

                XtraMessageBox.Show("Engraving done successfully", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Mostrar();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            pCAbajo.Visible = false;
            splitterControl1.Visible = false;
        }
        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }


        private void treeList1_RowClick(object sender, DevExpress.XtraTreeList.RowClickEventArgs e)
        {
            var item = treeList1.GetFocusedRow() as MiAcceso;

            txtRaiz.EditValue = item.ID;
        }
    }
}
