using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Core;
using Gm.Data;
using Gm.Entities;

namespace Gm.NET
{
    public class LecturaArchivo
    {
        private const string fileName = "them.txt";
        private const string fileAccess = "access.txt";

        public string error;

        public string GetTerminal
        {
            get {
                var resp = Properties.Resources.access.Split('-');
                return resp[1];
            }
        }
        public string GetSkin
        {
            get { return mySkin(); }
        }
        public void GetSkink1(string arg)
        {
            string myfile = Properties.Resources.them;
            General.NomSkin = myfile;
        }
        
        public string GetAccess
        {
            get
            {
                return Properties.Resources.access;
            }
        }
        private string mySkin()
        {
            bool Result = File.Exists(fileName) ? true: false;
            
            if (!Result)
            {
                using (StreamWriter mylogs = File.AppendText(fileName))
                {
                    mylogs.WriteLine(Properties.Resources.them);
                    mylogs.Close();
                }
            }

            return File.ReadAllText(fileName);
        }

        public string mySkinSave(string arg)
        {
            File.WriteAllText(fileName, arg);

            return File.ReadAllText(fileName);
        }
        //actualizado de app.config

        public System.Configuration.ConnectionStringSettingsCollection temp;

        public bool UpdateServer(string arg)
        {
            bool Result = true;
            try
            {
                string resp = arg;
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");

                if (connectionStringsSection != null)
                {
                    connectionStringsSection.ConnectionStrings["DB_MMercadoEntities"].ConnectionString = resp;
                    config.Save();
                    ConfigurationManager.RefreshSection("connectionStrings");
                    
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                Result = false;
            }
            return Result;
        }
        
        /// <summary>
        /// Grabamos nueva instalacion
        /// </summary>
        /// <param name="mac">Mac de equipo</param>
        /// <param name="pc">Nombre de equipo</param>
        /// <returns></returns>
        public bool Save(string mac, string pc)
        {
            bool Resp = true;

            LecturaBase bdd = new LecturaBase();

            string cadena = string.Format("Password = {0}; Persist Security Info = True; User ID = {1}; Initial Catalog = {2}; Data Source = {3}",
                bdd.myPassword, bdd.myUsuario, bdd.myCatalog, bdd.myDataSource
                );
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                SqlCommand command = new SqlCommand("Select IDTerminal from Terminal where mac=@mac", conexion);
                command.Parameters.AddWithValue("@mac",mac);

                int result = command.ExecuteNonQuery();
                if (result == -1)
                {
                    String query = "INSERT INTO Terminal (IDTerminal,Mac,Maquina,Oficina,Estado) VALUES (@id,@mac,@pc,@Oficina,@Estado)";

                    command = new SqlCommand(query, conexion);
                    command.Parameters.AddWithValue("@id", 0);
                    command.Parameters.AddWithValue("@mac", mac);
                    command.Parameters.AddWithValue("@pc", pc);
                    command.Parameters.AddWithValue("@Oficina", "NINGUNO");
                    command.Parameters.AddWithValue("@Estado", "A");

                    command.ExecuteNonQuery();
                }
               
            }
            catch (Exception ex)
            {
                error = ex.Message;
                Resp = false;
            }
            finally
            {
                conexion.Close();
            }
            
            return Resp;
        }
        
    }
}
