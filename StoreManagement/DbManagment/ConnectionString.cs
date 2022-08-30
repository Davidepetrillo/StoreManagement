using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class ConnectionString
    {
        private string DB_Host;

        private string DB_NAME;

        public string getDbHost()
        {
            return DB_Host;
        }
        public void setDBhost()
        {
            DB_Host = ConfigurationSettings.AppSettings["DB_Host"].ToString().Trim();
        }
        public string getDbName()
        {
            return DB_NAME;
        }
        public void setDBName()
        {
            DB_NAME = ConfigurationSettings.AppSettings["DB_NAME"].ToString().Trim();
        }
        public string GetConnectionString()
        {
            setDBhost();
            setDBName();
            string connString = $"SERVER={getDbHost()};Initial Catalog={getDbName()};Trusted_Connection=True;";
            return connString;
        }
    }
}
