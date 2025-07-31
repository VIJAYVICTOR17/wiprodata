using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableThreadingSyncronIndexer
{
    internal class NullableExmp
    {
        static void Main()
        {
            Employ emp1 = new Employ();
            emp1.Id = 1;
            emp1.Name = "vijay";
            emp1.Salary = 25000;

            Employ emp2 = new Employ();
            emp2.Id = 2;
            emp2.Name = "Deva";
            emp2.Salary = 36000;

            Employ emp3 = new Employ();
            emp3.Id = 3;
            emp3.Name = "Sai";
            emp3.Salary = 35000;

            emp1.Leaves = 5;
            emp3.Leaves = 2;

            if (emp1.Leaves.HasValue)
            {
                Console.WriteLine("{0} taken leaves", emp1.Name);
                emp1.Status = 0;
            }
            else
            {
                Console.WriteLine("{0} Not taken leaves", emp1.Name);
                emp1.Status=1;
            }

            if (emp2.Leaves.HasValue)
            {
                Console.WriteLine("{0} taken leaves", emp2.Name);
                emp2.Status = 0;
            }else
            {
                Console.WriteLine("{0} not taken leaves", emp2.Name);
            }

            if (emp3.Leaves.HasValue)
            {
                Console.WriteLine("{0} taken leaves", emp3.Name);
                emp3.Status = 0;
            }
            else
            {
                Console.WriteLine("{0} not tkaen leaves", emp3.Name);
                emp2.Status=1;
            }
        }
    }
}
