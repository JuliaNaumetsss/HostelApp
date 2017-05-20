using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using HostelApplication.Model;

namespace HostelApplication.DataAccessLayer
{
    public class InspectionHandler
    {
        public List<Dictionary<string, string>> GetListOfInspectors()
        {
            List<Dictionary<string, string>> resultList = new List<Dictionary<string, string>>();
            DataBaseConnector connector = null;
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic, [User].[login] " +
            "FROM[PersonalInfo] INNER JOIN[User] ON[PersonalInfo].idPersonalInfo = [User].personalInfoId " +
            "INNER JOIN[UserType] ON[User].userTypeId = [UserType].idUserType " +
            "WHERE[UserType].typeName = 'воспитатель' OR[UserType].typeName = 'заведующий общежитием'";
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Inspectors");
                foreach(DataRow row in ds.Tables["Inspectors"].Rows)
                {
                    Dictionary<string, string> infoDict = new Dictionary<string, string>();
                    infoDict["login"] = row["login"].ToString();
                    infoDict["commonInfo"] = row["surname"] + " " + row["name"] + " " + row["patronymic"];
                    resultList.Add(infoDict);
                }
                
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToList());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return resultList;
        }

        public bool AddInspection(Inspection inspection)
        {
            bool isSuccess = true;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
                isSuccess = false;
            }
            return isSuccess;
        }
    }
}
