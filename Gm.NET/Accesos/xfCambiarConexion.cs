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
using System.Net.NetworkInformation;
using System.Configuration;
using System.Collections;

using Gm.Data;
using Gm.Entities;
using Gm.NET.ClasesVarias;
using Gm.Core.Generales;

namespace Gm.NET
{
    public partial class xfCambiarConexion : DevExpress.XtraEditors.XtraForm
    {
        string mac = "";
        string pc = "";

        //Data data;
        ArrayList data ;
        ArrayList data1;
        ObtenerPropiedades p;
        LecturaArchivo aux;

        bool Result = true;

        public xfCambiarConexion()
        {
            InitializeComponent();
        }

        private void xfConfigurar_Load(object sender, EventArgs e)
        {
            p = new ObtenerPropiedades();

            mac = p.MyMac;
            pc = p.MyPc;
            btnOk.Enabled = false;
        }

        private void btnLLave_Click(object sender, EventArgs e)
        {
            var re = ConfigurationManager.ConnectionStrings["DB_MMercadoEntities"].ConnectionString;
            string []lista = re.ToString().Split(';');

            data = new ArrayList();

            string aux = mac + pc;
            char[] resp = txtLlave.Text.ToCharArray();
            string cademafinal = "";

            for(int i=1; i < resp.Length-1; i++)
            {
                cademafinal += resp[i];
            }


            if (aux == Encriptar.myDesEncriptar(cademafinal))
            {
                btnOk.Enabled = true;

                foreach (string item in lista)
                    data.Add(new ConfigFile { linea= item });

                gridControl1.DataSource = data;
            }

            else
            {
                this.Visible = false;
                XtraMessageBox.Show("Clave introducida es incorrecta, favor comuniquese con\nproveedor del producto para su activacion",
                    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtLlave.EditValue = null;
                txtLlave.Focus();
                this.Visible = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(1);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string resp = "";
            int total = 3;
            int coun = 0;
            int percentage = 0;

            aux = new LecturaArchivo();
            data1 = (ArrayList)data.Clone();

            //cramos la cadena de cambio
            //1. -
            resp = cadena(data);

            percentage = (coun ++) * 100 / total;
            bgw.ReportProgress(percentage);

            //2. -
            if (aux.UpdateServer(resp))
            {
                percentage = (coun++) * 100 / total;
                bgw.ReportProgress(percentage);

                if (!new LecturaBase().myStateConexion)
                    Result = false;
            }
            //3. -
            if (!Result)
            {
                percentage = (coun++) * 100 / total;
                bgw.ReportProgress(percentage);

                aux.UpdateServer(cadena(data1));
            }
            //4. -
            if (Result)
            {
                percentage = (coun++) * 100 / total;
                bgw.ReportProgress(percentage);

                aux.Save(mac, pc);
            }

        }

        private string cadena(ArrayList data)
        {
            string resp = "";

            for (int i = 0; i < data.Count - 1; i++)
            {
                resp += (data[i] as ConfigFile).linea + ";";

            }
            resp += (data[data.Count - 1] as ConfigFile).linea;
            return resp;
        }
        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Result)
            {
                this.Hide();
                XtraMessageBox.Show("Cambio realizado con exito, precione Aceptar para iniciar\nnuevamente la aplicación..",
                    "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnCancel_Click(null, null);
            }
            else
            {
                XtraMessageBox.Show("No se logro completar el proceso", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnOk.Enabled = true;
            }
        }
    }

}