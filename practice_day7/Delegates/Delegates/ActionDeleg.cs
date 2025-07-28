using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Delegates
{
    internal class ActionDeleg
    {
        public delegate void AcDelegate(string s);
        public static void Func(string s)
        {
            Console.WriteLine("Hi " +s);
        }
        static void Main()
        {
            AcDelegate ad = Func;
            ad("Vijay");
        }
    }
}
