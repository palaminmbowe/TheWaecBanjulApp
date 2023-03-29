using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAT_8_Processing
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
            //string cnn = $"provider=System.Data.SqlClient;provider connection string=&quot;data source=waecgmvdbs;initial catalog=WaecCommon;persist security info=True;user id=ictdstaff;password=Wa123Ec321;multipleactiveresultsets=True;application name=EntityFramework&quot;";
            //string cnnPersist = $"Persist Security Info=False;Integrated Security=true;Initial Catalog=WaecCommon; Server=waecgmvdbs";
            //string cnnPersist2 = $"Persist Security Info=False;Trusted_Connection=True;database=WaecCommon; Server=waecgmvdbs";
            UpdateConnectionStrings();
            Application.Run(new frmNat8Main());
            //Application.Run(new frmViewEditCandidates(GetConnectionString()));
        }

        static void UpdateConnectionStrings()
        {
            //return "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";
            //return "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";

            User.EntityConnectionString = ConfigurationManager.ConnectionStrings["WaecNatEntities"].ConnectionString;

            //User.EntityConnectionString = ConfigurationManager.ConnectionStrings["WaecNatEntities"].ConnectionString.Replace("credentials", "user id = ictdstaff;password = Wa123Ec321");


            //return User.EntityConnectionString;
            User.IctdConnectionString = "Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;";
        }
    }
}
