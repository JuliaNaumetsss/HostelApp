using System;
using System.Data.SqlClient;


namespace HostelApplication.DataAccessLayer
{
    public class AddEditDataInDataBase
    {
        public void PerformRequest(string query)
        {
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Insert into personal info
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
        }
    }
}
