using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExp
{
    internal class Vijay : PersonDetails
    {
        public override void Age()
        {
            Console.WriteLine("My age is 23");
        }

        public override void Name()
        {
            Console.WriteLine("my name is vijay"); 
        }
    }
}
