using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class CircleProg
    {
        public void Calc(double radius)
        {
            double area, circ;
            area = Math.PI * radius* radius;
            circ = 2* Math.PI*radius;
            Console.WriteLine("Area of a circle : " +area);
            Console.WriteLine("Circumference : " +circ);
        }
        static void Main()
        {
            double radius;
            Console.WriteLine("Enter radius ");
            radius = Convert.ToDouble(Console.ReadLine());
            CircleProg cp  = new CircleProg();
            cp.Calc(radius);
        }
    }
}
