using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExmp
{
    internal class OutputParams
    {
        public void Show(int EmpId, out string name, out double salary)
        {
            name = string.Empty;
            salary = 0;
            if (EmpId==1)
            {
                name = "vijay";
                salary = 25000;
            }
            if (EmpId==2)
            {
                name = "kanna";
                salary = 30000;
            }
            if (EmpId==3)
            {
                name = "siddu";
                salary = 27000;
            }
        }
        static void Main()
        {
            int EmpId;
            Console.WriteLine("Enter the employee id : ");
            EmpId = Convert.ToInt32(Console.ReadLine());
            OutputParams op = new OutputParams();
            string name;
            double salary;
            op.Show(EmpId, out name, out salary);
            Console.WriteLine("name" +name);
            Console.WriteLine("salary" +salary);
        }
       
    }
}
