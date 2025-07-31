using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableThreadingSyncronIndexer
{
    public class Demo
    {
        public string[] names = new string[4];
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
    }
    public class IndexerExmp
    {
        static void Main()
        {
            Demo demo = new Demo();
            demo[0] = "Vijay";
            demo[1] = "Deva";
            demo[2] = "Sai";
            demo[3] = "Siddu";
            
            foreach(var v in demo.names)
            {
                Console.WriteLine(v);
            }
        }
    }
}
