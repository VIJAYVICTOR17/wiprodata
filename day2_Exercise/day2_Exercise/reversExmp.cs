using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class reversExmp
    {
        static void Main()
        {
            string str = "we are good friends";
            string[] strings = str.Split(' ');
            foreach (string s in strings)
            {
                Console.WriteLine(s.Reverse());
            }
        }
    }
}
