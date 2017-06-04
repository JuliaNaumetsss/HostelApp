using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HostelApplication.Model;

namespace HostelApplication.DataAccessLayer
{
    public class WorkedHoursHandler
    {
        public bool AddWorkedHoursInformation(WorkedHours info)
        {
            AddEditDataInDataBase hdl = new AddEditDataInDataBase();
            bool isSucces = true;

            int count = this.GetWorkedHoursForStudentByLogin(info.StudentId) + info.HoursCount;

            string query = "INSERT INTO [WorkedHours] (workedDate, hoursCount, studentId, employeeId, description) " +
                $"VALUES ('{info.WorkedDate}', '{info.HoursCount}', '{info.StudentId}', '{info.EmployeeId}', '{info.Description}')";
            string updateStudentQuery = $"UPDATE [Student] SET totalWorkedHours='{count}' WHERE studentId='{info.StudentId}'";

            try
            {
                // Insert into worked hours
                hdl.PerformRequest(query);

                // Update user table
                hdl.PerformRequest(updateStudentQuery);
            }
            catch(SqlException ex)
            {
                isSucces = false;
                Console.WriteLine(ex.Message.ToString());
            }
            return isSucces;
        }

        public int GetWorkedHoursForStudentByLogin(string login)
        {
            int count = -1;
            string query = $"SELECT [Student].totalWorkedHours FROM [Student] WHERE [Student].studentId='{login}'";
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Hours");
                if(ds.Tables["Hours"].Rows.Count!=0)
                {
                    count = int.Parse(ds.Tables["Hours"].Rows[0]["totalWorkedHours"].ToString());
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
            return count;
        }

        public List<Dictionary<string, string>> GetDebtors(int expectedHours)
        {
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic, [Student].totalWorkedHours " +
            "FROM[PersonalInfo] INNER JOIN[User] ON[USER].personalInfoId = [PersonalInfo].idPersonalInfo " +
            $"INNER JOIN[Student] ON[User].login = [Student].studentId WHERE [Student].totalWorkedHours < '{expectedHours}'";
            List<Dictionary<string, string>> resultListDict = new List<Dictionary<string, string>>();

            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Debtors");
                foreach(DataRow row in ds.Tables["Debtors"].Rows)
                {
                    Dictionary<string, string> resultDict = new Dictionary<string, string>();
                    resultDict["surname"] = row["surname"].ToString();
                    resultDict["name"] = row["name"].ToString();
                    resultDict["patronymic"] = row["patronymic"].ToString();
                    resultDict["totalWorkedHours"] = row["totalWorkedHours"].ToString();
                    resultListDict.Add(resultDict);
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
            return resultListDict;
        }
    }
}
