using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class ArrayExp
    {
        public void Show()
        {
            int[] i = new int[] { 2, 3, 4, 5, 6, 7, 8 };
            foreach(int a in i)
            {
                Console.WriteLine(+a);
            }
        }
        static void Main()
        {
            ArrayExp ae = new ArrayExp();
            ae.Show();
        }
    }
}
