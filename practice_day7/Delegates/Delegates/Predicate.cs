using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Predicate
    {
        public static bool Check(string gender)
        {
            if (gender.Equals("male") || gender.Equals("female"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Marry(int status)
        {
            if (status == 0 || status == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            int status;
            string gender;
            Console.WriteLine("enter your gender : ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your marratial status(0 or 1)");
            status = Convert.ToInt32(Console.ReadLine());
            Predicate<string> pd = Check;
            Console.WriteLine(pd(gender));
            Predicate<int> pi = Marry;
            Console.WriteLine(pi(status));
        }
    }
}
