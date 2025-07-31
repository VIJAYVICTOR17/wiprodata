using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [InformationAtt(InfoString = "Class")]
    public class Stuudent
    {
        private int sno;
        private string name;

        [InformationAtt(InfoString = "Constructor")]
        public Stuudent(int sno, string name)
        {
            this.sno = sno;
            this.name = name;
        }

        [InformationAtt(InfoString = "Method")]
        public void Display()
        {
            Console.WriteLine("Sno " + sno + " Name  " + name);
        }
    }
}
