using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class EditInformationHandler
    {
        public bool EditStudent(Student student)
        {
            DataBaseConnector connector = null;
            bool isSuccess = true;
            try
            {
                UserHandler userHandler = new UserHandler();
                // Get room id from table (old value)
                string oldRoomNumber = userHandler.GetStudentRoomIdByLogin(student.Login);

                // Get new value of room
                string newRoomNumber = student.Room.IdRoom;
                
                int idPersonalInfo = userHandler.GetPersonalInfoIdByLogin(student.Login);

                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Update Personal Info
                cmd.CommandText = this.FormQueryForUpdatePersonalInfoTable<Student>(student, idPersonalInfo);
                cmd.ExecuteNonQuery();

                // Update Student Table
                cmd.CommandText = this.FormQueryForUpdateStudentTable(student);
                cmd.ExecuteNonQuery();

                // Update count of empty room
                if (!oldRoomNumber.Trim().Equals(newRoomNumber.Trim()))
                {
                    RoomHandler roomHandler = new RoomHandler();
                    roomHandler.UpdateEmptyRoomCountAfterAddingUser(newRoomNumber);
                    roomHandler.UpdateEmptyRoomCountAfterRemovingUser(oldRoomNumber);
                }
            }
            catch(SqlException ex)
            {
                string message = ex.Message.ToString();
                isSuccess = false;
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        public bool EditEmployee(Employee employee)
        {
            DataBaseConnector connector = null;
            bool isSuccess = true;
            try
            {
                UserHandler userHandler = new UserHandler();
                // Get room id from table (old value)
                string oldRoomNumber = userHandler.GetEmployeeRoomIdByLogin(employee.Login);

                // Get new value of room
                string newRoomNumber = employee.Room.IdRoom;

                int idPersonalInfo = userHandler.GetPersonalInfoIdByLogin(employee.Login);

                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Update Personal Info
                cmd.CommandText = this.FormQueryForUpdatePersonalInfoTable<Employee>(employee, idPersonalInfo);
                cmd.ExecuteNonQuery();

                // Update User Table
                cmd.CommandText = this.FormQueryForUpdateUserTable(employee.UserTypeInt, employee.Login);
                cmd.ExecuteNonQuery();

                // Update Employee Table
                cmd.CommandText = this.FormQueryForUpdateEmployeeTable(employee);
                cmd.ExecuteNonQuery();

                // Update count of empty room
                if (!oldRoomNumber.Trim().Equals(newRoomNumber.Trim()))
                {
                    RoomHandler roomHandler = new RoomHandler();
                    roomHandler.UpdateEmptyRoomCountAfterAddingUser(newRoomNumber);
                    roomHandler.UpdateEmptyRoomCountAfterRemovingUser(oldRoomNumber);
                }
            }
            catch(SqlException ex)
            {
                string message = ex.Message.ToString();
                isSuccess = false;
            }
            finally
            {

            }
            return isSuccess;
        }

        private string FormQueryForUpdatePersonalInfoTable<T>(T user, int id) where T : User
        {
            string query = $"UPDATE [PersonalInfo] SET name='{user.Name}', surname='{user.Surname}', patronymic='{user.Patronymic}', " +
                $"phone='{user.PhoneNumber}', address='{user.Address}', passport='{user.PassportData}' WHERE idPersonalInfo='{id}'";
            return query;
        }

        private string FormQueryForUpdateStudentTable(Student student)
        {
            string query = $"UPDATE [Student] SET groupNumber='{student.GroupNumber}', course='{student.Course}', isHeadFloor='{student.IsHeadFloor}'," +
                $" roomId='{student.Room.IdRoom}' WHERE studentId='{student.Login}'";
            return query;
        }

        private string FormQueryForUpdateUserTable(int userType, string login)
        {
            string query = $"UPDATE [User] SET userTypeId='{userType}' WHERE login='{login}'";
            return query;
        }

        private string FormQueryForUpdateEmployeeTable(Employee employee)
        {
            string query = $"Update [Employee] SET workPhone='{employee.WorkPhoneNumber}', roomId='{employee.Room.IdRoom}' " +
                $"WHERE idEmployee='{employee.Login}'";
            return query;
        }
    }
}
