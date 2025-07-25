using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            One one = new Test();
            one.Show();
            Two two = new Test();
            two.Show();
        }
    }
}
