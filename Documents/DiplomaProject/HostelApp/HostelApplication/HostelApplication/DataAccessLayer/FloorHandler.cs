using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HostelApplication.Enum;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class FloorHandler
    {
        public Floor GetFloorById(int floorId)
        {
            Floor floor = new Floor();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [Floor] WHERE idFloor='{floorId}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Floor");
                if(ds.Tables["Floor"].Rows.Count!=0)
                {
                    floor.IdFloor = int.Parse(ds.Tables["Floor"].Rows[0]["idFloor"].ToString());
                    floor.RoomCount = int.Parse(ds.Tables["Floor"].Rows[0]["roomCount"].ToString());
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return floor;
        }

        public List<string> GetFloorNumberList()
        {
            List<string> floorList = new List<string>();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [Floor].{FloorEnum.idFloor} FROM [Floor]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Floor");
                foreach (DataRow row in ds.Tables["Floor"].Rows)
                {
                    floorList.Add(row[$"{FloorEnum.idFloor}"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return floorList;
        }
    }
}
