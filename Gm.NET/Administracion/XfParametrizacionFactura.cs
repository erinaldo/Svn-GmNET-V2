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
using Gm.Data;

namespace Gm.NET.Herramientas
{
    public partial class XfParametrizacionFactura : DevExpress.XtraEditors.XtraForm
    {
        Repository<Parametros> p;
        public XfParametrizacionFactura()
        {
            InitializeComponent();
        }

        private void xfAccesoUsuario_Load(object sender, EventArgs e)
        {
            p = new Repository<Parametros>();
            var aux = p.GetAll().First();
            txtSecuencial.EditValue = aux.NumFactura;
            txtIva.EditValue = aux.Iva;
            if (aux.Foto != null && aux.Foto.Length > 0)
                pEFoto.Image = TratadoImagen.Convertir_Bytes_Imagen(aux.Foto);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
            //progressBarControl1.Properties.Maximum = 100;
            progressBarControl1.EditValue = 1;
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
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

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pEFoto.Image = null;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var aux = p.GetAll().First();
            try
            {
                if (!string.IsNullOrEmpty(txtNuevoSecuencial.Text) && Convert.ToInt16(txtNuevoSecuencial.Text) > 0)
                    aux.NumFactura = Convert.ToInt32(txtNuevoSecuencial.Text);

                if (!string.IsNullOrEmpty(txtNuevoIva.Text) && Convert.ToInt16(txtNuevoIva.Text) > 0)
                    aux.Iva = Convert.ToInt32(txtNuevoIva.Text);

                if (!string.IsNullOrEmpty(pEFoto.EditValue.ToString()))
                    aux.Foto = TratadoImagen.Convertir_Imagen_Bytes(pEFoto.Image);
                else
                    aux.Foto = null;

                if (!p.Update(aux))
                    throw new Exception(p.Error);

                
                for (int i=0;i<100; i++)
                {
                    System.Threading.Thread.Sleep(30);
                    progressBarControl1.EditValue = Convert.ToInt16(progressBarControl1.EditValue) + 1;
                }
                    

            }
            catch (Exception ex)
            {
                backgroundWorker1.Dispose();
                this.Hide();
                XtraMessageBox.Show(ex.Message);
                this.Visible = true;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnGrabar.Enabled = true;
        }
    }
}