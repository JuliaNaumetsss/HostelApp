using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using HostelApplication.Model;
using HostelApplication.Enum;
using HostelApplication.DataAccessLayer;

namespace HostelApplication.Handler
{
    public class UserHandler
    {
        public bool UpdateUserPassword(string login, string newPassword)
        {
            AddEditDataInDataBase hdl = new AddEditDataInDataBase();
            string query = $"UPDATE [User] SET password='{newPassword}' WHERE login='{login}'";
            bool isUpdated = true;
            try
            {
                hdl.PerformRequest(query);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                isUpdated = false;
            }
            return isUpdated;
        }

        public int GetPersonalInfoIdByLogin(string login)
        {
            DataBaseConnector connector = null;
            int id = -1;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT {UserEnum.personalInfoId} FROM [User] WHERE {UserEnum.login}='{login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "User");
                if(ds.Tables["User"].Rows.Count!=0)
                {
                    int.TryParse(ds.Tables["User"].Rows[0][$"{UserEnum.personalInfoId}"].ToString(), out id);
                }
            }
            catch
            {

            }
            finally
            {
                connector.CloseConnection();
            }
            return id;
        }

        public string GetStudentRoomIdByLogin(string login)
        {
            DataBaseConnector connector = null;
            string id = "";
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT {StudentEnum.roomId} FROM [Student] WHERE {StudentEnum.studentId}='{login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Student");
                if (ds.Tables["Student"].Rows.Count != 0)
                {
                    id = ds.Tables["Student"].Rows[0][$"{StudentEnum.roomId}"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connector.CloseConnection();
            }
            return id;
        }

        public string GetEmployeeRoomIdByLogin(string login)
        {
            DataBaseConnector connector = null;
            string id = "";
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT {EmployeeEnum.roomId} FROM [Employee] WHERE {EmployeeEnum.idEmployee}='{login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Employee");
                if (ds.Tables["Employee"].Rows.Count != 0)
                {
                    id = ds.Tables["Employee"].Rows[0][$"{EmployeeEnum.roomId}"].ToString();
                }
            }
            catch
            {

            }
            finally
            {
                connector.CloseConnection();
            }
            return id;
        }

        public Employee GetEmployeeByLogin(string login)
        {
            User user = this.GetUserByLogin(login);
            bool isEmployee = false;
            Employee employee = this.GetEmployeeInfo(user, out isEmployee);
            return employee;
        }

        public Student GetStudentByLogin(string login)
        {
            User user = this.GetUserByLogin(login);
            bool isStudent = false;
            Student student = this.GetStudentInfo(user, out isStudent);
            return student;
        }

