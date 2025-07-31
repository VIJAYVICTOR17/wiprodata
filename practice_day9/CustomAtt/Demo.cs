using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAtt
{
    internal class Demo
    {
        public static void PrintClassInfor(Type t)
        {
            MemberInfo memberInfo = t;
            object[] arr = memberInfo.GetCustomAttributes(typeof(VendorAtt), false);
            foreach (object ob in arr)
            {
                VendorAtt v = (VendorAtt)ob;
                Console.WriteLine(v.vendorName);
                Console.WriteLine(v.premiumAmount);
            }
        }
    }
}
