using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method |
           AttributeTargets.Constructor, AllowMultiple = true)]
    public class InformationAtt : Attribute
    {
        public string InfoString { get; set; }
    }
}
