using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class Overload1
    {
        public void Show(int n)
        {
            Console.WriteLine("From integer : " +n);
        }
        public void Show(string n)
        {
            Console.WriteLine("From string : " +n);
        }
        public void Show(double n)
        {
            Console.WriteLine("From double : " +n);
        }
        static void Main()
        {
            Overload1 ov = new Overload1();
            ov.Show(1);
        }
    }
}
