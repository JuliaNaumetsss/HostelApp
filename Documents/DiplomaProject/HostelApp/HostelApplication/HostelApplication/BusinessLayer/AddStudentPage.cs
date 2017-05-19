using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Enum;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class AddStudentPage
    {
        public List<string> GetFloorList()
        {
            FloorHandler handler = new FloorHandler();
            return handler.GetFloorNumberList();
        }

        public List<string> GetEmptyRoomListByFloorNumber(int floorNumber)
        {
            RoomHandler handler = new RoomHandler();
            return handler.GetAllFreeRoomListOnFloor(floorNumber);
        }

        public string AddStudent(Dictionary<string, string> studentInfo)
        {
            string resultMessage = "";
            string successMessage = "Студент был успешно добавлен.";
            string errorMessage = "Произошла ошибка при добавлении студента.";
            Student student = this.ConvertFromDictionaryInforToStudent(studentInfo);
            UserHandler userHandler = new UserHandler();
            if (!userHandler.IsUserByLoginExist(student.Login))
            {
                AddInformationHandler addInfoHandler = new AddInformationHandler();
                bool isUserAdded = addInfoHandler.AddStudent(student);
                resultMessage = isUserAdded ? successMessage : errorMessage;
            }
            else
            {
                resultMessage = "Пользователь с таким логином уже существует!\r\n Введите другой логин пользователя.";
            }
            return resultMessage;
        }

        private Student ConvertFromDictionaryInforToStudent(Dictionary<string, string> studentInfo)
        {
            Student student = new Student();
            student.Name = studentInfo["name"];
            student.Surname = studentInfo["surname"];
            student.Patronymic = studentInfo["patronymic"];
            student.PhoneNumber = studentInfo["phone"];
            student.Address = studentInfo["address"];
            student.PassportData = studentInfo["passport"];
            student.Login = studentInfo["login"];
            student.Password = studentInfo["password"];
            student.UserTypeInt = (int)UserTypeEnum.Student;
            student.UserType = "студент";
            student.Room = new Room();
            student.Room.IdRoom = studentInfo["room"];
            student.GroupNumber = studentInfo["group"];
            student.Course = int.Parse(studentInfo["course"]);
            student.IsHeadFloor = studentInfo["headFloor"];
            student.PathToPhoto = studentInfo["filePath"];
            return student;
        }
    }
}
