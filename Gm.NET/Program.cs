using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gm.NET
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //XtraFormMain login = new XtraFormMain();
            //XtraFormLogin login = new XtraFormLogin();
            //RibbonFormMenu login = new RibbonFormMenu();
            Application.Run(new XtraFormLogin());
            //Application.Run(new xfConfigurar());
            //if (login.btOk == true)
            //{
            //    Application.Run(new RibbonFormMenu());
            //    //Application.Run(new XtraFormMenu());
            //    //Application.Run(new XtraFormMain());
            //}
        }
    }
}
