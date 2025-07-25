using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Test : One, Two
    {
        void One.Show()
        {
            Console.WriteLine("Method from interface one");
        }
        void Two.Show()
        {
            Console.WriteLine("Method from interface two");
        }
    }
}
