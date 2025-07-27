using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class MilestoneExcepMain : ApplicationException
    {
        public MilestoneExcepMain(string error) : base (error) { }
    }
}
