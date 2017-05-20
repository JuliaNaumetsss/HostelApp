using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string resultMessage = "";
            return resultMessage;
        }
    }
}
