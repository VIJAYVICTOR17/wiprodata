using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemos
{
    public class EmployDao
    {
        static List<Employ> employList;
        static EmployDao()
        {
            employList = new List<Employ>()
            {
                new Employ { Id = 1, Name = "Vijay", Salary = 88222 },
                new Employ { Id = 2, Name = "Deva", Salary = 99223 },
                new Employ { Id = 3, Name = "Sai", Salary = 99211 },
                new Employ { Id = 4, Name = "Siddu", Salary = 92344 }
            };
        }
        public List<Employ> ShowEmploy()
        {
            return employList;
        }

        public Employ SearchEmploy(int empno)
        {
            Employ employFound = null;
            foreach (Employ employ in employList)
            {
                if (employ.Id == empno)
                {
                    employFound = employ;
                }
            }
            return employFound;
        }
    }
}
