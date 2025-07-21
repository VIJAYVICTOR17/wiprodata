using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class CustomExample
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine(); 
            
            Console.WriteLine("hello " +name); 
        }
    }
}
