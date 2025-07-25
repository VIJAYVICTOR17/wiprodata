using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    class C1
    {
        public C1()
        {
            Console.WriteLine("Base Class Constructor...");
        }
    }

    class C2 : C1
    {
        public C2()
        {
            Console.WriteLine("Derived Class Constructor...");
        }
    }
    internal class Inheritance
    {
        static void Main()
        {
            C1 c1 = new C1();
            //C2 c2 = new C2();
        }
    }
}
