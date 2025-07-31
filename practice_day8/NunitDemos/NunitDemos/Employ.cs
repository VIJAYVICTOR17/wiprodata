using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitDemos
{
    public class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employ() { }

        public Employ(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return "EmpId" +Id+ "EmpName" +Name+ "Salary" +Salary;
        }
    }
}
