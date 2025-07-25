using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExp
{
    internal abstract class PersonDetails
    {
        public void Comapny()
        {
            Console.WriteLine("Company is Wipro");
        }
        public abstract void Name();
        public abstract void Age();
    }
}
