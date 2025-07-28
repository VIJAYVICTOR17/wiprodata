using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class FunctionDeleg
    {
        

        public static int Check(int a)
        {
            int f= 1;
            for (int i=1; i<=a;i++)
            {
                f= f*i;
            }
            return f;
        }

        static void Main()
        {
            int a;
            Console.WriteLine("Enter a value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Func<int, int> f = Check;
            Console.WriteLine(+f(a));
        }
    }
}
