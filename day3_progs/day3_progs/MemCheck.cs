using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class MemCheck
    {
        static void Main()
        {
            string s1 = "vijay", s2 = "deva", s3 = "vijay", s4 = "sai", s5 = "siddu";
            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
            Console.WriteLine(s5.GetHashCode());
        }
    }
}
