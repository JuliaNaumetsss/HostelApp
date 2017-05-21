using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HostelApplication.Model;
using HostelApplication.DataAccessLayer;

namespace HostelApplication.Handler
{
    public class RoomHandler
    {
        public Room GetRoomById(string roomId)
        {
            Room room = new Room();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [Room] WHERE idRoom='{roomId}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Room");
                if(ds.Tables["Room"].Rows.Count!=0)
                {
                    room.IdRoom = roomId;
                    room.RoomLetter = ds.Tables["Room"].Rows[0]["roomLetter"].ToString();
                    room.RoomNumber = int.Parse(ds.Tables["Room"].Rows[0]["roomNumber"].ToString());
                    room.TotalPlaceCount = int.Parse(ds.Tables["Room"].Rows[0]["allPlaceCount"].ToString());
                    room.EmptyPlaceCount = int.Parse(ds.Tables["Room"].Rows[0]["emptyPlaceCount"].ToString());
                    int floorId = int.Parse(ds.Tables["Room"].Rows[0]["floorId"].ToString());
                    FloorHandler floorHandler = new FloorHandler();
                    room.Floor = floorHandler.GetFloorById(floorId);
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
            return room;
        }

        public void UpdateEmptyRoomCountAfterAddingUser(string roomId)
        {
            Room room = this.GetRoomById(roomId);
            int emptyPlace = room.EmptyPlaceCount - 1;
            this.UpdateRoomCount(roomId, emptyPlace);
        }

        public void UpdateEmptyRoomCountAfterRemovingUser(string roomId)
        {
            Room room = this.GetRoomById(roomId);
            int emptyPlace = room.EmptyPlaceCount + 1;
            this.UpdateRoomCount(roomId, emptyPlace);
        }

        public List<string> GetAllFreeRoomList()
        {
            string query = $"SELECT [Room].idRoom FROM [Room] WHERE [Room].emptyPlaceCount <> 0";
            return this.GeRoomList(query);
        }

        public List<string> GetAllFreeRoomListOnFloor(int floorId)
        {
            string query = $"SELECT [Room].idRoom FROM [Room] WHERE [Room].emptyPlaceCount <> 0 AND [Room].floorId = {floorId}";
            return this.GeRoomList(query);
        }
        public List<string> GetAllRoomList()
        {
            string query = $"SELECT [Room].idRoom FROM [Room]";
            return this.GeRoomList(query);
        }

        public List<string> GetAllRoomListByFloor(int floorId)
        {
            string query = $"SELECT [Room].idRoom FROM [Room] WHERE [Room].floorId = {floorId}";
            return this.GeRoomList(query);
        }

        private List<string> GeRoomList(string query)
        {
            List<string> roomList = new List<string>();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Room");
                foreach (DataRow row in ds.Tables["Room"].Rows)
                {
                    roomList.Add(row["idRoom"].ToString());
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
            return roomList;
        }

        private void UpdateRoomCount(string roomId, int emptyPlaceCount)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            Room room = this.GetRoomById(roomId);
            string query = $"UPDATE [Room] SET [Room].emptyPlaceCount = {emptyPlaceCount} WHERE [Room].idRoom='{roomId.Trim()}'";
            try
            {
                hdl.PerformRequest(query);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
