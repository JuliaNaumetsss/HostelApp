using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class EditEmployeePage
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

        public List<string> GetUsersTypeForEmployee()
        {
            UserTypeHandler userTypeHandler = new UserTypeHandler();
            List<string> usersType = userTypeHandler.GetAllUsersType();
            return usersType.Where(type => type != "студент").ToList();
        }

        public Dictionary<string, string> GetEmployeeInfoDictionaryByLogin(string login)
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            UserHandler handler = new UserHandler();
            Employee employee = handler.GetEmployeeByLogin(login);
            resultDict["surname"] = employee.Surname;
            resultDict["name"] = employee.Name;
            resultDict["patronymic"] = employee.Patronymic;
            resultDict["phone"] = employee.PhoneNumber;
            resultDict["address"] = employee.Address;
            resultDict["passport"] = employee.PassportData;
            resultDict["floor"] = employee.Room.Floor.IdFloor.ToString();
            resultDict["room"] = employee.Room.IdRoom.ToString();
            resultDict["userType"] = employee.UserType;
            resultDict["workPhone"] = employee.WorkPhoneNumber;
            return resultDict;
        }

        public string EditEmployeeInformation(Dictionary<string, string> employeeInfo)
        {
            string successMessage = "Редактирование сотрудника прошло успешно.";
            string errorMessage = "Произошла ошибка при редактировании сотрудника.";
            Employee employee = this.ConvertInformDictionaryToEmployee(employeeInfo);
            EditInformationHandler editHandler = new EditInformationHandler();
            bool isSuccess = editHandler.EditEmployee(employee);
            return isSuccess ? successMessage : errorMessage;
        }

        private Employee ConvertInformDictionaryToEmployee(Dictionary<string, string> employeeInfoDict)
        {
            Employee employee = new Employee();
            employee.Name = employeeInfoDict["name"];
            employee.Surname = employeeInfoDict["surname"];
            employee.Patronymic = employeeInfoDict["patronymic"];
            employee.PhoneNumber = employeeInfoDict["phone"];
            employee.Address = employeeInfoDict["address"];
            employee.PassportData = employeeInfoDict["passport"];
            employee.Login = employeeInfoDict["login"];
            employee.UserType = employeeInfoDict["userType"];
            UserTypeHandler userTypeHandler = new UserTypeHandler();
            employee.UserTypeInt = userTypeHandler.GetUserTypeIdByName(employee.UserType);
            employee.WorkPhoneNumber = employeeInfoDict["workPhone"];
            employee.Room = new Room();
            employee.Room.IdRoom = employeeInfoDict["room"];
            return employee;
        }
    }
}
