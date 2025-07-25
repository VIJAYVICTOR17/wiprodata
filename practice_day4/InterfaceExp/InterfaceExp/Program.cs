using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Details[] d = new Details[]
            {
                new Vijay(),
                new Kanna()
            };
            foreach (Details pd in d)
            {
                pd.Name();
                pd.Age();
            }
        }
    }
}
