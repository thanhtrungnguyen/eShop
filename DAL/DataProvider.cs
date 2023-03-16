using DAL.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider : IDataProvider
    {
        SqlConnection connection;
        public DataProvider()
        {
            ConnectToDatabase();
        }
        protected void ConnectToDatabase()
        {
            try
            {
                // OK, em dang hardcode
                string connecttionString = @"Data Source=THANHTRUNGPC\MSSQLSERVER01;Initial Catalog=eshop;Persist Security Info=True;User ID=trungnt;TrustServerCertificate=True;Trusted_Connection=True";
                connection = new SqlConnection(connecttionString);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        public DataTable ExecuteQuery(string sql)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(dataTable);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
        }
    }
}
