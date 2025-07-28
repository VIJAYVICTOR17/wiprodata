﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpresions
{
    internal class NameCompare : Comparer<Employ>
    {
        public override int Compare(Employ x, Employ y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
