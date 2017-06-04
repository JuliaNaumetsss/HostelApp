using System.Collections.Generic;
using HostelApplication.DataAccessLayer;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.BusinessLayer
{
    public class InspectionPage
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

        public string GetEmployeeSurnameName(string login)
        {
            UserHandler hdl = new UserHandler();
            string employeeInfo = hdl.GetEmployeeCommonInfo(login);
            return employeeInfo;
        }

        public List<Dictionary<string, string>> GetInspectorList()
        {
            InspectionHandler hdl = new InspectionHandler();
            return hdl.GetListOfInspectors();
        }

        public string AddInspectionInfo(Dictionary<string, string> inspectionInfo)
        {
            string successMessage = "Информация о проверке блока была успешно добавлена.";
            string errorMessage = "Произошла ошибка при добавлении информации о проверке блока.";
            Inspection inspection = this.ConvertInfoDictionaryToInspection(inspectionInfo);
            InspectionHandler hdl = new InspectionHandler();
            return hdl.AddInspection(inspection) ? successMessage : errorMessage;
        }

        private Inspection ConvertInfoDictionaryToInspection(Dictionary<string, string> inspectionInfo)
        {
            Inspection inspection = new Inspection();
            inspection.Room = inspectionInfo["room"];
            inspection.InspectionDate = inspectionInfo["date"];
            inspection.EmployeeLoginList = new List<string>();
            inspection.EmployeeLoginList.Add(inspectionInfo["firstEmployee"]);
            if(!inspectionInfo["secondEmploye"].Equals("-") || !string.IsNullOrEmpty(inspectionInfo["secondEmploye"]))
            {
                inspection.EmployeeLoginList.Add(inspectionInfo["secondEmploye"]);
            }
            inspection.Estimation = this.FormEstimation(inspectionInfo);
            return inspection;
        }

        private Estimation FormEstimation(Dictionary<string, string> inspectionInfo)
        {
            Estimation estimation = new Estimation();
            estimation.Hall = int.Parse(inspectionInfo["hall"]);
            estimation.Kitchen = int.Parse(inspectionInfo["kitchen"]);
            estimation.Restroom = int.Parse(inspectionInfo["restRoom"]);
            estimation.Bathroom = int.Parse(inspectionInfo["bathroom"]);
            estimation.RoomA = int.Parse(inspectionInfo["roomA"]);
            estimation.RoomB = int.Parse(inspectionInfo["roomB"]);
            estimation.AverageRoomB = this.GetAverageMark(estimation, "b");
            estimation.AverageRoomA = this.GetAverageMark(estimation, "a");
            return estimation;
        }

        private double GetAverageMark(Estimation estimation, string roomLetter)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            int roomMark = roomLetter.Equals("a") ? estimation.RoomA : estimation.RoomB;
            double result = (double)(estimation.Hall + estimation.Kitchen + estimation.Restroom + estimation.Bathroom + roomMark) / 5;
            return result;
        }
    }
}
