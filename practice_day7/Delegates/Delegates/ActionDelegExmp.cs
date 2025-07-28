using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ActionDelegExmp
    {
        public static void Show(string a)
        {
            Console.WriteLine("Hi Deva");
        }
        public static void Check(string a)
        {
            Console.WriteLine("HI vijay");
        }

        static void Main()
        {
            string a;
            Console.WriteLine("Enter value : ");
            a = Console.ReadLine();
            Action<string> sd = Show;
            sd += Check;
            sd(a);
        }
    }
}
