using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace day2_Exercise
{
    internal class ifElse
    {
        public void Show(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("I am vijay");
            } else if (choice == 2)
            {
                Console.WriteLine("I am Sai");
            }
            else if (choice == 3)
            {
                Console.WriteLine("I am deva");
            }
            else
            {
                Console.WriteLine("I am siddu");
            }
        }
        static void Main()
        {
            int choice;
            Console.WriteLine("enter ur choice ");
            choice = Convert.ToInt32(Console.ReadLine());
            ifElse id = new ifElse();
            id.Show(choice);
           
        }
    }
}
