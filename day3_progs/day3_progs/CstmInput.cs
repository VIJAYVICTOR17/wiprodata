using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3_progs
{
    internal class CstmInput
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the rows and coloms : ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            int[,] x = new int[a, b];
            Console.WriteLine("Enter the elements : " +(a*b));
            for (int i=0; i<x.GetLength(0);i++)
            {
                for (int j=0; j<x.GetLength(a-1);j++)
                {
                    x[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Display as a matrix : ");
            for (int i=0;i<x.GetLength(0);i++)
            {
                for  (int j=0;j<x.GetLength(1);j++)
                {
                    Console.Write(x[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
