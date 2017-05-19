using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HostelApplication.Utils
{
    public class ConfigReader
    {
        public Dictionary<string, string> Read()
        {
            Dictionary<string, string> parametersOfConfigFile = new Dictionary<string, string>();
            string[] keysFromConfigFile = ConfigurationManager.AppSettings.AllKeys;
            foreach (string key in keysFromConfigFile)
            {
                parametersOfConfigFile.Add(key, ConfigurationManager.AppSettings[key]);
            }
            //throw new NotImplementedException();
            return parametersOfConfigFile;
        }
    }
}