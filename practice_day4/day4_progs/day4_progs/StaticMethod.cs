using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_progs
{
    class Person
    {
        public static void Show()
        {
            Console.WriteLine("show method from person class");
        }
        public void Check()
        {
            Console.WriteLine("check method from person class ");
        }
    }
    internal class StaticMethod
    {
        static  void Main()
        {
            new Person().Check();
            Person.Show();

        }
    }
}
