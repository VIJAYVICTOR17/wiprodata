using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class Calculation
    {
        public int Sum(int a,  int b)
        {
            return a + b;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a and b values :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculation calc = new Calculation();
            Console.WriteLine("Sum of two numbers : " +calc.Sum(a, b));
            Console.WriteLine("Sub of two numbers : " +calc.Sub(a,b));
            Console.WriteLine("Mul of two numbers : " +calc.Mul(a,b));
        }
    }
}
