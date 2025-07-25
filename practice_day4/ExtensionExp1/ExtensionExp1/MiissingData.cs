using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLibrary;

namespace ExtensionExp1
{
    internal static class MiissingData
    {
        public static string MileStone3(this Operations op)
        {
            return "Milestone 3 is on html and css";
        }
        public static string MileStone4(this Operations op)
        {
            return "Milestone 4 is on react";
        }
        public static string Project(this Operations op)
        {
            return "CapStone project is the last";
        }
    }
}
