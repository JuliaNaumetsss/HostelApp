using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.DataAccessLayer
{
    public class AddEtitDataInDataBase
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
