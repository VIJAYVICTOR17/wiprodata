using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    internal class Employ : IComparable<Employ>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employ employ)
        {
            if (Id >= employ.Id)
            {
                return 1;
            }
            return -1;
        }

        public override string ToString()
        {
            return "Employ No " + Id + " Employ Name " + Name + " Basic " + Salary;
        }
    }
}
