using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class StuDet
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }

        public StuDet()
        {
            Rollno = 0;
            Name = string.Empty;
            Marks = 0.0;
        }
        public StuDet(int rollno, string name, double marks)
        {
            Rollno = rollno;
            Name = name;
            Marks = marks;
        }
        public override string ToString()
        {
            return "rollno" + Rollno + "name" + Name + "marks" + Marks; 
        }

        public void ShowStudent()
        {
            Console.WriteLine("Still Pending");
        }
        public void DeleteStudent(int sid)
        {
            Console.WriteLine("Delete Student " + Rollno);
        }
        public void SearchStudent(int sid)
        {
            Console.WriteLine("Search Student  " + Rollno);
        }

        public void AddStudent(StuDet student)
        {
            Console.WriteLine("Add Student");
        }
    }

}
