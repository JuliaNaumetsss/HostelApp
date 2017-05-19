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
    public class EditStudentPage
    {
        public List<string> GetAllFloorList()
        {
            FloorHandler handler = new FloorHandler();
            return handler.GetFloorNumberList();
        }

        public List<string> GetEmptyRoomListByFloorNumber(int floorNumber)
        {
            RoomHandler handler = new RoomHandler();
            return handler.GetAllFreeRoomListOnFloor(floorNumber);
        }

        public string EditStudentInformation(Dictionary<string, string> studentInfo)
        {
            string successMessage = "Редактирование студента прошло успешно.";
            string errorMessage = "Произошла ошибка при редактировании студента.";
            Student student = this.ConvertFromDictionaryInforToStudent(studentInfo);
            EditInformationHandler editHandler = new EditInformationHandler();
            bool isSuccess = editHandler.EditStudent(student);
            return isSuccess ? successMessage : errorMessage;
        }

        public Dictionary<string, string> GetStudentInfoDictionaryByLogin(string login)
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            UserHandler handler = new UserHandler();
            Student student = handler.GetStudentByLogin(login);
            resultDict["surname"] = student.Surname;
            resultDict["name"] = student.Name;
            resultDict["patronymic"] = student.Patronymic;
            resultDict["phone"] = student.PhoneNumber;
            resultDict["address"] = student.Address;
            resultDict["passport"] = student.PassportData;
            resultDict["course"] = student.Course.ToString();
            resultDict["floor"] = student.Room.Floor.IdFloor.ToString();
            resultDict["room"] = student.Room.IdRoom.ToString();
            resultDict["headFloor"] = student.IsHeadFloor;
            resultDict["group"] = student.GroupNumber;
            return resultDict;
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
            student.UserTypeInt = (int)UserTypeEnum.Student;
            student.UserType = "студент";
            student.Room = new Room();
            student.Room.IdRoom = studentInfo["room"];
            student.GroupNumber = studentInfo["group"];
            student.Course = int.Parse(studentInfo["course"]);
            student.IsHeadFloor = studentInfo["headFloor"];
            return student;
        }
    }
}
