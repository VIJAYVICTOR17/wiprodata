using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExp
{
    internal class Siddu : PersonDetails
    {
        public override void Age()
        {
            Console.WriteLine("My age is 22");
        }

        public override void Name()
        {
            Console.WriteLine("My name is siddu");
        }
    }
}
