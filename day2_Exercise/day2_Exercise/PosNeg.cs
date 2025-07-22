using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class PosNeg
    {
        public void Check(int a)
        {
            if (a<0)
            {
                Console.WriteLine("It's a -ve number");
            }else if (a>0)
            {
                Console.WriteLine("It's a +ve number");
            }else
            {
                Console.WriteLine("It's a '0' ");
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("Enter a value ");
            a = Convert.ToInt32(Console.ReadLine());
            PosNeg pn = new PosNeg();
            pn.Check(a);
        }
    }
}
