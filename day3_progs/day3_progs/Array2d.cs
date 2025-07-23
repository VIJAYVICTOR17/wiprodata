using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class Array2d
    {
        static void Main()
        {
            int[,] x = new int[2, 3]
            {
                {1,2,3},
                {4,5,6}
            };
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("x{0}{1}  {2}", i, j, x[i, j]);
                }
            }
        }
    }
}
