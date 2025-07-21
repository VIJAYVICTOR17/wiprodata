using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Uniary
    {
        static void Main()
        {
            int a =3;
 
            int x = a++ + ++a;
            Console.WriteLine(x);
        }
    }
}
