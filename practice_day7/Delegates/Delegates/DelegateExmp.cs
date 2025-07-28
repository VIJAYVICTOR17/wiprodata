using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DelegateExmp
    {
        public delegate void Delegate();

        public  static void Show()
        {
            Console.WriteLine("Welcome to Wipro Training");
        }

        static void Main()
        {
            Delegate dg = new Delegate(Show);
            dg();
        }
    }
}
