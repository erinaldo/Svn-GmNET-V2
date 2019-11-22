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
using System.Configuration;
using System.Data.SqlClient;
using Gm.Core;
using Gm.NET.ClasesVarias;
using System.IO;

namespace Gm.NET.Herramientas
{
    public partial class XfCopiaBDD : DevExpress.XtraEditors.XtraForm
    {
       
        private string myFolder = "C:\\myBase";
        public XfCopiaBDD()
        {
            InitializeComponent();
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            btnCancel.Enabled = false;
            myBGWorker.RunWorkerAsync();
        }
        public void Porcesar()
        {
            LecturaBase bdd = new LecturaBase();

            if (bdd.myCatalog!=null)
            {
                string nombreCopia = string.Format("{0}-{1}-{2}-{3}-{4}-{5}-{6}.bak",
                    bdd.myCatalog,
                    DateTime.Now.Year, 
                    DateTime.Now.Month, 
                    DateTime.Now.Day,
                    DateTime.Now.Hour,
                    DateTime.Now.Minute,
                    DateTime.Now.Second
                    );

                createFolder();

                string comando_consulta = "BACKUP DATABASE [" + bdd.myCatalog + "]" +
                    "TO DISK = N'"+myFolder+"\\" + nombreCopia + "' WITH NOFORMAT, NOINIT, NAME = N'" + nombreCopia +
                    "-Completa Base de datos Copia de seguridad',SKIP, NOREWIND, STATS = 10";


                string myConection = "SERVER =" + bdd.myDataSource + "; DATABASE = " + bdd.myCatalog + "; Uid = " + bdd.myUsuario + "; Pwd = " + bdd.myPassword;

                SqlConnection connection = new SqlConnection(myConection);
                SqlCommand cmd = new SqlCommand(comando_consulta, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    //error = ex.Message;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                    
                }
            }
        }

        private void createFolder()
        {
            if (!Directory.Exists(myFolder))
                Directory.CreateDirectory(myFolder);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xfLimpiezaBDD_Load(object sender, EventArgs e)
        {
            myBGWorker.WorkerReportsProgress = true;
        }

        private void myBGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarControl1.EditValue = e.ProgressPercentage;
        }

        private void myBGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Porcesar();
            for (int i=0; i < 100; i++)
            {
                if (i == 100)
                    i = 0;
                myBGWorker.ReportProgress(i);
            }
        }

        private void myBGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarControl1.EditValue = 100;
            btnCancel.Enabled = true;
            btnOK.Enabled = true;
            XtraMessageBox.Show("Engraving done successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}