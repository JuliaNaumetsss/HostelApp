using System.Data.SqlClient;
using HostelApplication.DataAccessLayer;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class EditInformationHandler
    {
        public bool EditStudent(Student student)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            bool isSuccess = true;
            try
            {
                UserHandler userHandler = new UserHandler();
                // Get room id from table (old value)
                string oldRoomNumber = userHandler.GetStudentRoomIdByLogin(student.Login);

                // Get new value of room
                string newRoomNumber = student.Room.IdRoom;
                
                int idPersonalInfo = userHandler.GetPersonalInfoIdByLogin(student.Login);               

                // Update Personal Info
                hdl.PerformRequest(this.FormQueryForUpdatePersonalInfoTable<Student>(student, idPersonalInfo));

                // Update Student Table
                hdl.PerformRequest(this.FormQueryForUpdateStudentTable(student));

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
            return isSuccess;
        }

        public bool EditEmployee(Employee employee)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            bool isSuccess = true;
            try
            {
                UserHandler userHandler = new UserHandler();
                // Get room id from table (old value)
                string oldRoomNumber = userHandler.GetEmployeeRoomIdByLogin(employee.Login);

                // Get new value of room
                string newRoomNumber = employee.Room.IdRoom;

                int idPersonalInfo = userHandler.GetPersonalInfoIdByLogin(employee.Login);

                // Update Personal Info
                hdl.PerformRequest(this.FormQueryForUpdatePersonalInfoTable<Employee>(employee, idPersonalInfo));

                // Update User Table
                hdl.PerformRequest(this.FormQueryForUpdateUserTable(employee.UserTypeInt, employee.Login));

                // Update Employee Table
                hdl.PerformRequest(this.FormQueryForUpdateEmployeeTable(employee));

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
