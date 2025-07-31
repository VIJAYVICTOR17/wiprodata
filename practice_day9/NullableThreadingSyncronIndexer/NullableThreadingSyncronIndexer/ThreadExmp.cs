using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NullableThreadingSyncronIndexer
{
    public class ThreadExmp
    {
        public static void EvenCheck()
        {
            for (int i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(+i + "Even");
                    Thread.Sleep(1000);
                }
            }
        }
        public static void Table()
        {
            int n=5;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n * i );
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            ThreadStart ts1 = new ThreadStart(EvenCheck);
            ThreadStart ts2 = new ThreadStart(Table);

            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);

            t1.Start();
            t2.Start();
        }
    }

}
