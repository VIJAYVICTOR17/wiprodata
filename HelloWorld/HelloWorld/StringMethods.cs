using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class StringMethods
    {
        static void Main()
        {
            string str = "Hi vijay welcome to the wipro training";
            Console.WriteLine("Length of the string " +str.Length);
            Console.WriteLine("Lower case of the string" +str.ToLower());
            Console.WriteLine("Upper case of the string" +str.ToUpper());
            Console.WriteLine("occurence of 'v' string" +str.IndexOf("v"));
        }
    }
}
