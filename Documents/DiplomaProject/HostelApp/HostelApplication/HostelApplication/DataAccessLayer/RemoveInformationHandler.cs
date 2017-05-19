using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Enum;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class RemoveInformationHandler
    {
        public bool RemoveEmployee(string login)
        {
            bool isSuccess = true;
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                // Get Personal Info id for current employee
                UserHandler handler = new UserHandler();
                int idPersonalInfo = handler.GetPersonalInfoIdByLogin(login);
                if (idPersonalInfo != -1)
                {
                    Employee employee = handler.GetEmployeeByLogin(login);

                    connector = new DataBaseConnector();
                    connector.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connector.Connection;

                    // Remove information from Employee table
                    cmd.CommandText = this.FormQueryForDeleteFromEmployeeTable(login);
                    cmd.ExecuteNonQuery();

                    // Remove information from User table
                    cmd.CommandText = this.FormQueryForDeleteFromUserTable(login);
                    cmd.ExecuteNonQuery();

                    // Remove information from PersonalInfo table
                    cmd.CommandText = this.FormQueryForDeleteFromPersonalInfoTable(idPersonalInfo);
                    cmd.ExecuteNonQuery();

                    // Update Room Table
                    RoomHandler roomHandler = new RoomHandler();
                    roomHandler.UpdateEmptyRoomCountAfterRemovingUser(employee.Room.IdRoom);
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                isSuccess = false;
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        public bool RemoveStudent(string login)
        {
            bool isSuccess = true;            
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                // Get Personal Info id for current student
                UserHandler handler = new UserHandler();
                int idPersonalInfo = handler.GetPersonalInfoIdByLogin(login);
                if (idPersonalInfo != -1)
                {
                    Student student = handler.GetStudentByLogin(login);

                    connector = new DataBaseConnector();
                    connector.OpenConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connector.Connection;

                    // Remove information from Student table
                    cmd.CommandText = this.FormQueryForDeleteFromStudentTable(login);
                    cmd.ExecuteNonQuery();

                    // Remove information from User table
                    cmd.CommandText = this.FormQueryForDeleteFromUserTable(login);
                    cmd.ExecuteNonQuery();

                    // Remove information from PersonalInfo table
                    cmd.CommandText = this.FormQueryForDeleteFromPersonalInfoTable(idPersonalInfo);
                    cmd.ExecuteNonQuery();

                    // Update Room Table
                    RoomHandler roomHandler = new RoomHandler();
                    roomHandler.UpdateEmptyRoomCountAfterRemovingUser(student.Room.IdRoom);
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {
                isSuccess = false;
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        private string FormQueryForDeleteFromStudentTable(string login)
        {
            return $"DELETE FROM [Student] WHERE studentId='{login}'";
        }

        private string FormQueryForDeleteFromEmployeeTable(string login)
        {
            return $"DELETE FROM [Employee] WHERE idEmployee='{login}'";
        }

        private string FormQueryForDeleteFromUserTable(string login)
        {
            return $"DELETE FROM [User] WHERE login='{login}'";
        }

        private string FormQueryForDeleteFromPersonalInfoTable(int idPersonalInfo)
        {
            return $"DELETE FROM [PersonalInfo] WHERE idPersonalInfo='{idPersonalInfo}'";
        }
    }
}
