using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_Exercise
{
    internal class MilstoneExmp1
    {
        public void Show(string str)
        {
            int count = 0;
            char[] chars = str.ToCharArray();
            foreach (char c in chars)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine("the count of vowles are : " + count);
        }
        static void Main()
        {
            string str;
            Console.WriteLine("enter a sentence : ");
            str = Console.ReadLine();
            MilstoneExmp1 ms = new MilstoneExmp1();
            ms.Show(str);
        }
    }
}
