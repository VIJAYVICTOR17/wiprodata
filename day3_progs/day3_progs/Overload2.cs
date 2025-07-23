using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class Overload2
    {
        public int Sum()
        {
            return 2;
        }
        public int Sum(int x)
        {
            return x + 9;
        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main()
        {
            Overload2 ov = new Overload2();
            Console.WriteLine(+ov.Sum(7,7));

        }
    }
}
