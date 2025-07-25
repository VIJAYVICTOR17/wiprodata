using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_progs
{
    internal class StaticExten
    {
        int cnt;
        public void Increment()
        {
            cnt++;
        }
        public void Show()
        {
            Console.WriteLine("displaying count : " + cnt);
        }
        static void Main()
        {
            StaticExten s1 = new StaticExten();
            StaticExten s2 = new StaticExten();
            s1.Increment();
            
            s2.Increment();
            s1.Show();
            //s2.Show();
        }
    }
}
