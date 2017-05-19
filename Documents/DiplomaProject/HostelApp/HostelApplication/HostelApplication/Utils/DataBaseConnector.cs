using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HostelApplication.Utils;

namespace HostelApplication
{
    public class DataBaseConnector
    {
        public DataBaseConnector()
        {
            this.FormConnectionString();
        }

        string dataSource = "";
        string initialCatalog = "";
        string integratedSecurity = "";

        private string ConnectionString { get; set; }

        public SqlConnection Connection { get; private set; }

        private void FormConnectionString()
        {
            this.ReadConfigFile();
            if (string.IsNullOrEmpty(dataSource))
            {
                throw new Exception(" Parameter 'Data Source' shouldn't be empty. Please fill DataFile");
            }
            if (string.IsNullOrEmpty(initialCatalog))
            {
                throw new Exception(" Parameter 'Initial Catalog' shouldn't be empty. Please fill DataFile");
            }
            if (string.IsNullOrEmpty(integratedSecurity))
            {
                integratedSecurity = "True";
            }
            this.ConnectionString = $"Data Source={dataSource}; Initial Catalog={initialCatalog}; Integrated Security={integratedSecurity};";

        }

        public void OpenConnection()
        {
            this.Connection = new SqlConnection(this.ConnectionString);
            this.Connection.Open();
        }

        public void CloseConnection()
        {
            this.Connection?.Close();
        }

        private void ReadConfigFile()
        {
            ConfigReader reader = new ConfigReader();
            Dictionary<string, string> configData = reader.Read();
            configData.TryGetValue("DataSource", out dataSource);
            configData.TryGetValue("InitialCatalog", out initialCatalog);
            configData.TryGetValue("IntagratedSecurity", out integratedSecurity);
        }

    }
}
