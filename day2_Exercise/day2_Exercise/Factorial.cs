using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class Factorial
    {
        public void Check(int a)
        {
            int t = 1;
            for (int i = 1; i<=a; i++)
            {
                  t = t * i;
            }
            Console.WriteLine(+t);
        }
        
        static void Main()
        {
            int a;
            Console.WriteLine("enter a number :");
            a = Convert.ToInt32(Console.ReadLine());
            Factorial f = new Factorial();
            f.Check(a);
        }
    }
}
