using EmployProject.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace EmployProject.Dao
{
    public class EmployDaoImpl : IEmployDao
    {
        static List<Employ> employList;

        static EmployDaoImpl()
        {
            employList = new List<Employ>();
        }
        public string AddEmployDao(Employ employ)
        {
            employList.Add(employ);
            return "Employ record added successfully";
        }

        public string DeleteEmployDao(int empno)
        {
            Employ employFound = SearchEmployDao(empno);
            if (employFound != null)
            {
                employList.Remove(employFound);
                return "Employ record deleted successfully";
            }
            return "Employ record is not found";
        }

        public string ReadFromFileDao()
        {
            FileStream fs = new FileStream(@"c:\files\Employ.txt", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            employList = (List<Employ>)formatter.Deserialize(fs);
            return "Data retrieved from the file Successfully";
        }

        public Employ SearchEmployDao(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                employFound = employ;
                break;
            }
            return employFound;
        }

        public List<Employ> ShowEmployDao()
        {
            return employList;
        }

        public string UpdateEmployDao(Employ employUpdated)
        {
            Employ employFound = SearchEmployDao(employUpdated.Empno);
            if (employFound != null)
            {
                employFound.Name = employUpdated.Name;
                employFound.Gender = employUpdated.Gender;
                employFound.Dept = employUpdated.Dept;
                employFound.Desig = employUpdated.Desig;
                employFound.Salary = employUpdated.Salary;
                return "Employ details are updated";
            }
            return "Employ details are not found";
        }

        public string WriteToFileDao()
        {
            FileStream fs = new FileStream(@"c:\files\EmployDet.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, employList);
            fs.Close();
            return "Data stored in the files successfully";
        }
    }
}
