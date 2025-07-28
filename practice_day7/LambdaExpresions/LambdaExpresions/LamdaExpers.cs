using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    internal class LamdaExpers
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

            Console.WriteLine("Employ List ");
            var result1 = employList.Select(x => x);
            foreach (var v in result1)
            {
                Console.WriteLine(v);
            }

            var result2 = employList.Select(x => new { x.Name, x.Salary });
            Console.WriteLine("Projected Fields are");
            foreach (var v in result2)
            {
                Console.WriteLine(v);
            }

            var result3 = employList.Where(x => x.Salary >= 90000);
            Console.WriteLine("Salary > 90000 records are");
            foreach (var v in result3)
            {
                Console.WriteLine(v);
            }
            var result4 = employList.Where(x => x.Name.StartsWith("P"));
            foreach (var v in result4)
            {
                Console.WriteLine(v);
            }
        }
    }
}
