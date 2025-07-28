using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegateArray
    {
        public delegate void MultiDelegate(int a);

        public static void Fact(int a)
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;
            }
            Console.WriteLine("The factorial of" + a + " is" + f);
        }

        public static void PosNeg(int a)
        {
            if (a < 0)
            {
                Console.WriteLine(+a + " is -ve numner");
            }
            else if (a > 0)
            {
                Console.WriteLine(+a + " is  +ve number");
            }
            else
            {
                Console.WriteLine(+a + " is zero");
            }
        }

        public static void Check(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine(+a + " Even number");
            }
            else
            {
                Console.WriteLine(+a + " Odd number");
            }
        }

        public static void Main()
        {
            int a;
            Console.WriteLine("Enter a value : ");
            a = Convert.ToInt32(Console.ReadLine());
            MultiDelegate[] arr =
            {
                new MultiDelegate(PosNeg),
                new MultiDelegate(Fact),
                new MultiDelegate(Check)
            };

            foreach (MultiDelegate mr in arr)
            {
                mr(a);
            }
        }
    }
}
