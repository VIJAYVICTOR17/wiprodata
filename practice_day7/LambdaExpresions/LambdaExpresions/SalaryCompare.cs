using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    internal class SalaryCompare : Comparer<Employ>

    {
        public override int Compare(Employ x, Employ y)
        {
            if (x.Salary >= y.Salary)
            {
                return 1;
            }
            return -1;
        }
    }
}
