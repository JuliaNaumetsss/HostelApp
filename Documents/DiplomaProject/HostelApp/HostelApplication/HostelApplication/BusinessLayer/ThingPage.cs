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
    public class ThingPage
    {
        public List<string> GetThingsList()
        {
            ThingHandler hdl = new ThingHandler();
            return hdl.GetAllThingNameList();
        }

        public List<string> GetAvailableThingList()
        {
            ThingHandler hdl = new ThingHandler();
            return hdl.GetAvailableThingList();
        }

        public int GetAvailableThingCount(string thingName)
        {
            ThingHandler hdl = new ThingHandler();
            return hdl.GetActualThingCount(this.GetIdThingByName(thingName));
        }

        public string AddThings(Dictionary<string, string> infoToAdd, Dictionary<int, int> thingsInfo)
        {
            string resultMessage = "";
            for(int i = 0; i < thingsInfo.Count; i++)
            {
                ThingEmployee model = new ThingEmployee();
                model.StudentId = infoToAdd["student"];
                model.Date = infoToAdd["date"];
                model.ThingId = thingsInfo.ElementAt(i).Key;
                model.Count = thingsInfo.ElementAt(i).Value;
                ThingHandler hdl = new ThingHandler();

                // Add info to table Thing_Employee
                // Decrease count of elements
                if (hdl.AddThingInfo(model) && hdl.UpdateThingCount(model.ThingId, model.Count))
                {
                    resultMessage = "Информация была успешно добавлена.";
                }
                else
                {
                    resultMessage = "Произошла ошибка при добавлении информации.";
                }                
            }
            return resultMessage;
        }

        public int GetIdThingByName(string name)
        {
            ThingHandler hdl = new ThingHandler();
            return hdl.GetThingIdByName(name);
        }
    }
}
