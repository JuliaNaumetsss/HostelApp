using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class AddEmployeePage
    {
        public List<string> GetUsersTypeForEmployee()
        {
            UserTypeHandler userTypeHandler = new UserTypeHandler();
            List<string> usersType = userTypeHandler.GetAllUsersType();
            return usersType.Where(type => type != "студент").ToList();
        }

        public List<string> GetFloorList()
        {
            FloorHandler handler = new FloorHandler();
            return handler.GetFloorNumberList();
        }

        public List<string> GetEmptyRoomList()
        {
            RoomHandler handler = new RoomHandler();
            return handler.GetAllFreeRoomList();
        }

        public List<string> GetEmptyRoomListByFloorNumber(int floorNumber)
        {
            RoomHandler handler = new RoomHandler();
            return handler.GetAllFreeRoomListOnFloor(floorNumber);
        }

        public string AddEmployee(Dictionary<string, string> employeeInfoDict)
        {
            string resultMessage = "";
            string successMessage = "Сотрудник был успешно добавлен.";
            string errorMessage = "Произошла ошибка при добавлении сотрудника.";
           
            Employee employee = this.ConvertInformDictionaryToEmployee(employeeInfoDict);
            UserHandler userHandler = new UserHandler();
            if (!userHandler.IsUserByLoginExist(employee.Login))
            {
                AddInformationHandler addInfoHandler = new AddInformationHandler();
                bool isUserAdded = addInfoHandler.AddEmployee(employee);
                resultMessage = isUserAdded ? successMessage : errorMessage;
            }
            else
            {
                resultMessage = "Пользователь с таким логином уже существует!\r\n Введите другой логин пользователя.";
            }
            return resultMessage;
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
            employee.Password = employeeInfoDict["password"];
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
