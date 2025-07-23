using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClaculationLibrary1;

namespace ClaculationClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Claculation calculation = new Claculation();
            Console.WriteLine("Enter a and b values :");
            int a, b;
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of a and b : " +calculation.Sum(a,b));
            Console.WriteLine("Sub of a and b : " +calculation.Sub(a,b));
            Console.WriteLine("Mul of a and b : " +calculation.Mul(a,b));
        }
    }
}
