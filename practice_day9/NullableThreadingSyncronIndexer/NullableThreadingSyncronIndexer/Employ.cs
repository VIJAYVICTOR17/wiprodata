using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableThreadingSyncronIndexer
{
    public class Employ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int? Leaves { get; set; }

        public Nullable<int> Status { get; set; }
    }
}
