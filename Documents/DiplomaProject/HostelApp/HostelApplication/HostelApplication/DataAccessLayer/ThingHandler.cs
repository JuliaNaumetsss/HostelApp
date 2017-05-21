using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using HostelApplication.Model;

namespace HostelApplication.DataAccessLayer
{
    public class ThingHandler
    {
        public List<string> GetAllThingNameList()
        {
            string query = "SELECT [Thing].name FROM [Thing]";
            return this.GetThingNameList(query);
        }

        public List<string> GetAvailableThingList()
        {
            string query = "SELECT [Thing].name FROM [Thing] WHERE [Thing].actualCount > 0";
            return this.GetThingNameList(query);
        }

        public int GetThingIdByName(string name)
        {
            int id = -1;
            string query = $"SELECT [Thing].idThing FROM [Thing] WHERE [Thing].name='{name}'";
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Thing");
                if(ds.Tables["Thing"].Rows.Count!=0)
                {
                    id = int.Parse(ds.Tables["Thing"].Rows[0]["idThing"].ToString());
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return id;
        }

        public bool AddThingInfo(ThingEmployee info)
        {
            string query = "INSERT INTO [Student_Thing] (studentId, thingId, count, date) " +
                $"VALUES ('{info.StudentId}', {info.ThingId}, '{info.Count}', '{info.Date}')";
            return this.WorkWithRecords(query);
        }

        public bool UpdateThingCount(int idThing, int countToAdd)
        {
            int newCount = this.GetActualThingCount(idThing) - countToAdd;
            string query = $"UPDATE [Thing] SET [Thing].actualCount={newCount} WHERE idThing='{idThing}'";
            return this.WorkWithRecords(query);
        }

        public int GetActualThingCount(int idThing)
        {
            int count = -1;
            string query = $"SELECT [Thing].actualCount FROM [Thing] WHERE [Thing].idThing={idThing}";
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Thing");
                if (ds.Tables["Thing"].Rows.Count != 0)
                {
                    count = int.Parse(ds.Tables["Thing"].Rows[0]["actualCount"].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return count;
        }

        private bool WorkWithRecords(string query)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            bool isSuccess = true;
            try
            {
                // Insert into personal info
                hdl.PerformRequest(query);
            }
            catch (SqlException ex)
            {
                isSuccess = false;
                Console.WriteLine(ex.Message.ToString());
            }
            return isSuccess;
        }

        private List<string> GetThingNameList(string query)
        {
            List<string> resultList = new List<string>();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Thing");
                foreach (DataRow row in ds.Tables["Thing"].Rows)
                {
                    string name = row["name"].ToString();
                    resultList.Add(name);
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return resultList;
        }
    }
}
