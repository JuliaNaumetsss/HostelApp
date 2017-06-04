using System;
using System.Collections.Generic;
using System.Linq;
using HostelApplication.DataAccessLayer;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.BusinessLayer
{
    public class WorkedHoursPage
    {
        public List<string> GetFloorList()
        {
            FloorHandler handler = new FloorHandler();
            return handler.GetFloorNumberList();
        }

        public List<string> GetRoomList(int floorId)
        {
            RoomHandler hdl = new RoomHandler();
            return hdl.GetAllRoomListByFloor(floorId);
        }

        public List<Dictionary<string, string>> GetStudentListDictionary(string roomId)
        {
            UserHandler hdl = new UserHandler();
            return hdl.GetStudentCommonInfoByRoomId(roomId);           
        }

        public string GetEmployeeSurnameName(string login)
        {
            UserHandler hdl = new UserHandler();
            string employeeInfo = hdl.GetEmployeeCommonInfo(login);
            return employeeInfo;
        }

        public string AddWorkedHoursInformation(Dictionary<string, string> infoToAdd)
        {
            string successMessage = "Информация была успешно добавлена.";
            string failedMessage = "Произошла ошибка при добавлении информации.";
            WorkedHours workedHours = this.FormWorkedHoursObjectFromDictionary(infoToAdd);
            WorkedHoursHandler hdl = new WorkedHoursHandler();
            return hdl.AddWorkedHoursInformation(workedHours) ? successMessage : failedMessage;                
        }

        public List<Dictionary<string, string>> GetDebtorsList(int expectedHoursCount)
        {
            WorkedHoursHandler hdl = new WorkedHoursHandler();
            return hdl.GetDebtors(expectedHoursCount);
        }

        private WorkedHours FormWorkedHoursObjectFromDictionary(Dictionary<string, string> infoToAdd)
        {
            WorkedHours workedHours = new WorkedHours();
            workedHours.EmployeeId = infoToAdd["employee"];
            workedHours.StudentId = infoToAdd["student"];
            workedHours.WorkedDate = infoToAdd["date"];
            workedHours.HoursCount = int.Parse(infoToAdd["hoursCount"]);
            workedHours.Description = infoToAdd["description"];
            return workedHours;
        }
    }
}
