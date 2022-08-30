using StoreManagement.DbManagment;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            ConnectionString conn = new ConnectionString();
            conn.setDBhost(ConfigurationSettings.AppSettings["DB_Host"].ToString().Trim());
            conn.setDBName(ConfigurationSettings.AppSettings["DB_NAME"].ToString().Trim());

            DbClass connection = new DbClass();
            SqlConnection connessione = connection.Connect(conn.GetConnectionString());

            // List<string> argsInsertMovements = new List<string>();

            /*
            Query basicQuery = new Query("InsertIntoMovements", argsInsertMovements);
            basicQuery.SetQuery("InsertIntoMovements", argsInsertMovements);
            connection.OperationQuery(basicQuery.GetQuery(), connessione);
            */
        }
    }
}
