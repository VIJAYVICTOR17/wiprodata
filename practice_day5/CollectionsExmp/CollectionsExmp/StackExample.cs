using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExample
{
    internal class StackExample
    {
        static void Main()
        {
            Console.WriteLine("Stack Data  ");
            Stack stack = new Stack();
            stack.Push("vijay");
            stack.Push("deva");
            stack.Push("sai");
            stack.Push("siddu");
            
            
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
            stack.Pop();
            Console.WriteLine("pop up of one ele");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
            stack.Pop();
            Console.WriteLine("pop up of two ele");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
        }
    }
}