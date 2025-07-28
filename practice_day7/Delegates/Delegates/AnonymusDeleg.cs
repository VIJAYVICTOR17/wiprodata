using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class AnonymusDeleg
    {
        public delegate void AnonyDeleg(string s);
        static void Main()
        {
            AnonyDeleg ad = delegate(string s)
            {
                Console.WriteLine("From Anonymus Delegate " +s);
            };
            ad("vijay");
        }
    }
}
