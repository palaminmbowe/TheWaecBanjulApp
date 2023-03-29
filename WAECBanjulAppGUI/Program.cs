using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAECBanjulAppGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UpdateConnectionStrings();
            Application.Run(new mdiParent());
        }

        static void UpdateConnectionStrings()
        {
            //return "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";
            //return "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";
            //data source=waecgmvdbs;initial catalog=WaecCommon;integrated security=True;multipleactiveresultsets=True

            User.EntityConnectionString = ConfigurationManager.ConnectionStrings["WaecNatEntities"].ConnectionString;

            //User.EntityConnectionString = ConfigurationManager.ConnectionStrings["WaecNatEntities"].ConnectionString.Replace("credentials", "user id = ictdstaff;password = Wa123Ec321");


            //return User.EntityConnectionString;
            User.IctdConnectionString = "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";
        }
    }
}
