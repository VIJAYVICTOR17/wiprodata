using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class Quiz1
    {
        int n;
        static void Main()
        {
            int x = 12;
            Quiz1 a = new Quiz1();
            a.n = 2;
            Quiz1 b = a;
            b.n = 4;
            Console.WriteLine(b.n);
        }
    }
}
