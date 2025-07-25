using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Claculation cal = new Claculation();
            cal.Sum(3, 2);
            cal.Sub(3, 2);
            cal.Mul(3, 2);
        }
    }
}
