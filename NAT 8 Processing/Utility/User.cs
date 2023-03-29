using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

public static class User
{
    static public string EntityConnectionString { get; set; }
    static public string IctdConnectionString { get; set; }

    // helper class to help with basic things.
    public static string UserName()
    {
        return Environment.UserName;
    }

    public static string UserDomainName()
    {
        return Environment.UserDomainName;
    }

    public static string MachineName()
    {
        return Environment.MachineName;
    }

    public static string ConnectionStringEntity()
    {
        return "name=WaecNatEntities";
    }

    //public static string ConnectionStringDomain()
    //{
    //    return EntityconnectionString;
    //}

    public static string ConnectionStringOther()
    {
        //System.Windows.Forms.MessageBox.Show($"enter creds");
        return Environment.MachineName;
    }
}
