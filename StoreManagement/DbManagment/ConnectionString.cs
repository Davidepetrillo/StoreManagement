using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class ConnectionString
    {
        private string DB_Host;

        private string DB_NAME;

        private string DB_USERNAME;

        private string DB_PASSWORD;
        public string getDbHost()
        {
            return DB_Host;
        }
        public void setDBhost(string dbhost)
        {
            DB_Host = dbhost;
        }
        public string getDbName()
        {
            return DB_NAME;
        }
        public void setDBName(string dbName)
        {
            DB_NAME = dbName;
        }
        public string getDbUsername()
        {
            return DB_USERNAME;
        }
        public void setDBUsername(string dbUsername)
        {
            DB_USERNAME = dbUsername;
        }
        public string getDbPassword()
        {
            return DB_PASSWORD;
        }
        public void setDBPassword(string dbPassword)
        {
            DB_PASSWORD = dbPassword;
        }

        public string GetConnectionString()
        {
            string connString = $"SERVER={getDbHost()};Initial Catalog={getDbName()};Trusted_Connection=True;";
            return connString;
        }
    }
}
