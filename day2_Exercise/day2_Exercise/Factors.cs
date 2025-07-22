using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class Factors
    {
        public void Check(int n)
        {
            for (int i =1; i<=n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine("factors : " + i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Factors f= new Factors();
            f.Check(n);
        }
    }
}
