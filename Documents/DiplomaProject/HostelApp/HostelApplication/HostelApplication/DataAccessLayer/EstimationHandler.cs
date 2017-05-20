using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Model;
using System.Data.SqlClient;
using System.Data;

namespace HostelApplication.DataAccessLayer
{
    public class EstimationHandler
    {
        public bool AddEstimationInfo(Estimation estimation)
        {
            bool isSuccess = true;
            string query = "INSERT INTO [Estimation] (restroom, bathroom, hall, kitchen, roomA, roomB, averageRoomA, averageRoomB) " +
                $"VALUES ('{estimation.Restroom}', '{estimation.Bathroom}', '{estimation.Hall}', '{estimation.Kitchen}', '{estimation.RoomA}', "+
                $"'{estimation.RoomB}', '{estimation.AverageRoomA}', '{estimation.AverageRoomB}')";
            DataBaseConnector connector = null;
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
            catch(SqlException ex)
            {
                isSuccess = false;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        public int GetLastEstimationId()
        {
            int index = -1;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [Estimation].idEstimation FROM [Estimation]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Estimation");
                DataRow row = ds.Tables["Estimation"].Rows[ds.Tables["Estimation"].Rows.Count - 1];
                int.TryParse(row["idEstimation"].ToString(), out index);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return index;
        }
    }
}
