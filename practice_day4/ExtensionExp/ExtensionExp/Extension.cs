using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExp
{
    internal static class Extension
    {
        public static int Mul(this Claculation cal,int a,  int b)
        {
            return a * b;
        }
    }
}
