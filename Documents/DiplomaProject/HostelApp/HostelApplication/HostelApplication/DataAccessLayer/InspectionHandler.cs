﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HostelApplication.Model;

namespace HostelApplication.DataAccessLayer
{
    public class InspectionHandler
    {
        public List<Dictionary<string, string>> GetListOfInspectors()
        {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            DataBaseConnector connector = null;
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic, [User].[login] " +
            "FROM[PersonalInfo] INNER JOIN[User] ON[PersonalInfo].idPersonalInfo = [User].personalInfoId " +
            "INNER JOIN[UserType] ON[User].userTypeId = [UserType].idUserType " +
            "WHERE[UserType].typeName = 'воспитатель' OR[UserType].typeName = 'заведующий общежитием'";
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Inspectors");
                foreach(DataRow row in ds.Tables["Inspectors"].Rows)
                {
                    Dictionary<string, string> infoDict = new Dictionary<string, string>();
                    infoDict["login"] = row["login"].ToString();
                    infoDict["commonInfo"] = row["surname"] + " " + row["name"] + " " + row["patronymic"];
                    resultList.Add(infoDict);
                }
                
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToList());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return resultList;
        }

        public bool AddInspection(Inspection inspection)
        {
            bool isSuccess = true;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();

                // Add info to Estimation table
                EstimationHandler estimationHandler = new EstimationHandler();
                estimationHandler.AddEstimationInfo(inspection.Estimation);

                // Get last estimation Id
                int estimationId = estimationHandler.GetLastEstimationId();

                // Add info to Inspection table
                this.AddInfoToInspectionInfo(inspection.InspectionDate, inspection.Room, estimationId);

                // Get last inspection Id
                int inspectionId = this.GetLastInspectionId();

                // Add info to Inspection_Employee table
                foreach (string login in inspection.EmployeeLoginList)
                {
                    this.AddNoteToInspectionEmployeeTable(login, inspectionId);
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
                isSuccess = false;
            }
            return isSuccess;
        }

        private bool AddInfoToInspectionInfo(string date, string room, int estimationId)
        {            
            string query = "INSERT INTO [Inspection] (inspectionDate, roomId, estimationId) " +
                $"VALUES ('{date}', '{room}', '{estimationId}')";
            return this.AddRecord(query);
        }

        private int GetLastInspectionId()
        {
            int index = -1;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [Inspection].idInspection FROM [Inspection]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Inspection");
                DataRow row = ds.Tables["Inspection"].Rows[ds.Tables["Inspection"].Rows.Count - 1];
                int.TryParse(row["idInspection"].ToString(), out index);
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

        private bool AddNoteToInspectionEmployeeTable(string employeeId, int inspectionId)
        {
            string query = "INSERT INTO [Inspection_Employee] (employeeId, inspectionId) " +
                $"VALUES ('{employeeId}', '{inspectionId}')";
            return this.AddRecord(query);
        }

        private bool AddRecord(string query)
        {
            bool isSuccess = true;
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
            catch (SqlException ex)
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
    }
    
}
