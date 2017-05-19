using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Model;

namespace HostelApplication.DataAccessLayer
{
    public class PaymentHandler
    {
        public bool AddPaymentInformation(Payment info)
        {
            bool isSucces = true;

            int sum = this.GetPaymentSumForStudentByLogin(info.StudentId) + info.PaymentSum;

            string query = "INSERT INTO [Payment] (paymentDate, sum, studentId, employeeId) " +
                $"VALUES ('{info.PaymentDate}', '{info.PaymentSum}', '{info.StudentId}', '{info.EmployeeId}')";

            string updateStudentQuery = $"UPDATE [Student] SET paymentSum='{sum}' WHERE studentId='{info.StudentId}'";
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connector.Connection;

                // Insert into worked hours
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();

                // Update user table
                cmd.CommandText = updateStudentQuery;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                isSucces = false;
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return isSucces;
        }

        public int GetPaymentSumForStudentByLogin(string login)
        {
            int sum = -1;
            string query = $"SELECT [Student].paymentSum FROM [Student] WHERE [Student].studentId='{login}'";
            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Payment");
                if (ds.Tables["Payment"].Rows.Count != 0)
                {
                    sum = int.Parse(ds.Tables["Payment"].Rows[0]["paymentSum"].ToString());
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return sum;
        }

        public List<Dictionary<string, string>> GetDebtors(int expectedSum)
        {
            string query = "SELECT [PersonalInfo].surname, [PersonalInfo].name, [PersonalInfo].patronymic, [Student].paymentSum " +
            "FROM[PersonalInfo] INNER JOIN[User] ON[USER].personalInfoId = [PersonalInfo].idPersonalInfo " +
            $"INNER JOIN[Student] ON[User].login = [Student].studentId WHERE [Student].paymentSum < '{expectedSum}'";
            List<Dictionary<string, string>> resultListDict = new List<Dictionary<string, string>>();

            DataBaseConnector connector = null;
            try
            {
                connector = new DataBaseConnector();
                connector.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector.Connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Debtors");
                foreach (DataRow row in ds.Tables["Debtors"].Rows)
                {
                    Dictionary<string, string> resultDict = new Dictionary<string, string>();
                    resultDict["surname"] = row["surname"].ToString();
                    resultDict["name"] = row["name"].ToString();
                    resultDict["patronymic"] = row["patronymic"].ToString();
                    resultDict["paymentSum"] = row["paymentSum"].ToString();
                    resultListDict.Add(resultDict);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                connector?.CloseConnection();
            }
            return resultListDict;
        }
    }
}
