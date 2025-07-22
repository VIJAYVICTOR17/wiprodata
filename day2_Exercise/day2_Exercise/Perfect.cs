using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class Perfect
    {
        public void Check(int a)
        {
            int s = 0;
            for (int  i = 1; i<a; i++)
            {
                if (a%i==0)
                {
                   s =  i + s;
                }
            }
            if (s==a)
            {
                Console.WriteLine("Perfect number :" +a);
            }else
            {
                Console.WriteLine("Not a perfecrt number :" +a);
            }
        }
        static void Main()
        {
            int a;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            Perfect p = new Perfect();
            p.Check(a);
        }
    }
}
