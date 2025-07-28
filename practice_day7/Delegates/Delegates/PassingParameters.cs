using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class PassingParameters
    {
        public delegate void Delegate(int a);

        public static void Check(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("A is -Ve number" + a);
            }
            else if (a>0)
            {
                Console.WriteLine("A is +Ve number" +a);
            }
            else
            {
                Console.WriteLine("A is Zero" +a);
            }
            
        }
        public static void Main()
        {
            int a;
            Console.WriteLine("Enter a value : ");
            a=Convert.ToInt32(Console.ReadLine());
            Delegate db = new Delegate(Check);
            db(a);
        }
    }
}
