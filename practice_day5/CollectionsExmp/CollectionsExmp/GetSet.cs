using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExmp
{
    internal class OutputParam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "Emp Id  " + Id + " Emp Name  " + Name + " Salary  " + Salary;
        }
    }
}
