using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HostelApplication
{
    public class UserTypeHandler
    {
        
        public string GetUserTypeNameById(int userTypeId)
        {
            DataBaseConnector connector = null;
            string type = string.Empty;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [UserType] WHERE idUserType='{userTypeId}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Type");
                if(ds.Tables["Type"].Rows.Count != 0)
                {
                    type = ds.Tables["Type"].Rows[0]["typeName"].ToString();
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return type;
        }

        public List<string> GetAllUsersType()
        {
            List<string> resultList = new List<string>();
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [UserType].typeName FROM [UserType]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Type");
                foreach (DataRow row in ds.Tables["Type"].Rows)
                {
                    resultList.Add(row["typeName"].ToString());
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return resultList;
        }

        public int GetUserTypeIdByName(string userTypeName)
        {
            DataBaseConnector connector = null;
            int index = -1;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [UserType].idUserType FROM [UserType] WHERE typeName='{userTypeName}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "Type");
                if (ds.Tables["Type"].Rows.Count != 0)
                {
                    int.TryParse(ds.Tables["Type"].Rows[0]["idUserType"].ToString(), out index);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connector?.CloseConnection();
            }
            return index;
        }
    }
}
