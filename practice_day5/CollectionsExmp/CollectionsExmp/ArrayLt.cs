using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsExmp
{
    internal class ArrayLt
    {
        static void Main(string[] args)
        {
            ArrayList name = new ArrayList();
            name.Add("vijay");
            name.Add("deva");
            name.Add("siddu");
            name.Add("sai");
            Console.WriteLine("Array elements : ");
            foreach (object ob in name)
            {
                Console.WriteLine(ob);
            }
            name.Remove("vijay");
            Console.WriteLine("After removing");
            foreach (object ob in name)
            {
                Console.WriteLine(ob);
            }
        }

    }
}
