using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace NAT_8_Processing.Utility
{
    class  DbConnection
    {
        //Private dbNameP As String
        public string DatabaseName { get; } = "";
        public string DatabasePath { get; } = "";
        public string DatabaseUserName { get;} = "";
        private string DatabasePassword { get; set; } = "";
        public bool IsConnected { get; set; } = false;

        // use FileInfo to save dbFile
        // FileInfo dbFile;
        
        public enum TypeOfDatabase
        {
            AccessMDB,
            AccessACCDB,
            MSSQl,
            SQLite,
            MariaDB
        }

        private TypeOfDatabase DatabaseType { get; set; }
        //Public con, con1, con2, con3, con4 As New OleDb.OleDbConnection
        //Public cmd, cmd1, cmd2, cmd3, cmd4 As New OleDb.OleDbCommand
        //Public dr, dr1, dr2, dr3, dr4 As OleDb.OleDbDataReader
        public OleDbConnection con { get; set; }
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataReader dr { get; set; }

        //Private connectionStringP As String
        private string ConnectionStringP;

        public string ConnectionString
        {
            get { return ConnectionStringP; }
            set
            {
                ConnectionStringP = value;
                con = new OleDbConnection(ConnectionString);
                if (TestConnection())
                {
                    cmd.Connection = con;

                    IsConnected = true;
                }
                else
                    IsConnected = false;
            }
        }

        public DbConnection(string databaseName, string databasePath, TypeOfDatabase databaseType) : 
            this(databaseName, databasePath, "", databaseType) {}

        public DbConnection(FileInfo databaseFile, string databasePassword, TypeOfDatabase databaseType) :
                       this(databaseFile.Name, databaseFile.Directory.ToString(), databasePassword, databaseType) {}

        public DbConnection(string databaseName, string databasePath, string databasePassword, TypeOfDatabase databaseType)
        {
            DatabaseName = databaseName;
            DatabasePath = databasePath;
            DatabaseType = databaseType;
            DatabasePassword = databasePassword;

            if (ConnectToDb())
                Console.WriteLine($"Successfully connected to DB: {DatabaseName}!!!");
            else
                Console.WriteLine($"Error connecting to DB with: {DatabaseName} | {DatabasePath} !!!");
        }

        public DbConnection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private bool ConnectToDb()
        {
            if (DatabaseName == "" || DatabasePath == "")
            {
                Console.WriteLine("Please set database name and or path Connect Error");
                return false;
            }

            switch (DatabaseType)
            {
                case TypeOfDatabase.AccessMDB:
                    if (DatabasePassword == "")
                        ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={DatabasePath}\\{DatabaseName};Persist Security Info=True";
                    else
                        ConnectionString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={DatabasePath}\\{DatabaseName}; Jet OLEDB:Database Password={DatabasePassword};";
                    break;
                case TypeOfDatabase.AccessACCDB:
                    if (DatabasePassword == "")
                        ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath}\\{DatabaseName};Persist Security Info=True";
                    else
                        ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={DatabasePath}\\{DatabaseName}; Jet OLEDB:Database Password={DatabasePassword};";
                    break;
                case TypeOfDatabase.MSSQl:
                    break;
                case TypeOfDatabase.SQLite:
                    break;
                case TypeOfDatabase.MariaDB:
                    break;
                default:
                    ConnectionString = "";
                    break;
            }


            //if (TestConnection())
            //{
            //    cmd.Connection = con;
            //    // add other cmds

            //    return IsConnected = true;
            //}

            return IsConnected;
        }

        private bool TestConnection()
        {
            if (ConnectionString == "") { return false; }

            try
            {
                con.Open();
                Console.WriteLine($"Sucessfully connected to {DatabaseType}: {DatabaseName}");
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error testing connection: {ex.Message}");
            }

            return false;
        }

        public override string ToString()
        {
            return ConnectionString;
        }
    }
}
