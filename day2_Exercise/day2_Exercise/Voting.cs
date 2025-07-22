using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class Voting
    {
        public void Check(int a)
        {
            if (a>18)
            {
                Console.WriteLine("eligible for voting");
            }
            else
            {
                Console.WriteLine("Not eligible for voiting");
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("enter ur age : ");
            a = Convert.ToInt32(Console.ReadLine());
            Voting v = new Voting();
            v.Check(a);
        }
    }
}
