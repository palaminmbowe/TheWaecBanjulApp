using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaecCassUI
{
    public static class AppConnection
    {
        public static string CassConnection = ConfigurationManager.ConnectionStrings["CassConnectionStringServer"].ToString();
    }
}
