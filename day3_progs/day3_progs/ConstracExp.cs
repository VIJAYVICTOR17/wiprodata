using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class ConstracExp
    {
        static ConstracExp()
        {
            Console.WriteLine("It's a static constructor ");
        }
        ConstracExp()
        {
            Console.WriteLine("It's instance constractor ");
        }
        static void Main()
        {
            //ConstracExp ce = new ConstracExp();
            ConstracExp ce = new ConstracExp();
        }
    }
}
