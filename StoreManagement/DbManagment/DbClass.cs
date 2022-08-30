using StoreManagement.Eccezioni;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.DbManagment
{
    public class DbClass
    {
        public SqlConnection conn;
        public string path = ConfigurationSettings.AppSettings["path"].ToString().Trim();
        public SqlConnection Connect(string connString)
        {
            conn = new SqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (SqlException e)
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    EnumExceptions ConnessioneEx = EnumExceptions.ConnectionException;
                    File.AppendAllText(path, $"Codice Errore : {(int)ConnessioneEx} - {DateTime.Now} - ");
                    file.Close();
                }
            }
            return conn;
        }

        public void Disconnect()
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }
            catch (SqlException e)
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    EnumExceptions DisconnessioneEx = EnumExceptions.DisconnectionException;
                    File.AppendAllText(path, $"Codice Errore : {(int)DisconnessioneEx} - {DateTime.Now} - ");
                    file.Close();
                }
            }
        }


        public DataTable Select(string querySelect, SqlConnection conn)
        {

            DataTable dataTable = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(querySelect, conn);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                using (StreamWriter file = new StreamWriter(path))
                {
                    EnumExceptions SelectEx = EnumExceptions.SelectException;
                    File.AppendAllText(path, $"Codice Errore : {(int)SelectEx} - {DateTime.Now} - ");
                    file.Close();
                }
            }
            return dataTable;

        }





        public int OperationQuery(string queryOperation, SqlConnection conn)
        {
            int rows = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(queryOperation, conn);

                rows = cmd.ExecuteNonQuery();
            }

            catch (Exception ex)

            {

                using (StreamWriter file = new StreamWriter(path))
                {
                    EnumExceptions ManipulationEx = EnumExceptions.OperationQueryException;
                    File.AppendAllText(path, $"Codice Errore : {(int)ManipulationEx} - {DateTime.Now} - ");
                    file.Close();
                }
            }

            return rows;

        }

    }
}
