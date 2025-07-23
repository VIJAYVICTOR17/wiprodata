using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class JaggedArray
    {
        static void Main()

        {
            int[][] jaggedarray = new int[2][];
            int[] x = new int[] { 1, 2, 3 };
            int[] y = new int[] { 5, 6, 7 };
            jaggedarray[0] = x;
            jaggedarray[1] = y;

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.Write(jaggedarray[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
