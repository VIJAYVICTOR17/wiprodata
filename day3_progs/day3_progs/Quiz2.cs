using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class Quiz2
    {
        public void Increment(ref int a)
        {
            ++a;
        }
        static void Main()
        {
            int a = 7;
            Quiz2 n = new Quiz2();
            n.Increment(ref a);
            Console.WriteLine(a);
        }
    }
}
