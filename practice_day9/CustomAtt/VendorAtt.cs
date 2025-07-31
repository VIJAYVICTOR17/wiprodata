using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAtt
{
    [System.AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    internal class VendorAtt : Attribute
    {
        public string vendorName;
        public double premiumAmount;

        public VendorAtt(string vendorName)
        {
            this.vendorName = vendorName;
        }
    }
}
