using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_progs
{
    internal class StaticExp
    {
        static int cnt;
        public void Increment()
        {
            cnt++;
        }
        public void Show()
        {
            Console.WriteLine("displaying count : " +cnt);
        }
        static void Main()
        {
            StaticExp s1 = new StaticExp();
            StaticExp s2 = new StaticExp();
            s1.Increment();
            s1.Show();
            s2.Increment();
            s2.Show();
        }
    }
}
