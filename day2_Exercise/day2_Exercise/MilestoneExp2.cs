using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class MilestoneExp2
    {
        static void Main()
        {
            string str;
            Console.WriteLine("Enter a sentence : ");
            str = Console.ReadLine();
            string[] strings = str.Split(' ');
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }
    }
}
