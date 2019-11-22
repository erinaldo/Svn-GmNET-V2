using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Core;

namespace Gm.NET
{
    public class LecturaBase
    {
        private string servidor = "";
        private string usuario = "";
        private string password = "";
        private string catalogo = "";
        public string nombreConexion = "gm_mmercadoEntities";

        
        public LecturaBase()
        {
            getData();
        }

        /// <summary>
        /// DATA SOURCE o SERVIDOR
        /// </summary>
        public string myDataSource { get { return servidor; } }
        /// <summary>
        /// USER ID
        /// </summary>
        public string myUsuario { get { return usuario; } }
        /// <summary>
        /// PASSWORD
        /// </summary>
        public string myPassword { get { return password; } }
        /// <summary>
        /// INITIAL CATALOG
        /// </summary>
        public string myCatalog { get { return catalogo; } }
        /// <summary>
        /// STATE CONECTION
        /// </summary>
        public bool myStateConexion {
            get
            {
                bool Result = true;
                string cadena = string.Format("Password = {0}; Persist Security Info = True; User ID = {1}; Initial Catalog = {2}; Data Source = {3}",
                myPassword, myUsuario, myCatalog, myDataSource
                );
                SqlConnection conexion = new SqlConnection(cadena);
                try
                {
                    conexion.Open();
                }
                catch (Exception)
                {
                    Result = false;
                }
                finally
                {
                    conexion.Close();
                }
                return Result;
            }
        }

        private void getData()
        {
            var re = ConfigurationManager.ConnectionStrings[nombreConexion].ConnectionString;
            string[] lista = re.ToString().Split(';');
            foreach (string s in lista)
            {
                //separamos por el simbolo = para obtener el campo y el valor
                string[] spliter = s.Split('=');
                //comparamos los valores
                switch (spliter[0].ToUpper())
                {

                    case "DATA SOURCE":
                    case "PROVIDER CONNECTION STRING":
                        servidor = spliter[2];
                        break;
                    case "USER ID":
                        usuario = spliter[1];
                        break;
                    case "PASSWORD":
                        password = spliter[1];
                        break;
                    case "INITIAL CATALOG":
                        catalogo = spliter[1];
                        break;

                }
            }
        }
    }
}
