using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAECBanjulAppGUI.Models
{
    public static class AppConnection
    {
        public static string NatconnectionString = ConfigurationManager.ConnectionStrings["NatConnection"].ConnectionString;
    }
}
