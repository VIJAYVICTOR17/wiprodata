using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Reflections
{
    internal class ReflectionExmp
    {
        static void Main()
        {
            Type typeObj = typeof(Testcs);
            Console.WriteLine("Methods Avaialble in Tes Class Are");
            foreach (MethodInfo m in typeObj.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
            Console.WriteLine("Variables available in the class are ");
            foreach (FieldInfo fi in typeObj.GetFields())
            {
                Console.WriteLine(fi.Name);
            }
        }
    }
}
