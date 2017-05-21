using HostelApplication.DataAccessLayer;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class RemoveInformationHandler
    {
        public bool RemoveEmployee(string login)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            bool isSuccess = true;
            try
            {
                // Get Personal Info id for current employee
                UserHandler handler = new UserHandler();
                int idPersonalInfo = handler.GetPersonalInfoIdByLogin(login);
                if (idPersonalInfo != -1)
                {
                    Employee employee = handler.GetEmployeeByLogin(login);

                    // Remove information from Employee table
                    hdl.PerformRequest(this.FormQueryForDeleteFromEmployeeTable(login));

                    // Remove information from User table
                    hdl.PerformRequest(this.FormQueryForDeleteFromUserTable(login));

                    // Remove information from PersonalInfo table
                    hdl.PerformRequest(this.FormQueryForDeleteFromPersonalInfoTable(idPersonalInfo));

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
            return isSuccess;
        }

        public bool RemoveStudent(string login)
        {
            AddEtitDataInDataBase hdl = new AddEtitDataInDataBase();
            bool isSuccess = true;            
            try
            {
                // Get Personal Info id for current student
                UserHandler handler = new UserHandler();
                int idPersonalInfo = handler.GetPersonalInfoIdByLogin(login);
                if (idPersonalInfo != -1)
                {
                    Student student = handler.GetStudentByLogin(login);

                    // Remove information from Student table
                    hdl.PerformRequest(this.FormQueryForDeleteFromStudentTable(login));

                    // Remove information from User table
                    hdl.PerformRequest(this.FormQueryForDeleteFromUserTable(login));

                    // Remove information from PersonalInfo table
                    hdl.PerformRequest(this.FormQueryForDeleteFromPersonalInfoTable(idPersonalInfo));

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
