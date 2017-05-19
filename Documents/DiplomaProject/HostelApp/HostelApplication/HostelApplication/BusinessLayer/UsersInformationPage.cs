using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class UsersInformationPage
    {
        public List<Dictionary<string, string>> GetStudentListInfoForDisplaying()
        {
            List<Dictionary<string, string>> resultListDictionary = new List<Dictionary<string, string>>();
            UserHandler userHandler = new UserHandler();
            List<Student> studentList = userHandler.GeStudentList();
            foreach (Student student in studentList)
            {
                Dictionary<string, string> resultDictionary = new Dictionary<string, string>();
                resultDictionary.Add("surname", student.Surname);
                resultDictionary.Add("name", student.Name);
                resultDictionary.Add("patronymic", student.Patronymic);
                resultDictionary.Add("floor", student.Room.Floor.IdFloor.ToString());
                resultDictionary.Add("room", student.Room.IdRoom);
                resultDictionary.Add("phone", student.PhoneNumber);
                resultDictionary.Add("login", student.Login);
                resultListDictionary.Add(resultDictionary);
            }
            return resultListDictionary;
        }

        public List<Dictionary<string, string>> GetEmployeeListInfoForDisplay()
        {
            List<Dictionary<string, string>> resultListDictionary = new List<Dictionary<string, string>>();
            UserHandler userHandler = new UserHandler();
            List<Employee> employeeList = userHandler.GetEmployeeList();
            foreach(Employee employee in employeeList)
            {
                Dictionary<string, string> resultDictionary = new Dictionary<string, string>();
                resultDictionary.Add("surname", employee.Surname);
                resultDictionary.Add("name", employee.Name);
                resultDictionary.Add("patronymic", employee.Patronymic);
                resultDictionary.Add("room", employee.Room.IdRoom);
                resultDictionary.Add("userType", employee.UserType);
                resultDictionary.Add("phone", employee.PhoneNumber);
                resultDictionary.Add("login", employee.Login);
                resultListDictionary.Add(resultDictionary);
            }
            return resultListDictionary;
        }

        public Dictionary<string, string> GetStudentInfoByLogin(string login)
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            UserHandler userHandler = new UserHandler();
            Student student = userHandler.GetStudentByLogin(login);
            resultDict.Add("surname", student.Surname);
            resultDict.Add("name", student.Name);
            resultDict.Add("patronymic", student.Patronymic);
            resultDict.Add("address", student.Address);
            resultDict.Add("group", student.GroupNumber);
            resultDict.Add("course", student.Course.ToString());
            resultDict.Add("room", student.Room.IdRoom);
            resultDict.Add("headFloor", student.IsHeadFloor);
            resultDict.Add("phone", student.PhoneNumber);
            resultDict.Add("passport", student.PassportData);
            resultDict.Add("workedHours", student.TotalWorkedHours.ToString());
            resultDict.Add("payment", student.PaymentSum.ToString());
            return resultDict;
        }

        public Dictionary<string, string> GetEmployeeInfoByLogin(string login)
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            UserHandler userHandler = new UserHandler();
            Employee employee = userHandler.GetEmployeeByLogin(login);
            resultDict.Add("surname", employee.Surname);
            resultDict.Add("name", employee.Name);
            resultDict.Add("patronymic", employee.Patronymic);
            resultDict.Add("address", employee.Address);
            resultDict.Add("room", employee.Room.IdRoom);
            resultDict.Add("userType", employee.UserType);
            resultDict.Add("passport", employee.PassportData);
            resultDict.Add("workPhone", employee.WorkPhoneNumber);
            resultDict.Add("phone", employee.PhoneNumber);
            resultDict.Add("login", employee.Login);
            return resultDict;
        }
        
        public Image GetStudentPhotoFromDataBase(string studentLogin)
        {
            ImageHandler imgGenerator = new ImageHandler();
            UserHandler hdl = new UserHandler();
            byte[] photoArrayBytes = hdl.GetImageFromStudentDatabase(studentLogin);
            return photoArrayBytes != null ? imgGenerator.ConvertByteArrayToImage(photoArrayBytes) : null;
        }

        public Image CompressImage(Image image, int nWidth, int nHeight)
        {
            ImageHandler generator = new ImageHandler();
            return generator.ResizeOriginalImage(image, nWidth, nHeight);
        }
    }
}
