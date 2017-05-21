using System;
using System.Data;
using System.Data.SqlClient;
using HostelApplication.Enum;
using HostelApplication.Model;

namespace HostelApplication.Handler
{
    public class PersonalInfoHandler
    {
        public User FillUserByPersonalInfo(User user, int persnalInfoId)
        {
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT * FROM [PersonalInfo] WHERE {PersonalInfoEnum.idPersonalInfo}='{persnalInfoId}'", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "PersonalInfo");
                if(ds.Tables["PersonalInfo"].Rows.Count != 0)
                {
                    user.Address = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.address}"].ToString();
                    user.Name = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.name}"].ToString();
                    user.Surname = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.surname}"].ToString();
                    user.Patronymic = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.patronymic}"].ToString();
                    user.PhoneNumber = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.phone}"].ToString();
                    user.PassportData = ds.Tables["PersonalInfo"].Rows[0][$"{PersonalInfoEnum.passport}"].ToString();

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
            return user;
        }

        public int GetLatPersonalInfoIndex()
        {
            int index = -1;
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter($"SELECT [PersonalInfo].{PersonalInfoEnum.idPersonalInfo} FROM [PersonalInfo]", connector.Connection);
                DataSet ds = new DataSet();
                sqlAdapter.Fill(ds, "PersonalInfo");
                DataRow row = ds.Tables["PersonalInfo"].Rows[ds.Tables["PersonalInfo"].Rows.Count - 1];
                int.TryParse(row[$"{PersonalInfoEnum.idPersonalInfo}"].ToString(), out index);
            }
            catch(Exception ex)
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