        public User GetUserByLogin(string login)
        {
            DataBaseConnector connector = null;
            User user = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [User] WHERE {UserEnum.login}='{login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "User");
                if (ds.Tables["User"].Rows.Count != 0)
                {
                    int persnalInfoId = int.Parse(ds.Tables["User"].Rows[0][$"{UserEnum.personalInfoId}"].ToString());

                    user = new User();
                    user.Login = login;
                    user.Password = ds.Tables["User"].Rows[0][$"{ UserEnum.password}"].ToString().Trim();
                    UserTypeHandler typeHandler = new UserTypeHandler();
                    int userType = int.Parse(ds.Tables["User"].Rows[0][$"{UserEnum.userTypeId}"].ToString());
                    user.UserTypeInt = userType;
                    user.UserType = typeHandler.GetUserTypeNameById(userType);

                    PersonalInfoHandler personalInfoHandler = new PersonalInfoHandler();
                    user = personalInfoHandler.FillUserByPersonalInfo(user, persnalInfoId);
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
            return user;
        }

        public List<Student> GeStudentList()
        {
            List<Student> studentList = new List<Student>();
            List<User> userList = this.GetUserList();

            DataBaseConnector connector = null;
            try
            {
                foreach (User user in userList)
                {
                    bool isStudent = false;
                    Student student = this.GetStudentInfo(user, out isStudent);
                    if (isStudent)
                    {
                        studentList.Add(student);
                    }
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
            return studentList;
        }

        public List<Employee> GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            List<User> userList = this.GetUserList();
            DataBaseConnector connector = null;
            try
            {
                foreach (User user in userList)
                {
                    bool isEmployee = false;
                    Employee employee = this.GetEmployeeInfo(user, out isEmployee);
                    if(isEmployee)
                    {
                        employeeList.Add(employee);
                    }
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
            return employeeList;
        }

        public bool IsUserByLoginExist(string login)
        {
            bool isExist = false;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT {UserEnum.login} FROM [User] WHERE {UserEnum.login}='{login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "User");
                if (ds.Tables["User"].Rows.Count != 0)
                    isExist = true;
                else
                    isExist = false;
            }
            catch
            {

            }
            finally
            {
                connector?.CloseConnection();
            }
            return isExist;
        }

        public byte[] GetImageFromStudentDatabase(string login)
        {
            DataBaseConnector connector = null;
            byte[] result = null;
            try
            {
                //Initialize SQL Server connection.
                connector = new DataBaseConnector();
                connector.OpenConnection();

                //Initialize SQL adapter.
                SqlDataAdapter adapter = new SqlDataAdapter($"Select [Student].photo from [Student] WHERE studentId='{login}'", connector.Connection);

                //Initialize Dataset.
                DataSet dataSet = new DataSet();

                //Fill dataset with ImagesStore table.
                adapter.Fill(dataSet, "Image");

                //Fill Grid with dataset.
                result = (byte[])dataSet.Tables["Image"].Rows[0]["photo"];
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
            }
            finally
            {
                connector?.CloseConnection();
            }
            return result;
        }

        public List<Dictionary<string, string>> GetStudentCommonInfoByRoomId(string roomId)
        {
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic, [Student].studentId " +
            "FROM[Student] INNER JOIN[User] ON[Student].studentId = [User].login " +
            "INNER JOIN[PersonalInfo] ON[User].personalInfoId = [PersonalInfo].idPersonalInfo " +
            $"WHERE[Student].roomId = '{roomId}'";
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Info");
                foreach(DataRow row in ds.Tables["Info"].Rows)
                {
                    Dictionary<string, string> dict = new Dictionary<string, string>();
                    dict["surnameName"] = row["surname"].ToString() + " " + row["name"].ToString() + " " + row["patronymic"];
                    dict["login"] = row["studentId"].ToString();
                    resultList.Add(dict);
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
            return resultList;
        }

        public string GetEmployeeCommonInfo(string login)
        {
            string result = "";
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic " + 
                "FROM [User] INNER JOIN [PersonalInfo] ON [User].personalInfoId = [PersonalInfo].idPersonalInfo " + 
                $"WHERE [User].login = '{login}'";
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Info");
                if (ds.Tables["Info"].Rows.Count != 0)
                {
                    result = ds.Tables["Info"].Rows[0]["surname"].ToString() + " " +
                        ds.Tables["Info"].Rows[0]["name"].ToString() + " " + 
                        ds.Tables["Info"].Rows[0]["patronymic"].ToString();
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
            return result;
        }

        private string FormHeadFloorString(string headFloorString)
        {
            string resultString = "";
            if (headFloorString.Equals("True"))
            {
                resultString = "да";
            }
            else
            {
                resultString = "нет";
            }
            return resultString;
        }

        private List<User> GetUserList()
        {
            List<User> userList = new List<User>();

            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();

                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [User]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "User");
                //int count = 0;
                foreach (DataRow row in ds.Tables["User"].Rows)
                {
                    User user = new User();

                    int persnalInfoId = int.Parse(row[$"{UserEnum.personalInfoId}"].ToString());
                    user.Login = row["login"].ToString().Trim();
                    user.Password = row["password"].ToString().Trim();
                    UserTypeHandler typeHandler = new UserTypeHandler();
                    int userType = int.Parse(row["userTypeId"].ToString());
                    user.UserTypeInt = userType;
                    user.UserType = typeHandler.GetUserTypeNameById(userType);

                    PersonalInfoHandler personalInfoHandler = new PersonalInfoHandler();
                    user = personalInfoHandler.FillUserByPersonalInfo(user, persnalInfoId);
                    userList.Add(user);
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
            return userList;
        }

        private T FillStudentOrEmployeeFields<T>(User user) where T : User
        {
            T newUser = (T)Activator.CreateInstance(typeof(T));
            newUser.Address = user.Address;
            newUser.Login = user.Login;
            newUser.Name = user.Name;
            newUser.PassportData = user.PassportData;
            newUser.Password = user.Password;
            newUser.Patronymic = user.Patronymic;
            newUser.PhoneNumber = user.PhoneNumber;
            newUser.Surname = user.Surname;
            newUser.UserType = user.UserType;
            newUser.UserTypeInt = user.UserTypeInt;
            return newUser;
        }

        private Student GetStudentInfo(User user, out bool isStudent)
        {
            isStudent = false;
            Student student = this.FillStudentOrEmployeeFields<Student>(user);
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [Student] WHERE {StudentEnum.studentId}='{user.Login}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Student");
                if (ds.Tables["Student"].Rows.Count != 0)
                {
                    student.GroupNumber = ds.Tables["Student"].Rows[0][$"{StudentEnum.groupNumber}"].ToString();
                    student.Course = int.Parse(ds.Tables["Student"].Rows[0][$"{StudentEnum.course}"].ToString());
                    student.IsHeadFloor = this.FormHeadFloorString(ds.Tables["Student"].Rows[0][$"{StudentEnum.isHeadFloor}"].ToString());
                    string roomId = ds.Tables["Student"].Rows[0][$"{StudentEnum.roomId}"].ToString();
                    RoomHandler roomHandler = new RoomHandler();
                    student.Room = roomHandler.GetRoomById(roomId);
                    student.TotalWorkedHours = int.Parse(ds.Tables["Student"].Rows[0][$"{StudentEnum.totalWorkedHours}"].ToString());
                    student.PaymentSum = int.Parse(ds.Tables["Student"].Rows[0][$"{StudentEnum.paymentSum}"].ToString());
                    //studentList.Add(student);
                    isStudent = true;
                }
                else
                {
                    isStudent = false;
                }
            }
            catch
            {

            }
            finally
            {
                connector?.CloseConnection();
            }
            return student;
        }

        private Employee GetEmployeeInfo(User user, out bool isEmployee)
        {
            isEmployee = false;
            Employee employee = this.FillStudentOrEmployeeFields<Employee>(user);
            DataBaseConnector connector = null;
            try
            {                
                connector = new DataBaseConnector();
                connector.OpenConnection();
                string query = $"SELECT [Employee].{EmployeeEnum.workPhone}, [Employee].{EmployeeEnum.roomId}, [Room].{RoomEnum.roomNumber}, " +
                    $"[Room].{RoomEnum.roomLetter}, [Room].{RoomEnum.allPlaceCount}, [Room].{RoomEnum.emptyPlaceCount}, [Room].{RoomEnum.floorId}, [Floor].{FloorEnum.roomCount}" +
                    $" FROM [Employee] INNER JOIN [Room] ON [Employee].{EmployeeEnum.roomId}=Room.{RoomEnum.idRoom}" +
                    $" INNER JOIN [Floor] ON [Room].{RoomEnum.floorId} = [Floor].{FloorEnum.idFloor}" +
                    $" WHERE [Employee].{EmployeeEnum.idEmployee} = '{user.Login}'";
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Employee");
                if (ds.Tables["Employee"].Rows.Count != 0)
                {
                    employee.WorkPhoneNumber = ds.Tables["Employee"].Rows[0][$"{EmployeeEnum.workPhone}"].ToString();
                    employee.Room = new Room();
                    employee.Room.IdRoom = ds.Tables["Employee"].Rows[0][$"{EmployeeEnum.roomId}"].ToString();
                    employee.Room.RoomNumber = int.Parse(ds.Tables["Employee"].Rows[0][$"{RoomEnum.roomNumber}"].ToString());
                    employee.Room.RoomLetter = ds.Tables["Employee"].Rows[0][$"{RoomEnum.roomLetter}"].ToString();
                    employee.Room.TotalPlaceCount = int.Parse(ds.Tables["Employee"].Rows[0][$"{RoomEnum.allPlaceCount}"].ToString());
                    employee.Room.EmptyPlaceCount = int.Parse(ds.Tables["Employee"].Rows[0][$"{RoomEnum.emptyPlaceCount}"].ToString());
                    employee.Room.Floor = new Floor();
                    employee.Room.Floor.IdFloor = int.Parse(ds.Tables["Employee"].Rows[0][$"{RoomEnum.floorId}"].ToString());
                    employee.Room.Floor.RoomCount = int.Parse(ds.Tables["Employee"].Rows[0][$"{FloorEnum.roomCount}"].ToString());
                    // employeeList.Add(employee);
                    isEmployee = true;
                }
                else
                {
                    isEmployee = false;
                }
            }
            catch
            {

            }
            finally
            {
                connector.CloseConnection();
            }
            return employee;
        }


    }
}
    
