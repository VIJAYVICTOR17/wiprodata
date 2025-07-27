using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployProject.models
{
    public class Employ
    {
        public int Empno { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }
        public string Desig { get; set; }

        public Employ() { }
        public Employ(int empno, string name, string gender, string dept, double salary, string desig)  
        {
            Empno = empno;
            Name = name;
            Gender = gender;
            Dept = dept;
            Salary = salary;
            Desig = desig;
        }
        public override string ToString()
        {
            return "Emp no " + Empno +
                "name " + Name +
                "gender " + Gender +
                "department " + Dept +
                "salary " + Salary +
                "designation " + Desig;
        }
    }
}
