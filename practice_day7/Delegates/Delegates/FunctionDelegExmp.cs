using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class FunctionDelegExmp
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        static void main()
        {
            int a, b;
            Console.WriteLine("Enter a and b values : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Func<int, int, int> fc = Mul;
            Console.WriteLine("The Multi of a and b is: " +fc(a,b));
        }
    }
}
