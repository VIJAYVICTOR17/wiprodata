using ExtensionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            Console.WriteLine(op.MileStone1());
            Console.WriteLine(op.MileStone2());
            Console.WriteLine(op.MileStone3());
            Console.WriteLine(op.MileStone4());
            Console.WriteLine(op.Project());
        }
    }
}
