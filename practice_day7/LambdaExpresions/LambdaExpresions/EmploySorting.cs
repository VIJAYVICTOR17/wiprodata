using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    internal class EmploySorting
    {
        static void Main()
        {
            List<Employ> employList = new List<Employ>
            {
                new Employ{Id=1,Name="Vijay",Salary=88323},
                new Employ{Id=2,Name="Deva",Salary=91133},
                new Employ{Id=3,Name="Siddu",Salary=80022},
                new Employ{Id=4,Name="Sai",Salary=90321},
                new Employ{Id=5,Name="Kanna",Salary=78822},
            };
            employList.Sort();
            Console.WriteLine("Sorted Data (default w.r.t. Empno)  ");
            var result1 = employList.Select(x => x);
            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Sort by Name-wise  ");
            employList.Sort(new NameComparer());
            var result2 = employList.Select(x => x);
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Sort By Basic-Wise ");
            employList.Sort(new SalaryComparer());
            foreach (var v in employList)
            {
                Console.WriteLine(v);
            }
        }
    }
}
