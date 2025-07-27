using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployProject.models;
using EmployProject.Dao;
using EmployProject.Exceptions;

namespace EmployProject.Bal
{
    public class EmployBal
    {
        public StringBuilder sb = new StringBuilder();
        public static EmployDaoImpl daoImpl;

        static EmployBal()
        {
            daoImpl = new EmployDaoImpl();
        }

        public List<Employ> ShowEmployBal()
        {
            return daoImpl.ShowEmployDao();
        }

        public string WriteFileBal()
        {
            return daoImpl.WriteToFileDao();
        }

        public string ReadFileBal()
        {
            return daoImpl.ReadFromFileDao();
        }

        public string DeleteEmployBal(int empno)
        {
            return daoImpl.DeleteEmployDao(empno);
        }

        public string UpdateEmployBal(Employ employUpdated)
        {
            if (ValidateEmploy(employUpdated) == true)
            {
                return daoImpl.UpdateEmployDao(employUpdated);
            }
            throw new EmployException(sb.ToString());
        }

        public Employ SearchEmployBal(int employ)
        {
            return daoImpl.SearchEmployDao(employ);
        }

        public string AddEmployBal(Employ employ)
        {
            if (ValidateEmploy(employ) == true)
            {
                return daoImpl.AddEmployDao(employ);
            }
            throw new EmployException(sb.ToString());
        }
        public bool ValidateEmploy(Employ employ)
        {
            bool flag = true;
            if (employ.Empno<=0)
            {
                sb.Append("Empno can't be zero or -ve number");
                flag = false;
            }
            if (employ.Name.Length < 5)
            {
                sb.Append("Name should be more then 5 charecters");
                flag = false;
            }
            if (employ.Salary<10000 || employ.Salary>80000)
            {
                sb.Append("Salary should be between 10000 to 80000");
                flag = false;
            }
            return flag;
        }
    }
}
