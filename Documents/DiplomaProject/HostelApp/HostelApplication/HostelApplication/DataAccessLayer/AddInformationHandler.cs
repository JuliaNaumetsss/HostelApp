using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class AddInformationHandler
    {
        public bool AddEmployee(Employee employee)
        {
            bool isSuccess = true;
            string resultMessage = "";
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Insert into personal info
                cmd.CommandText = this.FormQueryForAddingPersonalIno<Employee>(employee);
                cmd.ExecuteNonQuery();

                // Get index
                PersonalInfoHandler personalInfoHadler = new PersonalInfoHandler();

                // Add information to table User
                cmd.CommandText = this.FormQueryForAddingUserEmployee(employee, personalInfoHadler.GetLatPersonalInfoIndex());
                cmd.ExecuteNonQuery();

                //Add information to Employee table
                cmd.CommandText = this.FormQueryForAdingEmployee(employee);
                cmd.ExecuteNonQuery();

                // Decrease room count
                RoomHandler roomHandler = new RoomHandler();
                roomHandler.UpdateEmptyRoomCountAfterAddingUser(employee.Room.IdRoom);
            }
            catch(SqlException ex)
            {               
                isSuccess = false;              
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        public bool AddStudent(Student student)
        {
            bool isSuccess = true;
            DataBaseConnector connector = new DataBaseConnector();
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Insert into personal info
                cmd.CommandText = this.FormQueryForAddingPersonalIno<Student>(student);
                cmd.ExecuteNonQuery();

                // Get index
                PersonalInfoHandler personalInfoHadler = new PersonalInfoHandler();

                // Add information to table User
                cmd.CommandText = this.FormQueryForAddingUserStudent(student, personalInfoHadler.GetLatPersonalInfoIndex());
                cmd.ExecuteNonQuery();

                //Add information to Student table
                if(!string.IsNullOrEmpty(student.PathToPhoto))
                {
                    // add photo if exist
                    byte[] imageBytes = this.GetImageBytesArray(student.PathToPhoto);
                    cmd = this.FormQueryToAddStudentWithPhoto(connector.Connection, student, imageBytes);
                }
                else
                {
                    // add informatio without photo
                    cmd.CommandText = this.FormQueryFToAddStudent(student);
                }

                cmd.ExecuteNonQuery();

                // Decrease room count                
                RoomHandler roomHandler = new RoomHandler();
                roomHandler.UpdateEmptyRoomCountAfterAddingUser(student.Room.IdRoom);
            }
            catch(Exception ex)
            {
                string mess = ex.Message.ToString();
                isSuccess = false;
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSuccess;
        }

        private string FormQueryForAddingPersonalIno<T>(T user) where T : User
        {
            // Add personal Info query
            string addEmployeeQuery = "INSERT INTO [PersonalInfo] (name, surname, patronymic, phone, address, passport) " +
                $"VALUES('{user.Name}', '{user.Surname}', '{user.Patronymic}', '{user.PhoneNumber}', '{user.Address}', '{user.PassportData}')";

            return addEmployeeQuery;
        }

        private string FormQueryForAddingUserEmployee(Employee employee, int personalInfoId)
        {
            EncryptionClass encryption = new EncryptionClass();
            employee.Password = encryption.GetHashString(employee.Password);
            string addUserQuery = "INSERT INTO [User] (login, password, userTypeId, personalInfoId, isEmployee, isStudent) " +
    $"VALUES('{employee.Login}', '{employee.Password}', '{employee.UserTypeInt}', '{personalInfoId}', '1', '0')";
            return addUserQuery;
        }

        private string FormQueryForAddingUserStudent(Student student, int personalInfoId)
        {
            EncryptionClass encryption = new EncryptionClass();
            student.Password = encryption.GetHashString(student.Password);
            string addUserQuery = "INSERT INTO [User] (login, password, userTypeId, personalInfoId, isEmployee, isStudent) " +
    $"VALUES('{student.Login}', '{student.Password}', '{student.UserTypeInt}', '{personalInfoId}', '0', '1')";
            return addUserQuery;
        }

        private string FormQueryForAdingEmployee(Employee employee)
        {
            string addEmployee = "INSERT INTO [Employee] (idEmployee, workPhone, roomId) " +
               $"VALUES('{employee.Login}', '{employee.WorkPhoneNumber}', '{employee.Room.IdRoom}')";

            return addEmployee;
        }

        private string FormQueryForAdingStudent(Student student, byte[] imageBytes)
        {
            string addStudent = "INSERT INTO [Student] (studentId, groupNumber, course, isHeadFloor, totalWorkedHours, paymentSum, roomId, photo) " +
                $"VALUES('{student.Login}', '{student.GroupNumber}', '{student.Course}', '{student.IsHeadFloor}', '0', '0', '{student.Room.IdRoom}', '{imageBytes}')";
            return addStudent;
        }

        private SqlCommand FormQueryToAddStudentWithPhoto(SqlConnection connection, Student student, byte[] img)
        {
            string query = "INSERT INTO [Student] (studentId, groupNumber, course, isHeadFloor, totalWorkedHours, paymentSum, roomId, photo) " +
                "VALUES(@login, @group, @course, @head, @hours, @sum, @room, @photo)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add(new SqlParameter("@login", student.Login));
            cmd.Parameters.Add(new SqlParameter("@group", student.GroupNumber));
            cmd.Parameters.Add(new SqlParameter("@course", student.Course));
            cmd.Parameters.Add(new SqlParameter("@head", student.IsHeadFloor));
            cmd.Parameters.Add(new SqlParameter("@hours", student.TotalWorkedHours));
            cmd.Parameters.Add(new SqlParameter("@sum", student.PaymentSum));
            cmd.Parameters.Add(new SqlParameter("@room", student.Room.IdRoom));
            cmd.Parameters.Add(new SqlParameter("@photo", img));
            return cmd;

        }

        private string FormQueryFToAddStudent(Student student)
        {
            string addStudent = "INSERT INTO [Student] (studentId, groupNumber, course, isHeadFloor, totalWorkedHours, paymentSum, roomId) " +
                $"VALUES('{student.Login}', '{student.GroupNumber}', '{student.Course}', '{student.IsHeadFloor}', '0', '0', '{student.Room.IdRoom}')";
            return addStudent;
        }

        private byte[] GetImageBytesArray(string filePath)
        {
            ImageHandler generator = new ImageHandler();
            return generator.CreateArrayOfBytesFromFilePath(filePath);
        }
    }
}
