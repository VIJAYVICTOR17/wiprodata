using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NullableThreadingSyncronIndexer
{
    class Data
    {
        public void Show(string name)
        {
            lock (this)
            {
                Console.WriteLine("Hello " + name);
                Thread.Sleep(1000);
                Console.WriteLine("I am working in Wipro"); 
            }
        }
    }
    public class SynchronizationExmp
    {
        Data data;
        SynchronizationExmp(Data data)
        {
            this.data = data;
        }
        public void Vijay()
        {
            data.Show("vijay");
        }
        public void Kanna()
        {
            data.Show("kanna");
        }
        static void Main()
        {
            SynchronizationExmp syncExample1 = new SynchronizationExmp(new Data());
            ThreadStart th1 = new ThreadStart(syncExample1.Vijay);
            ThreadStart th2 = new ThreadStart(syncExample1.Kanna);
            Thread t1 = new Thread(th1);
            Thread t2 = new Thread(th2);

            t1.Start();
            t2.Start();
        }

    }
}
