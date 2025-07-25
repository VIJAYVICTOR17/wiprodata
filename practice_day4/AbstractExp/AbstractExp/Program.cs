using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonDetails[] pd = new PersonDetails[]
            {
                new Vijay(),
                new Deva(),
                new Siddu()
            };
            foreach (PersonDetails p in pd)
            {
                p.Comapny();
                p.Name();
                p.Age();
            }

        }
    }
}
