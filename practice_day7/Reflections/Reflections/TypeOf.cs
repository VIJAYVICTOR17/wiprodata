using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class TypeOf
    {
        static  void Main()
        {
            Type t = typeof(string);
            Console.WriteLine("Name  " + t.Name);
            Console.WriteLine("Full Name  " + t.FullName);
            Console.WriteLine("Namespace  " + t.Namespace);
            Console.WriteLine("Base Type  " + t.BaseType);
        }
    }
}
