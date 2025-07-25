using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class ConstracOverload
    {
        int a, b;
        public ConstracOverload()
        {
            a = 2;
            b = 3;
        }
        public ConstracOverload(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Show()
        {
            Console.WriteLine("a value is" +a, "b value is" +b);
        }
        public void Main()
        {
            ConstracOverload co = new ConstracOverload();
            co.Show();
            ConstracOverload cd = new ConstracOverload(5,10);
            cd.Show();
        }

    }
}
