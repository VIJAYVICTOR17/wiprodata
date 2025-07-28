using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class ObsoleteExmp
    {
        [Obsolete("Deprecated Method", false)]
        public static void TestcsMethod()
        {
            Console.WriteLine("Hi I am Vijay");
        }
        static void Main()
        {

        }
    }
}
