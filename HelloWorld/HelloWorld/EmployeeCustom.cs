using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class EmployeeCustom
    {
        static void Main()
        {

            string name;
            int age;
            double salary;
            Console.WriteLine("enter employee name");
            name = Console.ReadLine();
            Console.WriteLine("enter employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }
    }
}
